using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
        }

        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        // MAKE FUNCTION TO RUN THE SIMULATION

        public int finishTime;
        public int maxQ;
        public int currentQ;

        private int SetInterArrival(List<TimeDistribution> arivalTD, int RandomInterArrival)
        {

            int InterArrival = -1;
            for (int i = 0; i < arivalTD.Count; ++i)
            {
                if (RandomInterArrival >= arivalTD[i].MinRange
                    && RandomInterArrival <= arivalTD[i].MaxRange)
                {
                    InterArrival = arivalTD[i].Time;
                    break;
                }
            }
           
            return InterArrival;
        }


        private int LeastUtilizationMethod(List<int> ServersIDs)
        {
            decimal lum = 1000000000;
            int serverID = -1;

            foreach (int i in ServersIDs)
            {
                if (this.finishTime == 0)
                    this.finishTime = 1;
                decimal tmp = (Servers[i].TotalWorkingTime / this.finishTime);
                if (lum > tmp)
                {
                    lum = tmp;
                    serverID = i;
  
                }
            }
            return serverID;
        }


        private int HighestPriorityMethod(List<int> ServersIDs)
        {
            return ServersIDs[0];
        }

        private int RandomMethod(List<int> ServersIDs)
        {
            Random rnd = new Random();
            int RandomInterArrival = rnd.Next(1, ServersIDs.Count);

            return ServersIDs[RandomInterArrival];
        }



        private List<int> MinFinishTime(List<Server> Servers)
        {
            int minFtime = 1000000000;
            int serverID = -1;

            for (int i = 0; i < Servers.Count; ++i)
            {
                if (minFtime > Servers[i].FinishTime)
                {
                    minFtime = Servers[i].FinishTime;
                    serverID = i;

                }
            }
            List<int> ServersIndecies = new List<int>();

            for (int i = 0; i < this.Servers.Count; ++i)
            {
                if (this.Servers[i].FinishTime == this.Servers[serverID].FinishTime)
                {
                    ServersIndecies.Add(i);
                }
            }
            return ServersIndecies;
        }

        private Server Findserver(int arrival, Enums.SelectionMethod StoppingCriteria)
        {
            List<int> ServersIndecies = new List<int>();
            int serverInd;

            for (int i = 0; i < this.Servers.Count; ++i)
            {
                if (this.Servers[i].FinishTime <= arrival)
                {
                    ServersIndecies.Add(i);
                }
                if (this.currentQ > 0)
                    --this.currentQ;
            }
            if (ServersIndecies.Count == 0)
            {
                ServersIndecies = MinFinishTime(this.Servers);
                ++this.currentQ;
                this.maxQ = Math.Max(this.currentQ, this.maxQ);
            }

            if (StoppingCriteria == Enums.SelectionMethod.HighestPriority)
            {
                serverInd = HighestPriorityMethod(ServersIndecies);
            }
            else if(StoppingCriteria == Enums.SelectionMethod.Random)
            {
                serverInd = RandomMethod(ServersIndecies);
            }
            else
            {
                serverInd = LeastUtilizationMethod(ServersIndecies);
            }

            return this.Servers[serverInd];
        }



        public int BuildSimulationTable()
        {
            this.finishTime = 0;
            this.maxQ = -1000;
            this.currentQ = 0;

            Random rndArraivalTime = new Random();
            Random rndServerTime = new Random();

            int prevArrivalTime = 0;
            Server s = Findserver(0, this.SelectionMethod);
            SimulationCase sc = new SimulationCase(s, 0, rndServerTime.Next(1, 101), 0, 0, 0);
           
            sc.buildCase();
            this.SimulationTable.Add(sc);

            int clientCount = 1;
            while (clientCount <= this.StoppingNumber)
            {
                
                int RandomInterArrival = rndArraivalTime.Next(1, 100);
                int RandomServerTime = rndServerTime.Next(1, 100);

                int InterArrivalTime = SetInterArrival(this.InterarrivalDistribution, RandomInterArrival);
                int ArrivalTime = prevArrivalTime + InterArrivalTime;
                Server sever= Findserver(ArrivalTime, this.SelectionMethod);

                SimulationCase simCase = new SimulationCase(sever, RandomInterArrival, RandomServerTime, InterArrivalTime, ArrivalTime, clientCount);
                int fTime = simCase.buildCase();

                // stoping condition based on time

                this.finishTime = Math.Max(fTime, this.finishTime);
                this.SimulationTable.Add(simCase);
                prevArrivalTime = ArrivalTime;
                ++clientCount;
            }
            return clientCount;
        }


        public void setPerformanceMeasures(int clientCount)
        {

            foreach (Server s in this.Servers)
            {
                if (s.ClientsCount > 0)
                    s.AverageServiceTime = s.TotalWorkingTime / s.ClientsCount;
                else
                    s.AverageServiceTime = 0;
                if (this.finishTime > 0)
                    s.Utilization = s.TotalWorkingTime / this.finishTime;
                else
                    s.Utilization = 0;
                s.IdleProbability = 1 - s.Utilization;
            }

            this.PerformanceMeasures.MaxQueueLength = this.maxQ;
            int sumWatingTime = 0;
            int sumWatingCount = 0;
            foreach(Server s in this.Servers)
            {
                sumWatingTime += s.WatingTime;
                sumWatingCount += s.ClientsWatingCount;
            }
            this.PerformanceMeasures.AverageWaitingTime = sumWatingTime / clientCount;
            this.PerformanceMeasures.WaitingProbability = sumWatingCount / clientCount;
        }

    }

}

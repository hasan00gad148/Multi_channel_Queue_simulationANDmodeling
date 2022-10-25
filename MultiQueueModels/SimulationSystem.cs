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
            this.rnd = new Random();
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
        Random rnd ;

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
            
            int RandomInterArrival = this.rnd.Next(1, ServersIDs.Count);

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

        //private void UpdateQ(bool emp, int Interarrival, int prevDelay)
        //{

        //    if (emp)
        //        this.currentQ -= 1;

        //    else {
        //        if (Interarrival < prevDelay)
        //            this.currentQ += 1;
        //        else
        //            this.currentQ = 1;
        //    }
        //    this.maxQ = Math.Max(this.currentQ, this.maxQ);
        //}

        private int Findserver(Enums.SelectionMethod StoppingCriteria ,int arrival)
        {
            List<int> ServersIndecies = new List<int>();
            int serverInd;

            bool emp = false; 
            for (int i = 0; i < this.Servers.Count; ++i)
            {
                
                if (this.Servers[i].FinishTime <= arrival)
                {
                    ServersIndecies.Add(i);
                    emp = true;
                }
            }
            if (!emp)
            {
                ServersIndecies = MinFinishTime(this.Servers);                
            }

            //UpdateQ(emp, Interarrival, prevDelay);

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

            return serverInd;
        }



        public int BuildSimulationTable()
        {
            this.finishTime = 0;

            int prevArrivalTime = 0;
            int si = Findserver(this.SelectionMethod, 0);
            Server s = this.Servers[si];
            SimulationCase sc = new SimulationCase(s, 1, this.rnd.Next(1, 101), 0, 0, 0);
            sc.buildCase();
            //SimulationCase sc = new SimulationCase(Servers[0], 1, 0, 0, 1, 2, 0, 2, 0, 0);

            this.SimulationTable.Add(sc);

            int clientCount = 1;
            while (clientCount < this.StoppingNumber)
            {
                
                int RandomInterArrival = this.rnd.Next(1, 101);
                int RandomServerTime = this.rnd.Next(1, 101);

                int InterArrivalTime = SetInterArrival(this.InterarrivalDistribution, RandomInterArrival);
                int ArrivalTime = prevArrivalTime + InterArrivalTime;

                int serverindex = Findserver(this.SelectionMethod, ArrivalTime);
                Server server = this.Servers[serverindex];

                SimulationCase simCase = new SimulationCase(server, RandomInterArrival, RandomServerTime, InterArrivalTime, ArrivalTime, clientCount);
                int fTime = simCase.buildCase();

                //this.Servers[serverindex] = simCase.AssignedServer;
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
                    s.AverageServiceTime = Convert.ToDecimal(s.TotalWorkingTime) / s.ClientsCount;
                else
                    s.AverageServiceTime = 0;
                if (this.finishTime > 0)
                    s.Utilization = Convert.ToDecimal(s.TotalWorkingTime) / this.finishTime;
                else
                    s.Utilization = 0;
                s.IdleProbability = 1 - s.Utilization;
            }

          
            int sumWatingTime = 0;
            int sumWatingCount = 0;
            foreach(Server s in this.Servers)
            {
                sumWatingTime += s.WatingTime;
                sumWatingCount += s.ClientsWatingCount;
            }
            this.PerformanceMeasures.AverageWaitingTime = Convert.ToDecimal(sumWatingTime) / clientCount;
            this.PerformanceMeasures.WaitingProbability = Convert.ToDecimal(sumWatingCount) / clientCount;


            MaxQ();

        }

        private void MaxQ()
        {
            List<int> arrivalT = new List<int>();
            SortedSet<int> finish = new SortedSet<int>();

            for (int i = 0; i < this.SimulationTable.Count; ++i)
            {
                arrivalT.Add(this.SimulationTable[i].ArrivalTime);
                finish.Add(this.SimulationTable[i].StartTime);
            }
            List<int> finishT = finish.ToList();


            int currentQ = 0;
            int maxQ = -100;
            int j = 0, k = 0;
            while (j < this.SimulationTable.Count-1 && k < this.SimulationTable.Count-1)
            {

                while (arrivalT[j] < finishT[k])
                {
                    currentQ += 1;
                    maxQ = Math.Max(maxQ, currentQ);

                    if (j < this.SimulationTable.Count-1)
                        ++j;
                    else
                        break;
                }
                //maxQ = Math.Max(maxQ, currentQ);

                while (arrivalT[j] > finishT[k])
                {

                    if (currentQ > 0)
                        currentQ -= 1;

                    if (k < this.SimulationTable.Count - 1)
                        ++k;
                    else
                        break;

                }
                //maxQ = Math.Max(maxQ, currentQ);

                while (j < this.SimulationTable.Count - 1 && k < this.SimulationTable.Count - 1 && arrivalT[j] == finishT[k])
                {

                    if (j > k)
                    {
                        currentQ -= 1;
                        if (k < this.SimulationTable.Count-1)
                            ++k;
                        else
                            break;
                    }
                    else if (k > j)
                    {
                        currentQ += 1;
                        maxQ = Math.Max(maxQ, currentQ);

                        if (j < this.SimulationTable.Count-1)
                            ++j;
                        else
                            break;

                    }
                    else
                    {
                        ++j;
                        ++k;
                    }

                }
                maxQ = Math.Max(maxQ, currentQ);

            }


            this.PerformanceMeasures.MaxQueueLength = maxQ;
        }
    }

}

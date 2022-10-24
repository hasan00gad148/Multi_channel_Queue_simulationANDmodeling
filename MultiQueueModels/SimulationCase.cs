using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationCase
    {
        public SimulationCase()
        {
            this.AssignedServer = new Server();

        }
        public SimulationCase(Server s)
        {
            this.AssignedServer = s;
        }
        public SimulationCase(Server s, int RandomInterArrival, int RandomService, int InterArrivalTime, int ArrivalTime,int CustomerNumber)
        {
            this.AssignedServer = s;

            this.RandomInterArrival = RandomInterArrival;
            this.RandomService = RandomService;

            this.ArrivalTime = ArrivalTime;
            this.InterArrival = InterArrivalTime;

            this.CustomerNumber = CustomerNumber;
        }



        //tmp constractor
        public SimulationCase(Server s, int RandomInterArrival, int InterArrivalTime, int ArrivalTime, int RandomService, int ServiceTime, int StartTime, int EndTime, int TimeInQueue, int CustomerNumber)
        {
            this.AssignedServer = s;

            this.RandomInterArrival = RandomInterArrival;
            this.ArrivalTime = ArrivalTime;
            this.InterArrival = InterArrivalTime;  

            this.RandomService = RandomService;
            this.ServiceTime = ServiceTime;

            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.TimeInQueue = TimeInQueue;

            this.CustomerNumber = CustomerNumber;

            this.AssignedServer.ClientsCount = 1;
            this.AssignedServer.WatingTime += this.TimeInQueue;
            this.AssignedServer.FinishTime = this.EndTime;
        }
        //-------------------------------------------------------------

        public int CustomerNumber { get; set; }
        public int RandomInterArrival { get; set; }
        public int InterArrival { get; set; }
        public int ArrivalTime { get; set; }
        public int RandomService { get; set; }
        public int ServiceTime { get; set; }
        public Server AssignedServer { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int TimeInQueue { get; set; }

        //----------------------------------
        public List<TimeDistribution> arivalTD;
        public int prevArrivalTime;



        public int setServiceTime()
        {
            for (int i = 0; i < this.AssignedServer.TimeDistribution.Count; ++i)
            {
                if (this.RandomService >= this.AssignedServer.TimeDistribution[i].MinRange
                    && this.RandomService <= this.AssignedServer.TimeDistribution[i].MaxRange)
                {
                    this.ServiceTime = this.AssignedServer.TimeDistribution[i].Time;
                    this.AssignedServer.TotalWorkingTime += this.ServiceTime;
                    break;
                }
            }
            return this.ServiceTime;
        }

        public int setStartTime()
        {
            this.StartTime = Math.Max(this.AssignedServer.FinishTime, this.ArrivalTime);
            this.AssignedServer.ClientsCount += 1;

            return this.StartTime;
        }

        public int setTimeInQueue()
        {
            if (this.AssignedServer.FinishTime > this.ArrivalTime)
            {
                this.TimeInQueue = this.StartTime - this.ArrivalTime;
                this.AssignedServer.ClientsWatingCount += 1;
                this.AssignedServer.WatingTime += this.TimeInQueue;
            }
            else
                this.TimeInQueue = 0;
            return this.TimeInQueue ;

        }
        public int setEndTime()
        {
            this.EndTime = this.StartTime + this.ServiceTime;
            this.AssignedServer.FinishTime = this.EndTime;

            return this.EndTime;
        }


        public int buildCase()
        {
            this.setServiceTime();
            this.setStartTime();

            this.setTimeInQueue();
            int endTime =  this.setEndTime();

            return endTime;

        }

    }
}

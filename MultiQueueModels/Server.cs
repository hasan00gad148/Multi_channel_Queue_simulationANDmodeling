using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
        }
        public Server(List<TimeDistribution> TD)
        {
            this.TimeDistribution = TD;
            this.ClientsWatingCount = 0;
            this.WatingTime = 0;
            this.ClientsCount = 0;
        }
        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; } 
        public decimal Utilization { get; set; }
        public List<TimeDistribution> TimeDistribution;

        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }

        public int ClientsCount;
        public int ClientsWatingCount;
        public int WatingTime;
        //public void initServerTimeDis()
        //{
        //decimal prevcumm = 0;
        //for (int i = 0; i < TimeDistribution.Count; ++i)
        //{
        //    decimal cumm = prevcumm + TimeDistribution[i].Probability;
        //    TimeDistribution[i].CummProbability = cumm;

        //    TimeDistribution[i].MinRange = (int)((prevcumm * 100) +1);
        //    TimeDistribution[i].MaxRange = (int)(cumm * 100);

        //    prevcumm = TimeDistribution[i].CummProbability;
        //}
        //}
    }
}

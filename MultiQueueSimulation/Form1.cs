using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiQueueModels;
using MultiQueueTesting;

namespace MultiQueueSimulation
{
    public partial class Form1 : Form
    {
        DataFileReader fileReader = new DataFileReader();

        public Form1()
        {
            InitializeComponent();
            comboBox_SelectionMethod.Items.Add("HighestPriority");
            comboBox_SelectionMethod.Items.Add("Random");
            comboBox_SelectionMethod.Items.Add("LeastUtilization");
        }

        private void but_Browse_Click(object sender, EventArgs e)
        {
            fileReader.BrowseToFile();
            // If no file name is given (the user cancels) then return
            if (fileReader.fileName == "")
                return;

            txt_FileName.Text = fileReader.fileName;
            // Parse the data from the chosen file
            fileReader.ParseDataFile(fileReader.dataFilePath);
            txt_StoppingNumber.Text = fileReader.stoppingNumber.ToString();
            txt_StoppingCriteria.Text = fileReader.stoppingCriteria.ToString();
            txt_ServersNumber.Text = fileReader.numberOfServers.ToString();

            // Reset the text
            txt_InterarrivalDistrib.Text = "";
            txt_ServerDistrib.Text = "";

            // View the time distributions in UI
            foreach (TimeDistribution timeDistribution in fileReader.interarrivalTimeDistrib)
            {
                txt_InterarrivalDistrib.Text += timeDistribution.Time.ToString() + ", " + timeDistribution.Probability.ToString();
                txt_InterarrivalDistrib.Text += '\n';
            }
            int serverCounter = 1;
            foreach (List<TimeDistribution> timeList in fileReader.serverTimeDistributions)
            {
                txt_ServerDistrib.Text += "Server " + serverCounter.ToString();
                txt_ServerDistrib.Text += '\n';
                foreach (TimeDistribution timeDistribution in timeList)
                {
                    txt_ServerDistrib.Text += timeDistribution.Time.ToString() + ", " + timeDistribution.Probability.ToString();
                    txt_ServerDistrib.Text += '\n';
                }
                serverCounter++;
                txt_ServerDistrib.Text += '\n';
            }

            // Sets the selection method
            comboBox_SelectionMethod.SelectedIndex = fileReader.selectionMethod - 1;

            but_Run.Enabled = true;
        }

        /*
        
        #####################################################################################################
        #####################################################################################################
        #####################################################################################################
        
        */
        //private List<TimeDistribution> initArraivalTime(List<TimeDistribution> TD)
        //{
        //    decimal prevcumm = 0;
        //    for (int i = 0; i < TD.Count; ++i)
        //    {
        //        decimal cumm = prevcumm + TD[i].Probability;
        //        TD[i].CummProbability = cumm;

        //        TD[i].MinRange = (int)((prevcumm * 100) + 1);
        //        TD[i].MaxRange = (int)(cumm * 100);

        //        prevcumm = TD[i].CummProbability;

        //    }
        //    return TD;
        //}
        private List<Server> initServers(List<List<TimeDistribution>> serversTD)
        {
            List<Server> servers = new List<Server>();

            for (int i = 0; i < serversTD.Count; i++)
            {
                Server s = new Server(serversTD[i]);
                s.ID = i;
                servers.Add(s);
            }

            return servers;
        }
        private SimulationSystem initSystem(DataFileReader dfr)
        {
            SimulationSystem ss = new SimulationSystem();
            ss.InterarrivalDistribution = dfr.interarrivalTimeDistrib;
            ss.Servers = initServers(dfr.serverTimeDistributions);
            ss.NumberOfServers = dfr.numberOfServers;

            if(dfr.selectionMethod == 2)
                ss.SelectionMethod = Enums.SelectionMethod.Random  ;
            else if ((dfr.selectionMethod == 3))
                ss.SelectionMethod = Enums.SelectionMethod.LeastUtilization;
            else
                ss.SelectionMethod = Enums.SelectionMethod.HighestPriority;


            ss.StoppingNumber = dfr.stoppingNumber;
            

            if (dfr.stoppingCriteria == 1)
                ss.StoppingCriteria = Enums.StoppingCriteria.NumberOfCustomers;
            else
                ss.StoppingCriteria = Enums.StoppingCriteria.SimulationEndTime;


            return ss;
        }
        private void but_Run_Click(object sender, EventArgs e)
        {
            // TODO:
            // 1- Put the data in the simulation object
            // 2- Run simulation and view outputs in different windows
            SimulationSystem system = initSystem(fileReader);
            int count = system.BuildSimulationTable();
            system.setPerformanceMeasures(count);


            string result = TestingManager.Test(system, Constants.FileNames.TestCase1);
            MessageBox.Show(result);
            Form2 f2 = new Form2(system.SimulationTable);
            f2.Show();

        }


    }
}

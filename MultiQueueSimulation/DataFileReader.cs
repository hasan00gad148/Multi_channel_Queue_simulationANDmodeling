using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MultiQueueModels
{
    class DataFileReader
    {
        public string dataFilePath;
        public string fileName;
        public int numberOfServers;
        public int stoppingNumber;
        public int stoppingCriteria;
        public int selectionMethod;
        public List<TimeDistribution> interarrivalTimeDistrib;
        // List of all server distributions
        public List<List<TimeDistribution>> serverTimeDistributions;

        // Gives functionality to reach the case file using UI
        public void BrowseToFile()
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Choose text case file";
            fdlg.InitialDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            fdlg.Filter = "txt files (*.txt)|*.txt";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                dataFilePath = fdlg.FileName;
                fileName = fdlg.SafeFileName;
            }
            else
            {
                fileName = "";
            }
        }

        // Parses case file to get the input data from
        public void ParseDataFile(string filePath)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Path or File does not exist");
            }

            StreamReader sReader = new StreamReader(filePath);
            interarrivalTimeDistrib = new List<TimeDistribution>();
            serverTimeDistributions = new List<List<TimeDistribution>>();

            string line;
            int serverCounter = 0;
            serverTimeDistributions.Clear();
            // Read lines till end of file
            while ((line = sReader.ReadLine()) != null)
            {
                if (line == "")
                    continue;
                
                switch (line)
                {
                    case "NumberOfServers":
                        numberOfServers = Int32.Parse(sReader.ReadLine());
                        continue;
                    case "StoppingNumber":
                        stoppingNumber = Int32.Parse(sReader.ReadLine());
                        continue;
                    case "StoppingCriteria":
                        stoppingCriteria = Int32.Parse(sReader.ReadLine());
                        continue;
                    case "SelectionMethod":
                        selectionMethod = Int32.Parse(sReader.ReadLine());
                        continue;
                    case "InterarrivalDistribution":
                        interarrivalTimeDistrib = new List<TimeDistribution>();
                        string lineValue;

                        int distCounter = 0;
                        int time = 0;
                        decimal frequency = 0;
                        decimal cumulativeFrequency = 0;

                        // Loops through all lines with the distribution values
                        while (true)
                        {
                            lineValue = sReader.ReadLine();
                            if (lineValue == "" || lineValue == null)
                                break;
                            time = Int32.Parse(lineValue.Split(',')[0]);
                            frequency = Decimal.Parse(lineValue.Split(' ')[1]);
                            cumulativeFrequency += frequency;

                            interarrivalTimeDistrib.Add(new TimeDistribution());
                            interarrivalTimeDistrib[distCounter].Time = time;
                            interarrivalTimeDistrib[distCounter].Probability = frequency;
                            interarrivalTimeDistrib[distCounter].CummProbability = cumulativeFrequency;
                            interarrivalTimeDistrib[distCounter].CalculateRange();

                            distCounter++;
                        }
                        continue;
                }

                // Parses server distribution data
                if (line.Contains("Server"))
                {
                    serverTimeDistributions.Add(new List<TimeDistribution>());
                    string lineValue;

                    int distCounter = 0;
                    int time = 0;
                    decimal frequency = 0;
                    decimal cumulativeFrequency = 0;

                    // Loops through all lines with the distribution values
                    while (true)
                    {
                        lineValue = sReader.ReadLine();
                        if (lineValue == "" || lineValue == null)
                            break;
                        time = Int32.Parse(lineValue.Split(',')[0]);
                        frequency = Decimal.Parse(lineValue.Split(' ')[1]);
                        cumulativeFrequency += frequency;

                        serverTimeDistributions[serverCounter].Add(new TimeDistribution());
                        serverTimeDistributions[serverCounter][distCounter].Time = time;
                        serverTimeDistributions[serverCounter][distCounter].Probability = frequency;
                        serverTimeDistributions[serverCounter][distCounter].CummProbability = cumulativeFrequency;
                        serverTimeDistributions[serverCounter][distCounter].CalculateRange();

                        distCounter++;
                    }
                    serverCounter++;
                }
            }

            sReader.Close();
        }
    }
}

using MultiQueueModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiQueueSimulation
{
    public partial class Form2 : Form
    {
        public List<SimulationCase> SimulationTable { get; set; }
        public Form2(List<SimulationCase> st)
        {
            InitializeComponent();
            this.SimulationTable = st;

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<dataGridView1.Columns.Count; ++i)
            {
                dataGridView1.Columns[i].DefaultCellStyle.ForeColor = Color.Black;
            }
            
            foreach (SimulationCase sc in SimulationTable)
            {
                DataGridViewRow row = (DataGridViewRow)this.dataGridView1.Rows[0].Clone();

                row.Cells[0].Value = sc.CustomerNumber;

                row.Cells[1].Value = sc.RandomInterArrival;
                row.Cells[2].Value = sc.InterArrival;
                row.Cells[3].Value = sc.ArrivalTime;

                row.Cells[4].Value = sc.AssignedServer.ID;
                row.Cells[5].Value = sc.RandomService;
                row.Cells[6].Value = sc.ServiceTime;

                row.Cells[7].Value = sc.TimeInQueue;
                row.Cells[8].Value = sc.StartTime;
                row.Cells[9].Value = sc.EndTime;

                this.dataGridView1.Rows.Add(row);
            }

        }

    }
}

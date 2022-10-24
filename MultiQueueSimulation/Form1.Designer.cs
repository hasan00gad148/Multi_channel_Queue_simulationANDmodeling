namespace MultiQueueSimulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_Browse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.but_Run = new System.Windows.Forms.Button();
            this.comboBox_SelectionMethod = new System.Windows.Forms.ComboBox();
            this.label_SelectionMethod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FileName = new System.Windows.Forms.Label();
            this.label_ServerNum = new System.Windows.Forms.Label();
            this.label_StoppingCount = new System.Windows.Forms.Label();
            this.label_StoppingCriteria = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_ServerDistrib = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_InterarrivalDistrib = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_StoppingCriteria = new System.Windows.Forms.Label();
            this.txt_StoppingNumber = new System.Windows.Forms.Label();
            this.txt_ServersNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Browse
            // 
            this.but_Browse.AutoSize = true;
            this.but_Browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.but_Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Browse.ForeColor = System.Drawing.SystemColors.Highlight;
            this.but_Browse.Location = new System.Drawing.Point(17, 16);
            this.but_Browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.but_Browse.Name = "but_Browse";
            this.but_Browse.Size = new System.Drawing.Size(127, 46);
            this.but_Browse.TabIndex = 0;
            this.but_Browse.Text = "Browse";
            this.but_Browse.UseVisualStyleBackColor = true;
            this.but_Browse.Click += new System.EventHandler(this.but_Browse_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(13, 12, 4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 81);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label1.Size = new System.Drawing.Size(623, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = "MultiQueue Simulator";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.MinimumSize = new System.Drawing.Size(243, 430);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel2.Size = new System.Drawing.Size(243, 583);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(13, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label4.Size = new System.Drawing.Size(215, 532);
            this.label4.TabIndex = 1;
            this.label4.Text = "\r\n- Press \"Browse\" and choose a test case file (Must be the right format)\r\n\r\n- Th" +
    "e data in the case file will be displayed\r\n\r\n- Press \"Run\" and the simulation wi" +
    "ll run";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "INSTRUCTIONS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.but_Run);
            this.panel3.Controls.Add(this.comboBox_SelectionMethod);
            this.panel3.Controls.Add(this.label_SelectionMethod);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txt_FileName);
            this.panel3.Controls.Add(this.but_Browse);
            this.panel3.Location = new System.Drawing.Point(248, 84);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel3.Size = new System.Drawing.Size(921, 211);
            this.panel3.TabIndex = 5;
            // 
            // but_Run
            // 
            this.but_Run.AutoSize = true;
            this.but_Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.but_Run.Enabled = false;
            this.but_Run.FlatAppearance.BorderSize = 0;
            this.but_Run.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.but_Run.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(90)))), ((int)(((byte)(54)))));
            this.but_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Run.ForeColor = System.Drawing.Color.Lime;
            this.but_Run.Location = new System.Drawing.Point(795, 155);
            this.but_Run.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.but_Run.Name = "but_Run";
            this.but_Run.Size = new System.Drawing.Size(107, 43);
            this.but_Run.TabIndex = 12;
            this.but_Run.Text = "Run";
            this.but_Run.UseVisualStyleBackColor = false;
            this.but_Run.Click += new System.EventHandler(this.but_Run_Click);
            // 
            // comboBox_SelectionMethod
            // 
            this.comboBox_SelectionMethod.BackColor = System.Drawing.SystemColors.MenuText;
            this.comboBox_SelectionMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SelectionMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelectionMethod.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox_SelectionMethod.FormattingEnabled = true;
            this.comboBox_SelectionMethod.Location = new System.Drawing.Point(264, 80);
            this.comboBox_SelectionMethod.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_SelectionMethod.Name = "comboBox_SelectionMethod";
            this.comboBox_SelectionMethod.Size = new System.Drawing.Size(275, 33);
            this.comboBox_SelectionMethod.TabIndex = 11;
            // 
            // label_SelectionMethod
            // 
            this.label_SelectionMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SelectionMethod.AutoSize = true;
            this.label_SelectionMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectionMethod.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_SelectionMethod.Location = new System.Drawing.Point(13, 84);
            this.label_SelectionMethod.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.label_SelectionMethod.Name = "label_SelectionMethod";
            this.label_SelectionMethod.Size = new System.Drawing.Size(164, 25);
            this.label_SelectionMethod.TabIndex = 10;
            this.label_SelectionMethod.Text = "Selection Method";
            this.label_SelectionMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(215, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "File";
            // 
            // txt_FileName
            // 
            this.txt_FileName.AutoSize = true;
            this.txt_FileName.BackColor = System.Drawing.Color.Black;
            this.txt_FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_FileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FileName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_FileName.Location = new System.Drawing.Point(264, 16);
            this.txt_FileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_FileName.MaximumSize = new System.Drawing.Size(639, 39);
            this.txt_FileName.MinimumSize = new System.Drawing.Size(639, 39);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(639, 39);
            this.txt_FileName.TabIndex = 1;
            this.txt_FileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ServerNum
            // 
            this.label_ServerNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ServerNum.AutoSize = true;
            this.label_ServerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ServerNum.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_ServerNum.Location = new System.Drawing.Point(13, 16);
            this.label_ServerNum.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.label_ServerNum.Name = "label_ServerNum";
            this.label_ServerNum.Size = new System.Drawing.Size(154, 25);
            this.label_ServerNum.TabIndex = 4;
            this.label_ServerNum.Text = "Servers Number";
            this.label_ServerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_StoppingCount
            // 
            this.label_StoppingCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_StoppingCount.AutoSize = true;
            this.label_StoppingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoppingCount.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_StoppingCount.Location = new System.Drawing.Point(13, 69);
            this.label_StoppingCount.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.label_StoppingCount.Name = "label_StoppingCount";
            this.label_StoppingCount.Size = new System.Drawing.Size(164, 25);
            this.label_StoppingCount.TabIndex = 6;
            this.label_StoppingCount.Text = "Stopping Number";
            this.label_StoppingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_StoppingCriteria
            // 
            this.label_StoppingCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_StoppingCriteria.AutoSize = true;
            this.label_StoppingCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StoppingCriteria.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label_StoppingCriteria.Location = new System.Drawing.Point(13, 122);
            this.label_StoppingCriteria.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.label_StoppingCriteria.Name = "label_StoppingCriteria";
            this.label_StoppingCriteria.Size = new System.Drawing.Size(157, 25);
            this.label_StoppingCriteria.TabIndex = 8;
            this.label_StoppingCriteria.Text = "Stopping Criteria";
            this.label_StoppingCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txt_ServerDistrib);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txt_InterarrivalDistrib);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_StoppingCriteria);
            this.panel4.Controls.Add(this.txt_StoppingNumber);
            this.panel4.Controls.Add(this.txt_ServersNumber);
            this.panel4.Controls.Add(this.label_ServerNum);
            this.panel4.Controls.Add(this.label_StoppingCount);
            this.panel4.Controls.Add(this.label_StoppingCriteria);
            this.panel4.Location = new System.Drawing.Point(248, 298);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel4.Size = new System.Drawing.Size(921, 369);
            this.panel4.TabIndex = 10;
            // 
            // txt_ServerDistrib
            // 
            this.txt_ServerDistrib.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ServerDistrib.AutoSize = true;
            this.txt_ServerDistrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ServerDistrib.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_ServerDistrib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_ServerDistrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ServerDistrib.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_ServerDistrib.Location = new System.Drawing.Point(355, 213);
            this.txt_ServerDistrib.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.txt_ServerDistrib.MinimumSize = new System.Drawing.Size(274, 141);
            this.txt_ServerDistrib.Name = "txt_ServerDistrib";
            this.txt_ServerDistrib.Size = new System.Drawing.Size(274, 141);
            this.txt_ServerDistrib.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Location = new System.Drawing.Point(349, 175);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Server Distribution:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_InterarrivalDistrib
            // 
            this.txt_InterarrivalDistrib.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_InterarrivalDistrib.AutoSize = true;
            this.txt_InterarrivalDistrib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_InterarrivalDistrib.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_InterarrivalDistrib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_InterarrivalDistrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_InterarrivalDistrib.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_InterarrivalDistrib.Location = new System.Drawing.Point(19, 213);
            this.txt_InterarrivalDistrib.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.txt_InterarrivalDistrib.MinimumSize = new System.Drawing.Size(274, 141);
            this.txt_InterarrivalDistrib.Name = "txt_InterarrivalDistrib";
            this.txt_InterarrivalDistrib.Size = new System.Drawing.Size(274, 141);
            this.txt_InterarrivalDistrib.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Inter-arrival Distribution:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_StoppingCriteria
            // 
            this.txt_StoppingCriteria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_StoppingCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StoppingCriteria.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_StoppingCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_StoppingCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StoppingCriteria.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_StoppingCriteria.Location = new System.Drawing.Point(259, 123);
            this.txt_StoppingCriteria.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.txt_StoppingCriteria.Name = "txt_StoppingCriteria";
            this.txt_StoppingCriteria.Size = new System.Drawing.Size(281, 27);
            this.txt_StoppingCriteria.TabIndex = 11;
            this.txt_StoppingCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StoppingNumber
            // 
            this.txt_StoppingNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_StoppingNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StoppingNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_StoppingNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_StoppingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StoppingNumber.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_StoppingNumber.Location = new System.Drawing.Point(259, 68);
            this.txt_StoppingNumber.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.txt_StoppingNumber.Name = "txt_StoppingNumber";
            this.txt_StoppingNumber.Size = new System.Drawing.Size(281, 27);
            this.txt_StoppingNumber.TabIndex = 10;
            this.txt_StoppingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ServersNumber
            // 
            this.txt_ServersNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ServersNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ServersNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_ServersNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_ServersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ServersNumber.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_ServersNumber.Location = new System.Drawing.Point(259, 16);
            this.txt_ServersNumber.Margin = new System.Windows.Forms.Padding(0, 4, 0, 25);
            this.txt_ServersNumber.Name = "txt_ServersNumber";
            this.txt_ServersNumber.Size = new System.Drawing.Size(281, 27);
            this.txt_ServersNumber.TabIndex = 9;
            this.txt_ServersNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1167, 658);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1185, 705);
            this.MinimumSize = new System.Drawing.Size(1185, 705);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Browse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txt_FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_ServerNum;
        private System.Windows.Forms.Label label_StoppingCount;
        private System.Windows.Forms.Label label_StoppingCriteria;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox_SelectionMethod;
        private System.Windows.Forms.Label label_SelectionMethod;
        private System.Windows.Forms.Button but_Run;
        private System.Windows.Forms.Label txt_StoppingCriteria;
        private System.Windows.Forms.Label txt_StoppingNumber;
        private System.Windows.Forms.Label txt_ServersNumber;
        private System.Windows.Forms.Label txt_ServerDistrib;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txt_InterarrivalDistrib;
        private System.Windows.Forms.Label label5;
    }
}


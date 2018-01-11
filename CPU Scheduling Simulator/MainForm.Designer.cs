using System.Drawing;

namespace CPU_Scheduling_Simulator
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelInput = new System.Windows.Forms.Panel();
            this.labelIOTime = new System.Windows.Forms.Label();
            this.labelBurstTime = new System.Windows.Forms.Label();
            this.textBoxBurstTime = new System.Windows.Forms.TextBox();
            this.textBoxIOTime = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.textBoxArrivalTime = new System.Windows.Forms.TextBox();
            this.textBoxPriority = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelArrivalTime = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.panelAlgorithmSelector = new System.Windows.Forms.Panel();
            this.buttonStartSimulation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRR = new System.Windows.Forms.RadioButton();
            this.radioButtonSJF = new System.Windows.Forms.RadioButton();
            this.radioButtonFCFS = new System.Windows.Forms.RadioButton();
            this.labelAlgorithmSelector = new System.Windows.Forms.Label();
            this.panelProcessesList = new System.Windows.Forms.Panel();
            this.dataGridViewProcessesList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Burst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputOutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelProcessesList = new System.Windows.Forms.Label();
            this.panelResults = new System.Windows.Forms.Panel();
            this.cpuchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGanttChart = new System.Windows.Forms.Button();
            this.labelResults = new System.Windows.Forms.Label();
            this.panelInput.SuspendLayout();
            this.panelAlgorithmSelector.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelProcessesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessesList)).BeginInit();
            this.panelResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuchart)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.labelIOTime);
            this.panelInput.Controls.Add(this.labelBurstTime);
            this.panelInput.Controls.Add(this.textBoxBurstTime);
            this.panelInput.Controls.Add(this.textBoxIOTime);
            this.panelInput.Controls.Add(this.buttonInput);
            this.panelInput.Controls.Add(this.textBoxArrivalTime);
            this.panelInput.Controls.Add(this.textBoxPriority);
            this.panelInput.Controls.Add(this.textBoxDuration);
            this.panelInput.Controls.Add(this.labelArrivalTime);
            this.panelInput.Controls.Add(this.labelPriority);
            this.panelInput.Controls.Add(this.labelDuration);
            this.panelInput.Controls.Add(this.labelInput);
            this.panelInput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelInput.Location = new System.Drawing.Point(9, 10);
            this.panelInput.Margin = new System.Windows.Forms.Padding(2);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(226, 277);
            this.panelInput.TabIndex = 0;
            // 
            // labelIOTime
            // 
            this.labelIOTime.AutoSize = true;
            this.labelIOTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIOTime.Location = new System.Drawing.Point(2, 197);
            this.labelIOTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIOTime.Name = "labelIOTime";
            this.labelIOTime.Size = new System.Drawing.Size(76, 20);
            this.labelIOTime.TabIndex = 11;
            this.labelIOTime.Text = "I/O Time";
            this.labelIOTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBurstTime
            // 
            this.labelBurstTime.AutoSize = true;
            this.labelBurstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBurstTime.Location = new System.Drawing.Point(2, 171);
            this.labelBurstTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBurstTime.Name = "labelBurstTime";
            this.labelBurstTime.Size = new System.Drawing.Size(95, 20);
            this.labelBurstTime.TabIndex = 10;
            this.labelBurstTime.Text = "Burst Time";
            this.labelBurstTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBurstTime
            // 
            this.textBoxBurstTime.Location = new System.Drawing.Point(124, 174);
            this.textBoxBurstTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBurstTime.Name = "textBoxBurstTime";
            this.textBoxBurstTime.Size = new System.Drawing.Size(66, 20);
            this.textBoxBurstTime.TabIndex = 9;
            // 
            // textBoxIOTime
            // 
            this.textBoxIOTime.Location = new System.Drawing.Point(124, 197);
            this.textBoxIOTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIOTime.Name = "textBoxIOTime";
            this.textBoxIOTime.Size = new System.Drawing.Size(66, 20);
            this.textBoxIOTime.TabIndex = 8;
            // 
            // buttonInput
            // 
            this.buttonInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInput.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonInput.Location = new System.Drawing.Point(63, 245);
            this.buttonInput.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(89, 28);
            this.buttonInput.TabIndex = 7;
            this.buttonInput.Text = "Add to list";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // textBoxArrivalTime
            // 
            this.textBoxArrivalTime.Location = new System.Drawing.Point(124, 61);
            this.textBoxArrivalTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxArrivalTime.Name = "textBoxArrivalTime";
            this.textBoxArrivalTime.Size = new System.Drawing.Size(66, 20);
            this.textBoxArrivalTime.TabIndex = 6;
            // 
            // textBoxPriority
            // 
            this.textBoxPriority.Location = new System.Drawing.Point(124, 116);
            this.textBoxPriority.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPriority.Name = "textBoxPriority";
            this.textBoxPriority.Size = new System.Drawing.Size(66, 20);
            this.textBoxPriority.TabIndex = 5;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(124, 88);
            this.textBoxDuration.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(66, 20);
            this.textBoxDuration.TabIndex = 4;
            // 
            // labelArrivalTime
            // 
            this.labelArrivalTime.AutoSize = true;
            this.labelArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArrivalTime.Location = new System.Drawing.Point(2, 61);
            this.labelArrivalTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArrivalTime.Name = "labelArrivalTime";
            this.labelArrivalTime.Size = new System.Drawing.Size(102, 20);
            this.labelArrivalTime.TabIndex = 3;
            this.labelArrivalTime.Text = "Arrival Time";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriority.Location = new System.Drawing.Point(2, 116);
            this.labelPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(64, 20);
            this.labelPriority.TabIndex = 2;
            this.labelPriority.Text = "Priority";
            this.labelPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(2, 88);
            this.labelDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(78, 20);
            this.labelDuration.TabIndex = 1;
            this.labelDuration.Text = "Duration";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(72, 0);
            this.labelInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(65, 26);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input";
            // 
            // panelAlgorithmSelector
            // 
            this.panelAlgorithmSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAlgorithmSelector.Controls.Add(this.buttonStartSimulation);
            this.panelAlgorithmSelector.Controls.Add(this.groupBox1);
            this.panelAlgorithmSelector.Controls.Add(this.labelAlgorithmSelector);
            this.panelAlgorithmSelector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelAlgorithmSelector.Location = new System.Drawing.Point(239, 11);
            this.panelAlgorithmSelector.Margin = new System.Windows.Forms.Padding(2);
            this.panelAlgorithmSelector.Name = "panelAlgorithmSelector";
            this.panelAlgorithmSelector.Size = new System.Drawing.Size(234, 277);
            this.panelAlgorithmSelector.TabIndex = 1;
            // 
            // buttonStartSimulation
            // 
            this.buttonStartSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartSimulation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStartSimulation.Location = new System.Drawing.Point(42, 245);
            this.buttonStartSimulation.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartSimulation.Name = "buttonStartSimulation";
            this.buttonStartSimulation.Size = new System.Drawing.Size(154, 28);
            this.buttonStartSimulation.TabIndex = 8;
            this.buttonStartSimulation.Text = "Start Simulation";
            this.buttonStartSimulation.UseVisualStyleBackColor = true;
            this.buttonStartSimulation.Click += new System.EventHandler(this.buttonStartSimulation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRR);
            this.groupBox1.Controls.Add(this.radioButtonSJF);
            this.groupBox1.Controls.Add(this.radioButtonFCFS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(138, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select one algorithm:";
            // 
            // radioButtonRR
            // 
            this.radioButtonRR.AutoSize = true;
            this.radioButtonRR.Location = new System.Drawing.Point(5, 63);
            this.radioButtonRR.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRR.Name = "radioButtonRR";
            this.radioButtonRR.Size = new System.Drawing.Size(41, 17);
            this.radioButtonRR.TabIndex = 2;
            this.radioButtonRR.TabStop = true;
            this.radioButtonRR.Text = "RR";
            this.radioButtonRR.UseVisualStyleBackColor = true;
            // 
            // radioButtonSJF
            // 
            this.radioButtonSJF.AutoSize = true;
            this.radioButtonSJF.Location = new System.Drawing.Point(5, 41);
            this.radioButtonSJF.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSJF.Name = "radioButtonSJF";
            this.radioButtonSJF.Size = new System.Drawing.Size(43, 17);
            this.radioButtonSJF.TabIndex = 1;
            this.radioButtonSJF.TabStop = true;
            this.radioButtonSJF.Text = "SJF";
            this.radioButtonSJF.UseVisualStyleBackColor = true;
            // 
            // radioButtonFCFS
            // 
            this.radioButtonFCFS.AutoSize = true;
            this.radioButtonFCFS.Location = new System.Drawing.Point(5, 18);
            this.radioButtonFCFS.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonFCFS.Name = "radioButtonFCFS";
            this.radioButtonFCFS.Size = new System.Drawing.Size(51, 17);
            this.radioButtonFCFS.TabIndex = 0;
            this.radioButtonFCFS.TabStop = true;
            this.radioButtonFCFS.Text = "FCFS";
            this.radioButtonFCFS.UseVisualStyleBackColor = true;
            // 
            // labelAlgorithmSelector
            // 
            this.labelAlgorithmSelector.AutoSize = true;
            this.labelAlgorithmSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlgorithmSelector.Location = new System.Drawing.Point(20, 0);
            this.labelAlgorithmSelector.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlgorithmSelector.Name = "labelAlgorithmSelector";
            this.labelAlgorithmSelector.Size = new System.Drawing.Size(209, 26);
            this.labelAlgorithmSelector.TabIndex = 0;
            this.labelAlgorithmSelector.Text = "Algorithm Selector";
            // 
            // panelProcessesList
            // 
            this.panelProcessesList.AutoScroll = true;
            this.panelProcessesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProcessesList.Controls.Add(this.dataGridViewProcessesList);
            this.panelProcessesList.Controls.Add(this.labelProcessesList);
            this.panelProcessesList.Location = new System.Drawing.Point(9, 292);
            this.panelProcessesList.Margin = new System.Windows.Forms.Padding(2);
            this.panelProcessesList.Name = "panelProcessesList";
            this.panelProcessesList.Size = new System.Drawing.Size(465, 331);
            this.panelProcessesList.TabIndex = 2;
            // 
            // dataGridViewProcessesList
            // 
            this.dataGridViewProcessesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcessesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Duration,
            this.Arrival,
            this.Priority,
            this.Burst,
            this.InputOutput,
            this.Delete});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProcessesList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProcessesList.Location = new System.Drawing.Point(14, 28);
            this.dataGridViewProcessesList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProcessesList.Name = "dataGridViewProcessesList";
            this.dataGridViewProcessesList.RowTemplate.Height = 24;
            this.dataGridViewProcessesList.Size = new System.Drawing.Size(435, 289);
            this.dataGridViewProcessesList.TabIndex = 2;
            this.dataGridViewProcessesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProcessesList_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.Width = 60;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.Name = "Arrival";
            this.Arrival.Width = 50;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.Name = "Priority";
            this.Priority.Width = 50;
            // 
            // Burst
            // 
            this.Burst.HeaderText = "Burst";
            this.Burst.Name = "Burst";
            this.Burst.ReadOnly = true;
            this.Burst.Width = 60;
            // 
            // InputOutput
            // 
            this.InputOutput.HeaderText = "I/O";
            this.InputOutput.Name = "InputOutput";
            this.InputOutput.ReadOnly = true;
            this.InputOutput.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "On delete processes Ids will be reordered.";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 60;
            // 
            // labelProcessesList
            // 
            this.labelProcessesList.AutoSize = true;
            this.labelProcessesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessesList.Location = new System.Drawing.Point(148, 0);
            this.labelProcessesList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProcessesList.Name = "labelProcessesList";
            this.labelProcessesList.Size = new System.Drawing.Size(168, 26);
            this.labelProcessesList.TabIndex = 1;
            this.labelProcessesList.Text = "Processes List";
            // 
            // panelResults
            // 
            this.panelResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResults.Controls.Add(this.cpuchart);
            this.panelResults.Controls.Add(this.buttonGanttChart);
            this.panelResults.Controls.Add(this.labelResults);
            this.panelResults.Location = new System.Drawing.Point(478, 11);
            this.panelResults.Margin = new System.Windows.Forms.Padding(2);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(651, 611);
            this.panelResults.TabIndex = 3;
            // 
            // cpuchart
            // 
            this.cpuchart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            chartArea1.Name = "ChartArea1";
            this.cpuchart.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 5;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.cpuchart.Legends.Add(legend1);
            this.cpuchart.Location = new System.Drawing.Point(3, 22);
            this.cpuchart.Name = "cpuchart";
            this.cpuchart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Average Response Time";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Average Waiting Time";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Average Turnaround Time";
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Average CPU Utilisation";
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Average No of Waiting Processes";
            this.cpuchart.Series.Add(series1);
            this.cpuchart.Series.Add(series2);
            this.cpuchart.Series.Add(series3);
            this.cpuchart.Series.Add(series4);
            this.cpuchart.Series.Add(series5);
            this.cpuchart.Size = new System.Drawing.Size(589, 551);
            this.cpuchart.TabIndex = 10;
            this.cpuchart.Text = "chart1";
            this.cpuchart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // buttonGanttChart
            // 
            this.buttonGanttChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGanttChart.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonGanttChart.Location = new System.Drawing.Point(236, 578);
            this.buttonGanttChart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGanttChart.Name = "buttonGanttChart";
            this.buttonGanttChart.Size = new System.Drawing.Size(154, 28);
            this.buttonGanttChart.TabIndex = 9;
            this.buttonGanttChart.Text = "View Gantt Chart";
            this.buttonGanttChart.UseVisualStyleBackColor = true;
            this.buttonGanttChart.Click += new System.EventHandler(this.buttonGanttChart_Click);
            // 
            // labelResults
            // 
            this.labelResults.AutoSize = true;
            this.labelResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResults.Location = new System.Drawing.Point(214, -3);
            this.labelResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(176, 26);
            this.labelResults.TabIndex = 1;
            this.labelResults.Text = "Scheduler Data";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 629);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.panelProcessesList);
            this.Controls.Add(this.panelAlgorithmSelector);
            this.Controls.Add(this.panelInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "CPU Scheduling SImulator";
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelAlgorithmSelector.ResumeLayout(false);
            this.panelAlgorithmSelector.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelProcessesList.ResumeLayout(false);
            this.panelProcessesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcessesList)).EndInit();
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuchart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelArrivalTime;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.TextBox textBoxArrivalTime;
        private System.Windows.Forms.TextBox textBoxPriority;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Panel panelAlgorithmSelector;
        private System.Windows.Forms.Label labelAlgorithmSelector;
        private System.Windows.Forms.Panel panelProcessesList;
        private System.Windows.Forms.Label labelProcessesList;
        private System.Windows.Forms.DataGridView dataGridViewProcessesList;
        private System.Windows.Forms.Label labelIOTime;
        private System.Windows.Forms.Label labelBurstTime;
        private System.Windows.Forms.TextBox textBoxBurstTime;
        private System.Windows.Forms.TextBox textBoxIOTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Burst;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputOutput;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRR;
        private System.Windows.Forms.RadioButton radioButtonSJF;
        private System.Windows.Forms.RadioButton radioButtonFCFS;
        private System.Windows.Forms.Button buttonStartSimulation;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Button buttonGanttChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuchart;
    }
}


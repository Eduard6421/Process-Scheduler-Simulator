namespace CPU_Scheduling_Simulator
{
    partial class ChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelSplitContainer = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSplitContainer)).BeginInit();
            this.panelSplitContainer.Panel1.SuspendLayout();
            this.panelSplitContainer.Panel2.SuspendLayout();
            this.panelSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChart
            // 
            this.panelChart.AutoScroll = true;
            this.panelChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChart.Controls.Add(this.panelSplitContainer);
            this.panelChart.Location = new System.Drawing.Point(12, 12);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(1506, 730);
            this.panelChart.TabIndex = 0;
            // 
            // panelSplitContainer
            // 
            this.panelSplitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.panelSplitContainer.Name = "panelSplitContainer";
            // 
            // panelSplitContainer.Panel1
            // 
            this.panelSplitContainer.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // panelSplitContainer.Panel2
            // 
            this.panelSplitContainer.Panel2.Controls.Add(this.splitContainerRight);
            this.panelSplitContainer.Size = new System.Drawing.Size(1504, 728);
            this.panelSplitContainer.SplitterDistance = 49;
            this.panelSplitContainer.TabIndex = 0;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.AutoScroll = true;
            this.splitContainerLeft.Size = new System.Drawing.Size(49, 728);
            this.splitContainerLeft.SplitterDistance = 36;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.AutoScroll = true;
            this.splitContainerRight.Panel1Collapsed = true;
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.AutoScroll = true;
            this.splitContainerRight.Size = new System.Drawing.Size(1451, 728);
            this.splitContainerRight.SplitterDistance = 36;
            this.splitContainerRight.TabIndex = 0;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1690, 897);
            this.Controls.Add(this.panelChart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChartForm";
            this.Text = "CPU Scheduling Simulator - Result Chart";
            this.panelChart.ResumeLayout(false);
            this.panelSplitContainer.Panel1.ResumeLayout(false);
            this.panelSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelSplitContainer)).EndInit();
            this.panelSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.SplitContainer panelSplitContainer;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
    }
}
namespace OOProjektovanje_lab2
{
    partial class GraphForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphChart)).BeginInit();
            this.SuspendLayout();
            // 
            // graphChart
            // 
            chartArea2.Name = "ChartArea1";
            this.graphChart.ChartAreas.Add(chartArea2);
            this.graphChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.graphChart.Legends.Add(legend2);
            this.graphChart.Location = new System.Drawing.Point(0, 0);
            this.graphChart.Name = "graphChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValueMembers = "Y";
            this.graphChart.Series.Add(series2);
            this.graphChart.Size = new System.Drawing.Size(562, 263);
            this.graphChart.TabIndex = 0;
            this.graphChart.Text = "chart1";
            this.graphChart.DoubleClick += new System.EventHandler(this.graphChart_DoubleClick);
            // 
            // logCheck
            // 
            this.logCheck.AutoSize = true;
            this.logCheck.Location = new System.Drawing.Point(446, 49);
            this.logCheck.Name = "logCheck";
            this.logCheck.Size = new System.Drawing.Size(104, 17);
            this.logCheck.TabIndex = 1;
            this.logCheck.Text = "Show Logaritmic";
            this.logCheck.UseVisualStyleBackColor = true;
            this.logCheck.CheckedChanged += new System.EventHandler(this.logCheck_CheckedChanged);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 263);
            this.Controls.Add(this.logCheck);
            this.Controls.Add(this.graphChart);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.graphChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graphChart;
        private System.Windows.Forms.CheckBox logCheck;
    }
}
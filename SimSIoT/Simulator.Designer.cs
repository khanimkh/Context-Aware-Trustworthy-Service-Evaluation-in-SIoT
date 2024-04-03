namespace SimSIoT
{
    partial class Simulator
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSuccessTrustOfSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTrustValueOfSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSatisfication = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSuccessTrustOfSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrustValueOfSR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatisfication)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSuccessTrustOfSR
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSuccessTrustOfSR.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSuccessTrustOfSR.Legends.Add(legend1);
            this.chartSuccessTrustOfSR.Location = new System.Drawing.Point(55, 27);
            this.chartSuccessTrustOfSR.Name = "chartSuccessTrustOfSR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSuccessTrustOfSR.Series.Add(series1);
            this.chartSuccessTrustOfSR.Size = new System.Drawing.Size(306, 324);
            this.chartSuccessTrustOfSR.TabIndex = 0;
            this.chartSuccessTrustOfSR.Text = "chart1";
            // 
            // chartTrustValueOfSR
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTrustValueOfSR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTrustValueOfSR.Legends.Add(legend2);
            this.chartTrustValueOfSR.Location = new System.Drawing.Point(504, 27);
            this.chartTrustValueOfSR.Name = "chartTrustValueOfSR";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTrustValueOfSR.Series.Add(series2);
            this.chartTrustValueOfSR.Size = new System.Drawing.Size(306, 324);
            this.chartTrustValueOfSR.TabIndex = 1;
            this.chartTrustValueOfSR.Text = "chart1";
            // 
            // chartSatisfication
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSatisfication.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSatisfication.Legends.Add(legend3);
            this.chartSatisfication.Location = new System.Drawing.Point(938, 27);
            this.chartSatisfication.Name = "chartSatisfication";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartSatisfication.Series.Add(series3);
            this.chartSatisfication.Size = new System.Drawing.Size(306, 324);
            this.chartSatisfication.TabIndex = 2;
            this.chartSatisfication.Text = "chart1";
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 723);
            this.Controls.Add(this.chartSatisfication);
            this.Controls.Add(this.chartTrustValueOfSR);
            this.Controls.Add(this.chartSuccessTrustOfSR);
            this.Name = "Simulator";
            this.Text = "Form_SIoT";
            ((System.ComponentModel.ISupportInitialize)(this.chartSuccessTrustOfSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrustValueOfSR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSatisfication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSuccessTrustOfSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrustValueOfSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSatisfication;
    }
}


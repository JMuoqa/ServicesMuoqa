
using System.Windows.Forms.DataVisualization.Charting;

namespace ServicesMuoqa.Views
{
    partial class StatisticsView
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            chart1 = new Chart();
            label1 = new Label();
            label2 = new Label();
            chart2 = new Chart();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = Color.FromArgb(10, 16, 25);
            chart1.BorderlineColor = Color.Empty;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(6, 54);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Pie;
            series1.LabelBackColor = Color.FromArgb(10, 16, 25);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(408, 250);
            chart1.TabIndex = 0;
            chart1.Text = "Rendimiento del ultimo mes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(408, 32);
            label1.TabIndex = 1;
            label1.Text = "Rendimiento de los meses anteriores";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(465, 19);
            label2.Name = "label2";
            label2.Size = new Size(382, 32);
            label2.TabIndex = 2;
            label2.Text = "Gastos y ganancias del ultimo mes";
            // 
            // chart2
            // 
            chart2.BackColor = Color.FromArgb(10, 16, 25);
            chart2.BorderlineColor = Color.Empty;
            chartArea2.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart2.Legends.Add(legend2);
            chart2.Location = new Point(465, 54);
            chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Pie;
            series2.LabelBackColor = Color.FromArgb(10, 16, 25);
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart2.Series.Add(series2);
            chart2.Size = new Size(368, 250);
            chart2.TabIndex = 3;
            chart2.Text = "Gastos y ganancias del ultimo mes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(chart2);
            groupBox1.Controls.Add(chart1);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(854, 494);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(872, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(355, 494);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // StatisticsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 16, 25);
            ClientSize = new Size(1239, 518);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StatisticsView";
            Text = "StatisticsView";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Chart chart1;
        private Label label1;
        private Label label2;
        private Chart chart2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
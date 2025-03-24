
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
            richTextBox2 = new RichTextBox();
            label10 = new Label();
            label9 = new Label();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label8 = new Label();
            richTextBox1 = new RichTextBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox1.Text = "Estadisticas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(872, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(359, 494);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cargar Ingresos y Gastos Externos";
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Location = new Point(6, 243);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(345, 51);
            richTextBox2.TabIndex = 17;
            richTextBox2.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 225);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 16;
            label10.Text = "Mas Info";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(240, 181);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 15;
            label9.Text = "Fecha";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(240, 199);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(111, 23);
            comboBox4.TabIndex = 14;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(123, 199);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(111, 23);
            comboBox3.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(123, 181);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 12;
            label8.Text = "Motivo";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(6, 98);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(345, 51);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 80);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 10;
            label7.Text = "Mas Info";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(240, 54);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(111, 23);
            comboBox2.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 36);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 8;
            label6.Text = "Fecha";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sueldo", "Muoqa", "Otro" });
            comboBox1.Location = new Point(123, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 23);
            comboBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 36);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Motivo";
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(276, 300);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Registrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(276, 155);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 23);
            textBox1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 181);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 1;
            label4.Text = "Gastos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 36);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 0;
            label3.Text = "Ingresos";
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Chart chart1;
        private Label label1;
        private Label label2;
        private Chart chart2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Button button2;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox1;
        private Label label5;
        private RichTextBox richTextBox1;
        private Label label7;
        private RichTextBox richTextBox2;
        private Label label10;
        private Label label9;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Label label8;
    }
}
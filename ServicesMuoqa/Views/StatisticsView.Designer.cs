
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
            ChartArea chartArea3 = new ChartArea();
            Legend legend3 = new Legend();
            Series series3 = new Series();
            ChartArea chartArea4 = new ChartArea();
            Legend legend4 = new Legend();
            Series series4 = new Series();
            lastMonthStatisticsChart = new Chart();
            label1 = new Label();
            label2 = new Label();
            lastMonthExpensesAndEarnings = new Chart();
            groupBox1 = new GroupBox();
            IncomeTag = new Label();
            label19 = new Label();
            ExpenseTag = new Label();
            label17 = new Label();
            DifferenceLabel = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            ExtraExpenseInfoTextBox = new RichTextBox();
            label10 = new Label();
            label9 = new Label();
            ExpenseRegistrationDateInput = new ComboBox();
            ExpenseReasonInput = new ComboBox();
            label8 = new Label();
            ExtraIncomeDetailsText = new RichTextBox();
            label7 = new Label();
            IncomeRegistrationDateTextBox = new ComboBox();
            label6 = new Label();
            IncomeReasonText = new ComboBox();
            label5 = new Label();
            EgressButton = new Button();
            InputButton = new Button();
            ExpenseAmountInput = new TextBox();
            IncomeAmountTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)lastMonthStatisticsChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lastMonthExpensesAndEarnings).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lastMonthStatisticsChart
            // 
            lastMonthStatisticsChart.BackColor = Color.Transparent;
            lastMonthStatisticsChart.BorderlineColor = Color.Empty;
            chartArea3.Name = "ChartArea1";
            lastMonthStatisticsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            lastMonthStatisticsChart.Legends.Add(legend3);
            lastMonthStatisticsChart.Location = new Point(6, 54);
            lastMonthStatisticsChart.Name = "lastMonthStatisticsChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = SeriesChartType.Pie;
            series3.Font = new Font("Segoe UI", 10F);
            series3.LabelBackColor = Color.Transparent;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            lastMonthStatisticsChart.Series.Add(series3);
            lastMonthStatisticsChart.Size = new Size(408, 206);
            lastMonthStatisticsChart.TabIndex = 0;
            lastMonthStatisticsChart.Text = "Rendimiento del ultimo mes";
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
            // lastMonthExpensesAndEarnings
            // 
            lastMonthExpensesAndEarnings.BackColor = Color.Transparent;
            lastMonthExpensesAndEarnings.BorderlineColor = Color.Empty;
            chartArea4.Name = "ChartArea1";
            lastMonthExpensesAndEarnings.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            lastMonthExpensesAndEarnings.Legends.Add(legend4);
            lastMonthExpensesAndEarnings.Location = new Point(465, 54);
            lastMonthExpensesAndEarnings.Name = "lastMonthExpensesAndEarnings";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = SeriesChartType.Pie;
            series4.Font = new Font("Segoe UI", 10F);
            series4.LabelBackColor = Color.Transparent;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            lastMonthExpensesAndEarnings.Series.Add(series4);
            lastMonthExpensesAndEarnings.Size = new Size(368, 206);
            lastMonthExpensesAndEarnings.TabIndex = 3;
            lastMonthExpensesAndEarnings.Text = "Gastos y ganancias del ultimo mes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(IncomeTag);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(ExpenseTag);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(DifferenceLabel);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lastMonthExpensesAndEarnings);
            groupBox1.Controls.Add(lastMonthStatisticsChart);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(854, 494);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Estadisticas";
            // 
            // IncomeTag
            // 
            IncomeTag.AutoSize = true;
            IncomeTag.Font = new Font("Segoe UI", 18F);
            IncomeTag.Location = new Point(598, 365);
            IncomeTag.Name = "IncomeTag";
            IncomeTag.Size = new Size(24, 32);
            IncomeTag.TabIndex = 13;
            IncomeTag.Text = "-";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 18F);
            label19.Location = new Point(465, 365);
            label19.Name = "label19";
            label19.Size = new Size(108, 32);
            label19.TabIndex = 12;
            label19.Text = "Ingresos:";
            // 
            // ExpenseTag
            // 
            ExpenseTag.AutoSize = true;
            ExpenseTag.Font = new Font("Segoe UI", 18F);
            ExpenseTag.Location = new Point(598, 326);
            ExpenseTag.Name = "ExpenseTag";
            ExpenseTag.Size = new Size(24, 32);
            ExpenseTag.TabIndex = 11;
            ExpenseTag.Text = "-";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 18F);
            label17.Location = new Point(465, 326);
            label17.Name = "label17";
            label17.Size = new Size(89, 32);
            label17.TabIndex = 10;
            label17.Text = "Gastos:";
            // 
            // DifferenceLabel
            // 
            DifferenceLabel.AutoSize = true;
            DifferenceLabel.Font = new Font("Segoe UI", 18F);
            DifferenceLabel.Location = new Point(598, 287);
            DifferenceLabel.Name = "DifferenceLabel";
            DifferenceLabel.Size = new Size(24, 32);
            DifferenceLabel.TabIndex = 9;
            DifferenceLabel.Text = "-";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 18F);
            label15.Location = new Point(465, 287);
            label15.Name = "label15";
            label15.Size = new Size(127, 32);
            label15.TabIndex = 8;
            label15.Text = "Diferencia:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F);
            label14.Location = new Point(220, 326);
            label14.Name = "label14";
            label14.Size = new Size(85, 32);
            label14.TabIndex = 7;
            label14.Text = "Pronto";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F);
            label13.Location = new Point(6, 326);
            label13.Name = "label13";
            label13.Size = new Size(186, 32);
            label13.TabIndex = 6;
            label13.Text = "Ingresos totales:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 18F);
            label.Location = new Point(220, 287);
            label.Name = "label";
            label.Size = new Size(85, 32);
            label.TabIndex = 5;
            label.Text = "Pronto";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F);
            label11.Location = new Point(6, 287);
            label11.Name = "label11";
            label11.Size = new Size(208, 32);
            label11.TabIndex = 4;
            label11.Text = "Tu mejor mes fue:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ExtraExpenseInfoTextBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(ExpenseRegistrationDateInput);
            groupBox2.Controls.Add(ExpenseReasonInput);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(ExtraIncomeDetailsText);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(IncomeRegistrationDateTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(IncomeReasonText);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(EgressButton);
            groupBox2.Controls.Add(InputButton);
            groupBox2.Controls.Add(ExpenseAmountInput);
            groupBox2.Controls.Add(IncomeAmountTextBox);
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
            // ExtraExpenseInfoTextBox
            // 
            ExtraExpenseInfoTextBox.BorderStyle = BorderStyle.None;
            ExtraExpenseInfoTextBox.Location = new Point(8, 340);
            ExtraExpenseInfoTextBox.Name = "ExtraExpenseInfoTextBox";
            ExtraExpenseInfoTextBox.Size = new Size(345, 119);
            ExtraExpenseInfoTextBox.TabIndex = 17;
            ExtraExpenseInfoTextBox.Text = "";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 322);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 16;
            label10.Text = "Mas Info";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(242, 278);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 15;
            label9.Text = "Fecha";
            // 
            // ExpenseRegistrationDateInput
            // 
            ExpenseRegistrationDateInput.FormattingEnabled = true;
            ExpenseRegistrationDateInput.Location = new Point(242, 296);
            ExpenseRegistrationDateInput.Name = "ExpenseRegistrationDateInput";
            ExpenseRegistrationDateInput.Size = new Size(111, 23);
            ExpenseRegistrationDateInput.TabIndex = 14;
            // 
            // ExpenseReasonInput
            // 
            ExpenseReasonInput.FormattingEnabled = true;
            ExpenseReasonInput.Items.AddRange(new object[] { "", "Comida", "Perro", "Ropa", "Muoqa", "Comida Rapida", "Transporte", "Deudas", "Casa", "Otro" });
            ExpenseReasonInput.Location = new Point(125, 296);
            ExpenseReasonInput.Name = "ExpenseReasonInput";
            ExpenseReasonInput.Size = new Size(111, 23);
            ExpenseReasonInput.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(125, 278);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 12;
            label8.Text = "Motivo";
            // 
            // ExtraIncomeDetailsText
            // 
            ExtraIncomeDetailsText.BorderStyle = BorderStyle.None;
            ExtraIncomeDetailsText.Location = new Point(6, 98);
            ExtraIncomeDetailsText.Name = "ExtraIncomeDetailsText";
            ExtraIncomeDetailsText.Size = new Size(345, 119);
            ExtraIncomeDetailsText.TabIndex = 11;
            ExtraIncomeDetailsText.Text = "";
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
            // IncomeRegistrationDateTextBox
            // 
            IncomeRegistrationDateTextBox.FormattingEnabled = true;
            IncomeRegistrationDateTextBox.Location = new Point(240, 54);
            IncomeRegistrationDateTextBox.Name = "IncomeRegistrationDateTextBox";
            IncomeRegistrationDateTextBox.Size = new Size(111, 23);
            IncomeRegistrationDateTextBox.TabIndex = 9;
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
            // IncomeReasonText
            // 
            IncomeReasonText.FormattingEnabled = true;
            IncomeReasonText.Items.AddRange(new object[] { "", "Sueldo", "Muoqa", "Otro" });
            IncomeReasonText.Location = new Point(123, 54);
            IncomeReasonText.Name = "IncomeReasonText";
            IncomeReasonText.Size = new Size(111, 23);
            IncomeReasonText.TabIndex = 7;
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
            // EgressButton
            // 
            EgressButton.ForeColor = Color.Black;
            EgressButton.Location = new Point(278, 465);
            EgressButton.Name = "EgressButton";
            EgressButton.Size = new Size(75, 23);
            EgressButton.TabIndex = 5;
            EgressButton.Text = "Registrar";
            EgressButton.UseVisualStyleBackColor = true;
            EgressButton.Click += EgressButton_Click;
            // 
            // InputButton
            // 
            InputButton.ForeColor = Color.Black;
            InputButton.Location = new Point(278, 223);
            InputButton.Name = "InputButton";
            InputButton.Size = new Size(75, 23);
            InputButton.TabIndex = 4;
            InputButton.Text = "Registrar";
            InputButton.UseVisualStyleBackColor = true;
            InputButton.Click += InputButton_Click;
            // 
            // ExpenseAmountInput
            // 
            ExpenseAmountInput.Location = new Point(8, 296);
            ExpenseAmountInput.Name = "ExpenseAmountInput";
            ExpenseAmountInput.Size = new Size(111, 23);
            ExpenseAmountInput.TabIndex = 3;
            ExpenseAmountInput.KeyPress += AmountTxt_KeyPress;
            // 
            // IncomeAmountTextBox
            // 
            IncomeAmountTextBox.Location = new Point(6, 54);
            IncomeAmountTextBox.Name = "IncomeAmountTextBox";
            IncomeAmountTextBox.Size = new Size(111, 23);
            IncomeAmountTextBox.TabIndex = 2;
            IncomeAmountTextBox.KeyPress += AmountTxt_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 278);
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
            ((System.ComponentModel.ISupportInitialize)lastMonthStatisticsChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)lastMonthExpensesAndEarnings).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Chart lastMonthStatisticsChart;
        private Label label1;
        private Label label2;
        private Chart lastMonthExpensesAndEarnings;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button InputButton;
        private TextBox ExpenseAmountInput;
        private TextBox IncomeAmountTextBox;
        private Label label4;
        private Label label3;
        private Button EgressButton;
        private ComboBox IncomeRegistrationDateTextBox;
        private Label label6;
        private ComboBox IncomeReasonText;
        private Label label5;
        private RichTextBox ExtraIncomeDetailsText;
        private Label label7;
        private RichTextBox ExtraExpenseInfoTextBox;
        private Label label10;
        private Label label9;
        private ComboBox ExpenseRegistrationDateInput;
        private ComboBox ExpenseReasonInput;
        private Label label8;
        private Label label11;
        private Label label;
        private Label label14;
        private Label label13;
        private Label DifferenceLabel;
        private Label label15;
        private Label ExpenseTag;
        private Label label17;
        private Label label19;
        private Label IncomeTag;
    }
}
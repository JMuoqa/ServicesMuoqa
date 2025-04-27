using System.Windows.Forms;

namespace ServicesMuoqa.Views
{
    partial class UploadJob
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            jobData = new DataGridView();
            jobAddGroup = new GroupBox();
            entryDateInput = new ComboBox();
            addJobButton = new Button();
            deliveryDateInput = new TextBox();
            jobStatusInput = new TextBox();
            jobPriceInput = new TextBox();
            jobNameInput = new TextBox();
            customerNumberInput = new TextBox();
            customerNameInput = new TextBox();
            deliveryDate = new Label();
            entryDate = new Label();
            jobStatus = new Label();
            jobPrice = new Label();
            jobName = new Label();
            customerNumber = new Label();
            customerName = new Label();
            modifyJobButton = new Button();
            jobModifyGroup = new GroupBox();
            jobStatusTextBoxForModify = new ComboBox();
            instruction = new Label();
            jobIdTextBoxForModify = new TextBox();
            label8 = new Label();
            deliveryDateTextBoxForModify = new TextBox();
            entryDateTextBoxForModify = new TextBox();
            jobPriceTextBoxForModify = new TextBox();
            jobNameTextBoxForModify = new TextBox();
            customerNumberTextBoxForModify = new TextBox();
            customerNameTextBoxForModify = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)jobData).BeginInit();
            jobAddGroup.SuspendLayout();
            jobModifyGroup.SuspendLayout();
            SuspendLayout();
            // 
            // jobData
            // 
            jobData.AllowUserToAddRows = false;
            jobData.AllowUserToResizeRows = false;
            jobData.BackgroundColor = Color.FromArgb(10, 16, 25);
            jobData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(200, 200, 200);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(100, 100, 100);
            jobData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            jobData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            jobData.DefaultCellStyle = dataGridViewCellStyle4;
            jobData.EnableHeadersVisualStyles = false;
            jobData.GridColor = Color.FromArgb(100, 100, 100);
            jobData.Location = new Point(12, 12);
            jobData.Name = "jobData";
            jobData.ReadOnly = true;
            jobData.RowHeadersVisible = false;
            jobData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            jobData.Size = new Size(1215, 195);
            jobData.TabIndex = 4;
            // 
            // jobAddGroup
            // 
            jobAddGroup.Controls.Add(entryDateInput);
            jobAddGroup.Controls.Add(addJobButton);
            jobAddGroup.Controls.Add(deliveryDateInput);
            jobAddGroup.Controls.Add(jobStatusInput);
            jobAddGroup.Controls.Add(jobPriceInput);
            jobAddGroup.Controls.Add(jobNameInput);
            jobAddGroup.Controls.Add(customerNumberInput);
            jobAddGroup.Controls.Add(customerNameInput);
            jobAddGroup.Controls.Add(deliveryDate);
            jobAddGroup.Controls.Add(entryDate);
            jobAddGroup.Controls.Add(jobStatus);
            jobAddGroup.Controls.Add(jobPrice);
            jobAddGroup.Controls.Add(jobName);
            jobAddGroup.Controls.Add(customerNumber);
            jobAddGroup.Controls.Add(customerName);
            jobAddGroup.ForeColor = Color.White;
            jobAddGroup.Location = new Point(12, 213);
            jobAddGroup.Name = "jobAddGroup";
            jobAddGroup.Size = new Size(957, 139);
            jobAddGroup.TabIndex = 5;
            jobAddGroup.TabStop = false;
            jobAddGroup.Text = "Añadir";
            // 
            // entryDateInput
            // 
            entryDateInput.FormattingEnabled = true;
            entryDateInput.Items.AddRange(new object[] { "", "Presupuestar", "Confirmados", "Esperando Corf", "Sin reparación", "Reparado" });
            entryDateInput.Location = new Point(686, 46);
            entryDateInput.Name = "entryDateInput";
            entryDateInput.Size = new Size(130, 23);
            entryDateInput.TabIndex = 17;
            // 
            // addJobButton
            // 
            addJobButton.BackColor = Color.Transparent;
            addJobButton.FlatStyle = FlatStyle.Popup;
            addJobButton.ForeColor = Color.White;
            addJobButton.Location = new Point(821, 104);
            addJobButton.Name = "addJobButton";
            addJobButton.Size = new Size(130, 29);
            addJobButton.TabIndex = 16;
            addJobButton.Text = "Agregar";
            addJobButton.UseVisualStyleBackColor = false;
            addJobButton.Click += addJobButton_Click;
            // 
            // deliveryDateInput
            // 
            deliveryDateInput.Location = new Point(822, 46);
            deliveryDateInput.Name = "deliveryDateInput";
            deliveryDateInput.Size = new Size(130, 23);
            deliveryDateInput.TabIndex = 15;
            // 
            // jobStatusInput
            // 
            jobStatusInput.Location = new Point(550, 46);
            jobStatusInput.Name = "jobStatusInput";
            jobStatusInput.Size = new Size(130, 23);
            jobStatusInput.TabIndex = 12;
            // 
            // jobPriceInput
            // 
            jobPriceInput.Location = new Point(414, 46);
            jobPriceInput.Name = "jobPriceInput";
            jobPriceInput.Size = new Size(130, 23);
            jobPriceInput.TabIndex = 11;
            jobPriceInput.KeyPress += PriceTextBox_KeyPress;
            // 
            // jobNameInput
            // 
            jobNameInput.Location = new Point(278, 46);
            jobNameInput.Name = "jobNameInput";
            jobNameInput.Size = new Size(130, 23);
            jobNameInput.TabIndex = 10;
            // 
            // customerNumberInput
            // 
            customerNumberInput.Location = new Point(142, 46);
            customerNumberInput.Name = "customerNumberInput";
            customerNumberInput.Size = new Size(130, 23);
            customerNumberInput.TabIndex = 9;
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(6, 46);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(130, 23);
            customerNameInput.TabIndex = 8;
            // 
            // deliveryDate
            // 
            deliveryDate.AutoSize = true;
            deliveryDate.Location = new Point(822, 19);
            deliveryDate.Name = "deliveryDate";
            deliveryDate.Size = new Size(97, 15);
            deliveryDate.TabIndex = 7;
            deliveryDate.Text = "Dia para Entregar";
            // 
            // entryDate
            // 
            entryDate.AutoSize = true;
            entryDate.Location = new Point(686, 19);
            entryDate.Name = "entryDate";
            entryDate.Size = new Size(82, 15);
            entryDate.TabIndex = 6;
            entryDate.Text = "Dia de Ingreso";
            // 
            // jobStatus
            // 
            jobStatus.AutoSize = true;
            jobStatus.Location = new Point(550, 19);
            jobStatus.Name = "jobStatus";
            jobStatus.Size = new Size(103, 15);
            jobStatus.TabIndex = 4;
            jobStatus.Text = "Estado del Trabajo";
            // 
            // jobPrice
            // 
            jobPrice.AutoSize = true;
            jobPrice.Location = new Point(414, 19);
            jobPrice.Name = "jobPrice";
            jobPrice.Size = new Size(101, 15);
            jobPrice.TabIndex = 3;
            jobPrice.Text = "Precio del Trabajo";
            // 
            // jobName
            // 
            jobName.AutoSize = true;
            jobName.Location = new Point(278, 19);
            jobName.Name = "jobName";
            jobName.Size = new Size(112, 15);
            jobName.TabIndex = 2;
            jobName.Text = "Nombre del Trabajo";
            // 
            // customerNumber
            // 
            customerNumber.AutoSize = true;
            customerNumber.Location = new Point(142, 19);
            customerNumber.Name = "customerNumber";
            customerNumber.Size = new Size(110, 15);
            customerNumber.TabIndex = 1;
            customerNumber.Text = "Numero del Cliente";
            // 
            // customerName
            // 
            customerName.AutoSize = true;
            customerName.Location = new Point(6, 19);
            customerName.Name = "customerName";
            customerName.Size = new Size(110, 15);
            customerName.TabIndex = 0;
            customerName.Text = "Nombre del Cliente";
            // 
            // modifyJobButton
            // 
            modifyJobButton.BackColor = Color.Transparent;
            modifyJobButton.FlatStyle = FlatStyle.Popup;
            modifyJobButton.ForeColor = Color.White;
            modifyJobButton.Location = new Point(822, 104);
            modifyJobButton.Name = "modifyJobButton";
            modifyJobButton.Size = new Size(130, 29);
            modifyJobButton.TabIndex = 17;
            modifyJobButton.Text = "Modificar";
            modifyJobButton.UseVisualStyleBackColor = false;
            modifyJobButton.Click += modifyJobButton_Click;
            // 
            // jobModifyGroup
            // 
            jobModifyGroup.Controls.Add(jobStatusTextBoxForModify);
            jobModifyGroup.Controls.Add(instruction);
            jobModifyGroup.Controls.Add(jobIdTextBoxForModify);
            jobModifyGroup.Controls.Add(label8);
            jobModifyGroup.Controls.Add(deliveryDateTextBoxForModify);
            jobModifyGroup.Controls.Add(modifyJobButton);
            jobModifyGroup.Controls.Add(entryDateTextBoxForModify);
            jobModifyGroup.Controls.Add(jobPriceTextBoxForModify);
            jobModifyGroup.Controls.Add(jobNameTextBoxForModify);
            jobModifyGroup.Controls.Add(customerNumberTextBoxForModify);
            jobModifyGroup.Controls.Add(customerNameTextBoxForModify);
            jobModifyGroup.Controls.Add(label1);
            jobModifyGroup.Controls.Add(label2);
            jobModifyGroup.Controls.Add(label3);
            jobModifyGroup.Controls.Add(label4);
            jobModifyGroup.Controls.Add(label5);
            jobModifyGroup.Controls.Add(label6);
            jobModifyGroup.Controls.Add(label7);
            jobModifyGroup.ForeColor = Color.White;
            jobModifyGroup.Location = new Point(12, 367);
            jobModifyGroup.Name = "jobModifyGroup";
            jobModifyGroup.Size = new Size(957, 139);
            jobModifyGroup.TabIndex = 18;
            jobModifyGroup.TabStop = false;
            jobModifyGroup.Text = "Modificar";
            // 
            // jobStatusTextBoxForModify
            // 
            jobStatusTextBoxForModify.FormattingEnabled = true;
            jobStatusTextBoxForModify.Items.AddRange(new object[] { "", "Presupuestar", "Confirmados", "Esperando Corf", "Sin reparación", "Reparado" });
            jobStatusTextBoxForModify.Location = new Point(686, 46);
            jobStatusTextBoxForModify.Name = "jobStatusTextBoxForModify";
            jobStatusTextBoxForModify.Size = new Size(130, 23);
            jobStatusTextBoxForModify.TabIndex = 21;
            // 
            // instruction
            // 
            instruction.AutoSize = true;
            instruction.Location = new Point(599, 111);
            instruction.Name = "instruction";
            instruction.Size = new Size(217, 15);
            instruction.TabIndex = 20;
            instruction.Text = "El unico parametro obligatorio es el \"Id\"";
            // 
            // jobIdTextBoxForModify
            // 
            jobIdTextBoxForModify.Location = new Point(6, 46);
            jobIdTextBoxForModify.Name = "jobIdTextBoxForModify";
            jobIdTextBoxForModify.Size = new Size(130, 23);
            jobIdTextBoxForModify.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 19);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 18;
            label8.Text = "Id del Trabajo *";
            // 
            // deliveryDateTextBoxForModify
            // 
            deliveryDateTextBoxForModify.Location = new Point(6, 104);
            deliveryDateTextBoxForModify.Name = "deliveryDateTextBoxForModify";
            deliveryDateTextBoxForModify.Size = new Size(130, 23);
            deliveryDateTextBoxForModify.TabIndex = 15;
            // 
            // entryDateTextBoxForModify
            // 
            entryDateTextBoxForModify.Location = new Point(822, 46);
            entryDateTextBoxForModify.Name = "entryDateTextBoxForModify";
            entryDateTextBoxForModify.Size = new Size(130, 23);
            entryDateTextBoxForModify.TabIndex = 14;
            // 
            // jobPriceTextBoxForModify
            // 
            jobPriceTextBoxForModify.Location = new Point(550, 46);
            jobPriceTextBoxForModify.Name = "jobPriceTextBoxForModify";
            jobPriceTextBoxForModify.Size = new Size(130, 23);
            jobPriceTextBoxForModify.TabIndex = 11;
            jobPriceTextBoxForModify.KeyPress += PriceTextBox_KeyPress;
            // 
            // jobNameTextBoxForModify
            // 
            jobNameTextBoxForModify.Location = new Point(414, 46);
            jobNameTextBoxForModify.Name = "jobNameTextBoxForModify";
            jobNameTextBoxForModify.Size = new Size(130, 23);
            jobNameTextBoxForModify.TabIndex = 10;
            // 
            // customerNumberTextBoxForModify
            // 
            customerNumberTextBoxForModify.Location = new Point(278, 46);
            customerNumberTextBoxForModify.Name = "customerNumberTextBoxForModify";
            customerNumberTextBoxForModify.Size = new Size(130, 23);
            customerNumberTextBoxForModify.TabIndex = 9;
            // 
            // customerNameTextBoxForModify
            // 
            customerNameTextBoxForModify.Location = new Point(142, 46);
            customerNameTextBoxForModify.Name = "customerNameTextBoxForModify";
            customerNameTextBoxForModify.Size = new Size(130, 23);
            customerNameTextBoxForModify.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 77);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 7;
            label1.Text = "Dia para Entregar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(822, 19);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 6;
            label2.Text = "Dia de Ingreso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(686, 19);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 4;
            label3.Text = "Estado del Trabajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(550, 19);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio del Trabajo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 19);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 2;
            label5.Text = "Nombre del Trabajo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 19);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 1;
            label6.Text = "Numero del Cliente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(142, 19);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 0;
            label7.Text = "Nombre del Cliente";
            // 
            // UploadJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 16, 25);
            ClientSize = new Size(1239, 518);
            Controls.Add(jobModifyGroup);
            Controls.Add(jobAddGroup);
            Controls.Add(jobData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UploadJob";
            Text = "UploadJob";
            ((System.ComponentModel.ISupportInitialize)jobData).EndInit();
            jobAddGroup.ResumeLayout(false);
            jobAddGroup.PerformLayout();
            jobModifyGroup.ResumeLayout(false);
            jobModifyGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView jobData;
        private GroupBox jobAddGroup;
        private Label customerNumber;
        private Label customerName;
        private Label jobPrice;
        private Label jobName;
        private Label jobStatus;
        private TextBox deliveryDateInput;
        private TextBox jobStatusInput;
        private TextBox jobPriceInput;
        private TextBox jobNameInput;
        private TextBox customerNumberInput;
        private TextBox customerNameInput;
        private Label deliveryDate;
        private Label entryDate;
        private Button addJobButton;
        private Button modifyJobButton;
        private GroupBox jobModifyGroup;
        private TextBox deliveryDateTextBoxForModify;
        private TextBox entryDateTextBoxForModify;
        private TextBox jobPriceTextBoxForModify;
        private TextBox jobNameTextBoxForModify;
        private TextBox customerNumberTextBoxForModify;
        private TextBox customerNameTextBoxForModify;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox jobIdTextBoxForModify;
        private Label label8;
        private Label instruction;
        private ComboBox jobStatusTextBoxForModify;
        private ComboBox entryDateInput;
    }
}
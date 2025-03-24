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
            addJobButton = new Button();
            deliveryDateText = new TextBox();
            jobStatusText = new TextBox();
            jobPriceText = new TextBox();
            jobNameText = new TextBox();
            customerNumberText = new TextBox();
            customerNameText = new TextBox();
            deliveryDate = new Label();
            entryDate = new Label();
            jobStatus = new Label();
            jobPrice = new Label();
            jobName = new Label();
            customerNumber = new Label();
            customerName = new Label();
            modifyJobButton = new Button();
            jobModifyGroup = new GroupBox();
            jobStatusTextModify = new ComboBox();
            instruction = new Label();
            jobIdTextModify = new TextBox();
            label8 = new Label();
            deliveryDateTextModify = new TextBox();
            entryDateTextModify = new TextBox();
            jobPriceTextModify = new TextBox();
            jobNameTextModify = new TextBox();
            customerNumberTextModify = new TextBox();
            customerNameTextModify = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            entryDateText = new ComboBox();
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
            jobAddGroup.Controls.Add(entryDateText);
            jobAddGroup.Controls.Add(addJobButton);
            jobAddGroup.Controls.Add(deliveryDateText);
            jobAddGroup.Controls.Add(jobStatusText);
            jobAddGroup.Controls.Add(jobPriceText);
            jobAddGroup.Controls.Add(jobNameText);
            jobAddGroup.Controls.Add(customerNumberText);
            jobAddGroup.Controls.Add(customerNameText);
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
            // deliveryDateText
            // 
            deliveryDateText.Location = new Point(822, 46);
            deliveryDateText.Name = "deliveryDateText";
            deliveryDateText.Size = new Size(130, 23);
            deliveryDateText.TabIndex = 15;
            // 
            // jobStatusText
            // 
            jobStatusText.Location = new Point(550, 46);
            jobStatusText.Name = "jobStatusText";
            jobStatusText.Size = new Size(130, 23);
            jobStatusText.TabIndex = 12;
            // 
            // jobPriceText
            // 
            jobPriceText.Location = new Point(414, 46);
            jobPriceText.Name = "jobPriceText";
            jobPriceText.Size = new Size(130, 23);
            jobPriceText.TabIndex = 11;
            jobPriceText.KeyPress += PriceTextBox_KeyPress;
            // 
            // jobNameText
            // 
            jobNameText.Location = new Point(278, 46);
            jobNameText.Name = "jobNameText";
            jobNameText.Size = new Size(130, 23);
            jobNameText.TabIndex = 10;
            // 
            // customerNumberText
            // 
            customerNumberText.Location = new Point(142, 46);
            customerNumberText.Name = "customerNumberText";
            customerNumberText.Size = new Size(130, 23);
            customerNumberText.TabIndex = 9;
            // 
            // customerNameText
            // 
            customerNameText.Location = new Point(6, 46);
            customerNameText.Name = "customerNameText";
            customerNameText.Size = new Size(130, 23);
            customerNameText.TabIndex = 8;
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
            jobModifyGroup.Controls.Add(jobStatusTextModify);
            jobModifyGroup.Controls.Add(instruction);
            jobModifyGroup.Controls.Add(jobIdTextModify);
            jobModifyGroup.Controls.Add(label8);
            jobModifyGroup.Controls.Add(deliveryDateTextModify);
            jobModifyGroup.Controls.Add(modifyJobButton);
            jobModifyGroup.Controls.Add(entryDateTextModify);
            jobModifyGroup.Controls.Add(jobPriceTextModify);
            jobModifyGroup.Controls.Add(jobNameTextModify);
            jobModifyGroup.Controls.Add(customerNumberTextModify);
            jobModifyGroup.Controls.Add(customerNameTextModify);
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
            // jobStatusTextModify
            // 
            jobStatusTextModify.FormattingEnabled = true;
            jobStatusTextModify.Items.AddRange(new object[] { "", "Presupuestar", "Confirmados", "Esperando Corf", "Sin reparación", "Reparado" });
            jobStatusTextModify.Location = new Point(686, 46);
            jobStatusTextModify.Name = "jobStatusTextModify";
            jobStatusTextModify.Size = new Size(130, 23);
            jobStatusTextModify.TabIndex = 21;
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
            // jobIdTextModify
            // 
            jobIdTextModify.Location = new Point(6, 46);
            jobIdTextModify.Name = "jobIdTextModify";
            jobIdTextModify.Size = new Size(130, 23);
            jobIdTextModify.TabIndex = 19;
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
            // deliveryDateTextModify
            // 
            deliveryDateTextModify.Location = new Point(6, 104);
            deliveryDateTextModify.Name = "deliveryDateTextModify";
            deliveryDateTextModify.Size = new Size(130, 23);
            deliveryDateTextModify.TabIndex = 15;
            // 
            // entryDateTextModify
            // 
            entryDateTextModify.Location = new Point(822, 46);
            entryDateTextModify.Name = "entryDateTextModify";
            entryDateTextModify.Size = new Size(130, 23);
            entryDateTextModify.TabIndex = 14;
            // 
            // jobPriceTextModify
            // 
            jobPriceTextModify.Location = new Point(550, 46);
            jobPriceTextModify.Name = "jobPriceTextModify";
            jobPriceTextModify.Size = new Size(130, 23);
            jobPriceTextModify.TabIndex = 11;
            jobPriceTextModify.KeyPress += PriceTextBox_KeyPress;
            // 
            // jobNameTextModify
            // 
            jobNameTextModify.Location = new Point(414, 46);
            jobNameTextModify.Name = "jobNameTextModify";
            jobNameTextModify.Size = new Size(130, 23);
            jobNameTextModify.TabIndex = 10;
            // 
            // customerNumberTextModify
            // 
            customerNumberTextModify.Location = new Point(278, 46);
            customerNumberTextModify.Name = "customerNumberTextModify";
            customerNumberTextModify.Size = new Size(130, 23);
            customerNumberTextModify.TabIndex = 9;
            // 
            // customerNameTextModify
            // 
            customerNameTextModify.Location = new Point(142, 46);
            customerNameTextModify.Name = "customerNameTextModify";
            customerNameTextModify.Size = new Size(130, 23);
            customerNameTextModify.TabIndex = 8;
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
            // entryDateText
            // 
            entryDateText.FormattingEnabled = true;
            entryDateText.Items.AddRange(new object[] { "", "Presupuestar", "Confirmados", "Esperando Corf", "Sin reparación", "Reparado" });
            entryDateText.Location = new Point(686, 46);
            entryDateText.Name = "entryDateText";
            entryDateText.Size = new Size(130, 23);
            entryDateText.TabIndex = 17;
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
        private TextBox deliveryDateText;
        private TextBox jobStatusText;
        private TextBox jobPriceText;
        private TextBox jobNameText;
        private TextBox customerNumberText;
        private TextBox customerNameText;
        private Label deliveryDate;
        private Label entryDate;
        private Button addJobButton;
        private Button modifyJobButton;
        private GroupBox jobModifyGroup;
        private TextBox deliveryDateTextModify;
        private TextBox entryDateTextModify;
        private TextBox jobPriceTextModify;
        private TextBox jobNameTextModify;
        private TextBox customerNumberTextModify;
        private TextBox customerNameTextModify;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox jobIdTextModify;
        private Label label8;
        private Label instruction;
        private ComboBox jobStatusTextModify;
        private ComboBox entryDateText;
    }
}
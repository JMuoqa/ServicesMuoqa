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
            jobConfGroup = new GroupBox();
            modifyJobButton = new Button();
            addJobButton = new Button();
            deliveryDateText = new TextBox();
            entryDateText = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)jobData).BeginInit();
            jobConfGroup.SuspendLayout();
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
            jobData.Size = new Size(1215, 336);
            jobData.TabIndex = 4;
            // 
            // jobConfGroup
            // 
            jobConfGroup.Controls.Add(modifyJobButton);
            jobConfGroup.Controls.Add(addJobButton);
            jobConfGroup.Controls.Add(deliveryDateText);
            jobConfGroup.Controls.Add(entryDateText);
            jobConfGroup.Controls.Add(jobStatusText);
            jobConfGroup.Controls.Add(jobPriceText);
            jobConfGroup.Controls.Add(jobNameText);
            jobConfGroup.Controls.Add(customerNumberText);
            jobConfGroup.Controls.Add(customerNameText);
            jobConfGroup.Controls.Add(deliveryDate);
            jobConfGroup.Controls.Add(entryDate);
            jobConfGroup.Controls.Add(jobStatus);
            jobConfGroup.Controls.Add(jobPrice);
            jobConfGroup.Controls.Add(jobName);
            jobConfGroup.Controls.Add(customerNumber);
            jobConfGroup.Controls.Add(customerName);
            jobConfGroup.ForeColor = Color.White;
            jobConfGroup.Location = new Point(12, 354);
            jobConfGroup.Name = "jobConfGroup";
            jobConfGroup.Size = new Size(957, 139);
            jobConfGroup.TabIndex = 5;
            jobConfGroup.TabStop = false;
            jobConfGroup.Text = "Configuración";
            // 
            // modifyJobButton
            // 
            modifyJobButton.BackColor = Color.Transparent;
            modifyJobButton.FlatStyle = FlatStyle.Popup;
            modifyJobButton.ForeColor = Color.White;
            modifyJobButton.Location = new Point(172, 91);
            modifyJobButton.Name = "modifyJobButton";
            modifyJobButton.Size = new Size(144, 29);
            modifyJobButton.TabIndex = 17;
            modifyJobButton.Text = "Modificar";
            modifyJobButton.UseVisualStyleBackColor = false;
            // 
            // addJobButton
            // 
            addJobButton.BackColor = Color.Transparent;
            addJobButton.FlatStyle = FlatStyle.Popup;
            addJobButton.ForeColor = Color.White;
            addJobButton.Location = new Point(6, 91);
            addJobButton.Name = "addJobButton";
            addJobButton.Size = new Size(144, 29);
            addJobButton.TabIndex = 16;
            addJobButton.Text = "Añadir";
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
            // entryDateText
            // 
            entryDateText.Location = new Point(686, 46);
            entryDateText.Name = "entryDateText";
            entryDateText.Size = new Size(130, 23);
            entryDateText.TabIndex = 14;
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
            jobStatus.Size = new Size(102, 15);
            jobStatus.TabIndex = 4;
            jobStatus.Text = "Estado del Trabajo";
            // 
            // jobPrice
            // 
            jobPrice.AutoSize = true;
            jobPrice.Location = new Point(414, 19);
            jobPrice.Name = "jobPrice";
            jobPrice.Size = new Size(100, 15);
            jobPrice.TabIndex = 3;
            jobPrice.Text = "Precio del Trabajo";
            // 
            // jobName
            // 
            jobName.AutoSize = true;
            jobName.Location = new Point(278, 19);
            jobName.Name = "jobName";
            jobName.Size = new Size(111, 15);
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
            // UploadJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 16, 25);
            ClientSize = new Size(1239, 518);
            Controls.Add(jobConfGroup);
            Controls.Add(jobData);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UploadJob";
            Text = "UploadJob";
            ((System.ComponentModel.ISupportInitialize)jobData).EndInit();
            jobConfGroup.ResumeLayout(false);
            jobConfGroup.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView jobData;
        private GroupBox jobConfGroup;
        private Label customerNumber;
        private Label customerName;
        private Label jobPrice;
        private Label jobName;
        private Label jobStatus;
        private TextBox deliveryDateText;
        private TextBox entryDateText;
        private TextBox jobStatusText;
        private TextBox jobPriceText;
        private TextBox jobNameText;
        private TextBox customerNumberText;
        private TextBox customerNameText;
        private Label deliveryDate;
        private Label entryDate;
        private Button addJobButton;
        private Button modifyJobButton;
    }
}
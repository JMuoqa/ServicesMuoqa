using System.Windows.Forms;

namespace ServicesMuoqa.Views
{
    partial class ViewMain
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupActivation = new GroupBox();
            activateBtn = new Button();
            idTextDelete = new TextBox();
            idLabelDelete = new Label();
            deleteButton = new Button();
            groupAdd = new GroupBox();
            addButton = new Button();
            priceLabelAdd = new Label();
            priceTextAdd = new TextBox();
            nameTextAdd = new TextBox();
            nameLabelAdd = new Label();
            groupEdit = new GroupBox();
            editButton = new Button();
            label2 = new Label();
            label1 = new Label();
            idTextEdit = new TextBox();
            priceTextEdit = new TextBox();
            label3 = new Label();
            nameTextEdit = new TextBox();
            groupSearch = new GroupBox();
            cmbTextSearch = new ComboBox();
            searchButton = new Button();
            nameLabelSearch = new Label();
            idLabelSearch = new Label();
            servicesData = new DataGridView();
            groupActivation.SuspendLayout();
            groupAdd.SuspendLayout();
            groupEdit.SuspendLayout();
            groupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicesData).BeginInit();
            SuspendLayout();
            // 
            // groupActivation
            // 
            groupActivation.Controls.Add(activateBtn);
            groupActivation.Controls.Add(idTextDelete);
            groupActivation.Controls.Add(idLabelDelete);
            groupActivation.Controls.Add(deleteButton);
            groupActivation.ForeColor = Color.White;
            groupActivation.Location = new Point(12, 377);
            groupActivation.Name = "groupActivation";
            groupActivation.Size = new Size(200, 115);
            groupActivation.TabIndex = 0;
            groupActivation.TabStop = false;
            groupActivation.Text = "Activación";
            // 
            // activateBtn
            // 
            activateBtn.ForeColor = Color.Black;
            activateBtn.Location = new Point(10, 86);
            activateBtn.Name = "activateBtn";
            activateBtn.Size = new Size(90, 23);
            activateBtn.TabIndex = 3;
            activateBtn.Text = "Activar";
            activateBtn.UseVisualStyleBackColor = true;
            activateBtn.Click += activateBtn_Click;
            // 
            // idTextDelete
            // 
            idTextDelete.Location = new Point(10, 57);
            idTextDelete.Name = "idTextDelete";
            idTextDelete.PlaceholderText = "1, 2, 3";
            idTextDelete.Size = new Size(184, 23);
            idTextDelete.TabIndex = 2;
            idTextDelete.KeyPress += idTextDelete_KeyPress;
            // 
            // idLabelDelete
            // 
            idLabelDelete.AutoSize = true;
            idLabelDelete.Location = new Point(10, 31);
            idLabelDelete.Name = "idLabelDelete";
            idLabelDelete.Size = new Size(29, 15);
            idLabelDelete.TabIndex = 1;
            idLabelDelete.Text = "ID: *";
            // 
            // deleteButton
            // 
            deleteButton.ForeColor = Color.Black;
            deleteButton.Location = new Point(104, 86);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(90, 23);
            deleteButton.TabIndex = 0;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // groupAdd
            // 
            groupAdd.Controls.Add(addButton);
            groupAdd.Controls.Add(priceLabelAdd);
            groupAdd.Controls.Add(priceTextAdd);
            groupAdd.Controls.Add(nameTextAdd);
            groupAdd.Controls.Add(nameLabelAdd);
            groupAdd.ForeColor = Color.White;
            groupAdd.Location = new Point(218, 377);
            groupAdd.Name = "groupAdd";
            groupAdd.Size = new Size(384, 115);
            groupAdd.TabIndex = 1;
            groupAdd.TabStop = false;
            groupAdd.Text = "Añadir";
            // 
            // addButton
            // 
            addButton.ForeColor = Color.Black;
            addButton.Location = new Point(285, 86);
            addButton.Name = "addButton";
            addButton.Size = new Size(95, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Añadir";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // priceLabelAdd
            // 
            priceLabelAdd.AutoSize = true;
            priceLabelAdd.Location = new Point(196, 31);
            priceLabelAdd.Name = "priceLabelAdd";
            priceLabelAdd.Size = new Size(51, 15);
            priceLabelAdd.TabIndex = 5;
            priceLabelAdd.Text = "Precio: *";
            // 
            // priceTextAdd
            // 
            priceTextAdd.Location = new Point(196, 57);
            priceTextAdd.Name = "priceTextAdd";
            priceTextAdd.PlaceholderText = "$100000";
            priceTextAdd.Size = new Size(184, 23);
            priceTextAdd.TabIndex = 4;
            priceTextAdd.KeyPress += priceTextAdd_KeyPress;
            // 
            // nameTextAdd
            // 
            nameTextAdd.Location = new Point(6, 57);
            nameTextAdd.Name = "nameTextAdd";
            nameTextAdd.PlaceholderText = "Servicio";
            nameTextAdd.Size = new Size(184, 23);
            nameTextAdd.TabIndex = 3;
            nameTextAdd.KeyPress += nameTextAdd_KeyPress;
            // 
            // nameLabelAdd
            // 
            nameLabelAdd.AutoSize = true;
            nameLabelAdd.Location = new Point(6, 31);
            nameLabelAdd.Name = "nameLabelAdd";
            nameLabelAdd.Size = new Size(62, 15);
            nameLabelAdd.TabIndex = 0;
            nameLabelAdd.Text = "Nombre: *";
            // 
            // groupEdit
            // 
            groupEdit.Controls.Add(editButton);
            groupEdit.Controls.Add(label2);
            groupEdit.Controls.Add(label1);
            groupEdit.Controls.Add(idTextEdit);
            groupEdit.Controls.Add(priceTextEdit);
            groupEdit.Controls.Add(label3);
            groupEdit.Controls.Add(nameTextEdit);
            groupEdit.ForeColor = Color.White;
            groupEdit.Location = new Point(608, 377);
            groupEdit.Name = "groupEdit";
            groupEdit.Size = new Size(372, 115);
            groupEdit.TabIndex = 2;
            groupEdit.TabStop = false;
            groupEdit.Text = "Editar";
            // 
            // editButton
            // 
            editButton.ForeColor = Color.Black;
            editButton.Location = new Point(270, 86);
            editButton.Name = "editButton";
            editButton.Size = new Size(95, 23);
            editButton.TabIndex = 12;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 31);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 31);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 11;
            label1.Text = "Precio";
            // 
            // idTextEdit
            // 
            idTextEdit.Location = new Point(6, 57);
            idTextEdit.Name = "idTextEdit";
            idTextEdit.PlaceholderText = "1, 2, 3";
            idTextEdit.Size = new Size(70, 23);
            idTextEdit.TabIndex = 8;
            // 
            // priceTextEdit
            // 
            priceTextEdit.Location = new Point(270, 57);
            priceTextEdit.Name = "priceTextEdit";
            priceTextEdit.PlaceholderText = "$100000";
            priceTextEdit.Size = new Size(95, 23);
            priceTextEdit.TabIndex = 10;
            priceTextEdit.KeyPress += priceTextEdit_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 31);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 7;
            label3.Text = "ID: *";
            // 
            // nameTextEdit
            // 
            nameTextEdit.Location = new Point(80, 57);
            nameTextEdit.Name = "nameTextEdit";
            nameTextEdit.PlaceholderText = "Servicio";
            nameTextEdit.Size = new Size(184, 23);
            nameTextEdit.TabIndex = 9;
            // 
            // groupSearch
            // 
            groupSearch.Controls.Add(cmbTextSearch);
            groupSearch.Controls.Add(searchButton);
            groupSearch.Controls.Add(nameLabelSearch);
            groupSearch.Controls.Add(idLabelSearch);
            groupSearch.ForeColor = Color.White;
            groupSearch.Location = new Point(996, 377);
            groupSearch.Name = "groupSearch";
            groupSearch.Size = new Size(231, 115);
            groupSearch.TabIndex = 3;
            groupSearch.TabStop = false;
            groupSearch.Text = "Buscar";
            // 
            // cmbTextSearch
            // 
            cmbTextSearch.FormattingEnabled = true;
            cmbTextSearch.Location = new Point(6, 57);
            cmbTextSearch.Name = "cmbTextSearch";
            cmbTextSearch.Size = new Size(219, 23);
            cmbTextSearch.TabIndex = 14;
            cmbTextSearch.KeyDown += cmbTextSearch_KeyDown;
            cmbTextSearch.KeyUp += cmbTextSearch_KeyUp;
            // 
            // searchButton
            // 
            searchButton.ForeColor = Color.Black;
            searchButton.Location = new Point(130, 86);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(95, 23);
            searchButton.TabIndex = 13;
            searchButton.Text = "Buscar";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // nameLabelSearch
            // 
            nameLabelSearch.AutoSize = true;
            nameLabelSearch.Location = new Point(30, 31);
            nameLabelSearch.Name = "nameLabelSearch";
            nameLabelSearch.Size = new Size(51, 15);
            nameLabelSearch.TabIndex = 1;
            nameLabelSearch.Text = "Nombre";
            // 
            // idLabelSearch
            // 
            idLabelSearch.AutoSize = true;
            idLabelSearch.Location = new Point(6, 31);
            idLabelSearch.Name = "idLabelSearch";
            idLabelSearch.Size = new Size(26, 15);
            idLabelSearch.TabIndex = 0;
            idLabelSearch.Text = "ID /";
            // 
            // servicesData
            // 
            servicesData.AllowUserToAddRows = false;
            servicesData.AllowUserToResizeRows = false;
            servicesData.BackgroundColor = Color.FromArgb(10, 16, 25);
            servicesData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(200, 200, 200);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(100, 100, 100);
            servicesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            servicesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            servicesData.DefaultCellStyle = dataGridViewCellStyle2;
            servicesData.EnableHeadersVisualStyles = false;
            servicesData.GridColor = Color.FromArgb(100, 100, 100);
            servicesData.Location = new Point(12, 12);
            servicesData.Name = "servicesData";
            servicesData.ReadOnly = true;
            servicesData.RowHeadersVisible = false;
            servicesData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            servicesData.Size = new Size(1215, 346);
            servicesData.TabIndex = 4;
            // 
            // ViewMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 16, 25);
            ClientSize = new Size(1239, 518);
            Controls.Add(servicesData);
            Controls.Add(groupSearch);
            Controls.Add(groupEdit);
            Controls.Add(groupAdd);
            Controls.Add(groupActivation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMain";
            Text = "ViewMain";
            groupActivation.ResumeLayout(false);
            groupActivation.PerformLayout();
            groupAdd.ResumeLayout(false);
            groupAdd.PerformLayout();
            groupEdit.ResumeLayout(false);
            groupEdit.PerformLayout();
            groupSearch.ResumeLayout(false);
            groupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)servicesData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupActivation;
        private TextBox idTextDelete;
        private Label idLabelDelete;
        private Button deleteButton;
        private GroupBox groupAdd;
        private Label priceLabelAdd;
        private TextBox priceTextAdd;
        private TextBox nameTextAdd;
        private Label nameLabelAdd;
        private Button addButton;
        private GroupBox groupEdit;
        private Label label1;
        private TextBox priceTextEdit;
        private TextBox nameTextEdit;
        private Label label2;
        private TextBox idTextEdit;
        private Label label3;
        private Button editButton;
        private GroupBox groupSearch;
        private Label priceLabelSearch;
        private Label nameLabelSearch;
        private Label idLabelSearch;
        private TextBox textSearch;
        private Button searchButton;
        private DataGridView servicesData;
        private Button activateBtn;
        private ComboBox cmbTextSearch;
    }
}
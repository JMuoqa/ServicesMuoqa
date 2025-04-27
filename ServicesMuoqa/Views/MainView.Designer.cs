using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ServicesMuoqa.Views
{
    partial class MainView
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
            groupActivation = new GroupBox();
            activateButton = new Button();
            deleteIdText = new TextBox();
            deleteIdLabel = new Label();
            deleteButton = new Button();
            groupAdd = new GroupBox();
            addButton = new Button();
            addPriceLabel = new Label();
            addPriceText = new TextBox();
            addNameText = new TextBox();
            addEditGroupNameLabel = new Label();
            groupEdit = new GroupBox();
            editButton = new Button();
            nameToEditLabel = new Label();
            priceToEditLabel = new Label();
            editIdText = new TextBox();
            editPriceText = new TextBox();
            idForEditingLabel = new Label();
            editNameText = new TextBox();
            groupSearch = new GroupBox();
            searchComboBoxText = new ComboBox();
            searchButton = new Button();
            nameLabelSearch = new Label();
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
            groupActivation.Controls.Add(activateButton);
            groupActivation.Controls.Add(deleteIdText);
            groupActivation.Controls.Add(deleteIdLabel);
            groupActivation.Controls.Add(deleteButton);
            groupActivation.ForeColor = Color.White;
            groupActivation.Location = new Point(12, 377);
            groupActivation.Name = "groupActivation";
            groupActivation.Size = new Size(200, 115);
            groupActivation.TabIndex = 0;
            groupActivation.TabStop = false;
            groupActivation.Text = "Activación";
            // 
            // activateButton
            // 
            activateButton.ForeColor = Color.Black;
            activateButton.Location = new Point(10, 86);
            activateButton.Name = "activateButton";
            activateButton.Size = new Size(90, 23);
            activateButton.TabIndex = 3;
            activateButton.Text = "Activar";
            activateButton.UseVisualStyleBackColor = true;
            activateButton.Click += activateButton_Click;
            // 
            // deleteIdText
            // 
            deleteIdText.Location = new Point(10, 57);
            deleteIdText.Name = "deleteIdText";
            deleteIdText.PlaceholderText = "1, 2, 3";
            deleteIdText.Size = new Size(184, 23);
            deleteIdText.TabIndex = 2;
            deleteIdText.KeyPress += deleteIdText_KeyPress;
            // 
            // deleteIdLabel
            // 
            deleteIdLabel.AutoSize = true;
            deleteIdLabel.Location = new Point(10, 31);
            deleteIdLabel.Name = "deleteIdLabel";
            deleteIdLabel.Size = new Size(29, 15);
            deleteIdLabel.TabIndex = 1;
            deleteIdLabel.Text = "ID: *";
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
            groupAdd.Controls.Add(addPriceLabel);
            groupAdd.Controls.Add(addPriceText);
            groupAdd.Controls.Add(addNameText);
            groupAdd.Controls.Add(addEditGroupNameLabel);
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
            // addPriceLabel
            // 
            addPriceLabel.AutoSize = true;
            addPriceLabel.Location = new Point(196, 31);
            addPriceLabel.Name = "addPriceLabel";
            addPriceLabel.Size = new Size(51, 15);
            addPriceLabel.TabIndex = 5;
            addPriceLabel.Text = "Precio: *";
            // 
            // addPriceText
            // 
            addPriceText.Location = new Point(196, 57);
            addPriceText.Name = "addPriceText";
            addPriceText.PlaceholderText = "$100000";
            addPriceText.Size = new Size(184, 23);
            addPriceText.TabIndex = 4;
            addPriceText.KeyPress += priceTextAdd_KeyPress;
            // 
            // addNameText
            // 
            addNameText.Location = new Point(6, 57);
            addNameText.Name = "addNameText";
            addNameText.PlaceholderText = "Servicio";
            addNameText.Size = new Size(184, 23);
            addNameText.TabIndex = 3;
            addNameText.KeyPress += addNameText_KeyPress;
            // 
            // addEditGroupNameLabel
            // 
            addEditGroupNameLabel.AutoSize = true;
            addEditGroupNameLabel.Location = new Point(6, 31);
            addEditGroupNameLabel.Name = "addEditGroupNameLabel";
            addEditGroupNameLabel.Size = new Size(62, 15);
            addEditGroupNameLabel.TabIndex = 0;
            addEditGroupNameLabel.Text = "Nombre: *";
            // 
            // groupEdit
            // 
            groupEdit.Controls.Add(editButton);
            groupEdit.Controls.Add(nameToEditLabel);
            groupEdit.Controls.Add(priceToEditLabel);
            groupEdit.Controls.Add(editIdText);
            groupEdit.Controls.Add(editPriceText);
            groupEdit.Controls.Add(idForEditingLabel);
            groupEdit.Controls.Add(editNameText);
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
            // nameToEditLabel
            // 
            nameToEditLabel.AutoSize = true;
            nameToEditLabel.Location = new Point(80, 31);
            nameToEditLabel.Name = "nameToEditLabel";
            nameToEditLabel.Size = new Size(51, 15);
            nameToEditLabel.TabIndex = 6;
            nameToEditLabel.Text = "Nombre";
            // 
            // priceToEditLabel
            // 
            priceToEditLabel.AutoSize = true;
            priceToEditLabel.Location = new Point(270, 31);
            priceToEditLabel.Name = "priceToEditLabel";
            priceToEditLabel.Size = new Size(40, 15);
            priceToEditLabel.TabIndex = 11;
            priceToEditLabel.Text = "Precio";
            // 
            // editIdText
            // 
            editIdText.Location = new Point(6, 57);
            editIdText.Name = "editIdText";
            editIdText.PlaceholderText = "1, 2, 3";
            editIdText.Size = new Size(70, 23);
            editIdText.TabIndex = 8;
            // 
            // editPriceText
            // 
            editPriceText.Location = new Point(270, 57);
            editPriceText.Name = "editPriceText";
            editPriceText.PlaceholderText = "$100000";
            editPriceText.Size = new Size(95, 23);
            editPriceText.TabIndex = 10;
            editPriceText.KeyPress += editPriceText_KeyPress;
            // 
            // idForEditingLabel
            // 
            idForEditingLabel.AutoSize = true;
            idForEditingLabel.Location = new Point(6, 31);
            idForEditingLabel.Name = "idForEditingLabel";
            idForEditingLabel.Size = new Size(29, 15);
            idForEditingLabel.TabIndex = 7;
            idForEditingLabel.Text = "ID: *";
            // 
            // editNameText
            // 
            editNameText.Location = new Point(80, 57);
            editNameText.Name = "editNameText";
            editNameText.PlaceholderText = "Servicio";
            editNameText.Size = new Size(184, 23);
            editNameText.TabIndex = 9;
            // 
            // groupSearch
            // 
            groupSearch.Controls.Add(searchComboBoxText);
            groupSearch.Controls.Add(searchButton);
            groupSearch.Controls.Add(nameLabelSearch);
            groupSearch.ForeColor = Color.White;
            groupSearch.Location = new Point(996, 377);
            groupSearch.Name = "groupSearch";
            groupSearch.Size = new Size(231, 115);
            groupSearch.TabIndex = 3;
            groupSearch.TabStop = false;
            groupSearch.Text = "Buscar";
            // 
            // searchComboBoxText
            // 
            searchComboBoxText.FormattingEnabled = true;
            searchComboBoxText.Location = new Point(6, 57);
            searchComboBoxText.Name = "searchComboBoxText";
            searchComboBoxText.Size = new Size(219, 23);
            searchComboBoxText.TabIndex = 14;
            searchComboBoxText.KeyDown += searchComboBoxText_KeyDown;
            searchComboBoxText.KeyUp += searchComboBoxText_KeyUp;
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
            nameLabelSearch.Location = new Point(6, 31);
            nameLabelSearch.Name = "nameLabelSearch";
            nameLabelSearch.Size = new Size(51, 15);
            nameLabelSearch.TabIndex = 1;
            nameLabelSearch.Text = "Nombre";
            // 
            // servicesData
            // 
            servicesData.AllowUserToAddRows = false;
            servicesData.AllowUserToResizeRows = false;
            servicesData.BackgroundColor = Color.FromArgb(10, 16, 25);
            servicesData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(200, 200, 200);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(100, 100, 100);
            servicesData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            servicesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(250, 250, 250);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(10, 16, 25);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            servicesData.DefaultCellStyle = dataGridViewCellStyle4;
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
            // MainView
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
            Name = "MainView";
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
        private TextBox deleteIdText;
        private Label deleteIdLabel;
        private Button deleteButton;
        private GroupBox groupAdd;
        private Label addPriceLabel;
        private TextBox addPriceText;
        private TextBox addNameText;
        private Label addEditGroupNameLabel;
        private Button addButton;
        private GroupBox groupEdit;
        private Label priceToEditLabel;
        private TextBox editPriceText;
        private TextBox editNameText;
        private Label nameToEditLabel;
        private TextBox editIdText;
        private Label idForEditingLabel;
        private Button editButton;
        private GroupBox groupSearch;
        private Label priceLabelSearch;
        private Label nameLabelSearch;
        private TextBox textSearch;
        private Button searchButton;
        private DataGridView servicesData;
        private Button activateButton;
        private ComboBox searchComboBoxText;
    }
}
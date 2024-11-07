using BackendServicesMuoqa;
using Google.Protobuf.Reflection;
using IdentidadesServicesMuoqa;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ServicesMuoqa.Views
{
    public partial class ViewMain : Form
    {
        private readonly AdministrationServcices _logic;
        public ViewMain(AdministrationServcices logic)
        {
            _logic = logic ?? throw new ArgumentNullException(nameof(logic));
            InitializeComponent();
            ChangeServices();
            ElementProperties();
        }
        private void LabelSearch_MouseHover(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.Green;
            sender = label;
        }
        private void LabelSearch_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            label.ForeColor = Color.White;
            sender = label;
        }
        private void LabelSearch_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            textSearch.PlaceholderText = label.Text;
        }
        private void ChangeServices()
        {
            try
            {
                DataTable data = _logic.ChangeServices();
                LoadGrid(data);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                ServicesPrices objData = CheckEditingParameters();
                DataTable data = _logic.EditServices(objData);
                LoadGrid(data);
                ClearTexts();
                ElementProperties();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                ServicesPrices objData = CheckAdditionParameters();
                if (objData != null)
                {
                    throw new Exception("No se encontro ningun servicio");
                }
                DataTable data = _logic.AddServices(objData);
                LoadGrid(data);
                ClearTexts();
                ElementProperties();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                ClearTexts();
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(idTextDelete.Text, out int id))
                {
                    DataTable data = _logic.DeactivateService(id, "NO");
                    LoadGrid(data);
                    ClearTexts();
                }
                else
                {
                    throw new Exception("Introduca un numero valido");
                }
                ElementProperties();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                ClearTexts();
            }
        }
        private void activateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(idTextDelete.Text, out int id))
                {
                    DataTable data = _logic.DeactivateService(id, "YES");
                    LoadGrid(data);
                    ClearTexts();
                }
                else
                {
                    throw new Exception("Introduca un numero valido");
                }
                ElementProperties();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                ClearTexts();
            }
        }
        //Funciones sin eventos
        private void LoadGrid(DataTable data)
        {
            if (data.Rows.Count > 0)
            {
                servicesData.DataSource = null;
                servicesData.DataSource = data;
            }
        }
        private ServicesPrices CheckEditingParameters()
        {
            try
            {
                int id;
                if (!string.IsNullOrEmpty(idTextEdit.Text))
                {
                    id = int.Parse(idTextEdit.Text);
                }
                else
                {
                    throw new Exception("Necesitas poner un id");
                }
                int row = id - 1;
                string name;
                string price;

                if (string.IsNullOrEmpty(nameTextEdit.Text))
                    name = servicesData.Rows[row].Cells[1].Value.ToString() ?? "null";
                else
                    name = nameTextEdit.Text;
                if (string.IsNullOrEmpty(priceTextEdit.Text))
                    price = servicesData.Rows[row].Cells[2].Value.ToString() ?? "null";
                else
                    price = priceTextEdit.Text;
                if (price == "null" || name == "null")
                    throw new Exception("El id no existe");

                ServicesPrices servicesPrices = new ServicesPrices
                {
                    ServiceId = id,
                    ServiceName = name,
                    ServicePrice = price
                };
                return servicesPrices;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        private void ClearTexts()
        {
            idTextEdit.Clear();
            nameTextEdit.Clear();
            priceTextEdit.Clear();
            priceTextAdd.Clear();
            nameTextAdd.Clear();
            idTextDelete.Clear();
        }
        private void ElementProperties()
        {
            //serviceData
            int sizeDataService = servicesData.Width;
            int sizeColumn = sizeDataService / servicesData.Columns.Count;
            for (int i = 0; i < servicesData.Columns.Count; i++)
            {
                servicesData.Columns[i].Width = sizeColumn;
            }
            servicesData.ReadOnly = true;
        }
        private ServicesPrices CheckAdditionParameters()
        {
            try
            {
                if ((!string.IsNullOrEmpty(nameTextAdd.Text)) && (!string.IsNullOrEmpty(priceTextAdd.Text)))
                {
                    ServicesPrices data = new ServicesPrices
                    {
                        ServiceName = nameTextAdd.Text,
                        ServicePrice = priceTextAdd.Text
                    };
                    return data;
                }
                throw new Exception("Hay parametros vacios");
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        //Funciones de los textbox
        private void nameTextAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void priceTextAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(priceTextAdd.Text))
            {
                if (char.IsLetter(e.KeyChar))
                    e.Handled = true; 
                priceTextAdd.Text = "$";
                char press = e.KeyChar;
                e.Handled = true;
                if (press != '$' && char.IsNumber(press))
                    priceTextAdd.Text += press;
                priceTextAdd.SelectionStart = priceTextAdd.Text.Length;
            }
            if (char.IsLetter(e.KeyChar) && priceTextAdd.Text.Length == 1)
            {
                e.Handled = true;
            }
        }
        private void idTextDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void priceTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(priceTextEdit.Text))
            {
                if (char.IsLetter(e.KeyChar))
                    e.Handled = true;
                priceTextEdit.Text = "$";
                char press = e.KeyChar;
                e.Handled = true;
                if (press != '$' && char.IsNumber(press))
                    priceTextEdit.Text += press;
                priceTextEdit.SelectionStart = priceTextEdit.Text.Length;
            }
            if (char.IsLetter(e.KeyChar) && priceTextEdit.Text.Length == 1)
            {
                e.Handled = true;
            }
        }
    }
}
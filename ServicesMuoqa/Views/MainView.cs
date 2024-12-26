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
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ServicesMuoqa.Views
{
    public partial class MainView : Form
    {
        private readonly AdministrationServcices _logic;
        public MainView(AdministrationServcices logic)
        {
            _logic = logic ?? throw new ArgumentNullException(nameof(logic));
            InitializeComponent();
            GetAllServices();
            ElementProperties();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                ServicesPrices objData = CheckEditingParameters();
                DataTable data = _logic.EditServices(objData);
                LoadGrid(data);
                ClearTexts();
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
                if (objData == null)
                {
                    throw new Exception("No se encontro ningun servicio");
                }
                DataTable data = _logic.AddServices(objData);
                LoadGrid(data);
                ClearTexts();
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
        private void GetAllServices()
        {
            try
            {
                DataTable data = _logic.GetAllServices();
                LoadGrid(data);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
            }
        }
        private void LoadGrid(DataTable data)
        {
            servicesData.DataSource = null;
            servicesData.DataSource = data;
            ElementProperties();
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
        private ServicesPrices CheckEditingParameters()
        {
            try
            {
                int id;
                if (!string.IsNullOrEmpty(idTextEdit.Text))
                    id = int.Parse(idTextEdit.Text);
                else
                    throw new Exception("Necesitas poner un id");
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
        private List<string> GetServices(string text)
        {
            try
            {
                List<ServicesPrices> servicesPrices = _logic.SearchServices(text);
                DataTable data = _logic.ConvertListToData(servicesPrices);
                LoadGrid(data);
                if (servicesPrices.Count > 0)
                {
                    List<string> servicesList = new List<string>();
                    for (int i = 0; i < servicesPrices.Count; i++)
                    {
                        string name = servicesPrices[i].ServiceName;
                        servicesList.Add(name);
                    }
                    return servicesList;
                }
                return new List<string> { text };
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                return null;
            }
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
        private bool CheckChar(char character)
        {
            //Como la clase KeyEventsArgs no tiene la funcion char.IsLetter y otras
            //Simulo unas de esas funciones con esto
            try
            {
                //Agreagamos los caracteres a comparar
                string characterArray = "abcdefghijklmnñopqrstuvwxyz0123456789$";
                for (int i = 0; i < characterArray.Length; i++)
                {
                    if (characterArray[i] == character)
                        return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private bool CheckKey(KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Back:
                        return false;
                    case Keys.ControlKey:
                        return false;
                    case Keys.CapsLock:
                        return false;
                    case Keys.ShiftKey:
                        return false;
                    default:
                        return true;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        private string DeleteLastLetter(string text)
        {
            try
            {
                string newText = "";
                for (int i = 0;i < text.Length; i++)
                {
                    if (i == text.Length - 1 && text.Length >=2)
                        return newText;
                    newText += text[i].ToString();
                    if (i == text.Length - 1 && text.Length ==1)
                        return newText;
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
                GetAllServices();
                return string.Empty;
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
                //if (char.IsLetter(e.KeyChar))
                //    e.Handled = true;
                priceTextAdd.Text = "$";
                char press = e.KeyChar;
                e.Handled = true;
                if (press != '$' && char.IsNumber(press))
                    priceTextAdd.Text += press;
                priceTextAdd.SelectionStart = priceTextAdd.Text.Length;
            }
            if ((char.IsLetter(e.KeyChar)||char.IsSymbol(e.KeyChar)) && priceTextAdd.Text.Length == 1)
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
        private void cmbTextSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                if (!string.IsNullOrEmpty(cmbTextSearch.Text)&&e.KeyCode == Keys.Back) 
                {
                    string text = cmbTextSearch.Text;
                    list = GetServices(text);
                    if (cmbTextSearch.Items.Count>0)
                        cmbTextSearch.Items.Clear();
                    cmbTextSearch.Items.Add(text);
                    for (int i = 0; i < list.Count; i++)
                    {
                        cmbTextSearch.Items.Add(list[i]);
                    }
                    cmbTextSearch.SelectionStart = cmbTextSearch.Text.Length;
                    cmbTextSearch.DroppedDown = true;
                }
                else if(string.IsNullOrEmpty(cmbTextSearch.Text) && e.KeyCode == Keys.Back)
                {
                    cmbTextSearch.DroppedDown = false;
                    GetAllServices();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
        private void cmbTextSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                bool checkKey = CheckKey(e);
                string character = e.KeyCode.ToString().ToLower();
                char c;
                bool flag = char.TryParse(character, out c);
                if (checkKey && flag)//Comprueba si la tecla precionada es una tecla no deseada, como controlo la tecla borrar
                {                   
                    if (CheckChar(c))//Aca comprueba si la tecla esta dentro del "diccionario personalizado" de La funcion CheckChar.
                    {               //No se puede usar char.IsLetter por que solo sirve en la clase "KeyPresEventArgs"
                        List<string> list = new List<string>();
                        string text = "";
                        if (string.IsNullOrEmpty(cmbTextSearch.Text)) 
                        {
                            text = character;
                            if (Control.IsKeyLocked(Keys.CapsLock))//Comprueba si el Mayus esta activado
                                text = text.ToUpper();
                            list = GetServices(text);
                        }
                        else
                        {
                            if (Control.IsKeyLocked(Keys.CapsLock))
                                character = character.ToUpper();
                            text = cmbTextSearch.Text + character;//Esto es necesario ya que el evento KeyDown no llega a añadir la letra presionada
                            list = GetServices(text);
                        }
                        if (cmbTextSearch.Items.Count > 0)
                            cmbTextSearch.Items.Clear();
                        cmbTextSearch.Items.Add(text);
                        for (int i = 0; i < list.Count; i++)
                        {
                            cmbTextSearch.Items.Add(list[i]);
                        }
                        cmbTextSearch.SelectionStart = cmbTextSearch.Text.Length;
                        cmbTextSearch.DroppedDown = true;
                    }
                }
                else
                {
                    cmbTextSearch.SelectionStart = cmbTextSearch.Text.Length;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}



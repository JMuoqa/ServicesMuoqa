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
        private readonly ManageServices _logic;
        public MainView(ManageServices logic)
        {
            _logic = logic ?? throw new ArgumentNullException(nameof(logic));
            InitializeComponent();
            GetAllServices(true);
            SetGridWidth();
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                ServicesPrices objData = ValidateEditingParameters();
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
                ServicesPrices objData = ValidateAdditionParameters();
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
                if (int.TryParse(deleteIdText.Text, out int id))
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
        private void activateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(deleteIdText.Text, out int id))
                {
                    DataTable data = _logic.DeactivateService(id, "YES");
                    LoadGrid(data);
                    ClearTexts();
                }
                else
                {
                    throw new Exception("Introduca un numero valido");
                }
                SetGridWidth();
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
        private void GetAllServices(bool texts)
        {
            try
            {
                DataTable data = _logic.GetAllServices();
                if(texts)
                    ClearTexts();
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
            SetGridWidth();
        }
        private void SetGridWidth()
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
        private ServicesPrices ValidateEditingParameters()
        {
            try
            {
                GetAllServices(false);
                int id;
                if (!string.IsNullOrEmpty(editIdText.Text))
                    id = int.Parse(editIdText.Text);
                else
                    throw new Exception("Necesitas poner un id");
                int row = id - 1;
                string name;
                string price;
                if (string.IsNullOrEmpty(editNameText.Text))
                    name = servicesData.Rows[row].Cells[1].Value.ToString() ?? "null";
                else
                    name = editNameText.Text;
                if (string.IsNullOrEmpty(editPriceText.Text))
                    price = servicesData.Rows[row].Cells[2].Value.ToString() ?? "null";
                else
                    price = editPriceText.Text;
                if (price == "null" || name == "null")
                    throw new Exception("El id no existe");

                ServicesPrices servicesPrices = new ServicesPrices
                {
                    ServiceId = id,
                    ServiceName = name,
                    ServicePrice = price
                };
                ClearTexts();
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
            editIdText.Clear();
            editNameText.Clear();
            editPriceText.Clear();
            addPriceText.Clear();
            addNameText.Clear();
            deleteIdText.Clear();
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
        private ServicesPrices ValidateAdditionParameters()
        {
            try
            {
                GetAllServices(false);
                if ((!string.IsNullOrEmpty(addNameText.Text)) && (!string.IsNullOrEmpty(addPriceText.Text)))
                {
                    ServicesPrices data = new ServicesPrices
                    {
                        ServiceName = addNameText.Text,
                        ServicePrice = addPriceText.Text
                    };
                    ClearTexts();
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
        private bool ValidateChar(char character)
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
        private bool ValidateKey(KeyEventArgs e)
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
                GetAllServices(true);
                return string.Empty;
            }
        }

        //Funciones de los textbox
        private void addNameText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void priceTextAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(addPriceText.Text))
            {
                //if (char.IsLetter(e.KeyChar))
                //    e.Handled = true;
                addPriceText.Text = "$";
                char press = e.KeyChar;
                e.Handled = true;
                if (press != '$' && char.IsNumber(press))
                    addPriceText.Text += press;
                addPriceText.SelectionStart = addPriceText.Text.Length;
            }
            if ((char.IsLetter(e.KeyChar)||char.IsSymbol(e.KeyChar)) && addPriceText.Text.Length == 1)
            {
                e.Handled = true;
            }
        }
        private void deleteIdText_KeyPress(object sender, KeyPressEventArgs e)
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
        private void editPriceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(editPriceText.Text))
            {
                if (char.IsLetter(e.KeyChar))
                    e.Handled = true;
                editPriceText.Text = "$";
                char press = e.KeyChar;
                e.Handled = true;
                if (press != '$' && char.IsNumber(press))
                    editPriceText.Text += press;
                editPriceText.SelectionStart = editPriceText.Text.Length;
            }
            if (char.IsLetter(e.KeyChar) && editPriceText.Text.Length == 1)
            {
                e.Handled = true;
            }
        }
        private void searchComboBoxText_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                List<string> list = new List<string>();
                if (!string.IsNullOrEmpty(searchComboBoxText.Text)&&e.KeyCode == Keys.Back) 
                {
                    string text = searchComboBoxText.Text;
                    list = GetServices(text);
                    if (searchComboBoxText.Items.Count>0)
                        searchComboBoxText.Items.Clear();
                    searchComboBoxText.SelectionStart = searchComboBoxText.Text.Length;
                    searchComboBoxText.DroppedDown = true;
                }
                else if(string.IsNullOrEmpty(searchComboBoxText.Text) && e.KeyCode == Keys.Back)
                {
                    searchComboBoxText.DroppedDown = false;
                    GetAllServices(true);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
        private void searchComboBoxText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                bool checkKey = ValidateKey(e);
                string character = e.KeyCode.ToString().ToLower();
                char c;
                bool flag = char.TryParse(character, out c);
                if (checkKey && flag)//Comprueba si la tecla precionada es una tecla no deseada, como controlo la tecla borrar
                {                   
                    if (ValidateChar(c))//Aca comprueba si la tecla esta dentro del "diccionario personalizado" de La funcion CheckChar.
                    {               //No se puede usar char.IsLetter por que solo sirve en la clase "KeyPresEventArgs"
                        List<string> list = new List<string>();
                        string text = "";
                        if (string.IsNullOrEmpty(searchComboBoxText.Text)) 
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
                            text = searchComboBoxText.Text + character;//Esto es necesario ya que el evento KeyDown no llega a añadir la letra presionada
                            list = GetServices(text);
                        }
                        if (searchComboBoxText.Items.Count > 0)
                            searchComboBoxText.Items.Clear();
                        searchComboBoxText.Items.Add(text);
                        for (int i = 0; i < list.Count; i++)
                        {
                            searchComboBoxText.Items.Add(list[i]);
                        }
                        searchComboBoxText.SelectionStart = searchComboBoxText.Text.Length;
                        searchComboBoxText.DroppedDown = true;
                    }
                }
                else
                {
                    if(searchComboBoxText.Text.Length > 0)
                        searchComboBoxText.SelectionStart = searchComboBoxText.Text.Length;
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



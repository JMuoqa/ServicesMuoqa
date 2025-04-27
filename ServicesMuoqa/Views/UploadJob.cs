using BackendServicesMuoqa;
using IdentidadesServicesMuoqa;
using Microsoft.Extensions.DependencyInjection;
using Mysqlx;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ServicesMuoqa.Views
{
    public partial class UploadJob : Form
    {
        private readonly Jobs _jobs;
        public UploadJob(Jobs jobs)
        {
            _jobs = jobs ?? throw new ArgumentNullException(nameof(jobs));
            InitializeComponent();
            GetAllJobs();
        }
        private void addJobButton_Click(object sender, EventArgs e)
        {
            try
            {
                RequestedJobs newData = ValidateNullOrEmpty();
                DataTable dataTable = _jobs.AddJobs(newData);
                LoadGrid(dataTable);
                ClearTextBox();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void modifyJobButton_Click(object sender, EventArgs e)
        {
            try
            {
                RequestedJobs newJob = ValidateWorkToModify();
                DataTable data = _jobs.ModifyJob(newJob);
                LoadGrid(data);
                ClearTextBox();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        //Funciones sin eventos
        private void ClearTextBox()
        {
            customerNameInput.Clear();
            customerNumberInput.Clear();
            jobNameInput.Clear();
            jobPriceInput.Clear();
            jobStatusInput.Clear();
            entryDateInput.SelectedIndex = 0;
            deliveryDateInput.Clear();
            jobIdTextBoxForModify.Clear();
            jobNameTextBoxForModify.Clear();
            jobPriceTextBoxForModify.Clear();
            customerNameTextBoxForModify.Clear();
            customerNumberTextBoxForModify.Clear();
            jobStatusTextBoxForModify.SelectedIndex = 0;
            entryDateTextBoxForModify.Clear();
            deliveryDateTextBoxForModify.Clear();
        }
        private void GetAllJobs()
        {
            try
            {
                DataTable data = _jobs.GetAllJobs();
                LoadGrid(data);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadGrid(DataTable data)
        {
            try
            {
                jobData.DataSource = null;
                jobData.DataSource = data;
                SetDataGridViewWidth();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void SetDataGridViewWidth()
        {
            try
            {
                int sizeDataService = jobData.Width;
                int sizeColumn = sizeDataService / jobData.Columns.Count;
                for (int i = 0; i < jobData.Columns.Count; i++)
                {
                    jobData.Columns[i].Width = sizeColumn;
                }
                jobData.ReadOnly = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private RequestedJobs ValidateWorkToModify()
        {
            try
            {
                int id;
                if (!string.IsNullOrEmpty(jobIdTextBoxForModify.Text))
                    id = int.Parse(jobIdTextBoxForModify.Text);
                else
                    throw new Exception("Necesitas un id para modificarlo");
                int row = id - 1;
                string customerName, customerNumber, jobName, jobPrice, jobStatus;
                DateTime entry, delivery;
                if (string.IsNullOrEmpty(customerNameTextBoxForModify.Text))
                    customerName = jobData.Rows[row].Cells[1].Value.ToString() ?? "null";
                else
                    customerName = customerNameTextBoxForModify.Text;
                if (string.IsNullOrEmpty(customerNumberTextBoxForModify.Text))
                    customerNumber = jobData.Rows[row].Cells[2].Value.ToString() ?? "null";
                else
                    customerNumber = customerNumberTextBoxForModify.Text;
                if (string.IsNullOrEmpty(jobNameTextBoxForModify.Text))
                    jobName = jobData.Rows[row].Cells[3].Value.ToString() ?? "null";
                else
                    jobName = jobNameTextBoxForModify.Text;
                if (string.IsNullOrEmpty(jobPriceTextBoxForModify.Text))
                    jobPrice = jobData.Rows[row].Cells[4].Value.ToString() ?? "null";
                else
                    jobPrice = jobPriceTextBoxForModify.Text;
                if (string.IsNullOrEmpty(jobStatusTextBoxForModify.Text))
                    jobStatus = jobData.Rows[row].Cells[5].Value.ToString() ?? "null";
                else
                    jobStatus = jobStatusTextBoxForModify.Text;
                if (string.IsNullOrEmpty(entryDateTextBoxForModify.Text))
                {
                    string date = jobData.Rows[row].Cells[6].Value.ToString() ?? "null";
                    string date2 = date.Replace("/", "-") ?? date;// es necesario convertilos a guiones para que permita la conversion a datetime
                    date2 = ConvertTextToDate(date2);
                    entry = DateTime.ParseExact(date2, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    entry = entry.Date;
                }
                else
                {
                    string date2 = entryDateTextBoxForModify.Text.Replace("/", "-") ?? entryDateTextBoxForModify.Text;
                    entry = DateTime.ParseExact(date2, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                if (string.IsNullOrEmpty(deliveryDateTextBoxForModify.Text))
                {
                    string date = jobData.Rows[row].Cells[7].Value.ToString() ?? "null";
                    string date2 = date.Replace("/", "-");
                    date2 = ConvertTextToDate(date2);
                    delivery = DateTime.ParseExact(date2, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    delivery = delivery.Date;    
                }
                else
                {
                    string date2 = deliveryDateTextBoxForModify.Text.Replace("/", "-") ?? deliveryDateTextBoxForModify.Text;
                    delivery = DateTime.ParseExact(date2, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                RequestedJobs data = new RequestedJobs
                {
                    JobId = id,
                    CustomerName = customerName,
                    CustomerNumber = customerNumber,
                    JobName = jobName,
                    JobPrice = jobPrice,
                    JobStatus = jobStatus,
                    EntryDate = entry,
                    DeliveryDate = delivery
                };
                return data;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Sirve para colocar un 0 antes del dia.
        //Si es 2-11-2024 no lo acepta como datetime entonces 
        //se convirte a 02-11-2024 
        private string ConvertTextToDate(string date2)
        {
            try
            {
                string[] date3 = date2.Split('-');
                if(date3[1].Length == 1)
                {
                    string aux = date3[1];
                    date3[1] = "0";
                    date3[1] += aux;

                }
                if (date3[0].Length == 1)
                {
                    string aux = date3[0];
                    date3[0] = "0";
                    date3[0] += aux;
                    date2 = "";
                    foreach (string part in date3)
                    {
                        if(part.Length < 4)
                            date2 += part + "-";
                        else
                            date2 += part;
                    }
                }
                return date2;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private RequestedJobs ValidateNullOrEmpty()
        {
            try
            {
                DateTime entryDate, deliveryDate;
                if (string.IsNullOrEmpty(customerNameInput.Text))
                    throw new Exception("El nombre del cliente no puede estar vacio");
                if (string.IsNullOrEmpty(customerNumberInput.Text))
                    customerNumberInput.Text = "none";
                if (string.IsNullOrEmpty(jobNameInput.Text))
                    throw new Exception("El nombre del trabajo no puede estar vacio");
                if (string.IsNullOrEmpty(jobPriceInput.Text))
                    throw new Exception("El precio del trabajo no puede estar vacio");
                if (string.IsNullOrEmpty(jobStatusInput.Text))
                    jobStatusInput.Text = "Ingresado";
                if (string.IsNullOrEmpty(entryDateInput.Text))
                {
                    entryDate = DateTime.Now;
                    entryDate = entryDate.Date;
                }
                else
                {
                    string date = entryDateInput.Text;
                    date = date.Replace("/", "-");
                    date = ConvertTextToDate(date);
                    //Para convertir el DateTime en el formato esperado
                    entryDate = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                if (string.IsNullOrEmpty(deliveryDateInput.Text))
                {
                    throw new Exception("La fecha de entrega no puede estar vacia");
                }
                else
                {
                    string date = deliveryDateInput.Text;
                    date = date.Replace("/", "-");
                    date = ConvertTextToDate(date);
                    deliveryDate = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                return new RequestedJobs
                {
                    CustomerName = customerNameInput.Text,
                    CustomerNumber = customerNumberInput.Text,
                    JobName = jobNameInput.Text,
                    JobPrice = jobPriceInput.Text,
                    JobStatus = jobStatusInput.Text,
                    EntryDate = entryDate,
                    DeliveryDate = deliveryDate
                };
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        //Funciones de los textbox
        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox ?? new TextBox();
            if (string.IsNullOrEmpty(textBox.Text)) 
            {
                textBox.Text = "$";
                char press = e.KeyChar;
                e.Handled = true;
                if(press != '$' && char.IsNumber(press))
                    textBox.Text += press;
                textBox.SelectionStart = textBox.Text.Length;
            }
            if ((char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar)) && textBox.Text.Length == 1)
            {
                e.Handled = true;
            }
        }
    }
}

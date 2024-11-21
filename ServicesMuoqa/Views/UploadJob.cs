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
                RequestedJobs newData = CheckNullOrEmpty();
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

        //Funciones sin eventos
        private void ClearTextBox()
        {
            customerNameText.Clear();
            customerNumberText.Clear();
            jobNameText.Clear();
            jobPriceText.Clear();
            jobStatusText.Clear();
            entryDateText.Clear();
            deliveryDateText.Clear();
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
                ElementProperties();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void ElementProperties()
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
                throw;
            }
        }
        private RequestedJobs CheckNullOrEmpty()
        {
            try
            {
                DateTime entryDate, deliveryDate;

                if (string.IsNullOrEmpty(customerNameText.Text))
                    throw new Exception("El nombre del cliente no puede estar vacio");
                if (string.IsNullOrEmpty(customerNumberText.Text))
                    customerNumberText.Text = "none";
                if (string.IsNullOrEmpty(jobNameText.Text))
                    throw new Exception("El nombre del trabajo no puede estar vacio");
                if (string.IsNullOrEmpty(jobPriceText.Text))
                    throw new Exception("El precio del trabajo no puede estar vacio");
                if (string.IsNullOrEmpty(jobStatusText.Text))
                    jobStatusText.Text = "Ingresado";
                if (string.IsNullOrEmpty(entryDateText.Text))
                {
                    entryDate = DateTime.Now;
                }
                else
                {
                    //Para convertir el DateTime en el formato esperado
                    entryDate = DateTime.ParseExact(entryDateText.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                }
                if (string.IsNullOrEmpty(deliveryDateText.Text))
                    throw new Exception("La fecha de entrega no puede estar vacia");

                deliveryDate = DateTime.ParseExact(deliveryDateText.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

                return new RequestedJobs
                {
                    CustomerName = customerNameText.Text,
                    CustomerNumber = customerNumberText.Text,
                    JobName = jobNameText.Text,
                    JobPrice = jobPriceText.Text,
                    JobStatus = jobStatusText.Text,
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
    }
}

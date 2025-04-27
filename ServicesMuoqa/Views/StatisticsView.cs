using BackendServicesMuoqa;
using IdentidadesServicesMuoqa;
using Mysqlx.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ServicesMuoqa.Views
{
    public partial class StatisticsView : Form
    {
        private readonly LogFinancialTransactions _logic;
        public StatisticsView(LogFinancialTransactions logic)
        {
            _logic = logic ?? throw new ArgumentNullException(nameof(logic));
            InitializeComponent();
            string dateNow = DateTime.Now.ToString("dd-MM-yyyy");
            IncomeRegistrationDateTextBox.Text = dateNow;
            ExpenseRegistrationDateInput.Text += dateNow;
            FillInStatistics();
        }
        //Funciones con eventos
        private void EgressButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Chequea que no esten vacios los textos
                if(!TextChecking(ExpenseAmountInput.Text, ExpenseReasonInput.Text, ExpenseRegistrationDateInput.Text, ExtraExpenseInfoTextBox.Text))
                    MessageBox.Show("Necesitas llenar los espacios en blancos para cargar el ingreso");
                //Esta parta hasta el switch es para guardar solo la fecha y encontrar el mes
                string date2 = IncomeRegistrationDateTextBox.Text.Replace("/", "-") ?? IncomeRegistrationDateTextBox.Text;
                DateTime dateR = DateTime.ParseExact(ExpenseRegistrationDateInput.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                string month = ""; 
                int numberMonth = dateR.Month;
                switch (numberMonth)
                {
                    case 1: month = "Enero"; break;
                    case 2: month = "Febrero"; break;
                    case 3: month = "Marzo"; break;
                    case 4: month = "Abril"; break;
                    case 5: month = "Mayo"; break;
                    case 6: month = "Junio"; break;
                    case 7: month = "Julio"; break;
                    case 8: month = "Agosto"; break;
                    case 9: month = "Septiembre"; break;
                    case 10: month = "Octubre"; break;
                    case 11: month = "Noviembre"; break;
                    case 12: month = "Diciembre"; break;
                    default: break;
                }
                //Aca se registra el gasto
                MoneyMovement moneyMovement = new MoneyMovement
                {
                    Category = "Gasto",
                    Amount = ExpenseAmountInput.Text,
                    Reason = ExpenseReasonInput.Text,
                    DateR = dateR,
                    Validity = "Si",
                    MoreInfo = ExtraExpenseInfoTextBox.Text,
                    Months = month
                };
                _logic.InsertTheExpense(moneyMovement);
                //Se resetea los graficos de las estadisticas y los txt
                FillInStatistics();
                ClearTexts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void InputButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Chequea que no esten vacios los textos
                if (!TextChecking(IncomeAmountTextBox.Text, IncomeReasonText.Text, IncomeRegistrationDateTextBox.Text, ExtraIncomeDetailsText.Text))
                    MessageBox.Show("Necesitas llenar los espacios en blancos para cargar el ingreso");
                //Esta parta hasta el switch es para guardar solo la fecha y encontrar el mes
                string date2 = IncomeRegistrationDateTextBox.Text.Replace("/", "-") ?? IncomeRegistrationDateTextBox.Text;
                DateTime dateR = DateTime.ParseExact(IncomeRegistrationDateTextBox.Text, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                string month = "";
                int numberMonth = dateR.Month;
                switch (numberMonth)
                {
                    case 1: month = "Enero"; break;
                    case 2: month = "Febrero"; break;
                    case 3: month = "Marzo"; break;
                    case 4: month = "Abril"; break;
                    case 5: month = "Mayo"; break;
                    case 6: month = "Junio"; break;
                    case 7: month = "Julio"; break;
                    case 8: month = "Agosto"; break;
                    case 9: month = "Septiembre"; break;
                    case 10: month = "Octubre"; break;
                    case 11: month = "Noviembre"; break;
                    case 12: month = "Diciembre"; break;
                    default: break;
                }
                //Aca se registra el gasto
                MoneyMovement moneyMovement = new MoneyMovement
                {
                    Category = "Ingreso",
                    Amount = IncomeAmountTextBox.Text,
                    Reason = IncomeReasonText.Text,
                    DateR = dateR,
                    Validity = "Si",
                    MoreInfo = ExtraIncomeDetailsText.Text,
                    Months = month
                };
                _logic.InsertTheIncome(moneyMovement);
                FillInStatistics();
                ClearTexts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        //Esta funcion hace que al escribir en el txt de cantidad de dinero se escriba antes un "$"
        private void AmountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox ?? new TextBox();
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "$";
                char press = e.KeyChar;
                e.Handled = true;
                if (press != '$' && char.IsNumber(press))
                    textBox.Text += press;
                textBox.SelectionStart = textBox.Text.Length;
            }
            if ((char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar)) && textBox.Text.Length == 1)
            {
                e.Handled = true;
            }
        }
        //Funciones sin eventos
        private void ClearTexts()
        {
            IncomeAmountTextBox.Clear();
            ExtraIncomeDetailsText.Clear();
            ExtraIncomeDetailsText.Clear();
            ExpenseAmountInput.Clear();
            ExtraExpenseInfoTextBox.Clear();
            ExtraExpenseInfoTextBox.Clear();
            IncomeReasonText.SelectedItem = 0;
            ExpenseReasonInput.SelectedItem = 0;
            IncomeRegistrationDateTextBox.SelectedItem = 0;
            ExpenseRegistrationDateInput.SelectedItem = 0;
        }
        private void FillInStatistics()
        {
            lastMonthExpensesAndEarnings.Series[0].Points.Clear();
            lastMonthStatisticsChart.Series[0].Points.Clear();
            //Esta funcion carga la diferencia de ganancias y perdidas del ultimo mes
            StatisticsExpensesAndEarningsLastMonth();
            //Esta funcion caraga el rendimiento de los ultmos meses
            PerformanceOfRecentMonths();
        }
        private void StatisticsExpensesAndEarningsLastMonth()
        {
            //Obtiene los datos para llenar en los graficos
            DataTable expense = _logic.GetTheIncomeAndExpense();
            //Aca creamos un datatable con los campos "category" y "amount" y una fila con categoria: "ingreso"
            //y otra fila con categoria "gasto", esto es por que los datos en mysql los gastos e ingresos no estan sumados.
            DataTable commonExpense = new DataTable();
            commonExpense.Columns.Add("Category", typeof(string));
            commonExpense.Columns.Add("Amount", typeof(int));
            commonExpense.Rows.Add("Ingreso", 0);
            commonExpense.Rows.Add("Gasto", 0);
            //Aca sumamos todos los ingresos y todos los gastos
            for (int i = 0; i < expense.Rows.Count; i++)
            {
                string quantityText = expense.Rows[i]["Amount"].ToString();
                int amount = int.Parse(quantityText.Replace("$", ""));
                for (int j = 0; j < commonExpense.Rows.Count; j++)
                {
                    if (expense.Rows[i]["Category"].ToString() == commonExpense.Rows[j]["Category"].ToString())
                    {
                        commonExpense.Rows[j]["Amount"] = Convert.ToInt32(commonExpense.Rows[j]["Amount"].ToString()) + amount;
                        break;
                    }
                }
            }
            //Guardo los cambios
            commonExpense.AcceptChanges();
            //calculamos la diferencia entere los ingresos y los gastos
            int difference = Convert.ToInt32(commonExpense.Rows[0]["Amount"].ToString()) - Convert.ToInt32(commonExpense.Rows[1]["Amount"].ToString());
            DifferenceLabel.Text = "$"+difference.ToString();
            IncomeTag.Text = "$" + commonExpense.Rows[0]["Amount"].ToString();
            ExpenseTag.Text = "$" + commonExpense.Rows[1]["Amount"].ToString();
            //llenamos los graficos
            foreach (DataRow row in commonExpense.Rows)
            {
                lastMonthExpensesAndEarnings.Series[0].Points.AddXY($"{row["Category"]}s", row["Amount"]);
            }
        }
        private void PerformanceOfRecentMonths()
        {
            ///Posibles errores a corregir
            ///Cuando se alcancen el mimso mes pero diferente año, los datos seran incorectos
            //Creamos un datatable con todos los meses y obtenemos uno con los datos cargados (ingresos y meses)
            DataTable income = _logic.GetTheIncome();
            DataTable commonIncome = new DataTable();
            commonIncome.Columns.Add("Months", typeof(string));
            commonIncome.Columns.Add("Amount", typeof(int));
            commonIncome.Rows.Add("Enero", 0);
            commonIncome.Rows.Add("Febrero", 0);
            commonIncome.Rows.Add("Marzo", 0);
            commonIncome.Rows.Add("Abril", 0);
            commonIncome.Rows.Add("Mayo", 0);
            commonIncome.Rows.Add("Junio", 0);
            commonIncome.Rows.Add("Julio", 0);
            commonIncome.Rows.Add("Agosto", 0);
            commonIncome.Rows.Add("Septiembre", 0);
            commonIncome.Rows.Add("Octubre", 0);
            commonIncome.Rows.Add("Noviembre", 0);
            commonIncome.Rows.Add("Diciembre", 0);
            //Lo que hacemos aca es cargar la cantiad de dinero ingresado en cada mes
            for (int i = 0; i < income.Rows.Count; i++)
            {
                string quantityText = income.Rows[i]["Amount"].ToString();
                int amount = int.Parse(quantityText.Replace("$", ""));
                for (int j = 0; j < commonIncome.Rows.Count; j++)
                {
                    if (income.Rows[i]["Months"].ToString() == commonIncome.Rows[j]["Months"].ToString())
                    {
                        commonIncome.Rows[j]["Amount"] = Convert.ToInt32(commonIncome.Rows[j]["Amount"].ToString()) + amount;
                        break;
                    }
                }
            }
            //Aca elimino los meses que no estan registrados para solo cargar 
            for (int i = 0; i < commonIncome.Rows.Count; i++)
            {
                if (Convert.ToInt32(commonIncome.Rows[i]["Amount"]) == 0)
                {
                    commonIncome.Rows[i].Delete();
                    i--;
                }
            }
            commonIncome.AcceptChanges();
            //Cargo los datos en el chart
            foreach (DataRow row in commonIncome.Rows)
            {
                lastMonthStatisticsChart.Series[0].Points.AddXY($"{row["Months"]} ${row["Amount"]}", row["Amount"]);
            }
        }
        ///Esta funcion corrige el texto ingresado para que tenga el formato de fecha adecuado. "1-2-2025" --> "01-02-2024"
        ///De esta forma se podra convertir un string a un DateTime
        private string AdaptTextToDate(string date)
        {
            try
            {
                //Se separa el texto cada "-" que exista
                string[] date2 = date.Split('-');
                //Aca si es necesario le ponemos un 0 a la izquierda para darle la formato correcto "0-0-0000" --> "00-00-0000". "1-2-2025" --> "01-02-2024"
                if (date2[1].Length == 1)
                {
                    string aux = date2[1];
                    date2[1] = "0";
                    date2[1] += aux;
                }
                if (date2[0].Length == 1)
                {
                    string aux = date2[0];
                    date2[0] = "0";
                    date2[0] += aux;
                    //Aca volvemos a recrear el string de la forma correcta "00-00-0000"
                    date = "";
                    foreach (string part in date2)
                    {
                        if (part.Length < 4)
                            date += part + "-";
                        else
                            date += part;
                    }
                }
                return date;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Esta funcion revisa que los txt no esten vacios
        private bool TextChecking(string count, string reason, string date, string info)
        {
            try
            {
                if (string.IsNullOrEmpty(count))
                    return false;
                if (string.IsNullOrEmpty(reason))
                    return false;
                if (string.IsNullOrEmpty(date))
                    return false;
                if (string.IsNullOrEmpty(info))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception(ex.Message);
            }
        }
    }
}

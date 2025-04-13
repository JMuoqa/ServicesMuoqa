using DataBaseServicesMuoqa;
using IdentidadesServicesMuoqa;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendServicesMuoqa
{
    public class LogFinancialTransactions : CommonFunctionPer
    {
        private readonly Connection _conn;
        public LogFinancialTransactions(Connection conn) 
        {
            _conn = conn ?? throw new ArgumentNullException(nameof(conn));
        }
        public DataTable GetTheIncomeAndExpense()
        {
            try
            {
                DateTime dateTime = DateTime.Now.Date;
                int days = dateTime.Day;
                dateTime = dateTime.AddDays(-days + 1);
                dateTime = dateTime.AddMonths(-1);
                DateTime dateTime2 = dateTime.AddMonths(1);
                dateTime = dateTime2.AddDays(-1);
                List<MoneyMovement> list = _conn.MoneyMovement
                    .Where(u => u.DateR > dateTime && u.DateR < dateTime2)
                    .ToList();
                DataTable data = new DataTable();
                
                if (list.Count > 0)
                {
                    data = ConvertListToData(list);
                    return data;
                }
                list = _conn.MoneyMovement
                    .ToList();
                    data = ConvertListToData(list);
                return data;

            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public DataTable GetTheIncome()
        {
            try
            {
                List<MoneyMovement> list = _conn.MoneyMovement
                    .Where(u => u.Category == "Ingreso")
                    .Select(u => new MoneyMovement
                    {
                        Months = u.Months,
                        Amount = u.Amount
                    })
                    .ToList();
                DataTable data = ConvertListToData(list);
                return data;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message); 
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void InsertTheExpense(MoneyMovement money)
        {
            try
            {
                _conn.MoneyMovement.Add(money);
                int flag = _conn.SaveChanges();
                if(flag == 0)
                    throw new Exception("Ups, ocurrió un error al cargar. Por favor, inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public void InsertTheIncome(MoneyMovement money)
        {
            try
            {
                _conn.MoneyMovement.Add(money);
                int flag = _conn.SaveChanges();
                if (flag == 0)
                    throw new Exception("Ups, ocurrió un error al cargar. Por favor, inténtalo de nuevo.");
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

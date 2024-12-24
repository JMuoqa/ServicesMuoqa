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
    public class Jobs : CommonFunctionPer
    {
        private readonly Connection _conn;
        public Jobs(Connection conn)
        {
            _conn = conn ?? throw new ArgumentNullException(nameof(conn));
        }
        public DataTable GetAllJobs()
        {
            try
            {
                List<RequestedJobs> list = _conn.RequestedJobs.ToList();
                DataTable dataTable = ConvertListToData(list);
                return dataTable;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public DataTable AddJobs(RequestedJobs jobs) 
        {
            try
            {
                _conn.RequestedJobs.Add(jobs);
                int rows = _conn.SaveChanges();
                DataTable data = GetAllJobs();
                return data;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        
        public DataTable ModifyJob(RequestedJobs data)
        {
            try
            {
                var WorkToEdit = _conn.RequestedJobs.Find(data.JobId);
                if (WorkToEdit != null)
                {
                    WorkToEdit.CustomerName = data.CustomerName;
                    WorkToEdit.CustomerNumber = data.CustomerNumber;
                    WorkToEdit.JobName = data.JobName;
                    WorkToEdit.JobPrice = data.JobPrice;
                    WorkToEdit.JobStatus = data.JobStatus;
                    WorkToEdit.EntryDate = data.EntryDate;
                    WorkToEdit.DeliveryDate = data.DeliveryDate;
                }
                else
                    throw new Exception("El servicio no se encontro");
                int flag = _conn.SaveChanges();
                if (flag > 0)
                    return GetAllJobs();
                return new DataTable();

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

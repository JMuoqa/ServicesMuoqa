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
    }
}

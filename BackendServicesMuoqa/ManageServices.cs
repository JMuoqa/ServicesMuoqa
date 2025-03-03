﻿using DataBaseServicesMuoqa;
using IdentidadesServicesMuoqa;
using Org.BouncyCastle.Asn1.Cms;
using Serilog;
using System.Collections.ObjectModel;
using System.Data;

namespace BackendServicesMuoqa
{
    public class ManageServices : CommonFunctionPer
    {
        private readonly Connection _conn;
        public ManageServices(Connection conn)
        {
            _conn = conn ?? throw new ArgumentNullException(nameof(conn));
        }
        //Obtener lista de servicios
        public DataTable GetAllServices()
        {
            try
            {
                List<ServicesPrices> list = _conn.ServicesPrices.ToList();
                DataTable data = ConvertListToData(list);
                return data;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public DataTable EditServices(ServicesPrices objData)
        {
            try
            {
                var getData = _conn.ServicesPrices.Find(objData.ServiceId);
                if (getData != null) 
                {
                    getData.ServiceName = objData.ServiceName;
                    getData.ServicePrice = objData.ServicePrice;
                }
                else
                {
                    throw new Exception("El servicio no se encontro");
                }
                int flag = _conn.SaveChanges();
                if (flag > 0)
                {
                    DataTable data = GetAllServices();
                    return data;
                }
                return new DataTable();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        
        public DataTable AddServices(ServicesPrices objData)
        {
            try
            {
                _conn.ServicesPrices.Add(objData);
                int flag = _conn.SaveChanges();
                if(flag > 0)
                {
                    DataTable data = GetAllServices();
                    return data;
                }
                return new DataTable();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public DataTable DeactivateService(int id, string condition) 
        {
            try
            {
                var getData = _conn.ServicesPrices.Find(id); 
                if (getData != null)
                {
                    getData.ServiceActive = condition;
                }
                else
                {
                    throw new Exception("El servicio no se encontro");
                }
                int flag = _conn.SaveChanges();
                if (flag > 0) 
                {
                    DataTable data = GetAllServices();
                    return data;
                }
                return new DataTable();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }

        public List<ServicesPrices> SearchServices(string text)
        {
            try
            {
                List<ServicesPrices> listServices = _conn.ServicesPrices.Where(u=> u.ServiceName.StartsWith(text)).ToList();
                return listServices;
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

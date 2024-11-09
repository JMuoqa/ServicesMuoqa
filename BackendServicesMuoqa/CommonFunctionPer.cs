using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BackendServicesMuoqa
{
    public class CommonFunctionPer
    {
        public DataTable ConvertListToData<T>(List<T> data)
        {
            try
            {
                DataTable dataTable = new DataTable(typeof(T).Name);
                //Obtener todas las propiedades del tipo T
                PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                //Crear columnas en el DataTable basadas en las propiedades
                foreach (PropertyInfo property in properties)
                {
                    dataTable.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
                }
                //Añadir filas al DataTable
                foreach (T item in data)
                {
                    DataRow row = dataTable.NewRow();
                    foreach (PropertyInfo property in properties)
                    {
                        row[property.Name] = property.GetValue(item) ?? DBNull.Value;
                    }
                    dataTable.Rows.Add(row);
                }
                return dataTable;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Aplikacja_Logowanie_Rejestracja
{
    public class DatabaseService
    {
        private readonly string ConnectionString = "Server= localhost\\SQLEXPRESS; Database=LoginDB;Integrated Security = SSPI";
        private SqlConnection Connection;

        public void createConnection()
        {
            try
            {
                Connection = new SqlConnection(ConnectionString);
            }
            catch
            {
                MessageBox.Show("Nie połączono z bazą danych");
            }
        }

        public ObservableCollection<T> executeProcedureSelect<T>(string procedura)
        {
            ObservableCollection<T> list = null;
            try
            {
                SqlCommand Command = new SqlCommand(procedura, Connection);
                Command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SDA = new SqlDataAdapter(Command);
                DataTable dataTable = new DataTable();
                SDA.Fill(dataTable);
                list = ConvertDataTable<T>(dataTable);
            }
            catch
            {
                MessageBox.Show("Błąd połączenia z bazą danych");
            }
            return list;
        }

        public string executeProcedureModify<T>(string procedure, string mode, T item)
        {
            string login1 = null;
            try
            {
                Type type = typeof(T);
                SqlCommand Command = new SqlCommand(procedure, Connection);
                Command.CommandType = CommandType.StoredProcedure;

                Command.Parameters.Add(new SqlParameter("@mode", SqlDbType.VarChar)).Value = mode;

                Connection.Open();

                foreach (PropertyInfo propertyInfo in type.GetProperties())
                {
                    if (!propertyInfo.Name.StartsWith("x"))
                        Command.Parameters.Add(new SqlParameter("@" + propertyInfo.Name, SqlDbType.VarChar)).Value = propertyInfo.GetValue(item);
                }
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Błąd zapisu do bazy danych");
                MessageBox.Show(ex.Message);
            }
            return login1;
        }

        private ObservableCollection<T> ConvertDataTable<T>(DataTable dataTable)
        {
            ObservableCollection<T> collection = new ObservableCollection<T>();
            foreach (DataRow row in dataTable.Rows)
            {
                T item = GetItem<T>(row);
                collection.Add(item);
            }
            return collection;
        }
        private static T GetItem<T>(DataRow dataRow)
        {
            Type type = typeof(T);
            T rowObject = Activator.CreateInstance<T>();

            foreach (DataColumn dataColumn in dataRow.Table.Columns)
            {
                foreach (PropertyInfo propertyInfo in type.GetProperties())
                {
                    if (propertyInfo.Name == dataColumn.ColumnName)
                        propertyInfo.SetValue(rowObject, dataRow[dataColumn.ColumnName], null);
                    else
                        continue;
                }
            }
            return rowObject;
        }
    }
}

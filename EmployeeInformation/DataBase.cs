using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"server=F4ULER\SQLEXPRESS; Database=dbo;Trusted_Connection=True;;TrustServerCertificate=True;");

        public void openConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getSqlConnection()
        {
            return sqlConnection;
        }

        protected DataTable sendCommand(SqlCommand comm)
        {

            openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = comm;
            adapter.Fill(table);

            closeConnection();
            if(table.Rows.Count > 0)
            {
                return table;
            }
            else { MessageBox.Show("Ошибка! \n Проверьте корректность введенных данных."); return table; }
        }

        public DataTable sendCommandOutputNotes(string sortBy = "", string filterCol = "", string filterValue = "")
        {
            SqlCommand comm = new SqlCommand("OutputNotes", getSqlConnection());
            comm.CommandType = CommandType.StoredProcedure;
            if (sortBy != "") { comm.Parameters.AddWithValue("@sortBy", sortBy); }
            if (filterCol != "" && filterValue != "") 
            { 
                comm.Parameters.AddWithValue("@filterCol", filterCol);
                comm.Parameters.AddWithValue("@filterValue", filterValue);
            }
            return sendCommand(comm);
        }
    }
}

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
            else 
            { 
                MessageBox.Show("Записи не найдены!", "Ошибка"); 
                return table;
            }
        }

        public DataTable sendCommandOutputNotes(string sortBy = "", string filterStatus = "",
            string filterDep = "", string filterPost = "", string filterLastName = "")
        {
            SqlCommand comm = new SqlCommand("OutputNotes", getSqlConnection());
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@sortBy", sortBy);
            comm.Parameters.AddWithValue("@filterStatus", filterStatus);
            comm.Parameters.AddWithValue("@filterDep", filterDep);
            comm.Parameters.AddWithValue("@filterPost", filterPost);
            comm.Parameters.AddWithValue("@filterLastName", filterLastName);
            return sendCommand(comm);
        }

        public int sendCommandGetStatistics(string status = "", string dateName = "", 
            string firstDate = "", string secondDate = "")
        {
            DataTable number = new DataTable();
            SqlCommand comm = new SqlCommand("GetStatistics", getSqlConnection());
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@filterStatus", status);
            comm.Parameters.AddWithValue("@DateName", dateName);
            comm.Parameters.AddWithValue("@FirstDate", firstDate);
            comm.Parameters.AddWithValue("@SecondDate", secondDate);

            number = sendCommand(comm);
            return (int)(number.Rows.Count > 0 ? (number.Rows[0][0] ?? 0) : 0);
        }
    }
}

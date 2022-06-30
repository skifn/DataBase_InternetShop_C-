using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MISPiS_KP
{
    class Клиент : Товар
    {
        public void DisplayDefaultReport1(string str, string str1, string str2, DataGridView dataGrid)
        {
            connection.Open();
            if (str != "")
            {
                DataTable dataTable = new DataTable();
                adapter = new SqlDataAdapter("select * from Товары where Категория='"+ str +"'", connection);
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
            }
            if (str1 != "")
            {
                DataTable dataTable = new DataTable();
                adapter = new SqlDataAdapter("select * from Товары where Цена>" + str1 + "", connection);
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
            }
            if (str2 != "")
            {
                DataTable dataTable = new DataTable();
                adapter = new SqlDataAdapter("select * from Товары where Цена<" + str2 + "", connection);
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
            }
            if (str != "" && str1 != "")
            {
                DataTable dataTable = new DataTable();
                adapter = new SqlDataAdapter("select * from Товары where Категория='" + str + "' and Цена>" + str1 + "", connection); 
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
            }
            if (str != "" && str2 != "")
            if (str1 != "" && str2 != "")           
            if (str != "" && str1 != "" && str2 != "")
            {
                DataTable dataTable = new DataTable();
                adapter = new SqlDataAdapter("select * from Товары where Цена>" + str1 + " and Цена<" + str2 + "", connection);
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
            }
            if (str == "" && str1 == "" && str2 == "")
            {
                MessageBox.Show("Не были выбраны какие-либо данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
    }
}

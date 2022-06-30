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
    class Товар
    {
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;
        public SqlCommand cmd;
        public void DisplayData1(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Товары", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }
        public void DisplayData2(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Корзина", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }
        public void DisplayData3(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Заказ", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }
        public void DisplayData4(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Доставка", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }
        public void DisplayData5(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Отзывы", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }
        public void DisplayData6(DataGridView dataGrid)
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from Мои_Заказы", connection);
            adapter.Fill(dt);
            dataGrid.DataSource = dt;
            connection.Close();
        }




    }
}

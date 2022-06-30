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
    class Корзина : Товар
    {
        public void AddLesson(string str, DataGridView dataGrid)
        {
            if(str != "")
            {
                string[] str1 = str.Split(' ');
                cmd = new SqlCommand("SET IDENTITY_INSERT Корзина ON INSERT INTO Корзина(ID, Категория, Производитель, Страна, Цена, Гарантия, Наименование)" +
                                "SELECT ID, Категория, Производитель, Страна, Цена, Гарантия, Наименование FROM Товары WHERE ID=@str", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@str", str1[0]);
                cmd.ExecuteNonQuery();
                connection.Close();
                DisplayData2(dataGrid);
            }
            else
            {
                MessageBox.Show("Ошибка получения данных. Попробуйте еще раз.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TruncateTable(DataGridView dataGrid)
        {
            cmd = new SqlCommand("truncate table Корзина", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            DisplayData2(dataGrid);
        }
        public void DeleteLesson(string id, DataGridView dataGrid)
        {
            if (id != "")
            {
                string[] str1 = id.Split(' ');
                cmd = new SqlCommand("delete Корзина where ID = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", str1[0]);
                cmd.ExecuteNonQuery();
                connection.Close();
                DisplayData2(dataGrid);
            }
            else
            {
                MessageBox.Show("Ошибка удаления. Попробуйте еще раз.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

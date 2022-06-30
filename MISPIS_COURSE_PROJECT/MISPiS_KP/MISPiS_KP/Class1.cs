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
    class Оператор : Товар
    {
        public void AddLesson(string kat, string pr, string str, string zena, string gar, string name, DataGridView dataGrid)
        {
            if (kat != "" && pr != "" && str != "" && zena != "" && gar != "" && name != "")
            {
                cmd = new SqlCommand("insert into Товары(Категория, Производитель, Страна, Цена, Гарантия, Наименование) values(@кат, @произ, @стр, @цена, @гар, @name)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@кат", kat);
                cmd.Parameters.AddWithValue("@произ", pr);
                cmd.Parameters.AddWithValue("@стр", str);
                cmd.Parameters.AddWithValue("@цена", zena);
                cmd.Parameters.AddWithValue("@гар", gar);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
                connection.Close();
                DisplayData1(dataGrid);
            }
            else
            {
                MessageBox.Show("Были введены не все данные. Попробуйте еще раз.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteLesson(string id, DataGridView dataGrid)
        {
            if (id != "")
            {
                cmd = new SqlCommand("delete Товары where ID = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                DisplayData1(dataGrid);
            }
            else
            {
                MessageBox.Show("Вы не ввели данные. Попробуйте еще раз.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ChangeLesson(string id, string kat, string pr, string str, string zena, string gar, string name, DataGridView dataGrid)
        {
            if (id != "" && kat != "" && pr != "" && str != "" && zena != "" && gar != "" && name != "")
            {
                cmd = new SqlCommand("update Товары set Категория=@кат, Производитель=@произ, Страна=@стр, Цена=@цена, Гарантия=@гар, Наименование = @name where @id = ID", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@кат", kat);
                cmd.Parameters.AddWithValue("@произ", pr);
                cmd.Parameters.AddWithValue("@стр", str);
                cmd.Parameters.AddWithValue("@цена", zena);
                cmd.Parameters.AddWithValue("@гар", gar);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
                connection.Close();
                DisplayData1(dataGrid);
            }
            else
            {
                MessageBox.Show("Ошибка выполнения команды. Попробуйте еще раз.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void DeleteZak(string id, DataGridView dataGrid)
        {
            if (id != "")
            {
                string[] str1 = id.Split(' ');
                cmd = new SqlCommand("delete Заказ where ID = @id", connection);
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
        public void Oform(string id, DataGridView dataGrid)
        {
            if (id != "")
            {
                string[] str1 = id.Split(' ');
                cmd = new SqlCommand("INSERT INTO Доставка(Фамилия, Имя, Телефон, Адрес, Цена, Оплата)" +
                                "SELECT Фамилия, Имя, Телефон, Адрес, Цена, Оплата FROM Заказ WHERE ID=@str", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@str", str1[0]);
                cmd.ExecuteNonQuery();
                connection.Close();

                cmd = new SqlCommand("INSERT INTO Мои_Заказы (Фамилия, Имя, Телефон, Адрес, Цена, Оплата)" +
                               "SELECT Фамилия, Имя, Телефон, Адрес, Цена, Оплата FROM Заказ WHERE ID=@str", connection);
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





    }
}

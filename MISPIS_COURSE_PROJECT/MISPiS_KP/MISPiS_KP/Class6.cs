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
    class Доставка : Оператор
    {
        public void DeleteD(string id, DataGridView dataGrid)
        {
            if (id != "")
            {
                string[] str1 = id.Split(' ');
                cmd = new SqlCommand("delete Доставка where ID = @id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", str1[0]);
                cmd.ExecuteNonQuery();
                connection.Close();
                DisplayData2(dataGrid);
                MessageBox.Show("Заказ принят", "Доставка",
                      MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Ошибка выполнение операции. Попробуйте еще раз.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

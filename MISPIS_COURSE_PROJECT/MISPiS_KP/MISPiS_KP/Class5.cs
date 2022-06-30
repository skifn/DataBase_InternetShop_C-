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
    class Заказ : Корзина
    {
        Form2 form = new Form2();
        public void Oform(string fam, string name, string tel, string add, string opl, int sum)
        {
            if(fam != "" && name != "" && tel != "" && add != "" && opl != "")
            {
                cmd = new SqlCommand("insert into Заказ(Фамилия, Имя, Телефон, Адрес, Цена, Оплата) values(@фам, @имя, @тел, @адр, @цена, @опл)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@фам", fam);
                cmd.Parameters.AddWithValue("@имя", name);
                cmd.Parameters.AddWithValue("@тел", tel);
                cmd.Parameters.AddWithValue("@адр", add);
                cmd.Parameters.AddWithValue("@цена", sum);
                cmd.Parameters.AddWithValue("@опл", opl);
                cmd.ExecuteNonQuery();
                connection.Close();
                TruncateTable(form.dataGridView2); 
                MessageBox.Show("Заказ был оформлен и отправлен на обработку", "Получено",
                       MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Были введены не все данные. Попробуйте еще раз.", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}

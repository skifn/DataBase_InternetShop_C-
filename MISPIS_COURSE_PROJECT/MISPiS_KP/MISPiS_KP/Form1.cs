using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MISPiS_KP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1, str2;
            str1 = Convert.ToString(textBox1.Text);
            str2 = Convert.ToString(textBox2.Text);
            if (str1 == "сотрудник" && str2 == "123")
            {
                Form3 form = new Form3();
                form.Show();
            }
            else if(str1 == "клиент" && str2 == "111")
            {
                Form2 form = new Form2();
                form.Show();
            }
            else if(str1 == "курьер" && str2 == "789")
            {
                Form4 form = new Form4();
                form.Show();
            }
            else if(str1 == "" && str2 == "")
            {
                MessageBox.Show("Данные не были введены. Попробуйте еще раз.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show( "Введен неверный логин или пароль.", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

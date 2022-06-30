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
    public partial class Form5 : Form 
    {
        string[,] str = new string[64, 64];
        int[,] sum = new int[64, 64];
        int sum1;
        Form2 form = new Form2();
        Заказ z = new Заказ();
        public Form5()
        {
            InitializeComponent();
        }


     



        private void button1_Click(object sender, EventArgs e) => Hide();

        private void button2_Click(object sender, EventArgs e) => 
            z.Oform(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text, sum1);

        private void Form5_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Состав заказа:\n");
            for (int j = 0; j < form.dataGridView2.RowCount; j++)
            {
                for (int i = 1; i < form.dataGridView2.ColumnCount; i++)
                {
                    listBox1.Items.Add(str[i, j] = Convert.ToString(form.dataGridView2.Rows[j].Cells[i].Value));
                    if(i == 4)
                    {
                        sum[i, j] = Convert.ToInt32(form.dataGridView2.Rows[j].Cells[i].Value);
                        sum1 += sum[i, j];
                    }
                }
                listBox1.Items.Add("\n");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Картой" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" )
            {
                Form7 form = new Form7();
                form.Show();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

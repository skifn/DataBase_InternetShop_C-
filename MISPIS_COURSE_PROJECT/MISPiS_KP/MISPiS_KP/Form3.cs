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
    public partial class Form3 : Form

    {



        string str;
        Оператор op = new Оператор();
        Form2 form = new Form2();
        public Form3()
        {
            InitializeComponent();
            op.DisplayData1(dataGridView1);
            op.DisplayData1(dataGridView2);
            op.DisplayData1(dataGridView3);
            op.DisplayData3(dataGridView4);
            op.DisplayData5(dataGridView5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e) => op.AddLesson(comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text, dataGridView1);

        private void button4_Click(object sender, EventArgs e) => op.DeleteLesson(textBox14.Text, dataGridView3);

        private void button5_Click(object sender, EventArgs e)
        {
            op.DisplayData1(dataGridView1);
            op.DisplayData1(dataGridView2);
            op.DisplayData1(dataGridView3);
            op.DisplayData3(dataGridView4);
            op.DisplayData1(dataGridView5);
        }

        private void button3_Click(object sender, EventArgs e) => op.ChangeLesson(textBox13.Text, comboBox2.Text, textBox12.Text, textBox11.Text, textBox10.Text, textBox8.Text, textBox6.Text, dataGridView1);

        private void button6_Click(object sender, EventArgs e) => op.Oform(str, dataGridView4);



        private void button7_Click(object sender, EventArgs e)
        {

            op.DeleteZak(str, dataGridView4);
            form.listBox1.Items.Add("Внимание: Ваш заказ был отклонен из за отсутвия некоторых товаров");
            
        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                str = dataGridView4.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            op.DisplayData1(dataGridView1);
            op.DisplayData1(dataGridView2);
            op.DisplayData1(dataGridView3);
            op.DisplayData3(dataGridView4);
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            op.DisplayData5(dataGridView5);
        }
    }
}

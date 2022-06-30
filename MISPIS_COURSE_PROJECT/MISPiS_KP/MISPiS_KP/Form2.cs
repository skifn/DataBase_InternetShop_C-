using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MISPiS_KP
{
    public partial class Form2 : Form
    {
        Клиент k = new Клиент();
        Корзина kor = new Корзина();
        string str;
        public StringBuilder sb = new StringBuilder();
        public SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlDataAdapter adapter;


        


        public Form2()
        {
            InitializeComponent();
            k.DisplayData1(dataGridView1);
            kor.DisplayData2(dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e) =>
                k.DisplayDefaultReport1(comboBox1.Text, textBox1.Text, textBox2.Text, dataGridView1);

        private void button4_Click(object sender, EventArgs e) =>
            kor.TruncateTable(dataGridView2);

        private void button3_Click(object sender, EventArgs e) => 
            kor.DeleteLesson(str, dataGridView2);

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                str = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                kor.AddLesson(str, dataGridView2);
                str = "";
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                str = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            k.DisplayData6(dataGridView3);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

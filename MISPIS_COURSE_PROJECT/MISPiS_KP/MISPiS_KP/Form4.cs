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
    public partial class Form4 : Form
    {
        string str;
        Доставка d = new Доставка();
        public Form4()
        {
            InitializeComponent();
            d.DisplayData4(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e) => d.DisplayData4(dataGridView1);

        private void button2_Click(object sender, EventArgs e) => d.DeleteD(str, dataGridView1);

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                str = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
    }
}

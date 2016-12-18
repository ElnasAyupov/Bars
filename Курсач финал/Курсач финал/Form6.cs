using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач_финал
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.маркиTableAdapter.Fill(this.philatelistsDataSet.Марки);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.маркиTableAdapter.Update(this.philatelistsDataSet.Марки);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.связьTableAdapter.Insert(IDp.getid(), Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
            MessageBox.Show("Марка добавлена в вашу коллекцию");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            маркиTableAdapter.FillBy(philatelistsDataSet.Марки, textBox1.Text);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.маркиTableAdapter.Fill(this.philatelistsDataSet.Марки);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы искать марку по названию введите название в поле, чтобы сбросить результаты нажмите сбросить фильтр");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView1.Size.Width + 10, dataGridView1.Size.Height + 10);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}

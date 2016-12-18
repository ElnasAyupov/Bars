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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int UserId = ID.getid();
            if (авторTableAdapter.CountUsers(UserId) != 0)
            {
                dataGridView1.Visible = true;
                label1.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
                button5.Visible = true;
                this.маркиTableAdapter.MyCollectionFill(philatelistsDataSet.Марки, авторTableAdapter.SumId(UserId));
                IDp.changeid(Convert.ToInt32(авторTableAdapter.Idp(UserId)));
            }
            else
            {
                dataGridView1.Visible = false;
                label1.Visible = true;
                button2.Visible = false;
                button5.Visible = false;
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IDp.getid().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ID.getid().ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.связьTableAdapter.DeleteQuery(IDp.getid(), Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));
            this.маркиTableAdapter.MyCollectionFill(philatelistsDataSet.Марки, авторTableAdapter.SumId(ID.getid()));
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь может быть справка");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная программа - это справочник филателиста. Вы можете создать свою коллекцию, заполняя ее существующими марками");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель - Аюпов Эльнас, гр.8121-21");
        }
    }
}

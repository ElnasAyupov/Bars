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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            филателистыTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox2.Text);
            IDp.changeid(Convert.ToInt32(филателистыTableAdapter.MaxId()));
            авторTableAdapter.Insert(IDp.getid(), ID.getid());
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox2.Text  = (Convert.ToInt64((Convert.ToInt64(textBox1.Text, 16)).ToString(), 10)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "0000";
            int index;
            index = Convert.ToInt32(textBox4.Text);
            int newsymb = Convert.ToInt32(textBox5.Text, 10);
            textBox3.Text=str.Remove(index-1, 1).Insert(index-1, Convert.ToString(newsymb, 16).ToUpper());
        }
    }
}

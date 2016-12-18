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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != comboBox1.SelectedValue.ToString().Length)
            {
                int test = comboBox1.SelectedValue.ToString().Length - textBox1.Text.Length;
                for (int i = 0; i < test; i++)
                {
                    textBox1.Text = textBox1.Text + " ";
                }
            }
            if (textBox1.Text != comboBox1.SelectedValue.ToString())
            {
                MessageBox.Show("Неверное секретное слово");
            }
            else
            {
                string S;
                textBox2.Visible = true;
                S = textBox2.Text;
                textBox2.Visible = false;
                MessageBox.Show("Ваш пароль: " + S);
                this.Close();
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersAuthDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.usersAuthDataSet.Table);

        }
    }
}

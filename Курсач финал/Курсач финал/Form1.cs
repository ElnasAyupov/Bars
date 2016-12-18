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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersAuthDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.usersAuthDataSet.Table);
            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string S;
            textBox1.Visible = true;
            S = textBox1.Text;
            textBox1.Visible = false;
            if (S.Length != textBox2.Text.Length)
            {
                int test = S.Length - textBox2.Text.Length;
                for (int i = 0; i < test; i++)
                {
                    textBox2.Text = textBox2.Text + " ";
                }
            }
            if (S == textBox2.Text)
            {
                MessageBox.Show("Авторизация прошла успешно");
                ID.changeid(Convert.ToInt32(comboBox1.SelectedValue));
                Form4 f = new Form4();
                this.Visible = false;
                f.Show();
            }
            else
                MessageBox.Show("Пара логин-пароль неверна");
        }
            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}

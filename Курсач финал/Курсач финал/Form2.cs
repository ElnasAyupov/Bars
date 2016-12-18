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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
            {
                tableTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text);
                Clipboard.SetText("Логин: " + textBox1.Text + "\n"
                                + "Пароль: " + textBox2.Text + "\n"
                                + "Секретное слово: " + textBox3.Text);
                MessageBox.Show("Вы зарегистрированы, ваши регистрационные данные автоматически внесены в буффер обмена");
                this.tableTableAdapter.Update(usersAuthDataSet.Table);
                Application.Restart();
            }
            else
            {
                if ((textBox2.Text.Length < 6) && (textBox1.Text.Length > 10))
                    MessageBox.Show("Пожалуйста, введите пароль (6-10 символов)");  
                else
                {
                    if ((textBox1.Text.Length < 6) && (textBox1.Text.Length > 10))
                        MessageBox.Show("Пожалуйста введите логин (6-10 символов)");
                    else
                    {
                        if ((textBox3.Text.Length < 6) && (textBox3.Text.Length > 10))
                            MessageBox.Show("Пожалуйста введите секретное слово (6-10 символов)");
                    }
                }
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersAuthDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.usersAuthDataSet.Table);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true; 
        }
    }
}
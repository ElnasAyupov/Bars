using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.Должники". При необходимости она может быть перемещена или удалена.
            this.должникиTableAdapter.Fill(this.dataSet2.Должники);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.предметыTableAdapter.InsertQuery(textBox1.Text);
            MessageBox.Show("Предмет успешно добавлен!");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.tableTableAdapter.InsertQuery12345(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
            MessageBox.Show("Долг успешно добавлен!");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.должникиTableAdapter.Update(this.dataSet2.Должники);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.предметыTableAdapter.FillBy1(this.dataSet4.Предметы, Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString() + " " + "Группа: " +
                            dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString() + " " +
                                "Группа: " + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "\n" + "~~~~~~~" + "\n";
            if (dataGridView2.RowCount > 0)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    richTextBox1.Text = richTextBox1.Text + dataGridView2.Rows[i].Cells[1].Value.ToString() + "\n";
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали студента");
            }
                             
        }
    }
}

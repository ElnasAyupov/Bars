﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Попытка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Филателист". При необходимости она может быть перемещена или удалена.
            this.филателистTableAdapter.Fill(this.database1DataSet.Филателист);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            this.филателистBindingSource.EndEdit();
            this.филателистTableAdapter.Update(this.database1DataSet.Филателист);
            this.филателистTableAdapter.Fill(database1DataSet.Филателист);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.филателистTableAdapter.InsertQuery(Convert.ToInt32(textBox1.Text), textBox2.Text);
        }
    }
}

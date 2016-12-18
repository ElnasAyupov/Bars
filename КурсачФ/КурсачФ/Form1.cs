using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace КурсачФ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Марки". При необходимости она может быть перемещена или удалена.
            маркиTableAdapter.Fill(database1DataSet.Марки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            маркиTableAdapter.Update(database1DataSet.Марки);
        }
    }
}

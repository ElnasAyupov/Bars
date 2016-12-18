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

namespace Курсач
{
    public partial class Form1 : Form
    {
            string connectionString = @"Provider=System.Data.SqlClient;" +
                                      "Data Source=(LocalDB)" + @"\" + "MSSQLLocalDB;" +
                                      "AttachDbFilename=|DataDirectory|" + @"\" + "Marks.mdf;" +
                                      "Integrated Security=True";
            string commandText = "SELECT [Название], [Год], [Тираж], [Цена], [Страна] FROM [Марки]";
        public Form1()
        {
            InitializeComponent();
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText, conn);
            SqlCommand cmd = new SqlCommand("Insert into Марки" +
                "(Код марки, Название, Год, Тираж, Цена, Страна) Values (@ID,@Name,@Year,@Count,@Price,@Country)", conn);
            /*Работаем с параметрами(SqlParameter), эта техника позволяет уменьшить
            кол-во ошибок и достичь большего быстродействия
             но требует и больших усилий в написании кода*/
            //объявляем объект класса SqlParameter
            SqlParameter param = new SqlParameter();
            //задаем имя параметра
            param.ParameterName = "@ID";
            //задаем значение параметра
            param.Value = 1;
            //задаем тип параметра
            param.SqlDbType = SqlDbType.Int;
            //передаем параметр объекту класса SqlCommand
            cmd.Parameters.Add(param);
            //переопределяем объект класса SqlParameter
            param = new SqlParameter();
            //задаем имя параметра
            param.ParameterName = "@Name";
            //задаем значение параметра
            param.Value = "Иванов Иван Иванович";
            //задаем тип параметра
            param.SqlDbType = SqlDbType.Text;
            //передаем параметр объекту класса SqlCommand
            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }
}

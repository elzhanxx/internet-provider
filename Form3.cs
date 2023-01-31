using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=DESKTOP-KVL35UB\MSSQLSERVER01;Initial Catalog='Internet_provider';Integrated Security=True";
        string sql = "SELECT * FROM Prices";


        public Form3()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];            

        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string t1 = textBox2.Text;
                string t2 = textBox1.Text;
                string t3 = textBox3.Text;
                string t4 = textBox4.Text;

                try
                {
                    string Com = $"INSERT INTO [dbo].[Prices] ([date], [cost_of_one_minute_connection], [preferential_cost1] ,[preferential_cost2])" +
                        "VALUES (@1, @2, @3 ,@4)";
                   if(t1 != "" && t2 != "" && t3 != "" && t4 != "")
                    {
                        SqlCommand command = new SqlCommand(Com, connection);
                        command.Parameters.AddWithValue("1", t1);
                        command.Parameters.AddWithValue("2", t2);
                        command.Parameters.AddWithValue("3", t3);
                        command.Parameters.AddWithValue("4", t4);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Данные успешно добавлены");
                    }
                    else
                    {
                        MessageBox.Show("Введите данные во все поля");
                    }
                   
                }
                catch
                {
                    MessageBox.Show("Введите данные повторно");
                }
             
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
 
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            int index = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows[index].Visible = false;
            // if(dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            //   {
            try { 
                var id = dataGridView1.Rows[index].Cells[1].Value;

                var delQuery = $"DELETE FROM Prices WHERE cost_of_one_minute_connection = '{Convert.ToString(id)}'";

                SqlCommand command = new SqlCommand(delQuery, connection);
                command.ExecuteNonQuery();

                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                //  }
            }
            catch
            {
                MessageBox.Show("Повторите попытку");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapter = new SqlDataAdapter(sql, connection);

                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                // делаем недоступным столбец id для изменения
                //dataGridView1.Columns["Id"].ReadOnly = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_providerDataSet3.Prices". При необходимости она может быть перемещена или удалена.
            this.pricesTableAdapter.Fill(this.internet_providerDataSet3.Prices);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

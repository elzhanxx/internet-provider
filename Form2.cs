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
    public partial class Form2 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=DESKTOP-KVL35UB\MSSQLSERVER01;Initial Catalog='Internet_provider';Integrated Security=True";
        string sql = "SELECT * FROM Employees";


        public Form2()
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
                string t1 = textBox1.Text;
                string t2 = textBox2.Text;
                string t3 = textBox3.Text;
                string t4 = textBox4.Text;
                string t5 = textBox5.Text;
                try
                {
                    string Com = $"INSERT INTO [dbo].[Employees] ([full_name], [position], [home_address], [home_phone], [mobile_phone])" +
                        "VALUES (@1, @2, @3 ,@4 ,@5)";
                   if(t1 != "" && t2 != "" && t3 != "" && t4 != "")
                    {
                        SqlCommand command = new SqlCommand(Com, connection);
                        command.Parameters.AddWithValue("1", t1);
                        command.Parameters.AddWithValue("2", t2);
                        command.Parameters.AddWithValue("3", t3);
                        command.Parameters.AddWithValue("4", t4);
                        command.Parameters.AddWithValue("5", t5);
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
            try { 
                var id = dataGridView1.Rows[index].Cells[0].Value;
               

                var delQuery = $"DELETE FROM Employees WHERE full_name = {Convert.ToInt32(id)}";
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
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_providerDataSet1.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter1.Fill(this.internet_providerDataSet1.Employees);


        }
    }
}

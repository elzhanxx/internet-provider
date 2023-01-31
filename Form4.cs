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
    public partial class Form4 : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        string connectionString = @"Data Source=DESKTOP-KVL35UB\MSSQLSERVER01;Initial Catalog='Internet_provider';Integrated Security=True";
        string sql = "SELECT * FROM Receipts";


        public Form4()
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
                string t3 = textBox1.Text;
                string t4 = textBox2.Text;
                string t5 = textBox1.Text;
                string t6 = textBox2.Text;
                string t7 = textBox1.Text;
                string t8 = textBox2.Text;
                string t9 = textBox1.Text;
                string t10 = textBox2.Text;
                string t11 = textBox1.Text;
                string t12 = textBox2.Text;
                try
                {
                    string Com = $"INSERT INTO [dbo].[Receipts] ([name_of_organization], [adress_of_organization], [phone_of_organization], [date], [start_time], [end_time], [number_of_minutes], [cost_of_one_minute], [grand_total], [phone_of_operator], [full_name_of_operator], [shift_number]) " +
                        "VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12)";
                    if (t1 != "" && t2 != "" && t3 != "" && t4 != "" && t5 != "" && t6 != "" && t7 != "" && t8 != "" && t9 != "" && t10 != "" && t11 != "" && t12 != "")
                    {
                        SqlCommand command = new SqlCommand(Com, connection);
                        command.Parameters.AddWithValue("1", t1 );
                        command.Parameters.AddWithValue("2", t2 );
                        command.Parameters.AddWithValue("3", t3 );
                        command.Parameters.AddWithValue("4", t4 );
                        command.Parameters.AddWithValue("5", t5 );
                        command.Parameters.AddWithValue("6", t6 );
                        command.Parameters.AddWithValue("7", t7 );
                        command.Parameters.AddWithValue("8", t8 );
                        command.Parameters.AddWithValue("9", t9 );
                        command.Parameters.AddWithValue("10",t10);
                        command.Parameters.AddWithValue("11",t11);
                        command.Parameters.AddWithValue("12",t12);
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
                var id = dataGridView1.Rows[index].Cells[0].Value;
                //MessageBox.Show(id.ToString());
                //MessageBox.Show(index.ToString());

                var delQuery = $"DELETE FROM authors WHERE kod_author = {Convert.ToInt32(id)}";
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

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "internet_providerDataSet2.Receipts". При необходимости она может быть перемещена или удалена.
            this.receiptsTableAdapter.Fill(this.internet_providerDataSet2.Receipts);

        }
    }
}

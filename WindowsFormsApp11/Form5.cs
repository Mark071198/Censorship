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

namespace WindowsFormsApp11
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Censorship;Integrated Security=True; MultipleActiveResultSets=True";
        string sqlExpression = "SELECT * FROM LoginAndPassword";
        private void Form5_Load(object sender, EventArgs e)
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {

                        dataGridView1.Rows.Add(reader["Name"], reader["Login"], reader["Password"]);

                    }

                }
                reader.Close();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if (Login.Text.Length == 6 && Password.Text.Length == 10)
                {
                    SqlCommand sql = new SqlCommand("INSERT INTO [LoginAndPassword] (Name, Login, Password) VALUES (@Name, @Login, @Password)", connection);
                    sql.Parameters.AddWithValue("Name", NameUser.Text);
                    sql.Parameters.AddWithValue("Login", Login.Text);
                    sql.Parameters.AddWithValue("Password", Password.Text);
                    sql.ExecuteNonQuery();
                }
                else { MessageBox.Show("Long login or password is short"); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {

                        dataGridView1.Rows.Add(reader["Name"], reader["Login"], reader["Password"]);

                    }

                }
                reader.Close();
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DELETE FROM [LoginAndPassword] WHERE [Login]=@Login", connection);
                int a = dataGridView1.CurrentRow.Index;
                command.Parameters.AddWithValue("Login", dataGridView1.Rows[a].Cells[1].Value);
                dataGridView1.Rows.Remove(dataGridView1.Rows[a]);
                command.ExecuteNonQuery();
            }

        }
    }
}

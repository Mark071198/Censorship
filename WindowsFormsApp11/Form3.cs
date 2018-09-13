using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp11
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Censorship;Integrated Security=True; MultipleActiveResultSets=True";
            string sqlExpression = "SELECT * FROM LoginAndPassword";
            string loginFile = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                bool flag = true;

                if (reader.HasRows) // если есть данные
                {

                    while (reader.Read()) // построчно считываем данные
                    {

                        loginFile = (string)reader.GetValue(1);

                        if (loginFile == loginText.Text)
                        {
                            flag = false;
                        }
                                              
                    }                   
                }
               
                if (flag=true && loginText.Text.Length == 6 && passwordText.Text.Length == 10)
                 {
                        SqlCommand sql = new SqlCommand("INSERT INTO [LoginAndPassword] (Name, Login, Password) VALUES (@Name, @Login, @Password)", connection);
                        sql.Parameters.AddWithValue("Name", yourNameText.Text);
                        sql.Parameters.AddWithValue("Login", loginText.Text);
                        sql.Parameters.AddWithValue("Password", passwordText.Text);
                        sql.ExecuteNonQuery();
                        MessageBox.Show("You registrated");
                 }
                 else { MessageBox.Show("Long login or password is short"); }             
            }



            //string WritePath = @"C:\Users\Mk\source\repos\WindowsFormsApp11\WindowsFormsApp11\Registration\" + loginText.Text + ".txt";
            ////string ReadPath = @"C: \Users\admin\source\repos\WindowsFormsApp11\WindowsFormsApp11\Registration";
            //string name = yourNameText.Text;
            //string login = loginText.Text;
            //string parol = parolText.Text;
            //if (name != "" && login != "" && parol != "" && parolAgainText.Text != "")
            //{
            //    if (parolText.Text == parolAgainText.Text)
            //    {

            //        try
            //        {
            //            using (StreamWriter sw = new StreamWriter(WritePath, false, System.Text.Encoding.Default))
            //            {
            //                sw.WriteLine(name);
            //                sw.WriteLine(login);
            //                sw.WriteLine(parol);


            //                DialogResult result = MessageBox.Show("You registered");
            //                if (result == DialogResult.OK)
            //                    this.Close();


            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //    }
            //    else { MessageBox.Show("You input wrong parol"); }
            //}
            //else { MessageBox.Show("You wrote in not all lines "); }
        }
    }
}

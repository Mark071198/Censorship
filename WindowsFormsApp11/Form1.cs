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
    public partial class Form1 : Form
    {

        public string nameUser;
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            //nameUser = SendUserName();                     
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Censorship;Integrated Security=True";
            string sqlExpression = "SELECT * FROM LoginAndPassword";
            //string ReadPath = @"C: \Users\Mk\source\repos\WindowsFormsApp11\WindowsFormsApp11\Registration\" + loginText.Text + ".txt";
            string loginInput = loginText.Text;
            string parolInput = parolText.Text;   
            //string loginFile = "";
            //string parolFile = "";
            string userName ="";
            bool flag = false;

            if (loginText.Text == "admin" && parolText.Text == "ADMIN")
            {
                flag = true;
                Form4 form4 = new Form4();
                form4.Show();
                form4.label2.Text = "Admin";
                this.Visible = false;
            }
            else
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

                            string x = reader["Login"].ToString();
                            string y = reader["Password"].ToString();
                            //MessageBox.Show(x + proverkaX.Length + loginText.Text + parolText.Text);

                            if (x == loginText.Text && y == parolText.Text)
                            {
                                flag = true;
                                userName = (string)reader.GetValue(0);
                                form2.Show();
                                form2.label2.Text = userName;
                                this.Visible = false;

                            }

                        }
                    }
                    reader.Close();
                }
            }
            if (flag = false) { MessageBox.Show("Login or Password  is not correct"); }

            //if(File.Exists(ReadPath))
            //{
            //    try
            //    {
            //        using (StreamReader sr = new StreamReader(ReadPath, Encoding.Default))
            //        {
            //            userName = sr.ReadLine();
            //            loginFile = sr.ReadLine();
            //            parolFile = sr.ReadLine();
            //        }
            //    }
            //    catch(Exception ex) { MessageBox.Show(ex.Message); }
            //    if(loginInput !="" && parolInput!="" && loginInput == loginFile && parolInput ==parolFile)
            //    {
            //        form2.Show();
            //        form2.label2.Text = userName;
            //        this.Visible = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Wrong login or parol");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("Wrong login or parol");
            //    MessageBox.Show("Perhaps didn't you registered?");
            //}
        }

        private void Registration_Click(object sender, EventArgs e)
        {   
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                parolText.UseSystemPasswordChar = false;
            }
            else { parolText.UseSystemPasswordChar = true; }

        }         
    }
}

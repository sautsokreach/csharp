using HR_contract;
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

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_save_password_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Create a SqlConnection object
            using (SqlConnection connection = new Connection().dbs)
            {
                // Create a SqlCommand object with your query and the connection
                string query = "SELECT * FROM tbl_account"; // Replace with your actual query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query
                    SqlDataReader reader = command.ExecuteReader();

                    // Process the results
                    while (reader.Read())
                    {
                        // Access the columns using reader.GetString(), reader.GetInt32(), etc.
                        String column2Value = reader.GetString(1);
                        String column3Value = reader.GetString(2);
                        // Do something with the values
                        //Console.WriteLine("Column1: {0}, Column2: {1}", column2Value, column3Value);
                        //Console.WriteLine("Column1: {0}, Column2: {1}", column2Value, column3Value);
                        if (txtUserId.Text == column2Value && txtPassword.Text == column3Value)
                        {
                            Form homePage = new FormHomePage();
                            homePage.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username Or Password is not Incorrect");
                        }
                    }

                    // Close the SqlDataReader
                    reader.Close();
                }

                connection.Close();
            }
            //Form homePage = new FormHomePage();
            //homePage.Show();
            //this.Hide();
        }
    }
}

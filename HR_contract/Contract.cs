using Microsoft.ReportingServices.Diagnostics.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace HR_contract
{
    public partial class Contract : UserControl
    {
        public Contract()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new Connection().dbs;

                SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO dbo.tbl_contract ( staff_id,firstName, lastName, hireDate, salary,bonus, typeofstaff) VALUES(@staff_id,@firstName, @lastName, @hireDate, @salary, @bonus, @typeofstaff)"), con);
                cmd.Parameters.AddWithValue("@staff_id", idAndName.Text);
                cmd.Parameters.AddWithValue("@firstName", txtfirstN.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastN.Text);
                cmd.Parameters.AddWithValue("@hireDate", DateTime.Parse(dtpdob.Text));
                cmd.Parameters.AddWithValue("@salary", txtsalary.Text);
                cmd.Parameters.AddWithValue("@bonus", txtbonus.Text);
                cmd.Parameters.AddWithValue("@typeofstaff", cbotypestaff.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted successful.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new Connection().dbs;
            SqlCommand cmd = new SqlCommand("Delete dbo.tbl_contract where staff_id=@id", con);
            cmd.Parameters.AddWithValue("@id", idAndName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete successful.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in groupBox1.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new Connection().dbs;
                SqlCommand cmd = new SqlCommand(String.Format("UPDATE dbo.tbl_contract  SET firstName=@FirstName, lastName=@LastName, hireDate=@Date, salary=@Salary,bonus=@Bonus, typeofstaff=@TypeOfstaff WHERE staff_id ="+idAndName.Text), con);
                cmd.Parameters.AddWithValue("@FirstName", txtfirstN.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastN.Text);
                cmd.Parameters.AddWithValue("@Date", DateTime.Parse(dtpdob.Text));
                cmd.Parameters.AddWithValue("@Salary", txtsalary.Text);
                cmd.Parameters.AddWithValue("@Bonus", txtbonus.Text);
                cmd.Parameters.AddWithValue("@TypeOfstaff", cbotypestaff.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update successful.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void idAndName_SelectedIndexChanged(object sender, EventArgs e)
        {
            idAndName.Items.Add(new { Text = "report E", Value = "reportE" });
        }

        private void Contract_Load(object sender, EventArgs e)
        {

        }

        private void Contract_VisibleChanged(object sender, EventArgs e)
        {
         /*   idAndName.Items.Clear();
           // idAndName.AutoCompleteCustomSource.Clear();

            using (SqlConnection connection = new Connection().dbs)
            {
                // Create a SqlCommand object with your query and the connection
                string query = "SELECT id,firstname_khmer,lastname_khmer FROM tbl_staff"; // Replace with your actual query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query
                    SqlDataReader reader = command.ExecuteReader();

                    // Process the results
                    while (reader.Read())
                    {
                        // Access the columns using reader.GetString(), reader.GetInt32(), etc.
                        int id = reader.GetInt32(0);
                        String firstname_khmer = reader.GetString(1);
                        String lastname_khmer = reader.GetString(2);
                        idAndName.Items.Add(new { Text = firstname_khmer +" "+lastname_khmer, Value = id });
                       // idAndName.AutoCompleteCustomSource.Add(firstname_khmer + " " + lastname_khmer);
                    }
                    // Close the SqlDataReader
                    reader.Close();
                }

                connection.Close();
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new Connection().dbs)
            {
                // Create a SqlCommand object with your query and the connection
                string query = "SELECT id,firstname_eng,lastname_eng,sex,email,phonenumber FROM tbl_staff where id = " + idAndName.Text; // Replace with your actual query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query
                    SqlDataReader reader = command.ExecuteReader();

                    // Process the results
                    while (reader.Read())
                    {
                        // Access the columns using reader.GetString(), reader.GetInt32(), etc.
                        txtfirstN.Text =  reader.GetString(1);
                        txtLastN.Text = reader.GetString(2);
                        cboGender.Text = reader.GetString(3);
                        txtemail.Text = reader.GetString(4);
                        txtphone.Text = reader.GetString(5);
                    }
                    // Close the SqlDataReader
                    reader.Close();
                }

                connection.Close();
            }
        }
    }
}

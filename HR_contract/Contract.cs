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

                SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO dbo.tbl_contract ( firstName, lastName, gender, hireDate, salary,bonus, typeofstaff,phone, email) VALUES(@firstName, @lastName, @gender, @hireDate, @salary, @bonus, @typeofstaff, @phone, @email)"), con);
                cmd.Parameters.AddWithValue("@firstName", txtfirstN.Text);
                cmd.Parameters.AddWithValue("@lastName", txtLastN.Text);
                cmd.Parameters.AddWithValue("@gender", cboGender.Text);
                cmd.Parameters.AddWithValue("@hireDate", DateTime.Parse(dtpdob.Text));
                cmd.Parameters.AddWithValue("@salary", txtsalary.Text);
                cmd.Parameters.AddWithValue("@bonus", txtbonus.Text);

                //cmd.Parameters.AddWithValue("dob", DateTime.Parse(dtpdob.Text));
                cmd.Parameters.AddWithValue("@typeofstaff", cbotypestaff.Text);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);

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
            SqlCommand cmd = new SqlCommand("Delete dbo.tbl_contract where id=@id", con);
            cmd.Parameters.AddWithValue("@id", idAndName.SelectedValue);
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
                SqlCommand cmd = new SqlCommand(String.Format("UPDATE dbo.tbl_contract  SET id=@ID, firstName=@FirstName, lastName=@LastName, gender=@Gender, hireDate=@Date, salary=@Salary,bonus=@Bonus, typeofstaff=@TypeOfstaff WHERE phone=@Phone AND email=@Email"), con);
                cmd.Parameters.AddWithValue("ID", idAndName.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtfirstN.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastN.Text);
                cmd.Parameters.AddWithValue("@Gender", cboGender.Text);
                cmd.Parameters.AddWithValue("@Date", DateTime.Parse(dtpdob.Text));
                cmd.Parameters.AddWithValue("@Salary", txtsalary.Text);
                cmd.Parameters.AddWithValue("@Bonus", txtbonus.Text);

                //cmd.Parameters.AddWithValue("dob", DateTime.Parse(dtpdob.Text));
                cmd.Parameters.AddWithValue("@TypeOfstaff", cbotypestaff.Text);
                cmd.Parameters.AddWithValue("@Phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@Email", txtemail.Text);

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
    }
}

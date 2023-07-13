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

namespace HR_contract
{
    public partial class frminsertEmployeecontract : Form
    {
        public frminsertEmployeecontract()
        {
            InitializeComponent();
        }

        private void tbl_contractBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_contractBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hRDataSet);

        }

        private void frminsertEmployeecontract_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRDataSet.tbl_contract' table. You can move, or remove it, as needed.
            //this.tbl_contractTableAdapter.Fill(this.hRDataSet.tbl_contract);

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new Connection().dbs;

                SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO dbo.tbl_contract (id, firstName, lastName, gender, hireDate, salary,bonus, typeofstaff,phone, email) VALUES(@id,@firstName, @lastName, @gender, @hireDate, @salary, @bonus, @typeofstaff, @phone, @email)"), con);
                cmd.Parameters.AddWithValue("id", txtid.Text);
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
            cmd.Parameters.AddWithValue("@id", txtid.Text);
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
                cmd.Parameters.AddWithValue("ID", txtid.Text);
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

        private void txtLastN_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hireDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

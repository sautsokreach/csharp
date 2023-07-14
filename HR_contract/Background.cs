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
    public partial class Background : UserControl
    {
        public Background()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new Connection().dbs;

                SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO dbo.tbl_staff (firstname_khmer, lastname_khmer, firstname_eng, lastname_eng, sex, dateofbirth, placeofbirth, addresss, nation, nationality, phonenumber, email, education, langauge, langaugelevel,fathername, fatherstatus, fatherjob, mothername, motherstarus, motherjob,status) VALUES(@firstname_khmer, @lastname_khmer, @firstname_eng, @lastname_eng, @sex, @dateofbirth, @placeofbirth, @addresss, @nation, @nationality, @phonenumber, @email, @education, @langauge, @langaugelevel,@fathername, @fatherstatus, @fatherjob, @mothername, @motherstarus, @motherjob,@status)"), con);
                cmd.Parameters.AddWithValue("@firstname_khmer", firstNameKhmer.Text);
                cmd.Parameters.AddWithValue("@lastname_khmer", lastNameKhmer.Text);
                cmd.Parameters.AddWithValue("@firstname_eng", firstNameEng.Text);
                cmd.Parameters.AddWithValue("@lastname_eng", lastNameEng.Text);
                cmd.Parameters.AddWithValue("@sex", gender.Text);
                cmd.Parameters.AddWithValue("@dateofbirth", dateOfBirth.Text);
                cmd.Parameters.AddWithValue("@placeofbirth", placeOfBirth.Text);
                cmd.Parameters.AddWithValue("@addresss", addreess.Text);
                cmd.Parameters.AddWithValue("@nation", nation.Text);
                cmd.Parameters.AddWithValue("@nationality", nationality.Text);
                cmd.Parameters.AddWithValue("@phonenumber", phoneNumber.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@education", degreeEducation.Text);
                cmd.Parameters.AddWithValue("@langauge", langauge.Text);
                cmd.Parameters.AddWithValue("@langaugelevel", languageLevel.Text);
                cmd.Parameters.AddWithValue("@fathername", father.Text);
                cmd.Parameters.AddWithValue("@fatherstatus", fatherStatus.Text);
                cmd.Parameters.AddWithValue("@fatherjob", fatherJob.Text);
                cmd.Parameters.AddWithValue("@mothername", mother.Text);
                cmd.Parameters.AddWithValue("@motherstarus", motherStatus.Text);
                cmd.Parameters.AddWithValue("@motherjob", motherJob.Text);
                cmd.Parameters.AddWithValue("@status", familyStatus.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                textId.Text = (int.Parse(textId.Text) + 1).ToString();
                MessageBox.Show("Inserted successful.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new Connection().dbs)
            {
                // Create a SqlCommand object with your query and the connection
                string query = "SELECT * FROM tbl_staff where id = "+textId.Text; // Replace with your actual query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query
                    SqlDataReader reader = command.ExecuteReader();

                    // Process the results
                    while (reader.Read())
                    {
                        // Access the columns using reader.GetString(), reader.GetInt32(), etc.
                        firstNameKhmer.Text = reader.GetString(1);
                        lastNameKhmer.Text = reader.GetString(2);
                        firstNameEng.Text =  reader.GetString(3);
                        lastNameEng.Text = reader.GetString(4);
                        gender.Text =  reader.GetString(5);
                        dateOfBirth.Value = reader.GetDateTime(6);
                        placeOfBirth.Text = reader.GetString(7);
                        addreess.Text = reader.GetString(8);
                        nation.Text = reader.GetString(9);
                        nationality.Text =  reader.GetString(10);
                        phoneNumber.Text = reader.GetString(11);
                        email.Text = reader.GetString(12);
                        degreeEducation.Text = reader.GetString(13);
                        langauge.Text = reader.GetString(14);
                        languageLevel.Text = reader.GetString(15);
                        father.Text = reader.GetString(16);
                        familyStatus.Text = reader.GetString(17);
                        fatherJob.Text = reader.GetString(18);
                        mother.Text = reader.GetString(19);
                        motherStatus.Text = reader.GetString(20);
                        motherJob.Text = reader.GetString(21);
                    }
                    // Close the SqlDataReader
                    reader.Close();
                }

                connection.Close();
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new Connection().dbs;
                SqlCommand cmd = new SqlCommand(String.Format("UPDATE dbo.tbl_staff  SET firstname_khmer=@firstname_khmer, lastname_khmer=@lastname_khmer, firstname_eng=@firstname_eng, lastname_eng=@lastname_eng, sex=@sex, dateofbirth=@dateofbirth, placeofbirth=@placeofbirth, addresss=@addresss, nation=@nation, nationality=@nationality, phonenumber=@phonenumber, email=@email, education=@education, langauge=@langauge, langaugelevel=@langaugelevel,fathername=@fathername, fatherstatus=@fatherstatus, fatherjob=@fatherjob, mothername=@mothername, motherstarus=@motherstatus, motherjob=@motherjob WHERE id =" + textId.Text), con);
                cmd.Parameters.AddWithValue("@firstname_khmer", firstNameKhmer.Text);
                cmd.Parameters.AddWithValue("@lastname_khmer", lastNameKhmer.Text);
                cmd.Parameters.AddWithValue("@firstname_eng", firstNameEng.Text);
                cmd.Parameters.AddWithValue("@lastname_eng", lastNameEng.Text);
                cmd.Parameters.AddWithValue("@sex", gender.Text);
                cmd.Parameters.AddWithValue("@dateofbirth", dateOfBirth.Text);
                cmd.Parameters.AddWithValue("@placeofbirth", placeOfBirth.Text);
                cmd.Parameters.AddWithValue("@addresss", addreess.Text);
                cmd.Parameters.AddWithValue("@nation", nation.Text);
                cmd.Parameters.AddWithValue("@nationality", nationality.Text);
                cmd.Parameters.AddWithValue("@phonenumber", phoneNumber.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@education", degreeEducation.Text);
                cmd.Parameters.AddWithValue("@langauge", langauge.Text);
                cmd.Parameters.AddWithValue("@langaugelevel", languageLevel.Text);
                cmd.Parameters.AddWithValue("@fathername", father.Text);
                cmd.Parameters.AddWithValue("@fatherstatus", familyStatus.Text);
                cmd.Parameters.AddWithValue("@fatherjob", fatherJob.Text);
                cmd.Parameters.AddWithValue("@mothername", mother.Text);
                cmd.Parameters.AddWithValue("@motherstatus", motherStatus.Text);
                cmd.Parameters.AddWithValue("@motherjob", motherJob.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update successful.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new Connection().dbs;
            SqlCommand cmd = new SqlCommand("Delete dbo.tbl_staff where id=@id", con);
            cmd.Parameters.AddWithValue("@id", textId.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Delete successful.");
        }

        private void Background_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new Connection().dbs)
            {
                // Create a SqlCommand object with your query and the connection
                string query = "SELECT MAX(id) FROM tbl_staff" ; // Replace with your actual query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query
                    SqlDataReader reader = command.ExecuteReader();

                    // Process the results
                    while (reader.Read())
                    {
                        // Access the columns using reader.GetString(), reader.GetInt32(), etc.
                        textId.Text = (reader.GetInt32(0)+1).ToString();    
                    }
                    // Close the SqlDataReader
                    reader.Close();
                }

                connection.Close();
            }
        }
    }
}

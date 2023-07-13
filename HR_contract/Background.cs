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

                SqlCommand cmd = new SqlCommand(String.Format("INSERT INTO dbo.tbl_staff (firstname_khmer, lastname_khmer, firstname_eng, lastname_eng, sex, dateofbirth, placeofbirth, addresss, nation, nationality, phonenumber, email, education, langauge, langaugelevel,fathername, fatherstatus, fatherjob, mothername, motherstarus, motherjob) VALUES(@firstname_khmer, @lastname_khmer, @firstname_eng, @lastname_eng, @sex, @dateofbirth, @placeofbirth, @addresss, @nation, @nationality, @phonenumber, @email, @education, @langauge, @langaugelevel,@fathername, @fatherstatus, @fatherjob, @mothername, @motherstarus, @motherjob)"), con);
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
                cmd.Parameters.AddWithValue("@motherstarus", motherStatus.Text);
                cmd.Parameters.AddWithValue("@motherjob", motherJob.Text);

                cmd.ExecuteNonQuery();
                con.Close();
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
    }
}

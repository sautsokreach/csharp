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
    public partial class Dashboard : UserControl
    {
        String type = "staff";
        public Dashboard()
        {
            InitializeComponent();
            SqlConnection con = new Connection().dbs;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from tbl_staff";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (type == "staff")
            {
                ClassBackground classBackground = new ClassBackground();
                classBackground.Id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
                classBackground.Lastname_khmer = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                classBackground.Firstname_khmer = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                classBackground.Firstname_eng = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                classBackground.Lastname_eng = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();

                classBackground.Sex = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                classBackground.Dateofbirth = DateTime.Parse( dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString());
                classBackground.Placeofbirth = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
                classBackground.Address = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();

                classBackground.Nation = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString();
                classBackground.Nationality = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString();
                classBackground.Phonenumber = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[11].Value.ToString();
                classBackground.Email = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[12].Value.ToString();
                classBackground.Education = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[13].Value.ToString();
                classBackground.Langauge = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[14].Value.ToString();
                classBackground.Langaugelevel = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[15].Value.ToString();
                classBackground.Fathername = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[16].Value.ToString();
                classBackground.Fatherstatus = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[17].Value.ToString();

                classBackground.Fatherjob = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[18].Value.ToString();
                classBackground.Mothername = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[19].Value.ToString();
                classBackground.Motherstatus = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[20].Value.ToString();
                classBackground.Motherjob = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[21].Value.ToString();
                classBackground.Status = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[22].Value.ToString();
                Form1 reportBackground = new Form1(classBackground);
                reportBackground.ShowDialog();
            }
            else
            {
                ClassContract classContract = new ClassContract();
                classContract.firstName = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                classContract.laststName = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                classContract.gender = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                classContract.email = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();

                classContract.phoneNumber = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                classContract.dateContract = DateTime.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString());
                classContract.salary = float.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString());
                classContract.bonus = float.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString());
                classContract.typeStaff = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
                ContractForm reportContract = new ContractForm(classContract);
                reportContract.ShowDialog();
            }
         
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            type = "staff";
            SqlConnection con = new Connection().dbs;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select * from tbl_staff";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            type = "contract";
            SqlConnection con = new Connection().dbs;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = con;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select firstName,lastName,sex,email,phonenumber,hireDate,salary,bonus,typeofstaff  from tbl_contract inner join tbl_staff ts on tbl_contract.staff_id = ts.id";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
        }
    }
}

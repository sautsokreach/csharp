﻿using System;
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
                Form1 reportBackground = new Form1(classBackground);
                reportBackground.ShowDialog();
            }
            else
            {
                ClassContract classContract = new ClassContract();
                classContract.firstName = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                classContract.laststName = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                classContract.email = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
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
            sqlCmd.CommandText = "Select * from tbl_contract";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_contract
{
    public partial class FormHomePage : Form
    {
        public FormHomePage()
        {
            InitializeComponent();
            dashboard1.Show();
            dashboard1.Dock = DockStyle.Fill;
            dashboard1.BringToFront();
            contract1.Hide();
            background1.Hide();

        }

        private void contract_Click(object sender, EventArgs e)
        {
            changeTab(contract1);
        }

        private void background_Click(object sender, EventArgs e)
        {
            changeTab(background1);
        }

        private void home_Click(object sender, EventArgs e)
        {
            changeTab(dashboard1);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void changeTab(UserControl CurrentUserControl)
        {
            List<UserControl> allControl = new List<UserControl>();
            allControl.Add(dashboard1);
            allControl.Add(background1);
            allControl.Add(contract1);
            foreach (UserControl UserControl in allControl)
            {
                if (UserControl == CurrentUserControl)
                {
                    UserControl.Show();
                    UserControl.BringToFront();
                }
                else
                {
                    UserControl.Hide();
                }
            }

        }

        private void FormHomePage_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        ClassBackground classBackground;
        public Form1(ClassBackground classBackground)
        {
            InitializeComponent();
            this.classBackground = classBackground;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("LastNameKhmer",classBackground.Lastname_khmer),
                new Microsoft.Reporting.WinForms.ReportParameter("FirstNameKhmer",classBackground.Lastname_khmer),
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}

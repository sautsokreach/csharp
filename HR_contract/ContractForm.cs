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
    public partial class ContractForm : Form
    {
        ClassContract classContract;
        public ContractForm(ClassContract classContract)
        {
            InitializeComponent();
            this.classContract = classContract;
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new Microsoft.Reporting.WinForms.ReportParameter("LastNameKhmer",classContract.firstName),
                new Microsoft.Reporting.WinForms.ReportParameter("FirstNameKhmer",classContract.laststName),
           };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();

        }
    }
}

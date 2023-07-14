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
                new Microsoft.Reporting.WinForms.ReportParameter("LastNameKhmer",classBackground.Firstname_khmer),
                new Microsoft.Reporting.WinForms.ReportParameter("FirstNameKhmer",classBackground.Lastname_khmer),
                new Microsoft.Reporting.WinForms.ReportParameter("FirstNameEng",classBackground.Firstname_eng),
                new Microsoft.Reporting.WinForms.ReportParameter("LastNameEng",classBackground.Lastname_eng),
                new Microsoft.Reporting.WinForms.ReportParameter("Sex",classBackground.Sex),
                new Microsoft.Reporting.WinForms.ReportParameter("DateOfBirth",classBackground.Dateofbirth.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("PlaceofBirth",classBackground.Placeofbirth),
                new Microsoft.Reporting.WinForms.ReportParameter("Address",classBackground.Address),
                new Microsoft.Reporting.WinForms.ReportParameter("Nation",classBackground.Nation),
                new Microsoft.Reporting.WinForms.ReportParameter("Nationality",classBackground.Nationality),
                new Microsoft.Reporting.WinForms.ReportParameter("PhoneNumber",classBackground.Phonenumber),
                new Microsoft.Reporting.WinForms.ReportParameter("Email",classBackground.Email),
                new Microsoft.Reporting.WinForms.ReportParameter("Education",classBackground.Education),
                new Microsoft.Reporting.WinForms.ReportParameter("Language",classBackground.Langauge),
                new Microsoft.Reporting.WinForms.ReportParameter("LanguageLevel",classBackground.Langaugelevel),
                new Microsoft.Reporting.WinForms.ReportParameter("FatherName",classBackground.Fathername),

                new Microsoft.Reporting.WinForms.ReportParameter("FatherStatus",classBackground.Fatherstatus),
                new Microsoft.Reporting.WinForms.ReportParameter("FatherJob",classBackground.Fatherjob),
                new Microsoft.Reporting.WinForms.ReportParameter("MotherName",classBackground.Mothername),
                new Microsoft.Reporting.WinForms.ReportParameter("MotherJob",classBackground.Motherjob),
                new Microsoft.Reporting.WinForms.ReportParameter("MotherStatus",classBackground.Motherstatus),
                new Microsoft.Reporting.WinForms.ReportParameter("Status",classBackground.Status),
            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}

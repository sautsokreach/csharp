using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_contract
{
    public class Connection
    {
        public SqlConnection dbs;

        public Connection()
        {
            try
            {
                dbs = new SqlConnection("Data Source=16.171.161.144;Initial Catalog=FinalProjectWU;Persist Security Info=True;User ID=sa;Password=Sokreach123!@#");
                dbs.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
      
}

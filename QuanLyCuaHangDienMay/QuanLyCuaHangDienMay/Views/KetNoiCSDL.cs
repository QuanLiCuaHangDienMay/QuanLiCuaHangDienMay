using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienMay
{
    public partial class FrmKetNoiCSDL : Form
    {
        CauHinh cauhinh = new CauHinh();

        public FrmKetNoiCSDL()
        {
            InitializeComponent();
        }

        private void FrmKetNoiCSDL_Load(object sender, EventArgs e)
        {
            //SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            //System.Data.DataTable table = instance.GetDataSources();
            DataTable dataTable = cauhinh.GetServerName();
            cbb_Servername.Items.Clear();
            foreach (System.Data.DataRow row in dataTable.Rows)
            {
                foreach (System.Data.DataColumn col in dataTable.Columns)
                {
                    cbb_Servername.Items.Add(row[col]);
                }
            }
        }

        private void btn_Decline_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            if (cbb_Servername.Text.Length > 0 && txt_Password.Text.Length > 0 && txt_Username.Text.Length > 0 && cbb_Database.Text.Length > 0)
            {
                ChangeConnectionString(cbb_Servername.Text, cbb_Database.Text, txt_Username.Text, txt_Password.Text);
                this.Close();
            }
            else
            {
                string bien = "Vui lòng điền ";
                if (cbb_Servername.Text.Length == 0)
                    bien += "SeverName ";
                if (txt_Password.Text.Length == 0)
                    bien += "Password ";
                if (txt_Username.Text.Length == 0)
                    bien += "UserName ";
                if (cbb_Database.Text.Length == 0)
                    bien += "DataBase ";
                MessageBox.Show(bien);
            }
        }
        public void ChangeConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
            string chuoi = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";Password = " + pPass + "";

            SqlConnection sqlHelp = new SqlConnection(chuoi);
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.ConnectionStrings.ConnectionStrings["QuanLyCuaHangDienMay.Properties.Settings.QB_QL_CUA_HANG_DIEN_MAYConnectionString"].ConnectionString = chuoi;
            configuration.ConnectionStrings.ConnectionStrings["QuanLyCuaHangDienMay.Properties.Settings.QB_QL_CUA_HANG_DIEN_MAYConnectionString"].ProviderName = "System.Data.SqlClient";
            configuration.Save(ConfigurationSaveMode.Modified);





            //Properties.Settings.Default.QB_QL_CUA_HANG_DIEN_MAYConnectionString = chuoi;
            //Properties.Settings.Default.Save();
        }


        private bool CheckedBeforSearchNameDB()
        {
            if (cbb_Servername.Text.Length > 0 && txt_Password.Text.Length > 0 && txt_Username.Text.Length > 0)
                return true;
            return false;
        }


        private void loadDatabase()
        {
            if (CheckedBeforSearchNameDB())
            {
                cbb_Database.Items.Clear();
                List<string> _list = cauhinh.GetDatabaseName(cbb_Servername.Text, txt_Username.Text, txt_Password.Text);
                if (_list == null)
                {
                    return;
                }
                foreach (string item in _list)
                {
                    cbb_Database.Items.Add(item);
                }

            }
        }

        private void cbb_Servername_TextChanged(object sender, EventArgs e)
        {
            loadDatabase();
        }

        private void cbb_Servername_SelectedValueChanged(object sender, EventArgs e)
        {
            loadDatabase();
        }

      
    }
}

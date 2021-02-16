using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SetLocalWeaponControlStatus1
{

    public partial class MainSimulatorPage : Form
    {
        public static string localNameSet;
        static SqlConnection sqlCon = new SqlConnection(ConnectionString.GetConnectionString());
        public MainSimulatorPage()
        {
            InitializeComponent();
            setDefault();
        }

        private void setLocalWeaponControlStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetLocalWeaponControlStatus navigateTo = new SetLocalWeaponControlStatus();
            navigateTo.Show();
        }

        void setDefault()
        {
            int checkCount = sqlCon.ExecuteScalar<int>("select count (BatteryId) from localWeaponControlStatusMain");
            if (checkCount == 1)
            {
                var changeName = sqlCon.ExecuteScalar("select sta_tus from localWeaponControlStatusMain");
                localNameSet = Convert.ToString(changeName);
                lolToolStripMenuItem.Text = localNameSet;
            }
        }
        
    }
}

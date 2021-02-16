using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace SetLocalWeaponControlStatus1
{
    public partial class SetLocalWeaponControlStatus : Form
    {
        static SqlConnection sqlCon = new SqlConnection(ConnectionString.GetConnectionString());
        public SetLocalWeaponControlStatus()
        {
            InitializeComponent();
        }











































        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            batteryComboBox.Items.Add("All Live Batteries");
            batteryComboBox.Items.Add("All Simulated Batteries");
            batteryComboBox.SelectedIndex = 0;
            unspecifiedRadio.Checked = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                FinalProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void ProcessBatteryID()
        {
            if (batteryComboBox.SelectedIndex == 0)
            {
                
                Data.batteryID = batteryComboBox.SelectedItem.ToString();
            }
            else
            {
                Data.batteryID = batteryComboBox.SelectedItem.ToString();
            }
        }

        void ProcessStatus()
        {
            if (unspecifiedRadio.Checked == true)
            {
                Data.status = unspecifiedRadio.Text;
            }
            else if (holdRadio.Checked == true)
            {
                Data.status = holdRadio.Text;
            }
            else if (tightRadio.Checked == true)
            {
                Data.status = tightRadio.Text;
            }
            else if (freeRadio.Checked == true)
            {
                Data.status = freeRadio.Text;
            }
        }

        void FinalProcess()
        {
            ProcessBatteryID();
            ProcessStatus();

            Data.localWeaponControlStatus = Data.batteryID;

            if(sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            int isNull = sqlCon.ExecuteScalar<int>("select count (BatteryId) from localWeaponControlStatusMain");

            if (isNull == 1)
            {
                SelectBeforeAdd1();
                AddBeforeDelete();
                DeleteDummyData();
                AddDataToMain();
            }
            else
            {
                AddDataToMain();
            }
        }

        void DeleteDummyData()
        {
            try
            {
                sqlCon.Execute("DELETE FROM localWeaponControlStatusMain");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        void SelectBeforeAdd1()
        {
            var batteryIdTemp = sqlCon.ExecuteScalar("select BatteryId from localWeaponControlStatusMain");
            Data.tempData1 = Convert.ToString(batteryIdTemp);
            var statusTemp = sqlCon.ExecuteScalar("select sta_tus from localWeaponControlStatusMain");
            Data.tempData2 = Convert.ToString(statusTemp);
            var timeDateTemp = sqlCon.ExecuteScalar("select timeDate from localWeaponControlStatusMain");
            Data.tempData3 = Convert.ToString(timeDateTemp);
        }

        void AddBeforeDelete()
        {
            DynamicParameters paramTwo = new DynamicParameters();
            paramTwo.Add("@BatteryId", Data.tempData1);
            paramTwo.Add("@sta_tus", Data.tempData2);
            paramTwo.Add("@Timedate", Data.tempData3);
            sqlCon.Execute("DatabaseAddDataBeforeDeleteFromMain", paramTwo, commandType: CommandType.StoredProcedure);
        }
        void AddDataToMain()
        {
            DynamicParameters paramOne = new DynamicParameters();
            paramOne.Add("@BatteryId", Data.batteryID);
            paramOne.Add("@sta_tus", Data.status);
            paramOne.Add("@timeDate", DateTime.Now);
            sqlCon.Execute("MainAddData", paramOne, commandType: CommandType.StoredProcedure);
            MessageBox.Show("Added Succesfully");
        }
    }
}

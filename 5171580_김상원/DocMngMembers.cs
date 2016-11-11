using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace _5171580_김상원
{
    public partial class DocMngMembers : DevExpress.XtraEditors.XtraUserControl
    {
        private DataTable blacklistTable;

        public DocMngMembers()
        {
            InitializeComponent();
            oracleConnection1.Open();
            ReloadTables();
            blacklistTable = bLACKLISTTableAdapter.GetData();
        }

        private void ReloadTables()
        {
            cUSTOMERSTableAdapter.Fill(dataSet1.CUSTOMERS);
            bLACKLISTTableAdapter.Fill(dataSet1.BLACKLIST);
        }

        private void ActionCustomerRemove(object sender, EventArgs e)
        {

        }

        private void ActionBlackConsumer(object sender, EventArgs e)
        {
            Button input = sender as Button;

            switch (input.Name)
            {
                case "btn_add":
                    AddToBlack();
                    break;

                case "btn_remove":
                    removeFromBlack();
                    break;
            }
        }

        private void AddToBlack()
        {
            DataRowView view = cUSTOMERSBindingSource.Current as DataRowView;
            DataRow data = view.Row;
            int c_id = int.Parse(data["c_id"].ToString());

            DataRow newRow = blacklistTable.NewRow();
            newRow["c_id"] = c_id;
            newRow["blklist_date"] = getDateServerTime();
            blacklistTable.Rows.Add(newRow);


            if (bLACKLISTTableAdapter.Update(blacklistTable as DataSet1.BLACKLISTDataTable) > 0)
            {
                MessageBox.Show("업데이트 성공");
            }
            else
            {
                MessageBox.Show("업데이트 실패");
            }
            bLACKLISTTableAdapter.Fill(dataSet1.BLACKLIST);
        }

        private void removeFromBlack()
        {
        }

        Object getScalarData(string cmd)
        {
            oracleCommand1.CommandText = cmd;
            return oracleCommand1.ExecuteScalar();
        }

        DateTime getDateServerTime()
        {
            string cmd = "SELECT SYSDATE FROM DUAL";

            return (Convert.ToDateTime(getScalarData(cmd)));
        }
    }
}

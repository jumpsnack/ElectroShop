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
        //  private DataSet1.BLACKLISTDataTable blacklistTable;

        public DocMngMembers()
        {
            InitializeComponent();
            oracleConnection1.Open();
            ReloadTables();
            // blacklistTable = bLACKLISTTableAdapter.GetData();
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
            DataSet1.BLACKLISTDataTable blacklistTable = bLACKLISTTableAdapter.GetData();
            DataRowView view = cUSTOMERSBindingSource.Current as DataRowView;
            DataRow data = view.Row;
            int c_id = int.Parse(data["c_id"].ToString());
            try
            {
                DataRow newRow = blacklistTable.NewRow();
                newRow["c_id"] = c_id;
                newRow["blklist_date"] = getDateServerTime();
                blacklistTable.Rows.Add(newRow);

                if (bLACKLISTTableAdapter.Update(blacklistTable) > 0)
                {
                    MessageBox.Show("업데이트 성공");
                    bLACKLISTTableAdapter.Fill(dataSet1.BLACKLIST); dataGridView2.ResetBindings();
                }
                else
                {
                    MessageBox.Show("업데이트 실패");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "업데이트 실패");
            }


        }

        private void removeFromBlack()
        {
            try
            {
                bLACKLISTBindingSource.RemoveCurrent();
                bLACKLISTBindingSource.EndEdit();

                int ret = bLACKLISTTableAdapter.Update(dataSet1.BLACKLIST);
                if (ret > 0)
                {
                    MessageBox.Show("Update successful");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Update failed");
            }
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

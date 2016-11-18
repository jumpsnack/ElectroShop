using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Menu;

namespace _5171580_김상원
{
    public partial class ReturnForm : Form
    {
        private DataSet1.RENTRow rentRow;
        private DataSet1.CUSTOMERSRow customersRow;

        public ReturnForm()
        {

        }

        public ReturnForm(DataSet1.RENTRow rentRow, DataSet1.CUSTOMERSRow customersRow)
        {
            InitializeComponent();
            oracleConnection1.Open();
            this.rentRow = rentRow;
            this.customersRow = customersRow;

            setForm();
            setDropDownGrade();
        }

        void setForm()
        {
            string customerName;
            string itemName;
            string vender;
            string model;
            string serial;
            string grade;
            string rentQty;
            string unit;
            string returnQty;
            DateTime startDate;
            DateTime endDate;

            customerName = customersRow.C_NAME;
            itemName = goodsTableAdapter1.GetDataById(rentRow.GDS_ID)[0].GDS_NAME;
            vender =
                goodstypeTableAdapter1.GetDataByNo(goodsTableAdapter1.GetDataById(rentRow.GDS_ID)[0].GDSTYPE_NO)[0]
                    .GDSTYPE_DESC;
            model = goodsTableAdapter1.GetDataById(rentRow.GDS_ID)[0].GDS_MODEL;
            serial = rentRow.GDS_ID.ToString();
            grade =
                goodsgradeTableAdapter1.GetDataByNo(goodsTableAdapter1.GetDataById(rentRow.GDS_ID)[0].GDSGRADE_NO)[0]
                    .GDSGRADE_DESC;
            rentQty = rentRow.RNT_QTY.ToString();
            unit =
                goodsunitTableAdapter1.GetDataByNo(goodsTableAdapter1.GetDataById(rentRow.GDS_ID)[0].GDSUNIT_ID)[0]
                    .GDSUNIT_DESC;
            returnQty = rentQty;
            startDate = rentRow.RNT_DATE;
            endDate = rentRow.RNT_RETURNDATE;

            tb_name.Text = customerName;
            tb_item.Text = itemName;
            tb_vender.Text = vender;
            tb_model.Text = model;
            tb_serial.Text = serial;
            dtbtn_grade.Text = grade;
            tb_rentqty.Text = rentQty;
            tb_unit.Text = unit;
            tb_returnqty.Text = returnQty;
            dt_start.Value = startDate;
            dt_end.MinDate = getDateServerTime();
            dt_end.MaxDate = endDate;
        }

        void setDropDownGrade()
        {
            DXPopupMenu menu = new DXPopupMenu();
            goodsgradeTableAdapter1.Fill(dataSet11.GOODSGRADE);
            DataSet1.GOODSGRADEDataTable goodsgradeDataTable = goodsgradeTableAdapter1.GetData();
            foreach (DataRow data in goodsgradeDataTable.Rows)
            {
                menu.Items.Add(new DXMenuItem(data["gdsgrade_desc"] as string));
                menu.Items[menu.Items.Count - 1].Click += ActionDropDownGrade;
            }
            dtbtn_grade.DropDownControl = menu;

        }

        void ActionDropDownGrade(Object sender, EventArgs e)
        {
            dtbtn_grade.Text = ((DXMenuItem)sender).Caption;
        }

        private void ActionReturn(object sender, EventArgs e)
        {
            if (tb_returnqty.TextLength < 1) return;
            try
            {
                string grade = dtbtn_grade.Text;
                string returnQty = tb_returnqty.Text;
                DateTime reutnrTime = dt_end.Value;

                if (rentRow != null && customersRow != null)
                {
                    goodsTableAdapter1.Fill(dataSet11.GOODS);
                    DataSet1.GOODSRow goodsRow = goodsTableAdapter1.GetDataById(rentRow.GDS_ID)[0];
                    goodsRow.GDSGRADE_NO = goodsgradeTableAdapter1.GetDataByDesc(grade)[0].GDSGRADE_NO;
                    goodsRow.GDS_QTY += int.Parse(returnQty);

                    int ret = goodsTableAdapter1.Update(goodsRow);
                    if (ret < 1)
                    {
                        throw new Exception();
                    }

                    rentRow.RNT_RETURNDATE = reutnrTime;
                    rentRow.RNTSTATE_NO = "1";

                    ret = rentTableAdapter1.Update(rentRow);
                    if (ret > 0)
                    {
                        MessageBox.Show("반납완료");
                        this.Close();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "실패");
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

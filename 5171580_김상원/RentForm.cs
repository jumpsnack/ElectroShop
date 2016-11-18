using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5171580_김상원
{
    public partial class RentForm : Form
    {
        private DataSet1.GOODSRow goodsRow;
        private DataSet1.CUSTOMERSRow customersRow;

        public RentForm(DataSet1.GOODSRow goodsRow, DataSet1.CUSTOMERSRow customersRow)
        {
            InitializeComponent();
            oracleConnection1.Open();
            this.goodsRow = goodsRow;
            this.customersRow = customersRow;

            setForm(goodsRow, customersRow);
        }

        void setForm(DataSet1.GOODSRow goodsData, DataSet1.CUSTOMERSRow customerData)
        {
            goodsTableAdapter1.Fill(dataSet11.GOODS);
            goodstypeTableAdapter1.Fill(dataSet11.GOODSTYPE);
            goodsunitTableAdapter1.Fill(dataSet11.GOODSUNIT);
            goodsgradeTableAdapter1.Fill(dataSet11.GOODSGRADE);

            tb_required.Text = "1";
            tb_name.Text = customerData.C_NAME;

            tb_item.Text = goodsData.GDS_NAME;
            tb_vender.Text = goodstypeTableAdapter1.GetDataByNo(goodsData.GDSTYPE_NO)[0].GDSTYPE_DESC; 
            tb_model.Text = goodsData.GDS_MODEL;
            tb_qty.Text = goodsData.GDS_QTY.ToString();
            tb_unit.Text = goodsunitTableAdapter1.GetDataByNo(goodsData.GDSUNIT_ID)[0].GDSUNIT_DESC; 
            tb_grade.Text = goodsgradeTableAdapter1.GetDataByNo(goodsData.GDSGRADE_NO)[0].GDSGRADE_DESC;
            tb_serial.Text = goodsData.GDS_ID.ToString();

            dt_start.Value = getDateServerTime();
            dt_end.Value = dt_start.Value;
            dt_end.MinDate = dt_start.Value.AddDays(1);dt_end.MaxDate =
                dt_start.Value.AddDays(
                    double.Parse(goodsgradeTableAdapter1.GetDataByNo(goodsData.GDSGRADE_NO)[0].GDSGRADE_PERIOD));

            TimeSpan period = dt_end.Value - dt_start.Value;
            tb_period.Text = period.Days.ToString();
            decimal price = goodsData.GDS_PRICE;
            decimal priceRate = goodsgradeTableAdapter1.GetDataByNo(goodsData.GDSGRADE_NO)[0].GDSGRADE_PRICERATE;
            string days = tb_period.Text;
            string required = tb_required.Text;
            string fee = (Convert.ToInt64(price * priceRate) * int.Parse(days) * int.Parse(required)).ToString();
            tb_fee.Text = fee;
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

        private void ActionTimePicker(object sender, EventArgs e)
        {
            if (tb_period.TextLength * tb_required.TextLength < 1) return;
            TimeSpan period = dt_end.Value - dt_start.Value;
            tb_period.Text = period.Days.ToString();
            decimal price = goodsRow.GDS_PRICE;
            decimal priceRate = goodsgradeTableAdapter1.GetDataByNo(goodsRow.GDSGRADE_NO)[0].GDSGRADE_PRICERATE;
            string days = tb_period.Text;
            string required = tb_required.Text;
            string fee = (Convert.ToInt64(price * priceRate) * int.Parse(days) * int.Parse(required)).ToString();
            tb_fee.Text = fee;
        }

        private void ActionValueChanged(object sender, EventArgs e)
        {
            if (tb_period.TextLength * tb_required.TextLength < 1) return;
            decimal price = goodsRow.GDS_PRICE;
            decimal priceRate = goodsgradeTableAdapter1.GetDataByNo(goodsRow.GDSGRADE_NO)[0].GDSGRADE_PRICERATE;
            string days = tb_period.Text;
            string required = tb_required.Text;
            string fee = (Convert.ToInt64(price * priceRate) * int.Parse(days) * int.Parse(required)).ToString();
            tb_fee.Text = fee;
        }

        private void ActionRent(object sender, EventArgs e)
        {
            if (tb_required.TextLength < 1) return;
            try
            {
                int gds_id = Convert.ToInt16(goodsRow.GDS_ID);
                int c_id = Convert.ToInt16(customersRow.C_ID);
                DateTime rnt_date = getDateServerTime();
                DateTime rnt_returndate = dt_end.Value;
                int rnt_qty = int.Parse(tb_required.Text);
                string stf_id = Form1.account;string rntstate_no = "0";

                rentTableAdapter1.Fill(dataSet11.RENT);
                DataSet1.RENTDataTable rntTable = rentTableAdapter1.GetData();
                DataSet1.RENTRow newRow = rntTable.NewRENTRow();
                newRow.GDS_ID = gds_id;
                newRow.C_ID = c_id;
                newRow.RNT_DATE = rnt_date;
                newRow.RNT_QTY = rnt_qty;
                newRow.STF_ID = stf_id;
                newRow.RNTSTATE_NO = rntstate_no;
                newRow.RNT_RETURNDATE = rnt_returndate;

                rntTable.Rows.Add(newRow);
                int ret = rentTableAdapter1.Update(rntTable);
                if (ret < 1)
                {
                    MessageBox.Show("실패");
                    throw new Exception();
                }

                goodsRow.GDS_QTY = goodsRow.GDS_QTY - rnt_qty;
                ret = goodsTableAdapter1.Update(goodsRow);
                if (ret > 0)
                {
                    MessageBox.Show("성공");
                    
                    this.Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception exc){
                MessageBox.Show(exc.Message, "실패");
            }
        }
    }
}

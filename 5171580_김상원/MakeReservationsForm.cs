using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraRichEdit.UI;

namespace _5171580_김상원
{
    public partial class MakeReservationsForm : Form
    {
        private DataSet1.GOODSRow goodsRow;
        private DataSet1.CUSTOMERSRow customersRow;
        private string customersEmail;

        public MakeReservationsForm(DataSet1.GOODSRow goodsRow, string customersEmail)
        {
            InitializeComponent();
            oracleConnection1.Open();

            this.goodsRow = goodsRow;
            this.customersEmail = customersEmail;

            setUI();
        }

        public void setUI()
        {
            try
            {
                string name;
                string tel;
                string email;

                customersTableAdapter1.Fill(dataSet11.CUSTOMERS);
                DataSet1.CUSTOMERSRow customersRow = customersTableAdapter1.GetDataByEmail(customersEmail)[0];

                this.customersRow = customersRow;

                name = customersRow.C_NAME;
                tel = customersRow.C_TEL;
                email = customersRow.C_EMAIL;

                tb_name.Text = name;
                tb_tel.Text = tel;
                tb_email.Text = email;

                string item;
                string vendor;
                string model;
                string serial;
                string qty;
                string unit;

                goodsunitTableAdapter1.Fill(dataSet11.GOODSUNIT);
                goodstypeTableAdapter1.Fill(dataSet11.GOODSTYPE);

                item = goodsRow.GDS_NAME;
                vendor = goodstypeTableAdapter1.GetDataByNo(goodsRow.GDSTYPE_NO)[0].GDSTYPE_DESC;
                model = goodsRow.GDS_MODEL;
                serial = goodsRow.GDS_ID.ToString();
                qty = getQuantityCount(serial).ToString();
                unit = goodsunitTableAdapter1.GetDataByNo(goodsRow.GDSTYPE_NO)[0].GDSUNIT_DESC;

                tb_item.Text = item;
                tb_vendor.Text = vendor;
                tb_model.Text = model;
                tb_serial.Text = serial;
                tb_qty.Text = "1";
                tb_unit.Text = unit;
                pb_item.Image = (Image)new ImageConverter().ConvertFrom(goodsRow.GDS_IMG);

            }
            catch (Exception)
            {
                MessageBox.Show("시스템 오류입니다.\n나중에 다시 시도해 주세요.");
                this.Close();
                throw;
            }
        }

        int getQuantityCount(string gds_id)
        {
            goodsTableAdapter1.Fill(dataSet11.GOODS);
            rentTableAdapter1.Fill(dataSet11.RENT);

            int bookedQty = rentTableAdapter1.GetRentingDataByGdsID(int.Parse(gds_id)).Count;

            return bookedQty;
        }

        public void makeReservation()
        {
            reservationsTableAdapter1.Fill(dataSet11.RESERVATIONS);
            customersTableAdapter1.Fill(dataSet11.CUSTOMERS);
            DataSet1.CUSTOMERSRow customersRow = customersTableAdapter1.GetDataByEmail(customersEmail)[0];

            DataSet1.RESERVATIONSDataTable reservationsDataTable = reservationsTableAdapter1.GetData();
            DataSet1.RESERVATIONSRow newReservationsRow =
                reservationsDataTable.NewRESERVATIONSRow();
            newReservationsRow.C_ID = customersRow.C_ID;
            newReservationsRow.GDS_ID = goodsRow.GDS_ID;
            newReservationsRow.RSV_DATE = getDateServerTime();
            newReservationsRow.RSV_QTY = int.Parse(tb_qty.Text);

            reservationsDataTable.Rows.Add(newReservationsRow);
            int ret = reservationsTableAdapter1.Update(reservationsDataTable);
            if (ret > 0)
            {
                MessageBox.Show("예약 성공");
                this.Close();}
            else
            {
                MessageBox.Show("실패");
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

        private void ActionBook(object sender, EventArgs e)
        {
            makeReservation();
            
        }
    }
}

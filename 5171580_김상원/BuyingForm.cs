using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DevExpress.DataAccess.UI.Wizard.Views;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace _5171580_김상원
{
    public partial class BuyingForm : DevExpress.XtraEditors.XtraForm
    {
        private FileStream fs;
        private byte[] b;

        private DataSet1.GOODSRow currentGoodsRow;

        public BuyingForm()
        {
            InitializeComponent();

            oracleConnection1.Open();

            setDropDownUnit();
            setDropDownShelves();
            setDropDownVendors();
            setDropDownGrade();
            setDropDownStore();
        }

        public BuyingForm(DataSet1.GOODSRow data)
        {
            InitializeComponent();
            this.currentGoodsRow = data;oracleConnection1.Open();
            setDropDownUnit();
            setDropDownShelves();
            setDropDownVendors();
            setDropDownGrade();
            setDropDownStore();

            lb_add.Text = "수  정";

            setModify(data);
        }

        void setDropDownUnit()
        {
            DXPopupMenu menu = new DXPopupMenu();
            goodsunitTableAdapter1.Fill(dataSet1.GOODSUNIT);
            DataSet1.GOODSUNITDataTable goodsunitDataTable = goodsunitTableAdapter1.GetData();
            foreach (DataRow data in goodsunitDataTable.Rows)
            {
                menu.Items.Add(new DXMenuItem(data["gdsunit_desc"] as string));
                menu.Items[menu.Items.Count - 1].Click += ActionDropDownUnit;
            }

            drbtn_unit.DropDownControl = menu;
        }

        void setDropDownShelves()
        {
            DXPopupMenu menu = new DXPopupMenu();
            shelvesTableAdapter1.Fill(dataSet1.SHELVES);
            DataSet1.SHELVESDataTable shelvesDataTable = shelvesTableAdapter1.GetData();
            foreach (DataRow data in shelvesDataTable.Rows)
            {
                menu.Items.Add(new DXMenuItem(data["slvs_desc"] as string));
                menu.Items[menu.Items.Count - 1].Click += ActionDropDownShelves;
            }

            drbtn_slvs.DropDownControl = menu;
        }

        void setDropDownVendors()
        {
            DXPopupMenu menu = new DXPopupMenu();
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
            DataSet1.GOODSTYPEDataTable goodstypeDataTable = goodstypeTableAdapter1.GetData();
            foreach (DataRow data in goodstypeDataTable.Rows)
            {
                menu.Items.Add(new DXMenuItem(data["gdstype_desc"] as string));
                menu.Items[menu.Items.Count - 1].Click += ActionDropDownVendors;
            }

            drbtn_vendor.DropDownControl = menu;
        }

        void setDropDownGrade()
        {
            DXPopupMenu menu = new DXPopupMenu();
            goodsgradeTableAdapter1.Fill(dataSet1.GOODSGRADE);
            DataSet1.GOODSGRADEDataTable goodsgradeDataTable = goodsgradeTableAdapter1.GetData();
            foreach (DataRow data in goodsgradeDataTable.Rows)
            {
                menu.Items.Add(new DXMenuItem(data["gdsgrade_desc"] as string));
                menu.Items[menu.Items.Count - 1].Click += ActionDropDownGrade;
            }

            drbtn_grade.DropDownControl = menu;
        }

        void setDropDownStore()
        {
            DXPopupMenu menu = new DXPopupMenu();
            goodsstoreTableAdapter1.Fill(dataSet1.GOODSSTORE);
            DataSet1.GOODSSTOREDataTable goodsstoreDataTable = goodsstoreTableAdapter1.GetData();
            foreach (DataRow data in goodsstoreDataTable.Rows)
            {
                menu.Items.Add(new DXMenuItem(data["str_name"] as string));
                menu.Items[menu.Items.Count - 1].Click += ActionDropDownStore;
            }

            drbtn_store.DropDownControl = menu;
        }

        void ActionDropDownUnit(Object sender, EventArgs e)
        {
            drbtn_unit.Text = ((DXMenuItem)sender).Caption;
        }

        void ActionDropDownShelves(Object sender, EventArgs e)
        {
            drbtn_slvs.Text = ((DXMenuItem)sender).Caption;
        }

        void ActionDropDownVendors(Object sender, EventArgs e)
        {
            drbtn_vendor.Text = ((DXMenuItem)sender).Caption;
        }

        void ActionDropDownGrade(Object sender, EventArgs e)
        {
            drbtn_grade.Text = ((DXMenuItem)sender).Caption;
        }

        void ActionDropDownStore(Object sender, EventArgs e)
        {
            drbtn_store.Text = ((DXMenuItem)sender).Caption;
        }

        private void ActionImageUpload(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    pb_img.ImageLocation = openFileDialog1.FileName;
                    fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    b = new byte[fs.Length - 1];
                    fs.Read(b, 0, b.Length);
                    fs.Close();
                    MessageBox.Show("이미지 업로드 성공");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "실패");
                }

            }
        }

        private void ActionLabel(object sender, EventArgs e)
        {
            Label input = sender as Label;

            switch (input.Name)
            {
                case "lb_add":
                    if (lb_add.Text == "수  정")
                    {
                        Modify();
                    }
                    else
                    {
                        Buy();
                    }
                    break;
                case "lb_init":
                    pb_img.ImageLocation = "";
                    b.Initialize();

                    tb_name.Text = "";
                    tb_qty.Text = "";
                    tb_price.Text = "";
                    tb_model.Text = "";

                    drbtn_unit.Text = "";
                    drbtn_grade.Text = "";
                    drbtn_slvs.Text = "";
                    drbtn_vendor.Text = "";
                    break;
            }
        }

        private void Buy()
        {
            int ret;
            try
            {
                if (b.Length * tb_name.TextLength * tb_model.TextLength * tb_qty.TextLength * tb_price.TextLength * drbtn_unit.Text.Length *
                    drbtn_grade.Text.Length * drbtn_slvs.Text.Length * drbtn_store.Text.Length * drbtn_vendor.Text.Length == 0)
                    return;
                if (drbtn_unit.Text.Equals("단위")) return;

                goodsTableAdapter1.Fill(dataSet1.GOODS);
                goodsgradeTableAdapter1.Fill(dataSet1.GOODSGRADE);
                goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
                goodsunitTableAdapter1.Fill(dataSet1.GOODSUNIT);
                DataSet1.GOODSGRADEDataTable goodsgradeDataTable = goodsgradeTableAdapter1.GetData();
                DataSet1.GOODSTYPEDataTable goodstypeDataTable = goodstypeTableAdapter1.GetData();
                DataSet1.GOODSUNITDataTable goodsunitDataTable = goodsunitTableAdapter1.GetData();

                string gdsgrade_no;

                //  DataRow[] gradeData = goodsgradeDataTable.Select("gdsgrade_desc = " + drbtn_grade.Text);
                //   gdsgrade_no = gradeData[0]["gdsgrade_no"] as string;
                gdsgrade_no = goodsgradeTableAdapter1.GetDataByDesc(drbtn_grade.Text)[0].GDSGRADE_NO;
                string gdstype_no;
                // DataRow[] typeData = goodstypeDataTable.Select("gdstype_desc = " + drbtn_vendor.Text);
                //  gdstype_no = typeData[0]["gdstype_no"] as string;
                gdstype_no = goodstypeTableAdapter1.GetDataByDesc(drbtn_vendor.Text)[0].GDSTYPE_NO;
                string gdsunit_id;
                // DataRow[] unitData = goodsunitDataTable.Select("gdsunit_desc = " + drbtn_unit.Text);
                //  gdsunit_id = unitData[0]["gdsunit_id"] as string;
                gdsunit_id = goodsunitTableAdapter1.GetDataByDesc(drbtn_unit.Text)[0].GDSUNIT_ID;

                string slvs_no;
                slvs_no = shelvesTableAdapter1.GetDataByDesc(drbtn_slvs.Text)[0].SLVS_NO;

                DataSet1.GOODSDataTable goodsDataTable = goodsTableAdapter1.GetData();
                DataSet1.GOODSRow goodsRow = goodsDataTable.NewGOODSRow();
                goodsRow.GDS_IMG = b;
                goodsRow.GDS_NAME = tb_name.Text;
                goodsRow.GDSGRADE_NO = gdsgrade_no;
                goodsRow.GDSTYPE_NO = gdstype_no;
                goodsRow.GDSUNIT_ID = gdsunit_id;
                goodsRow.SLVS_NO = slvs_no;
                goodsRow.GDS_PRICE = int.Parse(tb_price.Text);
                goodsRow.GDS_QTY = int.Parse(tb_qty.Text);
                goodsRow.GDS_MODEL = tb_model.Text;

                goodsDataTable.Rows.Add(goodsRow);

                ret = goodsTableAdapter1.Update(goodsDataTable);
                if (ret < 1)
                {
                    throw new Exception("상품등록 실패");
                }


                goodsstoreTableAdapter1.Fill(dataSet1.GOODSSTORE);
                buyinggoodsTableAdapter1.Fill(dataSet1.BUYINGGOODS);
                DataSet1.GOODSSTOREDataTable goodsstoreDataTable = goodsstoreTableAdapter1.GetData();
                DataSet1.BUYINGGOODSDataTable buyinggoodsDataTable = buyinggoodsTableAdapter1.GetData();
                goodsDataTable = goodsTableAdapter1.GetData();

                int gds_id = int.Parse(goodsRow.GDS_ID.ToString());

                int str_id;
                //DataRow[] storeData = goodsstoreDataTable.Select("str_name = " + drbtn_store.Text);
                //  str_id = int.Parse(storeData[0]["str_id"] as string);
                str_id = int.Parse(goodsstoreTableAdapter1.GetDataByName(drbtn_store.Text)[0].STR_ID.ToString());

                DataSet1.BUYINGGOODSRow buyinggoodsRow = buyinggoodsDataTable.NewBUYINGGOODSRow();
                buyinggoodsRow.BUYING_DATE = getDateServerTime();
                buyinggoodsRow.GDS_ID = gds_id;
                buyinggoodsRow.STR_ID = str_id;
                buyinggoodsRow.MNG_ID = Form1.account;

                buyinggoodsDataTable.Rows.Add(buyinggoodsRow);
                ret = buyinggoodsTableAdapter1.Update(buyinggoodsDataTable);
                if (ret < 1)
                {
                    throw new Exception("구매정보 등록 실패");
                }
                MessageBox.Show("업데이트 성공");
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "실패");
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

        void setModify(DataSet1.GOODSRow data)
        {
            b = data.GDS_IMG;
            if (b != null)
            {
                pb_img.Image = new Bitmap(new MemoryStream(b));
            }

            string gds_id = data.GDS_ID.ToString();
            string gds_name = data.GDS_NAME;
            string gds_qty = data.GDS_QTY.ToString();
            string slvs_no = data.SLVS_NO;
            string gdstype_no = data.GDSTYPE_NO;
            string gdsgrade_no = data.GDSGRADE_NO;
            string gdsunit_id = data.GDSUNIT_ID;
            string gds_price = data.GDS_PRICE.ToString();
            string gds_model = data.GDS_MODEL.ToString();

            buyinggoodsTableAdapter1.Fill(dataSet1.BUYINGGOODS);
            goodsunitTableAdapter1.Fill(dataSet1.GOODSUNIT);
            goodsgradeTableAdapter1.Fill(dataSet1.GOODSGRADE);
            shelvesTableAdapter1.Fill(dataSet1.SHELVES);
            goodsstoreTableAdapter1.Fill(dataSet1.GOODSSTORE);
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
            DataSet1.BUYINGGOODSDataTable table = buyinggoodsTableAdapter1.GetData();
            DataRow[] rows = table.Select("gds_id = " + gds_id);
            DataRow row = rows[0];

            tb_name.Text = gds_name;
            tb_price.Text = gds_price;
            tb_qty.Text = gds_qty;
            tb_model.Text = gds_model;
            drbtn_unit.Text =
                goodsunitTableAdapter1.GetData().Select("gdsunit_id = " + gdsunit_id)[0]["gdsunit_desc"] as string;
            drbtn_grade.Text =
                goodsgradeTableAdapter1.GetData().Select("gdsgrade_no = " + gdsgrade_no)[0]["gdsgrade_desc"] as string;
            drbtn_slvs.Text = shelvesTableAdapter1.GetData().Select("slvs_no = " + slvs_no)[0]["slvs_desc"] as string;
            drbtn_store.Text =
                goodsstoreTableAdapter1.GetData().Select("str_id = " + row["str_id"])[0]["str_name"] as string;
            drbtn_vendor.Text =
                goodstypeTableAdapter1.GetData().Select("gdstype_no = " + gdsgrade_no)[0]["gdstype_desc"] as string;
        }

        void Modify()
        {
            try
            {

                if (b.Length * tb_name.TextLength * tb_model.TextLength * tb_qty.TextLength * tb_price.TextLength * drbtn_unit.Text.Length *
                drbtn_grade.Text.Length * drbtn_slvs.Text.Length * drbtn_store.Text.Length * drbtn_vendor.Text.Length == 0)
                    return;
                if (drbtn_unit.Text.Equals("단위")) return;

                goodsTableAdapter1.Fill(dataSet1.GOODS);
                goodsgradeTableAdapter1.Fill(dataSet1.GOODSGRADE);
                goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
                goodsunitTableAdapter1.Fill(dataSet1.GOODSUNIT);
                DataSet1.GOODSGRADEDataTable goodsgradeDataTable = goodsgradeTableAdapter1.GetData();
                DataSet1.GOODSTYPEDataTable goodstypeDataTable = goodstypeTableAdapter1.GetData();
                DataSet1.GOODSUNITDataTable goodsunitDataTable = goodsunitTableAdapter1.GetData();

                string gdsgrade_no;

                //  DataRow[] gradeData = goodsgradeDataTable.Select("gdsgrade_desc = " + drbtn_grade.Text);
                //   gdsgrade_no = gradeData[0]["gdsgrade_no"] as string;
                gdsgrade_no = goodsgradeTableAdapter1.GetDataByDesc(drbtn_grade.Text)[0].GDSGRADE_NO;
                string gdstype_no;
                // DataRow[] typeData = goodstypeDataTable.Select("gdstype_desc = " + drbtn_vendor.Text);
                //  gdstype_no = typeData[0]["gdstype_no"] as string;
                gdstype_no = goodstypeTableAdapter1.GetDataByDesc(drbtn_vendor.Text)[0].GDSTYPE_NO;
                string gdsunit_id;
                // DataRow[] unitData = goodsunitDataTable.Select("gdsunit_desc = " + drbtn_unit.Text);
                //  gdsunit_id = unitData[0]["gdsunit_id"] as string;
                gdsunit_id = goodsunitTableAdapter1.GetDataByDesc(drbtn_unit.Text)[0].GDSUNIT_ID;

                string slvs_no;
                slvs_no = shelvesTableAdapter1.GetDataByDesc(drbtn_slvs.Text)[0].SLVS_NO;

                DataSet1.GOODSDataTable goodsDataTable = goodsTableAdapter1.GetData();
                DataSet1.GOODSRow presentRow = goodsDataTable.FindByGDS_ID(currentGoodsRow.GDS_ID);
                presentRow.GDS_IMG = b;
                presentRow.GDS_NAME = tb_name.Text;
                presentRow.GDSGRADE_NO = gdsgrade_no;
                presentRow.GDSTYPE_NO = gdstype_no;
                presentRow.GDSUNIT_ID = gdsunit_id;
                presentRow.SLVS_NO = slvs_no;
                presentRow.GDS_PRICE = int.Parse(tb_price.Text);
                presentRow.GDS_QTY = int.Parse(tb_qty.Text);
                presentRow.GDS_MODEL = tb_model.Text;

                int ret = goodsTableAdapter1.Update(presentRow);
               if(ret < 1)
                {
                    MessageBox.Show("실패");
                }

               buyinggoodsTableAdapter1.Fill(dataSet1.BUYINGGOODS);
                goodsstoreTableAdapter1.Fill(dataSet1.GOODSSTORE);
                DataSet1.BUYINGGOODSRow buyingRows =
                    buyinggoodsTableAdapter1.GetData().Select("gds_id = " + currentGoodsRow.GDS_ID)[0] as DataSet1.BUYINGGOODSRow;
                buyingRows.STR_ID = goodsstoreTableAdapter1.GetDataByName(drbtn_store.Text)[0].STR_ID;

                ret = buyinggoodsTableAdapter1.Update(buyingRows);
                if (ret > 0)
                {
                    MessageBox.Show("성공");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("실패");}

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "실패!");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Tile;

namespace _5171580_김상원
{
    public partial class CustomerForm : Form
    {
        private string customersEmail;
        private string nowViewItem = "Apple";
        public CustomerForm()
        {
            InitializeComponent();
            this.customersEmail = Form1.account;
            oracleConnection1.Open();

            // setGrid();
        }

        private void LabelPaint(object sender, PaintEventArgs e)
        {
            Label input = sender as Label;

            switch (input.Name)
            {
                case "lb_title":
                    Pen penBorder = new Pen(Color.Black, 3);
                    input.ForeColor = Color.Black;
                    Rectangle rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
                    e.Graphics.DrawRectangle(penBorder, rectBorder);
                    break;
            }
        }

        void setGrid()
        {
            goodsTableAdapter1.Fill(dataSet1.GOODS);
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
            DataSet1.GOODSDataTable table =
                goodsTableAdapter1.GetDataByType(goodstypeTableAdapter1.GetDataByDesc("Apple")[0].GDSTYPE_NO);
            gridControl1.DataSource = table;
            nowViewItem = "Apple";
            tileView1.RefreshData();
        }

        private void ActionButton(object sender, EventArgs e)
        {
            Button input = sender as Button;

            switch (input.Text)
            {
                case "Apple":
                    setGrid();
                    break;
                case "LG":
                    setLG(); break;
                case "Samsung":
                    setSamsung();
                    break;
                case "GoPro":
                    setGoPro();
                    break;
                case "SONY":
                    setSONY();
                    break;
                case "BOSE":
                    setBOSE(); break;
            }
        }
        void setLG()
        {
            goodsTableAdapter1.Fill(dataSet1.GOODS);
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
            DataSet1.GOODSDataTable table = goodsTableAdapter1.GetDataByType(goodstypeTableAdapter1.GetDataByDesc("LG")[0].GDSTYPE_NO);
            gridControl1.DataSource = table;
            nowViewItem = "LG";
            tileView1.RefreshData();
        }

        void setSamsung()
        {
            goodsTableAdapter1.Fill(dataSet1.GOODS);
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
            DataSet1.GOODSDataTable table = goodsTableAdapter1.GetDataByType(goodstypeTableAdapter1.GetDataByDesc("Samsung")[0].GDSTYPE_NO);
            gridControl1.DataSource = table;
            nowViewItem = "Samsung";
            tileView1.RefreshData();
        }

        void setGoPro()
        {
            goodsTableAdapter1.Fill(dataSet1.GOODS);
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
            DataSet1.GOODSDataTable table = goodsTableAdapter1.GetDataByType(goodstypeTableAdapter1.GetDataByDesc("GoPro")[0].GDSTYPE_NO);
            gridControl1.DataSource = table;
            nowViewItem = "GoPro";
            tileView1.RefreshData();
        }

        void setSONY()
        {
            goodsTableAdapter1.Fill(dataSet1.GOODS);
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
            DataSet1.GOODSDataTable table = goodsTableAdapter1.GetDataByType(goodstypeTableAdapter1.GetDataByDesc("SONY")[0].GDSTYPE_NO);
            gridControl1.DataSource = table;
            nowViewItem = "SONY";
            tileView1.RefreshData();
        }

        void setBOSE()
        {
            goodsTableAdapter1.Fill(dataSet1.GOODS);
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
            DataSet1.GOODSDataTable table = goodsTableAdapter1.GetDataByType(goodstypeTableAdapter1.GetDataByDesc("BOSE")[0].GDSTYPE_NO);
            gridControl1.DataSource = table;
            nowViewItem = "BOSE";
            tileView1.RefreshData();
        }

        private void ActionRowDouble(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            DoRowDoubleClick(view, pt);
        }

        private void DoRowDoubleClick(GridView view, Point pt)
        {
            GridHitInfo info = view.CalcHitInfo(pt);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                if (!colCaption.Equals("N/A"))
                {
                    DataRowView rowView = view.GetRow(info.RowHandle) as DataRowView;
                    DataSet1.GOODSRow goodsRow = rowView.Row as DataSet1.GOODSRow;
                    new GoodsDetailView().Show();
                    /*
                    if (goodsRow.GDS_QTY < 1)
                    {
                        if (MessageBox.Show("현재 재고가 없습니다.\n예약하시겠습니까?", "재고부족", MessageBoxButtons.YesNo) ==
                            DialogResult.Yes)
                        {
                            new MakeReservationsForm(goodsRow, customersEmail).ShowDialog();
                        }
                    }*/
                }
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.REP_GOODS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            this.rEP_GOODSTableAdapter.Fill(this.dataSet1.REP_GOODS);
            goodsunitTableAdapter1.Fill(dataSet1.GOODSUNIT);
            remaiN_GOODSTableAdapter1.Fill(dataSet1.REMAIN_GOODS);
            miN_RENT_FEETableAdapter1.Fill(dataSet1.MIN_RENT_FEE);
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
        }

        private void ActionCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {
            try
            {
                //2:qty, 4:price
                string item = e.Item.Elements[1].Text;

                if (item != null)
                {
                    e.Item.Elements[2].Text =
                        remaiN_GOODSTableAdapter1.GetDataByName(e.Item.Elements[1].Text)[0].REMAINING + " " +
                        goodsunitTableAdapter1.GetDataByNo(
                                tileView1.GetRowCellValue(e.RowHandle, colGDSUNIT_ID1) as string)[0].GDSUNIT_DESC
                            .ToString();
                    e.Item.Elements[4].Text =
                        miN_RENT_FEETableAdapter1.GetDataByName(e.Item.Elements[1].Text)[0].GDS_MIN_FEE.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "경고");
            }


        }

        private void ActionFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            string vendor = goodstypeTableAdapter1.GetDataByDesc(nowViewItem)[0].GDSTYPE_NO;
            TileView view = sender as TileView;
            DataSet1.REP_GOODSRow row = view.GetDataRow(e.ListSourceRow) as DataSet1.REP_GOODSRow;
            if (row.GDSTYPE_NO == vendor)
            {
                e.Visible = true;
                e.Handled = false;
            }
            else
            {
                e.Visible = false;
                e.Handled = true;
            }
        }
    }
}

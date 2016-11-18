using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DashboardWin.Design;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Resizing;
using DevExpress.XtraRichEdit.Commands;
using _5171580_김상원.DataSet1TableAdapters;

namespace _5171580_김상원
{
    public partial class StaffForm : DevExpress.XtraEditors.XtraForm
    {
        public StaffForm()
        {
            InitializeComponent();

            tb_item.Enabled = tb_model.Enabled = btn_search.Enabled = drbtn_slvs.Enabled = drbtn_vendor.Enabled = false;

            setDropDownShelves();
            setDropDownvenders();
            setForm2();
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
        void setDropDownvenders()
        {
            DXPopupMenu menu = new DXPopupMenu();
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
            DataSet1.GOODSTYPEDataTable goodstypeDataTable = goodstypeTableAdapter1.GetData();
            foreach (DataRow data in goodstypeDataTable.Rows)
            {
                menu.Items.Add(new DXMenuItem(data["gdstype_desc"] as string));
                menu.Items[menu.Items.Count - 1].Click += ActionDropDownVenders;
            }
            drbtn_vendor.DropDownControl = menu;
        }

        void ActionDropDownShelves(Object sender, EventArgs e)
        {
            drbtn_slvs.Text = ((DXMenuItem)sender).Caption;
            gOODSTableAdapter.Fill(dataSet1.GOODS);
            shelvesTableAdapter1.Fill(dataSet1.SHELVES);
            DataSet1.GOODSDataTable table = gOODSTableAdapter.GetDataBySlvs(shelvesTableAdapter1.GetDataByDesc(drbtn_slvs.Text).Rows[0]["slvs_no"].ToString());
            gOODSBindingSource.DataSource = table;
            drbtn_vendor.Text = "제조사";
        }

        void ActionDropDownVenders(Object sender, EventArgs e)
        {
            drbtn_vendor.Text = ((DXMenuItem)sender).Caption;
            gOODSTableAdapter.Fill(dataSet1.GOODS);
            goodstypeTableAdapter1.Fill(dataSet1.GOODSTYPE);
            DataSet1.GOODSDataTable table = gOODSTableAdapter.GetDataByType(goodstypeTableAdapter1.GetDataByDesc(drbtn_vendor.Text)[0]["gdstype_no"].ToString());
            gOODSBindingSource.DataSource = table;
            drbtn_slvs.Text = "위치";
        }

        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);

        }

        private void ActionSearchCustomer(object sender, EventArgs e)
        {
            if (tb_name.TextLength < 1)
            {
                return;
            }

            customersTableAdapter1.Fill(dataSet1.CUSTOMERS);
            customersTableAdapter1.GetData().CaseSensitive = false;
            string name = tb_name.Text;
            DataSet1.CUSTOMERSDataTable table = customersTableAdapter1.GetRowsByName(name);
            //  gridCustomers.DataSource = table;
            cUSTOMERSBindingSource.DataSource = table;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'dataSet1.GOODS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.gOODSTableAdapter.Fill(this.dataSet1.GOODS);
            // TODO: 이 코드는 데이터를 'dataSet1.RENT' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //  this.rENTTableAdapter.Fill(this.dataSet1.RENT);
            // TODO: 이 코드는 데이터를 'dataSet1.CUSTOMERS' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            // this.customersTableAdapter1.Fill(this.dataSet1.CUSTOMERS);

        }

        private void ActionCustomerSelect(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRowView view = cUSTOMERSBindingSource.Current as DataRowView;
            DataSet1.CUSTOMERSRow row = view.Row as DataSet1.CUSTOMERSRow;
            tb_tel.Text = row.C_TEL;
            tb_email.Text = row.C_EMAIL;
            tb_addr.Text = row.C_ADDR;
            tb_birth.Text = row.C_BIRTH; tb_name.Text = row.C_NAME;
            lb_code.Text = row.C_ID.ToString();

            rENTTableAdapter.Fill(dataSet1.RENT);
            DataSet1.RENTDataTable table = rENTTableAdapter.GetDataByCid(row.C_ID);
            rENTBindingSource.DataSource = table;
            resetState(table);
            tb_item.Enabled = tb_model.Enabled = btn_search.Enabled = drbtn_slvs.Enabled = drbtn_vendor.Enabled = true;
        }

        void resetState(DataSet1.RENTDataTable table)
        {
            string ongoingState;
            string overdueState;
            int ongoing = 0;
            int overdue = 0;
            int total = 0;
            ongoingState = "0";
            overdueState = "3";

            foreach (DataSet1.RENTRow data in table.Rows)
            {
                if (data.RNTSTATE_NO == ongoingState)
                {
                    ongoing++;
                }
                else if (data.RNTSTATE_NO == overdueState)
                {
                    overdue++;
                }
            }
            total = table.Rows.Count;

            lb_ongoing.Text = ongoing.ToString();
            lb_overdue.Text = overdue.ToString();
            lb_total.Text = total.ToString();
        }

        private void ActionGoodsSearch(object sender, EventArgs e)
        {
            gOODSTableAdapter.Fill(dataSet1.GOODS);

            if (tb_item.TextLength != 0)
            {
                string name = tb_item.Text.ToLower();
                DataSet1.GOODSDataTable table = gOODSTableAdapter.GetData();
                table.CaseSensitive = false;

                DataRow[] data = table.Select("gds_name like '%" + name + "%'");
                gOODSBindingSource.DataSource = data;
            }
            else if (tb_model.TextLength != 0)
            {
                string model = tb_model.Text.ToLower();
                DataSet1.GOODSDataTable table = gOODSTableAdapter.GetData();
                table.CaseSensitive = false;

                DataRow[] data = table.Select("gds_model like '%" + model + "%'");
                gOODSBindingSource.DataSource = data;
            }
            else if (tb_item.TextLength != 0 && tb_model.TextLength != 0)
            {
                string name = tb_item.Text.ToLower();
                string model = tb_model.Text.ToLower(); DataSet1.GOODSDataTable table = gOODSTableAdapter.GetData();
                table.CaseSensitive = false;

                DataRow[] data = table.Select("gds_name like '%" + name + "%' AND gds_model like '%" + model + "%'");
                gOODSBindingSource.DataSource = data;
            }
            else
            {
                DataSet1.GOODSDataTable table = gOODSTableAdapter.GetData();
                gOODSBindingSource.DataSource = table;
            }
        }
        private void ActionEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ActionGoodsSearch(null, null);
        }

        private void ActionGoodsRent(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataSet1.GOODSRow goodsRow = gOODSBindingSource.Current as DataSet1.GOODSRow;
            if (goodsRow == null)
            {

                DataRowView goodsView = gOODSBindingSource.Current as DataRowView;
                goodsRow = goodsView.Row as DataSet1.GOODSRow;
            }

            DataSet1.CUSTOMERSRow customersRow = cUSTOMERSBindingSource.Current as DataSet1.CUSTOMERSRow;
            if (customersRow == null)
            {
                DataRowView customersView = cUSTOMERSBindingSource.Current as DataRowView;
                customersRow = customersView.Row as DataSet1.CUSTOMERSRow;
            }

            if (MessageBox.Show("대여를 진행합니다.", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new RentForm(goodsRow, customersRow).ShowDialog();
                rENTBindingSource.DataSource = rENTTableAdapter.GetDataByCid(customersRow.C_ID);
                rENTBindingSource.ResetBindings(true);
                resetState(rENTBindingSource.DataSource as DataSet1.RENTDataTable);
            }
        }

        private void ActionRentReturn(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataRowView view = rENTBindingSource.Current as DataRowView;
            DataSet1.RENTRow rentRow = view.Row as DataSet1.RENTRow;

            if (rentRow.RNTSTATE_NO != "1")
            {
                DataRowView customersView = cUSTOMERSBindingSource.Current as DataRowView;
                DataSet1.CUSTOMERSRow customersRow = customersView.Row as DataSet1.CUSTOMERSRow;

                if (MessageBox.Show("반납을 진행합니다.", "알림", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new ReturnForm(rentRow, customersRow).ShowDialog();
                    rENTBindingSource.DataSource = rENTTableAdapter.GetDataByCid(customersRow.C_ID);
                    rENTBindingSource.ResetBindings(true);
                    resetState(rENTBindingSource.DataSource as DataSet1.RENTDataTable);
                }
            }
            else
            {
                MessageBox.Show("반납된 상품입니다.");
            }
        }



        /**************************
         * 
         *       재고현황
         * 
         **************************/

        void setForm2()
        {
            gridView2.DataSource = gOODSTableAdapter.GetData().CopyToDataTable();

            if (gridView2.RowCount > 0)
            {
                for (int i = 0; i < gridView2.Columns.Count; i++)
                {
                    if (gridView2.Columns[i].GetType() == typeof(DataGridViewImageColumn))
                    {
                        (gridView2.Columns[i] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }
            }

            setDropDownRentState2();
            setDropDownVendeor2();
            setDropDownShelves2();
        }

        void setDropDownRentState2()
        {
            DXPopupMenu menu = new DXPopupMenu();
            rentstateTableAdapter1.Fill(dataSet1.RENTSTATE);
            DataSet1.RENTSTATEDataTable rentstateDataTable = rentstateTableAdapter1.GetData();
            menu.Items.Add(new DXMenuItem("대여상태"));
            menu.Items[menu.Items.Count - 1].Click += ActionDropDownRentState2;
            foreach (DataSet1.RENTSTATERow data in rentstateDataTable.Rows)
            {
                menu.Items.Add(new DXMenuItem(data["rntstate_desc"] as string));
                menu.Items[menu.Items.Count - 1].Click += ActionDropDownRentState2;
                if (menu.Items[menu.Items.Count - 1].Caption == "반납")
                {
                    menu.Items.RemoveAt(menu.Items.Count - 1);
                }
            }
            drbtn_rentstate2.DropDownControl = menu;
        }

        void setDropDownVendeor2()
        {
            DXPopupMenu menu = new DXPopupMenu();
            goodstypeTableAdapter2.Fill(dataSet1.GOODSTYPE);
            DataSet1.GOODSTYPEDataTable goodstypeDataTable = goodstypeTableAdapter2.GetData();
            menu.Items.Add(new DXMenuItem("제조사"));
            menu.Items[menu.Items.Count - 1].Click += ActionDropDownVender2;
            foreach (DataSet1.GOODSTYPERow data in goodstypeDataTable.Rows)
            {
                menu.Items.Add(new DXMenuItem(data["gdstype_desc"] as string));
                menu.Items[menu.Items.Count - 1].Click += ActionDropDownVender2;
            }
            drbtn_vendor2.DropDownControl = menu;
        }

        void setDropDownShelves2()
        {
            DXPopupMenu menu = new DXPopupMenu();
            shelvesTableAdapter1.Fill(dataSet1.SHELVES);
            DataSet1.SHELVESDataTable table = shelvesTableAdapter1.GetData();
            menu.Items.Add(new DXMenuItem("위치"));
            menu.Items[menu.Items.Count - 1].Click += ActionDropDownShelves2;
            foreach (DataSet1.SHELVESRow data in table.Rows)
            {
                menu.Items.Add(new DXMenuItem(data["slvs_desc"] as string));
                menu.Items[menu.Items.Count - 1].Click += ActionDropDownShelves2;
            }
            drbtn_slvs2.DropDownControl = menu;
        }

        void ActionDropDownRentState2(Object sender, EventArgs e)
        {
            drbtn_rentstate2.Text = ((DXMenuItem)sender).Caption;
            goodS_WITH_RENTTableAdapter1.Fill(dataSet1.GOODS_WITH_RENT);
            rentstateTableAdapter1.Fill(dataSet1.RENTSTATE);
            if (drbtn_rentstate2.Text == "대여상태")
            {
                gridView2.DataSource = gOODSTableAdapter.GetData().Copy();
                if (gridView2.RowCount > 0)
                {
                    for (int i = 0; i < gridView2.Columns.Count; i++)
                    {
                        if (gridView2.Columns[i].GetType() == typeof(DataGridViewImageColumn))
                        {
                            (gridView2.Columns[i] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }
                    }
                }
            }
            else
            {
                DataSet1.GOODS_WITH_RENTDataTable table =
                    goodS_WITH_RENTTableAdapter1.GetDataByRentState(
                        rentstateTableAdapter1.GetDataByDesc(drbtn_rentstate2.Text)[0]["rntstate_no"].ToString());
                gridView2.DataSource = table;
                if (table.Count > 0)
                {
                    for (int i = 0; i < gridView2.Columns.Count; i++)
                    {
                        if (gridView2.Columns[i].GetType() == typeof(DataGridViewImageColumn))
                        {
                            (gridView2.Columns[i] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }
                    }
                }
            }
            drbtn_vendor2.Text = "제조사";
            drbtn_slvs2.Text = "위치";
            tb_item2.Text = tb_model2.Text = "";}

        void ActionDropDownVender2(Object sender, EventArgs e)
        {
            drbtn_vendor2.Text = ((DXMenuItem)sender).Caption;
            //goodsTableAdapter1.Fill(dataSet1.GOODS);
            goodstypeTableAdapter2.Fill(dataSet1.GOODSTYPE);
            if (drbtn_vendor2.Text == "제조사")
            {
                gridView2.DataSource = gOODSTableAdapter.GetData().Copy();
                if (gridView2.RowCount > 0)
                {
                    for (int i = 0; i < gridView2.Columns.Count; i++)
                    {
                        if (gridView2.Columns[i].GetType() == typeof(DataGridViewImageColumn))
                        {
                            (gridView2.Columns[i] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }
                    }
                }
            }
            else
            {
                DataSet1.GOODSDataTable table = gOODSTableAdapter.GetDataByType(
                        goodstypeTableAdapter2.GetDataByDesc(drbtn_vendor2.Text)[0]["gdstype_no"].ToString());
                gridView2.DataSource = table;
                if (gridView2.RowCount > 0)
                {
                    for (int i = 0; i < gridView2.Columns.Count; i++)
                    {
                        if (gridView2.Columns[i].GetType() == typeof(DataGridViewImageColumn))
                        {
                            (gridView2.Columns[i] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }
                    }
                }
            }
            drbtn_rentstate2.Text = "대여상태";
            drbtn_slvs2.Text = "위치";
            tb_item2.Text = tb_model2.Text = "";
        }

        void ActionDropDownShelves2(Object sender, EventArgs e)
        {
            drbtn_slvs2.Text = ((DXMenuItem)sender).Caption;
           // goodsTableAdapter1.Fill(dataSet1.GOODS);
            shelvesTableAdapter1.Fill(dataSet1.SHELVES);
            if (drbtn_slvs2.Text == "위치")
            {
                gridView2.DataSource = gOODSTableAdapter.GetData().CopyToDataTable();
                if (gridView2.RowCount > 0)
                {
                    for (int i = 0; i < gridView2.Columns.Count; i++)
                    {
                        if (gridView2.Columns[i].GetType() == typeof(DataGridViewImageColumn))
                        {
                            (gridView2.Columns[i] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }
                    }
                }
            }
            else
            {
                DataSet1.GOODSDataTable table = gOODSTableAdapter.GetDataBySlvs(shelvesTableAdapter1.GetDataByDesc(drbtn_slvs2.Text)[0]["slvs_no"].ToString());
                gridView2.DataSource = table;
                if (gridView2.RowCount > 0)
                {
                    for (int i = 0; i < gridView2.Columns.Count; i++)
                    {
                        if (gridView2.Columns[i].GetType() == typeof(DataGridViewImageColumn))
                        {
                            (gridView2.Columns[i] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }
                    }
                }
            }
            drbtn_rentstate2.Text = "대여상태";
            drbtn_vendor2.Text = "제조사";
            tb_item2.Text = tb_model2.Text = "";
        }

        private void ActionButtonSearch(object sender, EventArgs e)
        {
            if (tb_item2.TextLength > 0)
            {
                string name = tb_item2.Text.ToLower();
                DataSet1.GOODSDataTable table = gOODSTableAdapter.GetData().Copy() as DataSet1.GOODSDataTable;
                table.CaseSensitive = false;
                DataRow[] data = table.Select("gds_name like '%" + name + "%'");
                if (data.Length > 0)
                {
                    DataTable newTable = data.CopyToDataTable();
                    gridView2.DataSource = newTable;
                    gridView2.ResetBindings();
                }
                else
                {
                    gridView2.DataSource = null;
                }
            }
            else if (tb_model2.TextLength > 0)
            {
                string model = tb_model2.Text.ToLower();
                DataSet1.GOODSDataTable table = goodsTableAdapter1.GetData().Copy() as DataSet1.GOODSDataTable;
                table.CaseSensitive = false;

                DataRow[] data = table.Select("gds_model like '%" + model + "%'");
                DataTable newTable = data.CopyToDataTable();
                gridView2.DataSource = newTable;
                gridView2.ResetBindings();
            }
            else if (tb_item2.TextLength * tb_model2.TextLength > 0)
            {
                string name = tb_item2.Text.ToLower();
                string model = tb_model2.Text.ToLower();
                DataSet1.GOODSDataTable table = gOODSTableAdapter.GetData().Copy() as DataSet1.GOODSDataTable;
                table.CaseSensitive = false;
                DataRow[] data = table.Select("gds_name like '%" + name + "%' AND gds_model like '%" + model + "%'");
                DataTable newTable = data.CopyToDataTable();
                gridView2.DataSource = newTable;
                gridView2.ResetBindings();
            }
            else
            {
                DataSet1.GOODSDataTable table = gOODSTableAdapter.GetData().Copy() as DataSet1.GOODSDataTable;
                gridView2.DataSource = table;
                if (gridView2.RowCount > 0)
                {
                    for (int i = 0; i < gridView2.Columns.Count; i++)
                    {
                        if (gridView2.Columns[i].GetType() == typeof(DataGridViewImageColumn))
                        {
                            (gridView2.Columns[i] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        }}
                }
                gridView2.ResetBindings();
            }

            drbtn_rentstate2.Text = "대여상태";
            drbtn_vendor2.Text = "제조사";
            drbtn_slvs2.Text = "위치";
        
        }
    }
}
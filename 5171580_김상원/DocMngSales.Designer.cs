namespace _5171580_김상원
{
    partial class DocMngSales
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileNavCategory3 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.tileNavItem1 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavItem2 = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tileNavCategory4 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.dataSet1 = new _5171580_김상원.DataSet1();
            this.rENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rENTTableAdapter = new _5171580_김상원.DataSet1TableAdapters.RENTTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPane1.Buttons.Add(this.navButton2);
            this.tileNavPane1.Categories.AddRange(new DevExpress.XtraBars.Navigation.TileNavCategory[] {
            this.tileNavCategory3,
            this.tileNavCategory4});
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Size = new System.Drawing.Size(670, 40);
            this.tileNavPane1.TabIndex = 0;
            this.tileNavPane1.Text = "tileNavPane1";
            this.tileNavPane1.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.ActionMenuItem);
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Main Menu";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            // 
            // tileNavCategory3
            // 
            this.tileNavCategory3.Caption = "대여 현황";
            this.tileNavCategory3.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.tileNavItem1,
            this.tileNavItem2});
            this.tileNavCategory3.Name = "tileNavCategory3";
            this.tileNavCategory3.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavCategory3.OwnerCollection = this.tileNavPane1.Categories;
            this.tileNavCategory3.Tag = "대여 현황";
            // 
            // 
            // 
            this.tileNavCategory3.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "대여 현황";
            this.tileNavCategory3.Tile.Elements.Add(tileItemElement3);
            this.tileNavCategory3.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavCategory3.Tile.Name = "tileBarItem2";
            // 
            // tileNavItem1
            // 
            this.tileNavItem1.Caption = "주차별 현황";
            this.tileNavItem1.Name = "tileNavItem1";
            this.tileNavItem1.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem1.OwnerCollection = this.tileNavCategory3.Items;
            this.tileNavItem1.Tag = "주차별 현황";
            // 
            // 
            // 
            this.tileNavItem1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Text = "주차별 현황";
            this.tileNavItem1.Tile.Elements.Add(tileItemElement1);
            this.tileNavItem1.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem1.Tile.Name = "tileBarItem1";
            // 
            // tileNavItem2
            // 
            this.tileNavItem2.Caption = "전체 현황";
            this.tileNavItem2.Name = "tileNavItem2";
            this.tileNavItem2.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavItem2.OwnerCollection = this.tileNavCategory3.Items;
            this.tileNavItem2.Tag = "전체 현황";
            // 
            // 
            // 
            this.tileNavItem2.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Text = "전체 현황";
            this.tileNavItem2.Tile.Elements.Add(tileItemElement2);
            this.tileNavItem2.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavItem2.Tile.Name = "tileBarItem4";
            // 
            // tileNavCategory4
            // 
            this.tileNavCategory4.Caption = "매출 현황";
            this.tileNavCategory4.Name = "tileNavCategory4";
            this.tileNavCategory4.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavCategory4.OwnerCollection = this.tileNavPane1.Categories;
            this.tileNavCategory4.Tag = "매출 현황";
            // 
            // 
            // 
            this.tileNavCategory4.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "매출 현황";
            this.tileNavCategory4.Tile.Elements.Add(tileItemElement4);
            this.tileNavCategory4.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavCategory4.Tile.Name = "tileBarItem3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartControl1);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 570);
            this.panel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(3, 271);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(644, 281);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.rENTTableAdapter;
            this.chartControl1.DataSource = this.rENTBindingSource;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(3, 6);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(644, 259);
            this.chartControl1.TabIndex = 1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rENTBindingSource
            // 
            this.rENTBindingSource.DataMember = "RENT";
            this.rENTBindingSource.DataSource = this.dataSet1;
            // 
            // rENTTableAdapter
            // 
            this.rENTTableAdapter.ClearBeforeFill = true;
            // 
            // DocMngSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "DocMngSales";
            this.Size = new System.Drawing.Size(670, 610);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem1;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory4;
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory3;
        private DevExpress.XtraBars.Navigation.TileNavItem tileNavItem2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DataSet1TableAdapters.RENTTableAdapter rENTTableAdapter;
        private System.Windows.Forms.BindingSource rENTBindingSource;
        private DataSet1 dataSet1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

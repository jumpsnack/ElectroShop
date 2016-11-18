namespace _5171580_김상원
{
    partial class DocMngRent
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new _5171580_김상원.DataSet1();
            this.gOODSGRADETableAdapter = new _5171580_김상원.DataSet1TableAdapters.GOODSGRADETableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGDSGRADE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDSGRADE_PERIOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cols_GDSGRADE_PRICERATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDSGRADE_PENALTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.gOODSGRADEBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSGRADEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "등급별 설정";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gOODSGRADETableAdapter
            // 
            this.gOODSGRADETableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.gOODSGRADEBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(372, 177);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGDSGRADE_DESC,
            this.colGDSGRADE_PERIOD,
            this.cols_GDSGRADE_PRICERATE,
            this.colGDSGRADE_PENALTY});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGDSGRADE_DESC, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGDSGRADE_PENALTY, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colGDSGRADE_DESC
            // 
            this.colGDSGRADE_DESC.Caption = " ";
            this.colGDSGRADE_DESC.FieldName = "GDSGRADE_DESC";
            this.colGDSGRADE_DESC.Name = "colGDSGRADE_DESC";
            this.colGDSGRADE_DESC.Visible = true;
            this.colGDSGRADE_DESC.VisibleIndex = 1;
            // 
            // colGDSGRADE_PERIOD
            // 
            this.colGDSGRADE_PERIOD.Caption = "대여기간(일)";
            this.colGDSGRADE_PERIOD.FieldName = "GDSGRADE_PERIOD";
            this.colGDSGRADE_PERIOD.Name = "colGDSGRADE_PERIOD";
            this.colGDSGRADE_PERIOD.Visible = true;
            this.colGDSGRADE_PERIOD.VisibleIndex = 0;
            // 
            // cols_GDSGRADE_PRICERATE
            // 
            this.cols_GDSGRADE_PRICERATE.Caption = "일별 이용료 부과율";
            this.cols_GDSGRADE_PRICERATE.FieldName = "GDSGRADE_PRICERATE";
            this.cols_GDSGRADE_PRICERATE.Name = "cols_GDSGRADE_PRICERATE";
            this.cols_GDSGRADE_PRICERATE.Visible = true;
            this.cols_GDSGRADE_PRICERATE.VisibleIndex = 1;
            // 
            // colGDSGRADE_PENALTY
            // 
            this.colGDSGRADE_PENALTY.Caption = "벌금 부과율";
            this.colGDSGRADE_PENALTY.FieldName = "GDSGRADE_PENALTY";
            this.colGDSGRADE_PENALTY.Name = "colGDSGRADE_PENALTY";
            this.colGDSGRADE_PENALTY.Visible = true;
            this.colGDSGRADE_PENALTY.VisibleIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(378, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "동기화";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ActionButtonSync);
            // 
            // gOODSGRADEBindingSource
            // 
            this.gOODSGRADEBindingSource.DataMember = "GOODSGRADE";
            this.gOODSGRADEBindingSource.DataSource = this.dataSet1;
            // 
            // DocMngRent
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Name = "DocMngRent";
            this.Size = new System.Drawing.Size(670, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSGRADEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.GOODSGRADETableAdapter gOODSGRADETableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGDSGRADE_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colGDSGRADE_PERIOD;
        private DevExpress.XtraGrid.Columns.GridColumn colGDSGRADE_PENALTY;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.Columns.GridColumn cols_GDSGRADE_PRICERATE;
        private System.Windows.Forms.BindingSource gOODSGRADEBindingSource;
    }
}

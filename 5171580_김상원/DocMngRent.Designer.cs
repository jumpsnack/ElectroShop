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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.gOODSGRADEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new _5171580_김상원.DataSet1();
            this.gOODSGRADETableAdapter = new _5171580_김상원.DataSet1TableAdapters.GOODSGRADETableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGDSGRADE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDSGRADE_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDSGRADE_PERIOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDSGRADE_PENALTY = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSGRADEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            // gOODSGRADEBindingSource
            // 
            this.gOODSGRADEBindingSource.DataMember = "GOODSGRADE";
            this.gOODSGRADEBindingSource.DataSource = this.dataSet1;
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
            this.gridControl1.Location = new System.Drawing.Point(3, 70);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(640, 118);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGDSGRADE_NO,
            this.colGDSGRADE_DESC,
            this.colGDSGRADE_PERIOD,
            this.colGDSGRADE_PENALTY});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colGDSGRADE_DESC, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colGDSGRADE_NO
            // 
            this.colGDSGRADE_NO.FieldName = "GDSGRADE_NO";
            this.colGDSGRADE_NO.Name = "colGDSGRADE_NO";
            this.colGDSGRADE_NO.Visible = true;
            this.colGDSGRADE_NO.VisibleIndex = 0;
            // 
            // colGDSGRADE_DESC
            // 
            this.colGDSGRADE_DESC.FieldName = "GDSGRADE_DESC";
            this.colGDSGRADE_DESC.Name = "colGDSGRADE_DESC";
            this.colGDSGRADE_DESC.Visible = true;
            this.colGDSGRADE_DESC.VisibleIndex = 1;
            // 
            // colGDSGRADE_PERIOD
            // 
            this.colGDSGRADE_PERIOD.FieldName = "GDSGRADE_PERIOD";
            this.colGDSGRADE_PERIOD.Name = "colGDSGRADE_PERIOD";
            this.colGDSGRADE_PERIOD.Visible = true;
            this.colGDSGRADE_PERIOD.VisibleIndex = 1;
            // 
            // colGDSGRADE_PENALTY
            // 
            this.colGDSGRADE_PENALTY.FieldName = "GDSGRADE_PENALTY";
            this.colGDSGRADE_PENALTY.Name = "colGDSGRADE_PENALTY";
            this.colGDSGRADE_PENALTY.Visible = true;
            this.colGDSGRADE_PENALTY.VisibleIndex = 2;
            // 
            // DocMngRent
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label1);
            this.Name = "DocMngRent";
            this.Size = new System.Drawing.Size(670, 610);
            ((System.ComponentModel.ISupportInitialize)(this.gOODSGRADEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource gOODSGRADEBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.GOODSGRADETableAdapter gOODSGRADETableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGDSGRADE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colGDSGRADE_DESC;
        private DevExpress.XtraGrid.Columns.GridColumn colGDSGRADE_PERIOD;
        private DevExpress.XtraGrid.Columns.GridColumn colGDSGRADE_PENALTY;
    }
}

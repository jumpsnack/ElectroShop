namespace _5171580_김상원
{
    partial class DocMngGoods
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        ///
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.itemLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.itemGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.dataSet1 = new _5171580_김상원.DataSet1();
            this.gOODSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gOODSTableAdapter = new _5171580_김상원.DataSet1TableAdapters.GOODSTableAdapter();
            this.colGDS_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDS_IMG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDS_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDS_QTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLVS_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDSTYPE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDSGRADE_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGDSUNIT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.labelControl);
            this.layoutControl.Controls.Add(this.gridControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(714, 316, 250, 350);
            this.layoutControl.Root = this.layoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(670, 545);
            this.layoutControl.TabIndex = 1;
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.LineVisible = true;
            this.labelControl.Location = new System.Drawing.Point(40, 0);
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(0, 3, 15, 6);
            this.labelControl.Size = new System.Drawing.Size(590, 34);
            this.labelControl.StyleController = this.layoutControl;
            this.labelControl.TabIndex = 4;
            this.labelControl.Text = "용품 리스트";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.gOODSBindingSource;
            this.gridControl.Location = new System.Drawing.Point(40, 34);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(590, 511);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGDS_ID,
            this.colGDS_IMG,
            this.colGDS_NAME,
            this.colGDS_QTY,
            this.colSLVS_NO,
            this.colGDSTYPE_NO,
            this.colGDSGRADE_NO,
            this.colGDSUNIT_ID});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView.OptionsMenu.EnableColumnMenu = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.itemLabel,
            this.itemGrid});
            this.layoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup.Name = "Root";
            this.layoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0);
            this.layoutControlGroup.Size = new System.Drawing.Size(670, 545);
            this.layoutControlGroup.TextVisible = false;
            // 
            // itemLabel
            // 
            this.itemLabel.Control = this.labelControl;
            this.itemLabel.Location = new System.Drawing.Point(0, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemLabel.Size = new System.Drawing.Size(590, 34);
            this.itemLabel.TextSize = new System.Drawing.Size(0, 0);
            this.itemLabel.TextVisible = false;
            // 
            // itemGrid
            // 
            this.itemGrid.Control = this.gridControl;
            this.itemGrid.Location = new System.Drawing.Point(0, 34);
            this.itemGrid.Name = "itemGrid";
            this.itemGrid.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.itemGrid.Size = new System.Drawing.Size(590, 511);
            this.itemGrid.TextSize = new System.Drawing.Size(0, 0);
            this.itemGrid.TextVisible = false;
            // 
            // windowsUIButtonPanel
            // 
            this.windowsUIButtonPanel.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("구매", null, "New;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("수정", null, "Edit;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("폐기", null, "Edit/Delete;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("새로고침", null, "Refresh;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("프린트", null, "Preview;Size32x32;GrayScaled")});
            this.windowsUIButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanel.EnableImageTransparency = true;
            this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 545);
            this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.windowsUIButtonPanel.MaximumSize = new System.Drawing.Size(0, 65);
            this.windowsUIButtonPanel.MinimumSize = new System.Drawing.Size(70, 65);
            this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(670, 65);
            this.windowsUIButtonPanel.TabIndex = 5;
            this.windowsUIButtonPanel.Text = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.UseButtonBackgroundImages = false;
            this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel_ButtonClick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gOODSBindingSource
            // 
            this.gOODSBindingSource.DataMember = "GOODS";
            this.gOODSBindingSource.DataSource = this.dataSet1;
            // 
            // gOODSTableAdapter
            // 
            this.gOODSTableAdapter.ClearBeforeFill = true;
            // 
            // colGDS_ID
            // 
            this.colGDS_ID.FieldName = "GDS_ID";
            this.colGDS_ID.Name = "colGDS_ID";
            this.colGDS_ID.Visible = true;
            this.colGDS_ID.VisibleIndex = 0;
            // 
            // colGDS_IMG
            // 
            this.colGDS_IMG.FieldName = "GDS_IMG";
            this.colGDS_IMG.Name = "colGDS_IMG";
            this.colGDS_IMG.Visible = true;
            this.colGDS_IMG.VisibleIndex = 1;
            // 
            // colGDS_NAME
            // 
            this.colGDS_NAME.FieldName = "GDS_NAME";
            this.colGDS_NAME.Name = "colGDS_NAME";
            this.colGDS_NAME.Visible = true;
            this.colGDS_NAME.VisibleIndex = 2;
            // 
            // colGDS_QTY
            // 
            this.colGDS_QTY.FieldName = "GDS_QTY";
            this.colGDS_QTY.Name = "colGDS_QTY";
            this.colGDS_QTY.Visible = true;
            this.colGDS_QTY.VisibleIndex = 3;
            // 
            // colSLVS_NO
            // 
            this.colSLVS_NO.FieldName = "SLVS_NO";
            this.colSLVS_NO.Name = "colSLVS_NO";
            this.colSLVS_NO.Visible = true;
            this.colSLVS_NO.VisibleIndex = 4;
            // 
            // colGDSTYPE_NO
            // 
            this.colGDSTYPE_NO.FieldName = "GDSTYPE_NO";
            this.colGDSTYPE_NO.Name = "colGDSTYPE_NO";
            this.colGDSTYPE_NO.Visible = true;
            this.colGDSTYPE_NO.VisibleIndex = 5;
            // 
            // colGDSGRADE_NO
            // 
            this.colGDSGRADE_NO.FieldName = "GDSGRADE_NO";
            this.colGDSGRADE_NO.Name = "colGDSGRADE_NO";
            this.colGDSGRADE_NO.Visible = true;
            this.colGDSGRADE_NO.VisibleIndex = 6;
            // 
            // colGDSUNIT_ID
            // 
            this.colGDSUNIT_ID.FieldName = "GDSUNIT_ID";
            this.colGDSUNIT_ID.Name = "colGDSUNIT_ID";
            this.colGDSUNIT_ID.Visible = true;
            this.colGDSUNIT_ID.VisibleIndex = 7;
            // 
            // DocMngGoods
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.windowsUIButtonPanel);
            this.Name = "DocMngGoods";
            this.Size = new System.Drawing.Size(670, 610);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraLayout.LayoutControlItem itemLabel;
        private DevExpress.XtraLayout.LayoutControlItem itemGrid;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
        private System.Windows.Forms.BindingSource gOODSBindingSource;
        private DataSet1 dataSet1;
        private DevExpress.XtraGrid.Columns.GridColumn colGDS_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colGDS_IMG;
        private DevExpress.XtraGrid.Columns.GridColumn colGDS_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colGDS_QTY;
        private DevExpress.XtraGrid.Columns.GridColumn colSLVS_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colGDSTYPE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colGDSGRADE_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colGDSUNIT_ID;
        private DataSet1TableAdapters.GOODSTableAdapter gOODSTableAdapter;
    }
}

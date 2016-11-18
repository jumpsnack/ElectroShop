namespace _5171580_김상원
{
    partial class BuyingForm
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.drbtn_unit = new DevExpress.XtraEditors.DropDownButton();
            this.drbtn_slvs = new DevExpress.XtraEditors.DropDownButton();
            this.drbtn_vendor = new DevExpress.XtraEditors.DropDownButton();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.lb_add = new System.Windows.Forms.Label();
            this.lb_init = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.drbtn_grade = new DevExpress.XtraEditors.DropDownButton();
            this.label8 = new System.Windows.Forms.Label();
            this.drbtn_store = new DevExpress.XtraEditors.DropDownButton();
            this.goodsunitTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSUNITTableAdapter();
            this.shelvesTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.SHELVESTableAdapter();
            this.goodstypeTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSTYPETableAdapter();
            this.goodsgradeTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSGRADETableAdapter();
            this.dataSet1 = new _5171580_김상원.DataSet1();
            this.gOODSUNITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsstoreTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSSTORETableAdapter();
            this.goodsTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSTableAdapter();
            this.buyinggoodsTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.BUYINGGOODSTableAdapter();
            this.oracleConnection1 = new System.Data.OracleClient.OracleConnection();
            this.oracleCommand1 = new System.Data.OracleClient.OracleCommand();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSUNITBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_img
            // 
            this.pb_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_img.InitialImage = null;
            this.pb_img.Location = new System.Drawing.Point(22, 23);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(200, 180);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_img.TabIndex = 0;
            this.pb_img.TabStop = false;
            // 
            // btn_upload
            // 
            this.btn_upload.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(22, 209);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(200, 37);
            this.btn_upload.TabIndex = 1;
            this.btn_upload.Text = "이미지 업로드";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.ActionImageUpload);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "상품명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "수   량";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "위   치";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(247, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "제조사";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "상   태";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "출고가";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(323, 23);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(415, 33);
            this.tb_name.TabIndex = 3;
            // 
            // tb_qty
            // 
            this.tb_qty.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qty.Location = new System.Drawing.Point(323, 192);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(155, 33);
            this.tb_qty.TabIndex = 3;
            // 
            // drbtn_unit
            // 
            this.drbtn_unit.Appearance.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drbtn_unit.Appearance.Options.UseFont = true;
            this.drbtn_unit.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.drbtn_unit.Location = new System.Drawing.Point(502, 192);
            this.drbtn_unit.Name = "drbtn_unit";
            this.drbtn_unit.Size = new System.Drawing.Size(88, 33);
            this.drbtn_unit.TabIndex = 4;
            this.drbtn_unit.Text = "단위";
            // 
            // drbtn_slvs
            // 
            this.drbtn_slvs.Appearance.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drbtn_slvs.Appearance.Options.UseFont = true;
            this.drbtn_slvs.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.drbtn_slvs.Location = new System.Drawing.Point(323, 137);
            this.drbtn_slvs.Name = "drbtn_slvs";
            this.drbtn_slvs.Size = new System.Drawing.Size(155, 33);
            this.drbtn_slvs.TabIndex = 4;
            // 
            // drbtn_vendor
            // 
            this.drbtn_vendor.Appearance.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drbtn_vendor.Appearance.Options.UseFont = true;
            this.drbtn_vendor.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.drbtn_vendor.Location = new System.Drawing.Point(323, 82);
            this.drbtn_vendor.Name = "drbtn_vendor";
            this.drbtn_vendor.Size = new System.Drawing.Size(155, 33);
            this.drbtn_vendor.TabIndex = 4;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(323, 308);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(155, 33);
            this.tb_price.TabIndex = 3;
            // 
            // lb_add
            // 
            this.lb_add.AutoSize = true;
            this.lb_add.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_add.Location = new System.Drawing.Point(656, 401);
            this.lb_add.Name = "lb_add";
            this.lb_add.Size = new System.Drawing.Size(61, 29);
            this.lb_add.TabIndex = 2;
            this.lb_add.Text = "등  록";
            this.lb_add.Click += new System.EventHandler(this.ActionLabel);
            // 
            // lb_init
            // 
            this.lb_init.AutoSize = true;
            this.lb_init.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_init.Location = new System.Drawing.Point(506, 401);
            this.lb_init.Name = "lb_init";
            this.lb_init.Size = new System.Drawing.Size(70, 29);
            this.lb_init.TabIndex = 2;
            this.lb_init.Text = "초기화";
            this.lb_init.Click += new System.EventHandler(this.ActionLabel);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "PNG|*.png|비트맵|*.bmp|JPEG|*.jpg";
            // 
            // drbtn_grade
            // 
            this.drbtn_grade.Appearance.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drbtn_grade.Appearance.Options.UseFont = true;
            this.drbtn_grade.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.drbtn_grade.Location = new System.Drawing.Point(323, 248);
            this.drbtn_grade.Name = "drbtn_grade";
            this.drbtn_grade.Size = new System.Drawing.Size(155, 33);
            this.drbtn_grade.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(497, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "거래처";
            // 
            // drbtn_store
            // 
            this.drbtn_store.Appearance.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drbtn_store.Appearance.Options.UseFont = true;
            this.drbtn_store.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Show;
            this.drbtn_store.Location = new System.Drawing.Point(569, 306);
            this.drbtn_store.Name = "drbtn_store";
            this.drbtn_store.Size = new System.Drawing.Size(169, 33);
            this.drbtn_store.TabIndex = 4;
            // 
            // goodsunitTableAdapter1
            // 
            this.goodsunitTableAdapter1.ClearBeforeFill = true;
            // 
            // shelvesTableAdapter1
            // 
            this.shelvesTableAdapter1.ClearBeforeFill = true;
            // 
            // goodstypeTableAdapter1
            // 
            this.goodstypeTableAdapter1.ClearBeforeFill = true;
            // 
            // goodsgradeTableAdapter1
            // 
            this.goodsgradeTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gOODSUNITBindingSource
            // 
            this.gOODSUNITBindingSource.DataMember = "GOODSUNIT";
            this.gOODSUNITBindingSource.DataSource = this.dataSet1;
            // 
            // goodsstoreTableAdapter1
            // 
            this.goodsstoreTableAdapter1.ClearBeforeFill = true;
            // 
            // goodsTableAdapter1
            // 
            this.goodsTableAdapter1.ClearBeforeFill = true;
            // 
            // buyinggoodsTableAdapter1
            // 
            this.buyinggoodsTableAdapter1.ClearBeforeFill = true;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=MyORCL;PERSIST SECURITY INFO=True;USER ID=B5171580;password=B5171580";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(497, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "모델명";
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_model.Location = new System.Drawing.Point(569, 80);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(169, 33);
            this.tb_model.TabIndex = 3;
            // 
            // BuyingForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.drbtn_store);
            this.Controls.Add(this.drbtn_grade);
            this.Controls.Add(this.drbtn_vendor);
            this.Controls.Add(this.drbtn_slvs);
            this.Controls.Add(this.drbtn_unit);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.tb_qty);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lb_init);
            this.Controls.Add(this.lb_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pb_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuyingForm";
            this.Text = "BuyingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gOODSUNITBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_qty;
        private DevExpress.XtraEditors.DropDownButton drbtn_unit;
        private DevExpress.XtraEditors.DropDownButton drbtn_slvs;
        private DevExpress.XtraEditors.DropDownButton drbtn_vendor;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label lb_add;
        private System.Windows.Forms.Label lb_init;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DataSet1TableAdapters.GOODSUNITTableAdapter goodsunitTableAdapter1;
        private DataSet1TableAdapters.SHELVESTableAdapter shelvesTableAdapter1;
        private DataSet1TableAdapters.GOODSTYPETableAdapter goodstypeTableAdapter1;
        private DataSet1TableAdapters.GOODSGRADETableAdapter goodsgradeTableAdapter1;
        private System.Windows.Forms.BindingSource gOODSUNITBindingSource;
        private DataSet1 dataSet1;
        private DevExpress.XtraEditors.DropDownButton drbtn_grade;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.DropDownButton drbtn_store;
        private DataSet1TableAdapters.GOODSSTORETableAdapter goodsstoreTableAdapter1;
        private DataSet1TableAdapters.GOODSTableAdapter goodsTableAdapter1;
        private DataSet1TableAdapters.BUYINGGOODSTableAdapter buyinggoodsTableAdapter1;
        private System.Data.OracleClient.OracleConnection oracleConnection1;
        private System.Data.OracleClient.OracleCommand oracleCommand1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_model;
    }
}
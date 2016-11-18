namespace _5171580_김상원
{
    partial class MakeReservationsForm
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
            this.oracleCommand1 = new System.Data.OracleClient.OracleCommand();
            this.oracleConnection1 = new System.Data.OracleClient.OracleConnection();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tb_item = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_vendor = new System.Windows.Forms.TextBox();
            this.pb_item = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_serial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.tb_unit = new System.Windows.Forms.TextBox();
            this.btn_book = new System.Windows.Forms.Button();
            this.reservationsTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.RESERVATIONSTableAdapter();
            this.customersTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.CUSTOMERSTableAdapter();
            this.dataSet11 = new _5171580_김상원.DataSet1();
            this.goodsunitTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSUNITTableAdapter();
            this.goodsTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSTableAdapter();
            this.rentTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.RENTTableAdapter();
            this.goodstypeTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSTYPETableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=MyORCL;PERSIST SECURITY INFO=True;USER ID=B5171580;password=B5171580";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "상품명";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tb_item
            // 
            this.tb_item.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item.Location = new System.Drawing.Point(80, 114);
            this.tb_item.Name = "tb_item";
            this.tb_item.ReadOnly = true;
            this.tb_item.Size = new System.Drawing.Size(335, 30);
            this.tb_item.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "제조사";
            // 
            // tb_vendor
            // 
            this.tb_vendor.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vendor.Location = new System.Drawing.Point(80, 150);
            this.tb_vendor.Name = "tb_vendor";
            this.tb_vendor.ReadOnly = true;
            this.tb_vendor.Size = new System.Drawing.Size(186, 30);
            this.tb_vendor.TabIndex = 3;
            // 
            // pb_item
            // 
            this.pb_item.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_item.Location = new System.Drawing.Point(272, 150);
            this.pb_item.Name = "pb_item";
            this.pb_item.Size = new System.Drawing.Size(143, 138);
            this.pb_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_item.TabIndex = 4;
            this.pb_item.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "모델명";
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_model.Location = new System.Drawing.Point(80, 186);
            this.tb_model.Name = "tb_model";
            this.tb_model.ReadOnly = true;
            this.tb_model.Size = new System.Drawing.Size(186, 30);
            this.tb_model.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "S/N";
            // 
            // tb_serial
            // 
            this.tb_serial.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_serial.Location = new System.Drawing.Point(80, 222);
            this.tb_serial.Name = "tb_serial";
            this.tb_serial.ReadOnly = true;
            this.tb_serial.Size = new System.Drawing.Size(186, 30);
            this.tb_serial.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "예약수량";
            // 
            // tb_qty
            // 
            this.tb_qty.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qty.Location = new System.Drawing.Point(80, 258);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(106, 30);
            this.tb_qty.TabIndex = 3;
            // 
            // tb_unit
            // 
            this.tb_unit.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unit.Location = new System.Drawing.Point(192, 258);
            this.tb_unit.Name = "tb_unit";
            this.tb_unit.ReadOnly = true;
            this.tb_unit.Size = new System.Drawing.Size(74, 30);
            this.tb_unit.TabIndex = 3;
            // 
            // btn_book
            // 
            this.btn_book.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.Location = new System.Drawing.Point(311, 304);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(104, 35);
            this.btn_book.TabIndex = 5;
            this.btn_book.Text = "예약";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.ActionBook);
            // 
            // reservationsTableAdapter1
            // 
            this.reservationsTableAdapter1.ClearBeforeFill = true;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsunitTableAdapter1
            // 
            this.goodsunitTableAdapter1.ClearBeforeFill = true;
            // 
            // goodsTableAdapter1
            // 
            this.goodsTableAdapter1.ClearBeforeFill = true;
            // 
            // rentTableAdapter1
            // 
            this.rentTableAdapter1.ClearBeforeFill = true;
            // 
            // goodstypeTableAdapter1
            // 
            this.goodstypeTableAdapter1.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "email";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(80, 57);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(335, 30);
            this.tb_email.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "이  름";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(80, 21);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(111, 30);
            this.tb_name.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(198, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "연락처";
            // 
            // tb_tel
            // 
            this.tb_tel.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tel.Location = new System.Drawing.Point(265, 21);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.ReadOnly = true;
            this.tb_tel.Size = new System.Drawing.Size(150, 30);
            this.tb_tel.TabIndex = 3;
            // 
            // MakeReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 353);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.pb_item);
            this.Controls.Add(this.tb_unit);
            this.Controls.Add(this.tb_qty);
            this.Controls.Add(this.tb_serial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_vendor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_item);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MakeReservationsForm";
            this.Text = "MakeReservations";
            ((System.ComponentModel.ISupportInitialize)(this.pb_item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OracleClient.OracleCommand oracleCommand1;
        private System.Data.OracleClient.OracleConnection oracleConnection1;
        private DataSet1TableAdapters.RESERVATIONSTableAdapter reservationsTableAdapter1;
        private DataSet1TableAdapters.CUSTOMERSTableAdapter customersTableAdapter1;
        private DataSet1 dataSet11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_vendor;
        private System.Windows.Forms.PictureBox pb_item;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_serial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.TextBox tb_unit;
        private System.Windows.Forms.Button btn_book;
        private DataSet1TableAdapters.GOODSUNITTableAdapter goodsunitTableAdapter1;
        private DataSet1TableAdapters.GOODSTableAdapter goodsTableAdapter1;
        private DataSet1TableAdapters.RENTTableAdapter rentTableAdapter1;
        private DataSet1TableAdapters.GOODSTYPETableAdapter goodstypeTableAdapter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_tel;
    }
}
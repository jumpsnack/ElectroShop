namespace _5171580_김상원
{
    partial class ReturnForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_vender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_rentqty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_unit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_returnqty = new System.Windows.Forms.TextBox();
            this.dtbtn_grade = new DevExpress.XtraEditors.DropDownButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_serial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.btn_return = new System.Windows.Forms.Button();
            this.goodsgradeTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSGRADETableAdapter();
            this.dataSet11 = new _5171580_김상원.DataSet1();
            this.goodsTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSTableAdapter();
            this.goodstypeTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSTYPETableAdapter();
            this.goodsunitTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSUNITTableAdapter();
            this.rentstateTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.RENTSTATETableAdapter();
            this.rentTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.RENTTableAdapter();
            this.oracleConnection1 = new System.Data.OracleClient.OracleConnection();
            this.oracleCommand1 = new System.Data.OracleClient.OracleCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "반납 정보";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(92, 32);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(114, 30);
            this.tb_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "고객명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "상품명";
            // 
            // tb_item
            // 
            this.tb_item.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item.Location = new System.Drawing.Point(92, 68);
            this.tb_item.Name = "tb_item";
            this.tb_item.ReadOnly = true;
            this.tb_item.Size = new System.Drawing.Size(325, 30);
            this.tb_item.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "제조사";
            // 
            // tb_vender
            // 
            this.tb_vender.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vender.Location = new System.Drawing.Point(92, 104);
            this.tb_vender.Name = "tb_vender";
            this.tb_vender.ReadOnly = true;
            this.tb_vender.Size = new System.Drawing.Size(114, 30);
            this.tb_vender.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "모델명";
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_model.Location = new System.Drawing.Point(303, 104);
            this.tb_model.Name = "tb_model";
            this.tb_model.ReadOnly = true;
            this.tb_model.Size = new System.Drawing.Size(114, 30);
            this.tb_model.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "대여수량";
            // 
            // tb_rentqty
            // 
            this.tb_rentqty.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_rentqty.Location = new System.Drawing.Point(92, 176);
            this.tb_rentqty.Name = "tb_rentqty";
            this.tb_rentqty.ReadOnly = true;
            this.tb_rentqty.Size = new System.Drawing.Size(114, 30);
            this.tb_rentqty.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "단  위";
            // 
            // tb_unit
            // 
            this.tb_unit.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unit.Location = new System.Drawing.Point(303, 176);
            this.tb_unit.Name = "tb_unit";
            this.tb_unit.ReadOnly = true;
            this.tb_unit.Size = new System.Drawing.Size(114, 30);
            this.tb_unit.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "반냡수량";
            // 
            // tb_returnqty
            // 
            this.tb_returnqty.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_returnqty.Location = new System.Drawing.Point(92, 212);
            this.tb_returnqty.Name = "tb_returnqty";
            this.tb_returnqty.Size = new System.Drawing.Size(114, 30);
            this.tb_returnqty.TabIndex = 1;
            // 
            // dtbtn_grade
            // 
            this.dtbtn_grade.Appearance.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbtn_grade.Appearance.Options.UseFont = true;
            this.dtbtn_grade.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dtbtn_grade.Location = new System.Drawing.Point(303, 140);
            this.dtbtn_grade.Name = "dtbtn_grade";
            this.dtbtn_grade.Size = new System.Drawing.Size(114, 30);
            this.dtbtn_grade.TabIndex = 2;
            this.dtbtn_grade.Text = "상태";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "상  태";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "S/N";
            // 
            // tb_serial
            // 
            this.tb_serial.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_serial.Location = new System.Drawing.Point(92, 138);
            this.tb_serial.Name = "tb_serial";
            this.tb_serial.ReadOnly = true;
            this.tb_serial.Size = new System.Drawing.Size(114, 30);
            this.tb_serial.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(31, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "대여일";
            // 
            // dt_start
            // 
            this.dt_start.CalendarFont = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start.Enabled = false;
            this.dt_start.Location = new System.Drawing.Point(92, 265);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(172, 21);
            this.dt_start.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "반납일";
            // 
            // dt_end
            // 
            this.dt_end.CalendarFont = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end.Location = new System.Drawing.Point(92, 292);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(172, 21);
            this.dt_end.TabIndex = 3;
            // 
            // btn_return
            // 
            this.btn_return.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(303, 265);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(114, 48);
            this.btn_return.TabIndex = 4;
            this.btn_return.Text = "반  납";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.ActionReturn);
            // 
            // goodsgradeTableAdapter1
            // 
            this.goodsgradeTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsTableAdapter1
            // 
            this.goodsTableAdapter1.ClearBeforeFill = true;
            // 
            // goodstypeTableAdapter1
            // 
            this.goodstypeTableAdapter1.ClearBeforeFill = true;
            // 
            // goodsunitTableAdapter1
            // 
            this.goodsunitTableAdapter1.ClearBeforeFill = true;
            // 
            // rentstateTableAdapter1
            // 
            this.rentstateTableAdapter1.ClearBeforeFill = true;
            // 
            // rentTableAdapter1
            // 
            this.rentTableAdapter1.ClearBeforeFill = true;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=MyORCL;PERSIST SECURITY INFO=True;USER ID=B5171580;password=B5171580";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(435, 326);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.dtbtn_grade);
            this.Controls.Add(this.tb_unit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.tb_returnqty);
            this.Controls.Add(this.tb_serial);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_rentqty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_vender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_item);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReturnForm";
            this.Text = "ReturnForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_vender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_rentqty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_unit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_returnqty;
        private DevExpress.XtraEditors.DropDownButton dtbtn_grade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_serial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.Button btn_return;
        private DataSet1TableAdapters.GOODSGRADETableAdapter goodsgradeTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.GOODSTableAdapter goodsTableAdapter1;
        private DataSet1TableAdapters.GOODSTYPETableAdapter goodstypeTableAdapter1;
        private DataSet1TableAdapters.GOODSUNITTableAdapter goodsunitTableAdapter1;
        private DataSet1TableAdapters.RENTSTATETableAdapter rentstateTableAdapter1;
        private DataSet1TableAdapters.RENTTableAdapter rentTableAdapter1;
        private System.Data.OracleClient.OracleConnection oracleConnection1;
        private System.Data.OracleClient.OracleCommand oracleCommand1;
    }
}
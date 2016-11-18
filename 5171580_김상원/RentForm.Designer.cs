namespace _5171580_김상원
{
    partial class RentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_item = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_vender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_unit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_grade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_period = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_fee = new System.Windows.Forms.TextBox();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_required = new System.Windows.Forms.TextBox();
            this.btn_rent = new System.Windows.Forms.Button();
            this.oracleConnection1 = new System.Data.OracleClient.OracleConnection();
            this.oracleCommand1 = new System.Data.OracleClient.OracleCommand();
            this.goodsTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSTableAdapter();
            this.goodstypeTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSTYPETableAdapter();
            this.dataSet11 = new _5171580_김상원.DataSet1();
            this.goodsunitTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSUNITTableAdapter();
            this.goodsgradeTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.GOODSGRADETableAdapter();
            this.rentstateTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.RENTSTATETableAdapter();
            this.rentTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.RENTTableAdapter();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_serial = new System.Windows.Forms.TextBox();
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
            this.label1.Text = "고객 정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "고객명";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(91, 39);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(127, 30);
            this.tb_name.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "상품 정보";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "상품명";
            // 
            // tb_item
            // 
            this.tb_item.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_item.Location = new System.Drawing.Point(91, 110);
            this.tb_item.Name = "tb_item";
            this.tb_item.ReadOnly = true;
            this.tb_item.Size = new System.Drawing.Size(339, 30);
            this.tb_item.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "제조사";
            // 
            // tb_vender
            // 
            this.tb_vender.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_vender.Location = new System.Drawing.Point(91, 146);
            this.tb_vender.Name = "tb_vender";
            this.tb_vender.ReadOnly = true;
            this.tb_vender.Size = new System.Drawing.Size(127, 30);
            this.tb_vender.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "모델명";
            // 
            // tb_model
            // 
            this.tb_model.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_model.Location = new System.Drawing.Point(303, 146);
            this.tb_model.Name = "tb_model";
            this.tb_model.ReadOnly = true;
            this.tb_model.Size = new System.Drawing.Size(127, 30);
            this.tb_model.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "재  고";
            // 
            // tb_qty
            // 
            this.tb_qty.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qty.Location = new System.Drawing.Point(91, 217);
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.ReadOnly = true;
            this.tb_qty.Size = new System.Drawing.Size(127, 30);
            this.tb_qty.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(245, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "단  위";
            // 
            // tb_unit
            // 
            this.tb_unit.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_unit.Location = new System.Drawing.Point(303, 217);
            this.tb_unit.Name = "tb_unit";
            this.tb_unit.ReadOnly = true;
            this.tb_unit.Size = new System.Drawing.Size(127, 30);
            this.tb_unit.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "상  태";
            // 
            // tb_grade
            // 
            this.tb_grade.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_grade.Location = new System.Drawing.Point(91, 182);
            this.tb_grade.Name = "tb_grade";
            this.tb_grade.ReadOnly = true;
            this.tb_grade.Size = new System.Drawing.Size(127, 30);
            this.tb_grade.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "대여 정보";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "대여일";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "반납일";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 354);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 23);
            this.label13.TabIndex = 0;
            this.label13.Text = "기  간";
            // 
            // tb_period
            // 
            this.tb_period.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_period.Location = new System.Drawing.Point(91, 351);
            this.tb_period.Name = "tb_period";
            this.tb_period.ReadOnly = true;
            this.tb_period.Size = new System.Drawing.Size(127, 30);
            this.tb_period.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(242, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "요금계";
            // 
            // tb_fee
            // 
            this.tb_fee.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fee.Location = new System.Drawing.Point(303, 354);
            this.tb_fee.Name = "tb_fee";
            this.tb_fee.ReadOnly = true;
            this.tb_fee.Size = new System.Drawing.Size(127, 30);
            this.tb_fee.TabIndex = 1;
            // 
            // dt_start
            // 
            this.dt_start.CalendarFont = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start.Enabled = false;
            this.dt_start.Location = new System.Drawing.Point(91, 298);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(175, 21);
            this.dt_start.TabIndex = 2;
            // 
            // dt_end
            // 
            this.dt_end.CalendarFont = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end.Location = new System.Drawing.Point(91, 324);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(175, 21);
            this.dt_end.TabIndex = 2;
            this.dt_end.ValueChanged += new System.EventHandler(this.ActionTimePicker);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(245, 393);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 23);
            this.label15.TabIndex = 0;
            this.label15.Text = "수  량";
            // 
            // tb_required
            // 
            this.tb_required.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_required.Location = new System.Drawing.Point(303, 390);
            this.tb_required.Name = "tb_required";
            this.tb_required.Size = new System.Drawing.Size(127, 30);
            this.tb_required.TabIndex = 1;
            this.tb_required.TextChanged += new System.EventHandler(this.ActionValueChanged);
            // 
            // btn_rent
            // 
            this.btn_rent.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rent.Location = new System.Drawing.Point(446, 354);
            this.btn_rent.Name = "btn_rent";
            this.btn_rent.Size = new System.Drawing.Size(85, 66);
            this.btn_rent.TabIndex = 3;
            this.btn_rent.Text = "대  여";
            this.btn_rent.UseVisualStyleBackColor = true;
            this.btn_rent.Click += new System.EventHandler(this.ActionRent);
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=MyORCL;PERSIST SECURITY INFO=True;USER ID=B5171580;password=B5171580";
            // 
            // oracleCommand1
            // 
            this.oracleCommand1.Connection = this.oracleConnection1;
            // 
            // goodsTableAdapter1
            // 
            this.goodsTableAdapter1.ClearBeforeFill = true;
            // 
            // goodstypeTableAdapter1
            // 
            this.goodstypeTableAdapter1.ClearBeforeFill = true;
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
            // goodsgradeTableAdapter1
            // 
            this.goodsgradeTableAdapter1.ClearBeforeFill = true;
            // 
            // rentstateTableAdapter1
            // 
            this.rentstateTableAdapter1.ClearBeforeFill = true;
            // 
            // rentTableAdapter1
            // 
            this.rentTableAdapter1.ClearBeforeFill = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(248, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 23);
            this.label16.TabIndex = 0;
            this.label16.Text = "S/N";
            // 
            // tb_serial
            // 
            this.tb_serial.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_serial.Location = new System.Drawing.Point(303, 182);
            this.tb_serial.Name = "tb_serial";
            this.tb_serial.ReadOnly = true;
            this.tb_serial.Size = new System.Drawing.Size(127, 30);
            this.tb_serial.TabIndex = 1;
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 435);
            this.Controls.Add(this.btn_rent);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.tb_model);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_unit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_fee);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_required);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb_period);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_serial);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb_grade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_qty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_vender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_item);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RentForm";
            this.Text = "RentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_item;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_vender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_unit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_grade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_period;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_fee;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_required;
        private System.Windows.Forms.Button btn_rent;
        private System.Data.OracleClient.OracleConnection oracleConnection1;
        private System.Data.OracleClient.OracleCommand oracleCommand1;
        private DataSet1TableAdapters.GOODSTableAdapter goodsTableAdapter1;
        private DataSet1TableAdapters.GOODSTYPETableAdapter goodstypeTableAdapter1;
        private DataSet1TableAdapters.GOODSUNITTableAdapter goodsunitTableAdapter1;
        private DataSet1TableAdapters.GOODSGRADETableAdapter goodsgradeTableAdapter1;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.RENTSTATETableAdapter rentstateTableAdapter1;
        private DataSet1TableAdapters.RENTTableAdapter rentTableAdapter1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_serial;
    }
}
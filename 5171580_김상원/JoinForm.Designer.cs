namespace _5171580_김상원
{
    partial class JoinForm
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
            this.lb_welcome = new System.Windows.Forms.Label();
            this.lb_desc = new System.Windows.Forms.Label();
            this.lb_start = new System.Windows.Forms.Label();
            this.panelJoin = new System.Windows.Forms.Panel();
            this.de_birth = new DevExpress.XtraEditors.DateEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_addr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cfm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customersTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.CUSTOMERSTableAdapter();
            this.dataSet11 = new _5171580_김상원.DataSet1();
            this.panelJoin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_birth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_birth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Myriad Pro", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_welcome.Location = new System.Drawing.Point(170, 96);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(156, 40);
            this.lb_welcome.TabIndex = 0;
            this.lb_welcome.Text = "Welcome!";
            // 
            // lb_desc
            // 
            this.lb_desc.AutoSize = true;
            this.lb_desc.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_desc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_desc.Location = new System.Drawing.Point(172, 218);
            this.lb_desc.Name = "lb_desc";
            this.lb_desc.Size = new System.Drawing.Size(153, 25);
            this.lb_desc.TabIndex = 0;
            this.lb_desc.Text = "Let\'s get started";
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(147)))), ((int)(((byte)(220)))));
            this.lb_start.Location = new System.Drawing.Point(209, 278);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(77, 23);
            this.lb_start.TabIndex = 1;
            this.lb_start.Text = "Get start";
            this.lb_start.Click += new System.EventHandler(this.ActionLabelStart);
            // 
            // panelJoin
            // 
            this.panelJoin.Controls.Add(this.de_birth);
            this.panelJoin.Controls.Add(this.label8);
            this.panelJoin.Controls.Add(this.label7);
            this.panelJoin.Controls.Add(this.tb_tel);
            this.panelJoin.Controls.Add(this.label6);
            this.panelJoin.Controls.Add(this.tb_addr);
            this.panelJoin.Controls.Add(this.label5);
            this.panelJoin.Controls.Add(this.label9);
            this.panelJoin.Controls.Add(this.tb_cfm);
            this.panelJoin.Controls.Add(this.label4);
            this.panelJoin.Controls.Add(this.tb_pwd);
            this.panelJoin.Controls.Add(this.label3);
            this.panelJoin.Controls.Add(this.tb_email);
            this.panelJoin.Controls.Add(this.label2);
            this.panelJoin.Controls.Add(this.tb_name);
            this.panelJoin.Controls.Add(this.label1);
            this.panelJoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJoin.Location = new System.Drawing.Point(0, 0);
            this.panelJoin.Name = "panelJoin";
            this.panelJoin.Size = new System.Drawing.Size(484, 361);
            this.panelJoin.TabIndex = 2;
            // 
            // de_birth
            // 
            this.de_birth.EditValue = null;
            this.de_birth.Location = new System.Drawing.Point(116, 226);
            this.de_birth.Name = "de_birth";
            this.de_birth.Properties.Appearance.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.de_birth.Properties.Appearance.Options.UseFont = true;
            this.de_birth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_birth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_birth.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.de_birth.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.de_birth.Size = new System.Drawing.Size(158, 30);
            this.de_birth.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(147)))), ((int)(((byte)(210)))));
            this.label8.Location = new System.Drawing.Point(406, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "submit";
            this.label8.Click += new System.EventHandler(this.ActionSubmitLabel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(147)))), ((int)(((byte)(210)))));
            this.label7.Location = new System.Drawing.Point(25, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Please fill out the form below";
            // 
            // tb_tel
            // 
            this.tb_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_tel.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_tel.Location = new System.Drawing.Point(116, 300);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(199, 30);
            this.tb_tel.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(74, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tel.";
            // 
            // tb_addr
            // 
            this.tb_addr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_addr.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_addr.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_addr.Location = new System.Drawing.Point(116, 264);
            this.tb_addr.Name = "tb_addr";
            this.tb_addr.Size = new System.Drawing.Size(199, 30);
            this.tb_addr.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(36, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(63, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Birth";
            // 
            // tb_cfm
            // 
            this.tb_cfm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_cfm.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cfm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_cfm.Location = new System.Drawing.Point(116, 173);
            this.tb_cfm.Name = "tb_cfm";
            this.tb_cfm.PasswordChar = '*';
            this.tb_cfm.Size = new System.Drawing.Size(199, 30);
            this.tb_cfm.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(36, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm";
            // 
            // tb_pwd
            // 
            this.tb_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pwd.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pwd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_pwd.Location = new System.Drawing.Point(116, 137);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(199, 30);
            this.tb_pwd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(24, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_email.Location = new System.Drawing.Point(116, 99);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(254, 30);
            this.tb_email.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(58, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // tb_name
            // 
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tb_name.Location = new System.Drawing.Point(116, 46);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(158, 30);
            this.tb_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
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
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.panelJoin);
            this.Controls.Add(this.lb_start);
            this.Controls.Add(this.lb_desc);
            this.Controls.Add(this.lb_welcome);
            this.Name = "JoinForm";
            this.Text = "JoinForm";
            this.panelJoin.ResumeLayout(false);
            this.panelJoin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_birth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_birth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_welcome;
        private System.Windows.Forms.Label lb_desc;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Panel panelJoin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_addr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_cfm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private DataSet1TableAdapters.CUSTOMERSTableAdapter customersTableAdapter1;
        private DataSet1 dataSet11;
        private DevExpress.XtraEditors.DateEdit de_birth;
        private System.Windows.Forms.Label label9;
    }
}
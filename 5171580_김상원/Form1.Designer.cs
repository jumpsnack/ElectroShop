namespace _5171580_김상원
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.Animation.Transition transition7 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.FadeTransition fadeTransition7 = new DevExpress.Utils.Animation.FadeTransition();
            DevExpress.Utils.Animation.Transition transition8 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.FadeTransition fadeTransition8 = new DevExpress.Utils.Animation.FadeTransition();
            DevExpress.Utils.Animation.Transition transition9 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.FadeTransition fadeTransition9 = new DevExpress.Utils.Animation.FadeTransition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_permission = new System.Windows.Forms.Label();
            this.lb_join = new System.Windows.Forms.Label();
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager();
            this.lb_title = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.navigationBarMain = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.navigationBarItem1 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.navigationBarItem2 = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.lb_login = new System.Windows.Forms.Label();
            this.transitionManager2 = new DevExpress.Utils.Animation.TransitionManager();
            this.dataSet11 = new _5171580_김상원.DataSet1();
            this.tableAdapterManager1 = new _5171580_김상원.DataSet1TableAdapters.TableAdapterManager();
            this.oracleConnection1 = new System.Data.OracleClient.OracleConnection();
            this.customersTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.CUSTOMERSTableAdapter();
            this.managerTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.MANAGERTableAdapter();
            this.staffTableAdapter1 = new _5171580_김상원.DataSet1TableAdapters.STAFFTableAdapter();
            this.transitionManager3 = new DevExpress.Utils.Animation.TransitionManager();
            ((System.ComponentModel.ISupportInitialize)(this.navigationBarMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_permission
            // 
            this.lb_permission.BackColor = System.Drawing.Color.Transparent;
            this.lb_permission.Font = new System.Drawing.Font("Myriad Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_permission.Location = new System.Drawing.Point(327, 185);
            this.lb_permission.Margin = new System.Windows.Forms.Padding(20, 6, 20, 6);
            this.lb_permission.Name = "lb_permission";
            this.lb_permission.Size = new System.Drawing.Size(110, 33);
            this.lb_permission.TabIndex = 2;
            this.lb_permission.Text = "Manager";
            this.lb_permission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_permission.Click += new System.EventHandler(this.ActionLabelPermission);
            this.lb_permission.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelPaint);
            // 
            // lb_join
            // 
            this.lb_join.BackColor = System.Drawing.Color.Transparent;
            this.lb_join.Font = new System.Drawing.Font("Myriad Pro SemiExt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_join.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_join.Location = new System.Drawing.Point(422, 364);
            this.lb_join.Name = "lb_join";
            this.lb_join.Size = new System.Drawing.Size(117, 23);
            this.lb_join.TabIndex = 6;
            this.lb_join.Text = "Join us >";
            this.lb_join.Click += new System.EventHandler(this.ActionLabelJoin);
            this.lb_join.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelPaint);
            // 
            // transitionManager1
            // 
            this.transitionManager1.FrameCount = 400;
            transition7.Control = this.lb_permission;
            transition7.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition7.LineWaitingIndicatorProperties.Caption = "";
            transition7.LineWaitingIndicatorProperties.Description = "";
            transition7.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition7.RingWaitingIndicatorProperties.Caption = "";
            transition7.RingWaitingIndicatorProperties.Description = "";
            transition7.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.False;
            transition7.TransitionType = fadeTransition7;
            transition7.WaitingIndicatorProperties.Caption = "";
            transition7.WaitingIndicatorProperties.Description = "";
            this.transitionManager1.Transitions.Add(transition7);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Myriad Pro", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(119, 27);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(534, 115);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "ElectroShop";
            this.lb_title.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelPaint);
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_password.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_password.Location = new System.Drawing.Point(233, 257);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(306, 33);
            this.tb_password.TabIndex = 3;
            this.tb_password.Text = "password";
            this.tb_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_password.WordWrap = false;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ActionPasswordBox);
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_email.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_email.Location = new System.Drawing.Point(233, 227);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(306, 33);
            this.tb_email.TabIndex = 3;
            this.tb_email.Text = "ID";
            this.tb_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_email.WordWrap = false;
            // 
            // navigationBarMain
            // 
            this.navigationBarMain.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden;
            this.navigationBarMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigationBarMain.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.navigationBarMain.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.navigationBarMain.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.navigationBarItem1,
            this.navigationBarItem2});
            this.navigationBarMain.Location = new System.Drawing.Point(0, 515);
            this.navigationBarMain.Name = "navigationBarMain";
            this.navigationBarMain.SelectedItem = this.navigationBarItem1;
            this.navigationBarMain.ShowToolTips = false;
            this.navigationBarMain.Size = new System.Drawing.Size(784, 46);
            this.navigationBarMain.TabIndex = 5;
            this.navigationBarMain.Text = "officeNavigationBar1";
            this.navigationBarMain.ItemClick += new DevExpress.XtraBars.Navigation.NavigationBarItemClickEventHandler(this.ActionNavItem);
            this.navigationBarMain.Paint += new System.Windows.Forms.PaintEventHandler(this.NavigationBarMainPaint);
            // 
            // navigationBarItem1
            // 
            this.navigationBarItem1.Name = "navigationBarItem1";
            this.navigationBarItem1.Text = "Employee";
            // 
            // navigationBarItem2
            // 
            this.navigationBarItem2.Name = "navigationBarItem2";
            this.navigationBarItem2.Text = "Customer";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.BackColor = System.Drawing.Color.Transparent;
            this.lb_login.Font = new System.Drawing.Font("Myriad Pro SemiExt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_login.Location = new System.Drawing.Point(276, 358);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(94, 27);
            this.lb_login.TabIndex = 4;
            this.lb_login.Text = "Login >";
            this.lb_login.Click += new System.EventHandler(this.ActionLabelLogin);
            this.lb_login.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelPaint);
            // 
            // transitionManager2
            // 
            this.transitionManager2.FrameCount = 400;
            transition8.Control = this.lb_join;
            transition8.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition8.LineWaitingIndicatorProperties.Caption = "";
            transition8.LineWaitingIndicatorProperties.Description = "";
            transition8.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition8.RingWaitingIndicatorProperties.Caption = "";
            transition8.RingWaitingIndicatorProperties.Description = "";
            transition8.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.False;
            transition8.TransitionType = fadeTransition8;
            transition8.WaitingIndicatorProperties.Caption = "";
            transition8.WaitingIndicatorProperties.Description = "";
            this.transitionManager2.Transitions.Add(transition8);
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BLACKLISTTableAdapter = null;
            this.tableAdapterManager1.BUYINGGOODSTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CUSTOMERSTableAdapter = null;
            this.tableAdapterManager1.DISCARDINGGOODSTableAdapter = null;
            this.tableAdapterManager1.GOODSGRADETableAdapter = null;
            this.tableAdapterManager1.GOODSSTORETableAdapter = null;
            this.tableAdapterManager1.GOODSTableAdapter = null;
            this.tableAdapterManager1.GOODSTYPETableAdapter = null;
            this.tableAdapterManager1.GOODSUNITTableAdapter = null;
            this.tableAdapterManager1.MANAGERTableAdapter = null;
            this.tableAdapterManager1.OVERDUETableAdapter = null;
            this.tableAdapterManager1.RENTSTATETableAdapter = null;
            this.tableAdapterManager1.RENTTableAdapter = null;
            this.tableAdapterManager1.RESERVATIONSTableAdapter = null;
            this.tableAdapterManager1.REVIEWSTableAdapter = null;
            this.tableAdapterManager1.SHELVESTableAdapter = null;
            this.tableAdapterManager1.STAFFTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = _5171580_김상원.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // oracleConnection1
            // 
            this.oracleConnection1.ConnectionString = "DATA SOURCE=MyORCL;PERSIST SECURITY INFO=True;USER ID=B5171580;password=B5171580";
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // managerTableAdapter1
            // 
            this.managerTableAdapter1.ClearBeforeFill = true;
            // 
            // staffTableAdapter1
            // 
            this.staffTableAdapter1.ClearBeforeFill = true;
            // 
            // transitionManager3
            // 
            this.transitionManager3.FrameCount = 400;
            transition9.Control = this.tb_email;
            transition9.LineWaitingIndicatorProperties.AnimationElementCount = 5;
            transition9.LineWaitingIndicatorProperties.Caption = "";
            transition9.LineWaitingIndicatorProperties.Description = "";
            transition9.RingWaitingIndicatorProperties.AnimationElementCount = 5;
            transition9.RingWaitingIndicatorProperties.Caption = "";
            transition9.RingWaitingIndicatorProperties.Description = "";
            transition9.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.False;
            transition9.TransitionType = fadeTransition9;
            transition9.WaitingIndicatorProperties.Caption = "";
            transition9.WaitingIndicatorProperties.Description = "";
            this.transitionManager3.Transitions.Add(transition9);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lb_join);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.navigationBarMain);
            this.Controls.Add(this.lb_permission);
            this.Controls.Add(this.lb_title);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "5171580_김상원";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromClosing);
            ((System.ComponentModel.ISupportInitialize)(this.navigationBarMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
        private System.Windows.Forms.Label lb_permission;
        private System.Windows.Forms.Label lb_title;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem navigationBarItem2;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar navigationBarMain;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_join;
        private DevExpress.Utils.Animation.TransitionManager transitionManager2;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Data.OracleClient.OracleConnection oracleConnection1;
        private DataSet1TableAdapters.CUSTOMERSTableAdapter customersTableAdapter1;
        private DataSet1TableAdapters.MANAGERTableAdapter managerTableAdapter1;
        private DataSet1TableAdapters.STAFFTableAdapter staffTableAdapter1;
        private DevExpress.Utils.Animation.TransitionManager transitionManager3;
    }
}


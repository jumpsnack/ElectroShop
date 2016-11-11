using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.XtraEditors;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using DevExpress.Utils.Animation;
using DevExpress.XtraBars.Navigation;
using Oracle.ManagedDataAccess.Client;
using _5171580_김상원.DataSet1TableAdapters;
using OracleConnection = System.Data.OracleClient.OracleConnection;

namespace _5171580_김상원
{
    public partial class Form1 : Form
    {
        public static OracleConnection oracleConnection;
        public Form1()
        {
            InitializeComponent();
            oracleConnection = oracleConnection1;
            oracleConnection.Open();

            tb_email.Location = new Point(400 - tb_email.Width / 2, 270);
            tb_password.Location = new Point(400 - tb_password.Width / 2, 302);
            tb_email.BringToFront();

            lb_join.Text = "";
            lb_join.Enabled = false;

            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            Invalidate();
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void LabelPaint(object sender, PaintEventArgs e)
        {
            Label input = sender as Label;
            switch (input.Name)
            {
                case "lb_title":
                    input.Location = new Point(400 - input.Width / 2, 50);
                    input.BackColor = Color.Transparent;
                    input.ForeColor = Color.White;
                    break;

                case "lb_permission":
                    Pen penBorder;
                    if (input.Text == "Customer")
                    {
                        penBorder = new Pen(Color.White, 1);
                        input.ForeColor = Color.White;
                    }
                    else
                    {
                        penBorder = new Pen(Color.DarkOrange, 1);
                        input.ForeColor = Color.DarkOrange;
                    }

                    Rectangle rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
                    using (GraphicsPath path = RoundedRect(rectBorder, 10))
                    {
                        e.Graphics.DrawPath(penBorder, path);
                    }
                    input.Location = new Point(400 - input.Width / 2, 190);
                    input.BackColor = Color.Transparent;
                    break;

                case "lb_login":
                    input.BackColor = Color.Transparent;
                    input.Location = new Point(300 - input.Width / 2, 380);
                    //input.ForeColor = Color.FromArgb(255, 117, 147, 220);
                    break;

                case "lb_join":
                    input.BackColor = Color.Transparent;
                    input.Location = new Point(500 - input.Width / 2, 380);
                    //input.ForeColor = Color.FromArgb(255, 117, 147, 220);
                    break;

            }
        }

        private void ActionLabelPermission(object sender, EventArgs e)
        {
            Label input = sender as Label;

            if (transitionManager1.IsTransition)
            {
                transitionManager1.EndTransition();
            }

            transitionManager1.StartTransition(lb_permission);
            try
            {
                switch (input.Text)
                {
                    case "Staff":
                        input.Text = "Manager";
                        break;

                    case "Manager":
                        input.Text = "Staff";
                        break;
                }
            }
            finally
            {
                transitionManager1.EndTransition();
            }
        }

        private void NavigationBarMainPaint(object sender, PaintEventArgs e)
        {
            navigationBarMain.BackColor = Color.FromArgb(30, 255, 255, 255);
        }

        private void FromClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void ActionNavItem(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            NavigationBarItem input = e.Item;

            if (transitionManager1.IsTransition && transitionManager2.IsTransition && transitionManager3.IsTransition)
            {
                transitionManager1.EndTransition();
                transitionManager2.EndTransition();
                transitionManager3.EndTransition();
            }

            transitionManager1.StartTransition(lb_permission);
            transitionManager2.StartTransition(lb_join);
            transitionManager3.StartTransition(tb_email);
            try
            {
                switch (input.Text)
                {
                    case "Employee":
                        lb_permission.Text = "Manager";
                        lb_join.Text = "";
                        lb_join.Enabled = false;tb_email.Text = "ID";
                        break;
                    case "Customer":
                        lb_permission.Text = "Customer";
                        lb_join.Text = "Join us >";
                        lb_join.Enabled = true;
                        tb_email.Text = "email";
                        break;
                }
            }
            finally
            {
                transitionManager1.EndTransition();
                transitionManager2.EndTransition();
                transitionManager3.EndTransition();
            }
        }

        private void ActionLabelJoin(object sender, EventArgs e)
        {
            new JoinForm().ShowDialog();
        }

        private void ActionLabelLogin(object sender, EventArgs e)
        {
            switch (lb_permission.Text)
            {
                case "Manager":
                    if (CheckManagerPassword())
                    {
                        this.Visible = false;
                        new ManagerForm().ShowDialog();
                        this.Close();
                    }
                    break;

                case "Staff":
                    if (CheckStaffPassword())
                    {
                        this.Visible = false;
                        new StaffForm().ShowDialog();
                        this.Close();
                    }
                    break;

                case "Customer":
                    if (CheckCustomerPassword())
                    {
                        this.Visible = false;
                        new CustomerForm().ShowDialog();
                        this.Close();
                    }
                    break;}
        }

        bool CheckCustomerPassword()
        {
            customersTableAdapter1.Fill(dataSet11.CUSTOMERS);
            DataSet1.CUSTOMERSDataTable customerDataTable = (DataSet1.CUSTOMERSDataTable)dataSet11.Tables["CUSTOMERS"];
            string email = tb_email.Text;
            string password = tb_password.Text;

            if (email.Length*password.Length < 1)
            {
                return false;
            }

            foreach (DataRow data in customerDataTable.Rows)
            {
                if (data["c_email"].ToString() == email)
                {if (data["c_pwd"].ToString() == NewAccount.EncryptMD5(password + data["c_birth"].ToString()))
                    {return true;
                    }
                }
            }
            return false;
        }

        bool CheckManagerPassword()
        {
            managerTableAdapter1.Fill(dataSet11.MANAGER);
            DataSet1.MANAGERDataTable managerDataTable = dataSet11.MANAGER;

            string id = tb_email.Text;
            string password = tb_password.Text;
            if (id.Length*password.Length < 1)
            {
                return false;
            }

           DataSet1.MANAGERRow row =  managerDataTable.FindByMNG_ID(id);
            if (row != null)
            {
                if (row.MNG_PIN == password)
                {
                    return true;
                }
            }
            return false;
        }

        bool CheckStaffPassword()
        {
            staffTableAdapter1.Fill(dataSet11.STAFF);
            DataSet1.STAFFDataTable staffDataTable = dataSet11.STAFF;
            string id = tb_email.Text;

            string password = tb_password.Text;
            if (id.Length*password.Length < 1)
            {
                return false;
            }

            DataSet1.STAFFRow row = staffDataTable.FindBySTF_ID(id);
            if (row != null)
            {
                if (row.STF_PIN == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void ActionPasswordBox(object sender, KeyPressEventArgs e)
        {
            ActionLabelLogin(null,null);
        }

    }
}

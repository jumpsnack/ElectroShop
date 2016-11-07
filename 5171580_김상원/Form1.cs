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

namespace _5171580_김상원
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                    Pen penBorder = new Pen(Color.DarkOrange, 1);
                    Rectangle rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
                    //e.Graphics.DrawRectangle(penBorder, rectBorder);
                    //  Rectangle textRec = new Rectangle(e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
                    //  TextRenderer.DrawText(e.Graphics, Text, this.Font, textRec, this.ForeColor, this.BackColor, TextFormatFlags.Default);

                    using (GraphicsPath path = RoundedRect(rectBorder, 10))
                    {
                        e.Graphics.DrawPath(penBorder, path);
                    }
                    input.Location = new Point(panelInput.Width/2 - input.Width / 2, 10);
                    input.BackColor = Color.Transparent;
                    input.ForeColor = Color.DarkOrange;
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

        private void PanelInputPaint(object sender, PaintEventArgs e)
        {
            Panel input = sender as Panel;

            input.BackColor = Color.Transparent;
            input.Location = new Point(400 - input.Width/2, 170);
            
        }

        private void NavigationBarMainPaint(object sender, PaintEventArgs e)
        {
            navigationBarMain.BackColor = Color.FromArgb(30,255,255,255);
        }

        private void FromClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }
    }
}

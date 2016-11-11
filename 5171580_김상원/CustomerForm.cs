using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;

namespace _5171580_김상원
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

        }

        private void LabelPaint(object sender, PaintEventArgs e)
        {
            Label input = sender as Label;

            switch (input.Name)
            {
                case "lb_title":
                    Pen penBorder = new Pen(Color.Black, 3);
                    input.ForeColor = Color.Black;
                    Rectangle rectBorder = new Rectangle(e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
                    e.Graphics.DrawRectangle(penBorder, rectBorder);
                    break;
            }
        }}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;

namespace _5171580_김상원
{
    public partial class ManagerForm : DevExpress.XtraEditors.XtraForm
    {public ManagerForm()
        {
            InitializeComponent();
        }

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            Panel panel = new Panel();panel.BackColor = Color.Aqua;if (e.Document == document1) e.Control = new DocMngMembers();
            if (e.Document == document2) e.Control = new DocMngGoods();
            if (e.Document == document3) e.Control = new DocMngRent();
            if (e.Document == document4) e.Control = new DocMngSales();}
    }
    
}

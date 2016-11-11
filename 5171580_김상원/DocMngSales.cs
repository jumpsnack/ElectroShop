using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace _5171580_김상원
{
    public partial class DocMngSales : DevExpress.XtraEditors.XtraUserControl
    {
        private ChartControl chartControl;
        private GridControl gridControl;
        public DocMngSales()
        {
            InitializeComponent();
            chartControl = chartControl1;
            gridControl = gridControl1;
        }

        private void ActionMenuItem(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            switch (e.Element.Tag as string)
            {
                case "대여 현황":
                    chartControl.BackColor = Color.Aquamarine;
                    gridControl.ForeColor = Color.DeepPink;
                    break;
                case "매출 현황":
                    chartControl.BackColor = Color.Blue;
                    gridControl.ForeColor = Color.Brown;
                    break;
                case "주차별 현황":
                    break;
                case "전체 현황":
                    break;
            }
        }
    }
}

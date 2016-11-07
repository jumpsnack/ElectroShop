using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5171580_김상원
{
    public partial class JoinForm : Form
    {
        public JoinForm(){
            InitializeComponent();

            lb_welcome.Location = new Point(this.Width/2 - lb_welcome.Width/2, 80);
            lb_desc.Location = new Point(this.Width/2 - lb_desc.Width/2, 220);
            lb_start.Location = new Point(this.Width/2 - lb_start.Width/2, 280);

            panelJoin.Visible = false;
        }

        private void ActionLabelStart(object sender, EventArgs e)
        {
                panelJoin.Location = new Point(0, 0);
                panelJoin.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ComponentModel.DataAnnotations;

namespace _5171580_김상원
{
    public partial class DocMngGoods : DevExpress.XtraEditors.XtraUserControl
    {
        public DocMngGoods()
        {
            InitializeComponent();

            goodsTableAdapter1.Fill(dataSet1.GOODS);
        }
        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            String button = e.Button.Properties.Caption;
            switch (button)
            {
                case "구매":
                    new BuyingForm().ShowDialog();
                    break;
                case "수정":
                    DataRowView view = gOODSBindingSource.Current as DataRowView;
                    DataSet1.GOODSRow data = view.Row as DataSet1.GOODSRow;
                    new BuyingForm(data).ShowDialog();
                    break;
                case "폐기":
                    if (MessageBox.Show("폐기하시겠습니까?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        try
                        {
                            gOODSBindingSource.EndEdit();
                            gOODSBindingSource.RemoveCurrent();
                            goodsTableAdapter1.Update(dataSet1.GOODS);
                            goodsTableAdapter1.Fill(dataSet1.GOODS);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Failed");
                        }
                    }
                    break;
                case "새로고침": break;
                case "프린트":
                    gridControl.ShowRibbonPrintPreview();
                    break;
            }
            goodsTableAdapter1.Fill(dataSet1.GOODS);
            gridControl.ResetBindings();
        }

        /*public BindingList<Customer> GetDataSource()
        {
            BindingList<Customer> result = new BindingList<Customer>();
            result.Add(new Customer()
            {
                ID = 1,
                Name = "ACME",
                Address = "2525 E El Segundo Blvd",
                City = "El Segundo",
                State = "CA",
                ZipCode = "90245",
                Phone = "(310) 536-0611"
            });
            result.Add(new Customer()
            {
                ID = 2,
                Name = "Electronics Depot",
                Address = "2455 Paces Ferry Road NW",
                City = "Atlanta",
                State = "GA",
                ZipCode = "30339",
                Phone = "(800) 595-3232"
            });
            return result;
        }
        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }*/
    }
}

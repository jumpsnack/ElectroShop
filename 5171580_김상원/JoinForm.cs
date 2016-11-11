using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using _5171580_김상원.DataSet1TableAdapters;
using System.Security.Cryptography;

namespace _5171580_김상원
{
    public partial class JoinForm : Form
    {
        private DataSet1.CUSTOMERSDataTable customersTable;
        public JoinForm(){
            InitializeComponent();

            customersTableAdapter1.Fill(dataSet11.CUSTOMERS);
            customersTable = (DataSet1.CUSTOMERSDataTable) dataSet11.Tables["CUSTOMERS"];

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

        private void ActionSubmitLabel(object sender, EventArgs e)
        {
            if ((tb_name.TextLength*tb_email.TextLength*tb_pwd.TextLength*tb_cfm.TextLength*tb_addr.TextLength*
                 tb_tel.TextLength) == 0)
            {
                MessageBox.Show("Please fill out the forms", "Warning!");
                return;
            }

            if (IsDupEmail()){
                MessageBox.Show("이미 회원입니다.", "가입 실패!");return;
            }

            /* Create User Account */
            NewAccount newAccount = new NewAccount()
            {
                Name = tb_name.Text,
                Email = tb_email.Text,
                RawPassword =  tb_pwd.Text,
                RawConfirmPassword = tb_cfm.Text,
                Birth = de_birth.DateTime.ToString("yyMMdd"),
                Address = tb_addr.Text,
                Telephone = tb_tel.Text
            };if (!newAccount.IsPasswordMatching())
            {
                MessageBox.Show("Password mismatch");
                return;
            }
            
            DataRow dataRow = newAccount.CreateDataRow(customersTable);
            customersTable.Rows.Add(dataRow);
            try
            {
                int ret = customersTableAdapter1.Update(customersTable);
                if (ret > 0)
                {
                    MessageBox.Show("Update successful");
                    this.Close();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Update failed");
            }
        }

        bool IsDupEmail()
        {
            bool result = false;
            foreach (DataRow dataRow in customersTable.Rows)
            {
                if (dataRow["c_email"].ToString() == tb_email.Text) result = true;
            }

            return result;
        }

        
    }

    class NewAccount
    {
        internal String Name { get; set; }
        internal String Email { get; set; }
        internal String RawPassword { get; set; }
        internal String RawConfirmPassword { get; set; }
        internal String Birth { get; set; }
        internal String Address { get; set; }
        internal String Telephone { get; set; }

        internal bool IsPasswordMatching()
        {
            return RawPassword == RawConfirmPassword;
        }

        internal DataRow CreateDataRow(DataTable custoDataTable)
        {
            DataRow newDataRow = custoDataTable.NewRow();

            newDataRow["c_name"] = Name;
            newDataRow["c_email"] = Email;
            newDataRow["c_pwd"] = EncryptMD5(RawPassword + Birth);
            newDataRow["c_birth"] = Birth;
            newDataRow["c_addr"] = Address;
            newDataRow["c_tel"] = Telephone;

            return newDataRow;
        }

        public static string EncryptMD5(string passwordWithSalt)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] bytes = md5.ComputeHash(Encoding.Unicode.GetBytes(passwordWithSalt));
            string result = BitConverter.ToString(bytes).Replace("-", String.Empty);
            return result.ToLower();
        }
    }
}

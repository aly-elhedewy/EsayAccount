using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Helpers;
using DevExpress.XtraEditors;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using EsayAccount.DAL2;
using static System.Convert;


namespace EsayAccount
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        EasyAccount22Context db = new EasyAccount22Context();
      

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            var user = db.Users.Where(x => x.UserName == txtUserName.Text
                                        && x.Password == txtPassword.Text
                                        && x.BranchCode == ToInt32( CbBranch.EditValue))
           .FirstOrDefault();
            
            if (user != null)
            {

                Sett.MsgGreen(user.FullName, " مرحباً بك  تمت عمليه الدخول بنجاح");
                Close  ();
            }
            else
            {
                Sett.MsgRed("خطأ دخول", " دخول خاطىْ  اسم المستخدم او كلمه السر غير صحيحه");
                txtUserName.Focus();
                txtUserName.SelectAll();
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CbBranch.Properties.DataSource = db.Branch.Select(x => new { Code = x.CodeBranch, Name = x.NameAr }).ToList();
            CbBranch.EditValue = CbBranch.Properties.GetKeyValue(0);

            //CbBranch.Properties.DataSource = db.Branch.ToList   ();
           // CbBranch.EditValue = CbBranch.Properties.GetKeyValue(0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CbBranch.Focus();
            }

        }

        private void CbBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.Focus();
            }
        }
    }
    }

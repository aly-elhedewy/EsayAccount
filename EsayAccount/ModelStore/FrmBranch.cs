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
using EsayAccount.DAL2;
using static System.Convert;

namespace EsayAccount.ModelStore
{
    public partial class FrmBranch : FrmMaster
    {
        EasyAccount22Context db = new EasyAccount22Context();
        int code;
        public FrmBranch()
        {
            InitializeComponent();
        }

        private void FrmBranch_Load(object sender, EventArgs e)
        {
            Getdate();
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnLode.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;




        }
        int maxcode()
        {
            int code = 0;
            try
            {
                code = db.Branch.Max(x => x.CodeBranch);
            }
            catch (Exception)
            {

                return code;
            }
            return code;

        }
        public override void New()
        {
            txtcode.EditValue = maxcode() + 1;
            txtNameAr.ResetText();
            txtNameEn.ResetText();
            txtNameAr.Focus();
            ADD = true;
            base.New();
        }
        public override void Getdate()
        {
            dgv.DataSource = db.Branch
                .Select(x => new { x.CodeBranch, x.NameAr, x.NameEn })
                .ToList();
            base.Getdate();
        }
        public override void Save()



        {
            if (txtNameAr.Text == string.Empty.Trim())
            {
                txtNameAr.ErrorText = "ادخل الاسم بالعربيه";
                txtNameAr.Focus();
                return;

            }
            if (txtNameEn.Text == string.Empty.Trim())
            {
                txtNameEn.ErrorText = "ادخل الاسم بالانجليزيه";
                txtNameEn.Focus();
                return;

            }

            if (ADD)
            {
                //insert data
                Branch Branch = new Branch();
                Branch.CodeBranch = ToInt32(txtcode.Text);
                Branch.NameAr = txtNameAr.Text;
                Branch.NameEn = txtNameEn.Text;
                db.Add(Branch);
                db.SaveChanges();
            }
            else
            {
                //update
                Branch branch = db.Branch.Where(x => x.CodeBranch == code).FirstOrDefault();
                branch.NameAr = txtNameAr.Text;
                branch.NameEn = txtNameEn.Text;
                db.SaveChanges();


            }
            base.Save();

            New();
        }
        public override void Delete()
        {
            if (XtraMessageBox.Show("هل أنت متأكد من الحذف", "الحذف"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                code = ToInt32(dgvlist.GetFocusedRowCellValue(CodeBranch));
                Branch branch = db.Branch.Where(x => x.CodeBranch == code).FirstOrDefault();
                db.Branch.Remove(branch);
                db.SaveChanges();
                base.Delete();
            }

        }
        private void repoEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            code = ToInt32(dgvlist.GetFocusedRowCellValue(CodeBranch));
            txtcode.EditValue = code;
            txtNameAr.Text = dgvlist.GetFocusedRowCellValue(colNameAr).ToString();
            txtNameEn.Text = dgvlist.GetFocusedRowCellValue(colNameEN).ToString();
            txtNameAr.SelectAll();
            ADD = false;

        }

        private void txtNameAr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNameEn.Focus();
                txtNameEn.SelectAll();

            }
        }

        private void txtNameEn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();


            }

        }
    }
}

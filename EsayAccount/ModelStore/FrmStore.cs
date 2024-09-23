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
    public partial class FrmStore : FrmMaster
    {
        EasyAccount22Context db = new EasyAccount22Context();
        int code;

        public FrmStore()
        {
            InitializeComponent();
        }

        private void FrmStore_Load(object sender, EventArgs e)
        {
            Getdate();
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnLode.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            CbBranch.Properties.DataSource = db.Branch.Select(x => new { Code = x.CodeBranch, Name = x.NameAr }).ToList();
            CbBranch.EditValue = CbBranch.Properties.GetKeyValue(0);
            New();
        }
        public override void Getdate()
        {
            dgv.DataSource =
                db.Store.Join(
                    db.Branch,
                    sto => sto.BranchCode,
                    br => br.CodeBranch,
                    (sto, br) => new
                    {
                        sto.CodeStore,
                        sto.NameStore,
                        sto.BranchCode,
                        BranchName = br.NameAr,
                    }
                ).ToList();
            base.Getdate();
        }
        int maxcode()
        {
            int code = 0;
            try
            {
                code = db.Store.Max(x => x.CodeStore);
            }
            catch (Exception)
            {

                return code;
            }
            return code;
        }
        public override void Save()
        {
            if (ADD)
            {
                //insert data
                Store store = new Store();
                store.CodeStore = maxcode() + 1;
                store.NameStore = txtName.Text;
                store.BranchCode = ToInt32(CbBranch.EditValue);


                db.Add(store);
                db.SaveChanges();

            }
            else
            {
                //update data
                Store store = db.Store.Where(x => x.CodeStore == code).FirstOrDefault();
                store.NameStore = txtName.Text;
                store.BranchCode = Convert.ToInt32(CbBranch.EditValue);
                db.SaveChanges();


            }
            New();
            CbBranch.EditValue = CbBranch.Properties.GetKeyValue(0);

            base.Save();
        }
        public override void New()
        {
            txtcode.EditValue = maxcode() + 1;
            txtName.ResetText();
            txtName.Focus();

            base.New();
        }
        public override void Delete()
        {
            if (XtraMessageBox.Show("هل أنت متأكد من الحذف", "الحذف"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                code = ToInt32(dgvlist.GetFocusedRowCellValue(ColCodeStore));
                Store store = db.Store.Where(x => x.CodeStore == code).FirstOrDefault();
                db.Store.Remove(store);
                db.SaveChanges();
                New();
                CbBranch.EditValue = CbBranch.Properties.GetKeyValue(0);

                base.Delete();
            }

        }


        private void repoEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ADD = false;
            code = ToInt32(dgvlist.GetFocusedRowCellValue(ColCodeStore));
            txtcode.EditValue = code;
            txtName.Text = dgvlist.GetFocusedRowCellValue(colNameStore).ToString();
            CbBranch.EditValue = ToInt32(dgvlist.GetFocusedRowCellValue(ColBranchCode));

        }
    }


}


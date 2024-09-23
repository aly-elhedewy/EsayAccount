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
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace EsayAccount.ModelStore
{
    public partial class FrmCategory : FrmMaster
    {
        EasyAccount22Context db = new EasyAccount22Context();
        int code;

        public FrmCategory()
        {
            InitializeComponent();
        }
        bool isValidCategory(int categoryCode)
        {
            var item = db.Product.Any(x => x.CodeCategory == categoryCode);
            return item;
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            Getdate();
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnLode.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            New();

        }
        int maxcode()
        {
            int code = 0;
            try
            {
                code = db.Category.Max(x => x.CodeCategory);
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
            txtNameCategory.ResetText();
            ADD = true;
            base.New();
        }
        public override void Getdate()
        {
            dgv.DataSource = db.Category
           .Select(x => new { x.CodeCategory, x.NameCategory })
           .ToList();


            base.Getdate();
        }
        public override void Save()
        {
            if (ADD)
            {
                //insert data
                Category category = new Category();
                category.CodeCategory = ToInt32(txtcode.Text);
                category.NameCategory = txtNameCategory.Text;
                db.Add(category);

                db.SaveChanges();


            }
            else
            {
                ////update
                Category category = db.Category.Where(x => x.CodeCategory == code).FirstOrDefault();
                category.NameCategory = txtNameCategory.Text;
                db.SaveChanges();


            }


            New();
            Getdate();

            base.Save();
        }
        public override void Delete()
        {
          code = ToInt32(dgvlist.GetFocusedRowCellValue(ColCodeCategory));

            if (isValidCategory(code))
            {

                Sett.MsgRed("تراجع", "لا يمكن الحذف لوجود اصناف مرتبطه بهذه المجموعه");
            }
            else
            {

                if (XtraMessageBox.Show("هل أنت متأكد من الحذف", "الحذف"
                 , MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
                    code = ToInt32(dgvlist.GetFocusedRowCellValue(ColCodeCategory));
                Category category = db.Category.Where(x => x.CodeCategory == code).FirstOrDefault();
                db.Category.Remove(category);
                db.SaveChanges();
                New();
                Getdate();

                base.Delete();

            }




        }



        private void dgv_Click(object sender, EventArgs e)
        {

        }

        private void txtNameCategory_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}











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
    public partial class FrmUnitName :  FrmMaster
    {
        EasyAccount22Context db = new EasyAccount22Context();
        int code;
        public FrmUnitName()
        {
            InitializeComponent();
        }

        private void FrmUnitName_Load(object sender, EventArgs e)
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
                code = db.UnitName.Max(x => x.CodeUnit);
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
            txtUnitName.ResetText();
            ADD = true;
            base.New();

           
        }
        public override void Getdate()
        {
            dgv.DataSource = db.UnitName
                .Select(x => new { x.CodeUnit, x.NameUnit })
                .ToList();
            base.Getdate();
        }
        public override void Save()

        {
            if (txtUnitName.Text == string.Empty.Trim())
            {
                txtUnitName.ErrorText = "ادخل الاسم بالعربيه";
                txtUnitName.Focus();
                return;

            }

            if (ADD)
            {
                //insert data
                UnitName unitName = new UnitName();
                unitName.CodeUnit = ToInt32(txtcode.Text);
                unitName.NameUnit = txtUnitName.Text;
                db.Add(unitName);
                db.SaveChanges();
            }
            else
            {
                //update
                UnitName unitName = db.UnitName.Where(x => x.CodeUnit == code).FirstOrDefault();
                unitName.NameUnit = txtUnitName.Text;
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
                code = ToInt32(dgvlist.GetFocusedRowCellValue(CodeUnit));
                UnitName unitName = db.UnitName.Where(x => x.CodeUnit == code).FirstOrDefault();
                db.UnitName.Remove(unitName);
                db.SaveChanges();
                base.Delete();
            }


        }

        private void txtUnitName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();


            }

        }

        private void repoEdit_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            code = ToInt32(dgvlist.GetFocusedRowCellValue(CodeUnit));
            txtcode.EditValue = code;
            txtUnitName.Text = dgvlist.GetFocusedRowCellValue(ColNameUnit).ToString();
            txtUnitName.SelectAll();
            ADD = false;

        }
    }

}

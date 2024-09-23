using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DevComponents.DotNetBar;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using EsayAccount.DAL2;
using static System.Convert;
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace EsayAccount.ModelStore
{
    public partial class FrmProduct : FrmMaster
    {
        EasyAccount22Context db = new EasyAccount22Context();
        int productcode;
        int code;


        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)

        {
            Getdate();
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDel.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnLode.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            New();


        }
        public override void Getdate()
        {
            var store = db.Store.Select(x => new { x.CodeStore, x.NameStore }).ToList();
            cbStore.Properties.DataSource = store;
            cbStore.EditValue = cbStore.Properties.GetKeyValue(0);

            var cate = db.Category.Select(x => new { x.IdCategory, x.NameCategory }).ToList();
            cbCategory.Properties.DataSource = cate;
            cbCategory.EditValue = cbCategory.Properties.GetKeyValue(0);

            cbProductType.SelectedIndex = 0;

            var prod = db.Product
                .Join
                (db.Category,
                 pro => pro.CodeCategory,
                cat => cat.CodeCategory,
                (pro, cat) => new
                {
                    pro.IdProduct,
                    pro.CodeProduct,
                    pro.NameProduct,
                    pro.Qyt,
                    pro.IsDeleat,
                    pro.IsActive,
                    pro.IsType,
                    IsTypeName = pro.IsType == 0 ? "مخزنى" : "خدمى",
                    pro.CodeCategory,
                    NameCategory = cat.NameCategory,
                    pro.CodeStore,
                    pro.Discount,
                    pro.Tax,

                }
                )
                  .Join
                (db.Store,
                 pro => pro.CodeStore,
                sto => sto.CodeStore,
                (pro, sto) => new
                {
                    pro.IdProduct,
                    pro.CodeProduct,
                    pro.NameProduct,
                    pro.Qyt,
                    pro.IsDeleat,
                    pro.IsActive,
                    pro.IsType,
                    IsTypeName = pro.IsType == 0 ? "مخزنى" : "خدمى",
                    pro.CodeCategory,
                    pro.NameCategory,
                    pro.CodeStore,
                    NameStore = sto.NameStore,
                    pro.Discount,
                    pro.Tax,

                }
                )
                .ToList();
            dgvProduct.DataSource = prod;
            var unitname = db.UnitName.ToList();
            cbUnitName.Properties.DataSource = unitname;
            cbUnitName.EditValue = cbUnitName.Properties.GetKeyValue(0);
            txtProductCode.EditValue = maxcode() + 1;
            base.Getdate();

            {
            }

        }
        int maxcode()
        {
            int code = 0;
            try
            {
                code = db.Product.Max(x => x.CodeProduct);
            }
            catch (Exception)
            {

                return code;
            }
            return code;
        }
        int maxcodeunitproduct()
        {
            int code = 0;
            try
            {
                code = db.UnitProduct.Max(x => x.Code);
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
                //insert
                var product = new Product();
                product.CodeProduct = ToInt32(txtProductCode.Text);
                product.NameProduct = txtProductName.Text;
                product.Qyt = 0;
                product.IsDeleat = false;
                product.IsActive = chActive.Checked;
                product.IsType = cbProductType.SelectedIndex;
                product.CodeCategory = ToInt32(cbCategory.EditValue);
                product.CodeBranch = 1;
                product.CodeStore = ToInt32(cbStore.EditValue);
                product.Discount = ToDouble(txtDiscount.EditValue);
                product.Tax = ToDouble(txtTax.EditValue);
              

                db.Add(product);
                db.SaveChanges();

                New();
                Double x = 0;
                for (int i = 0; i < dgvProductList.RowCount; i++)
                {
                    // count rows in dgv
                  //  x = ToDouble(dgvProductList.RowCount); 
                  //-------------------------

                  // sum col in dgv
                   x += ToDouble(dgvProductList.GetRowCellValue(i, colQyt));
                }
                txttotqyt.Text = x.ToString();







            }
            else
            {
                //update
                var product = db.Product.Where(x => x.CodeProduct == productcode).FirstOrDefault();
                product.NameProduct = txtProductName.Text;
                product.Qyt = 0;
                product.IsDeleat = false;
                product.IsActive = chActive.Checked;
                product.IsType = cbProductType.SelectedIndex;
                product.CodeCategory = ToInt32(cbCategory.EditValue);
                product.CodeStore = ToInt32(cbStore.EditValue);
                product.CodeBranch = 1;
                product.Discount = ToDouble(txtDiscount.EditValue);
                product.Tax = ToDouble(txtTax.EditValue);
                db.SaveChanges();
                New();

            }
            base.Save();
        }
        public override void New()
        {
            txtProductCode.EditValue = maxcode() + 1;
            txtProductName.ResetText();
            txtDiscount.ResetText();
            txtTax.ResetText();
            cbCategory.ResetText();
            cbStore.ResetText();
            txtProductName.Focus();


            base.New();
        }

        public override void Delete()
        {
            if (XtraMessageBox.Show("هل أنت متأكد من الحذف", "الحذف"
           , MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                code = ToInt32(dgvProductList.GetFocusedRowCellValue(colProductCode));
                Product product = db.Product.Where(x => x.CodeProduct == code).FirstOrDefault();
                db.Product.Remove(product);

                db.SaveChanges();
                Clcl();

                Getdate();
                base.Delete();



            }
            else
            {
                Sett.MsgGreen("تراجع", "تم التراجع عن الحذف");
            }
            
        }
        
        private void dgvProductList_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Getunitbyproduct();

        }
        void Getunitbyproduct()
        {
            productcode = ToInt32(dgvProductList.GetFocusedRowCellValue(colProductCode));

            var unit = db.UnitProduct.Where(x => x.ProductCode == productcode)
                .Join(
                db.UnitName,
                un => un.UintNameCode,
                unN => unN.CodeUnit,
                (un, unN) => new
                {
                    un.Id,
                    un.Code,
                    un.Barcode,
                    un.Factor,
                    un.PriceBuy,
                    un.PriceSales,
                    un.ProductCode,
                    un.UintNameCode,
                    UintNameName = unN.NameUnit,

                }
                )

                .ToList();
            dgvUnit.DataSource = unit;

        }

        private void chActive_CheckedChanged(object sender, EventArgs e)
        {

        }
        void addunittoproduct()
        {
            var unitproduct = new UnitProduct();
            unitproduct.Code = maxcodeunitproduct() + 1;
            unitproduct.Barcode = txtUnitBarcode.Text;
            unitproduct.ProductCode = ToInt32(cbUnitName.EditValue);
            unitproduct.Factor = ToInt32(txtUnitFactory.Text);
            unitproduct.PriceBuy = ToInt32(txtUnitPriceBye.Text);
            unitproduct.PriceSales = ToInt32(txtUnitPriceSales.Text);
            unitproduct.ProductCode = productcode;
            unitproduct.UintNameCode = ToInt32(cbUnitName.EditValue);
            db.UnitProduct.Add(unitproduct);
            db.SaveChanges();
            Getunitbyproduct();

        }
        private void btnSaveUnit_Click(object sender, EventArgs e)
        {
            addunittoproduct();
            Sett.MsgGreen("اضافه وحده", "تمت الاضافه بنجاح");

        }

        private void dgvProductList_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            cbStore.EditValue = ToInt32(dgvProductList.GetFocusedRowCellValue(colStoreCode));
            cbCategory.EditValue = ToInt32(dgvProductList.GetFocusedRowCellValue(colCategreCode));
            txtProductCode.EditValue = ToInt32(dgvProductList.GetFocusedRowCellValue(colProductCode));

            txtProductName.Text = dgvProductList.GetFocusedRowCellValue(colProductName).ToString();
            cbProductType.EditValue = dgvProductList.GetFocusedRowCellValue(colIsTypeName);
            txtDiscount.EditValue = ToInt32(dgvProductList.GetFocusedRowCellValue(colDescount));
            txtTax.EditValue = ToInt32(dgvProductList.GetFocusedRowCellValue(colTax));
            chActive.Checked = ToBoolean(dgvProductList.GetFocusedRowCellValue(colIsActive));
            ADD = false;

        }

        private void repounitdeleate_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)

        {
            if (XtraMessageBox.Show("هل أنت متأكد من الحذف", "الحذف"
            , MessageBoxButtons.YesNo, MessageBoxIcon.Question)
             == DialogResult.Yes)
            {
                code = ToInt32(dgvUnitList.GetFocusedRowCellValue(colunitid));
                UnitProduct unitProduct = db.UnitProduct.Where(x => x.Id == code).FirstOrDefault();
                db.UnitProduct.Remove(unitProduct);
                db.SaveChanges();
                Getunitbyproduct();
                base.Delete();
            }
            else
            {
                // MessageBox.Show("تم التراجع عن الحذف");
                Sett.MsgGreen("تراجع", "تم التراجع عن الحذف");

            }
        }
            void Clcl()
            {
                Double x = 0;
                for (int i = 0; i < dgvProductList.RowCount; i++)
                {
                    x += ToDouble(dgvProductList.GetRowCellValue(i,colQyt));
                }
                txttotqyt.Text = x.ToString();

            }

        private void cbUnitName_EditValueChanged(object sender, EventArgs e)
        {

        }
    }


    }




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
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Convert;
using static System.Runtime.CompilerServices.RuntimeHelpers;


namespace EsayAccount.ModelStore
{
    public partial class FrmCustmerSuplier : FrmMaster
    {
        EasyAccount22Context db = new EasyAccount22Context();
        int code;

        public FrmCustmerSuplier()
        {
            InitializeComponent();
        }

        private void FrmCustmerSuplier_Load(object sender, EventArgs e)
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
                code = db.CustmerSuplier.Max(x => x.Code);
            }
            catch (Exception)
            {

                return code;
            }
            return code;
        }
        public override void New()
        {
            txtCodeSubCus.EditValue = maxcode() + 1;
            cbType.ResetText();
            txtName.ResetText();
            txtAdrees.ResetText();
            txtTel1.ResetText();
            txtTel2.ResetText();
            txtAccCode.ResetText();
            ADD = true;
            base.New();

        }
        public override void Getdate()
        {

            CustmerSuplier cus = new CustmerSuplier();
            dgv.DataSource = db.CustmerSuplier
          .Select(x => new { x.Code, x.Name, x.IsType, x.Address, x.Tel1, x.Tel2, x.AccountCode, x.IsActive, IsTypeName = x.IsType == 0 ? "عميل" : "مورد" })
          .ToList();

            base.Getdate();

        }
        public override void Save()
        {
            if (ADD)
            {
                var custmerSuplier = new CustmerSuplier();
                custmerSuplier.Code = ToInt32(txtCodeSubCus.Text);
                custmerSuplier.Name = txtName.Text; 
                custmerSuplier.IsType = cbType.SelectedIndex;
                custmerSuplier.Address = txtAdrees.Text; 
                custmerSuplier.Tel1 = txtTel1.Text; 
                custmerSuplier.Tel2 = txtTel2.Text; 
                custmerSuplier.IsDeleat = false;
                custmerSuplier.IsActive = chActive.Checked;
                custmerSuplier.AccountCode = ToInt32(txtAccCode.Text);
                db.Add(custmerSuplier);
                db.SaveChanges();
                New();
                Getdate();

            }
            base.Save();
        }
    }


}




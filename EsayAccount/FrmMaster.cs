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

namespace EsayAccount
{
    public partial class FrmMaster : DevExpress.XtraEditors.XtraUserControl
    {
       public bool ADD = true;
        public FrmMaster()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();    
        }
        public virtual void New()
        {
            Getdate();
        }
        public virtual void Getdate()
        {

        }
        public virtual void Save()
        {
            if (ADD)
            {
                // INSERT DATA
                Sett.MsgGreen("الاضافه", "تمت الاضافه بنجاح");
            }
            else
            {
                // update DATA
                Sett.MsgBlue("التعديل", "تم التعديل بنجاح");
            }
            Getdate();
        }
        public virtual void print()
        {

        }
        public virtual void Delete()
        {
            Sett.MsgRed("الحذف", "تمت الحذف بنجاح");
            Getdate();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print();
        }

        private void btnLode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Getdate();
        }
    }
}

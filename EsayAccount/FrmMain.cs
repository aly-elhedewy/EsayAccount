using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using EsayAccount.ModelStore;

namespace EsayAccount
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            new FrmLogin().ShowDialog();
        }
        void setTabPage (UserControl formobject,String formtext ,Image image)
        {
            foreach (var item in xtraTabControl1.TabPages.ToList())
            {
                if (item.Text== formtext)
                {
                    xtraTabControl1.SelectedTabPage = item;
                    return;
                }
            }
            xtraTabControl1.TabPages.Add(formtext);
            formobject.Dock = DockStyle.Fill;
            var tc = xtraTabControl1.TabPages.Last();
            tc.Controls.Add(formobject);
            xtraTabControl1.SelectedTabPage= tc;
            xtraTabControl1.SelectedTabPage.ImageOptions.Image = image;

            {

            }
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage != xtraTabControl1.TabPages[0])
            {
                xtraTabControl1.TabPages.Remove(xtraTabControl1.SelectedTabPage);
                xtraTabControl1.SelectedTabPage=xtraTabControl1.TabPages.Last();

            }
            else
            {
                //msg
            }
        }

        private void btnbranch_Click(object sender, EventArgs e)
        {
            FrmBranch frm = new FrmBranch();
            setTabPage(frm, btnbranch.Text, btnbranch.Image);

        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            FrmStore frm = new FrmStore();
            setTabPage(frm, btnStore.Text, btnStore.Image);


        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            new FrmLogin().ShowDialog();



        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            setTabPage(frm, btnProduct.Text, btnProduct.Image);

        }

        private void btnUintName_Click(object sender, EventArgs e)
        {
            FrmUnitName frm = new FrmUnitName();
            setTabPage(frm, btnUintName.Text, btnUintName.Image);

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            setTabPage(frm, btnCategory.Text, btnCategory.Image);

        }

        private void btnCustmSupli_Click(object sender, EventArgs e)
        {
            FrmCustmerSuplier frm = new FrmCustmerSuplier();
            setTabPage(frm, btnCustmSupli.Text, btnCustmSupli.Image);

        }
    }
}

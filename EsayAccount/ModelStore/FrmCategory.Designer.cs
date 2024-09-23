namespace EsayAccount.ModelStore
{
    partial class FrmCategory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategory));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.dgvlist = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColCodeCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNameCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtNameCategory = new DevExpress.XtraEditors.TextEdit();
            this.txtcode = new DevExpress.XtraEditors.SpinEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dgv);
            this.layoutControl1.Controls.Add(this.txtNameCategory);
            this.layoutControl1.Controls.Add(this.txtcode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 39);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(738, 436);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dgv
            // 
            this.dgv.Location = new System.Drawing.Point(24, 51);
            this.dgv.MainView = this.dgvlist;
            this.dgv.Name = "dgv";
            this.dgv.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoEdit});
            this.dgv.Size = new System.Drawing.Size(370, 361);
            this.dgv.TabIndex = 8;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvlist});
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // dgvlist
            // 
            this.dgvlist.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvlist.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dgvlist.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.dgvlist.Appearance.FocusedRow.Options.UseBackColor = true;
            this.dgvlist.Appearance.FocusedRow.Options.UseFont = true;
            this.dgvlist.Appearance.FocusedRow.Options.UseForeColor = true;
            this.dgvlist.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvlist.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvlist.Appearance.Row.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvlist.Appearance.Row.Options.UseFont = true;
            this.dgvlist.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColCodeCategory,
            this.ColNameCategory,
            this.colEdit});
            this.dgvlist.GridControl = this.dgv;
            this.dgvlist.Name = "dgvlist";
            // 
            // ColCodeCategory
            // 
            this.ColCodeCategory.Caption = "الكود";
            this.ColCodeCategory.FieldName = "CodeCategory";
            this.ColCodeCategory.Name = "ColCodeCategory";
            this.ColCodeCategory.OptionsColumn.AllowEdit = false;
            this.ColCodeCategory.Visible = true;
            this.ColCodeCategory.VisibleIndex = 0;
            this.ColCodeCategory.Width = 101;
            // 
            // ColNameCategory
            // 
            this.ColNameCategory.Caption = "اسم الوحده";
            this.ColNameCategory.FieldName = "NameCategory";
            this.ColNameCategory.Name = "ColNameCategory";
            this.ColNameCategory.OptionsColumn.AllowEdit = false;
            this.ColNameCategory.Visible = true;
            this.ColNameCategory.VisibleIndex = 1;
            this.ColNameCategory.Width = 234;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "تعديل";
            this.colEdit.ColumnEdit = this.repoEdit;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 2;
            this.colEdit.Width = 139;
            // 
            // repoEdit
            // 
            this.repoEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repoEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoEdit.Name = "repoEdit";
            this.repoEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(422, 83);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtNameCategory.Properties.Appearance.Options.UseFont = true;
            this.txtNameCategory.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNameCategory.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNameCategory.Size = new System.Drawing.Size(194, 28);
            this.txtNameCategory.StyleController = this.layoutControl1;
            this.txtNameCategory.TabIndex = 6;
            this.txtNameCategory.EditValueChanged += new System.EventHandler(this.txtNameCategory_EditValueChanged);
            // 
            // txtcode
            // 
            this.txtcode.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtcode.Location = new System.Drawing.Point(422, 51);
            this.txtcode.Name = "txtcode";
            this.txtcode.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Properties.Appearance.Options.UseFont = true;
            this.txtcode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtcode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtcode.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtcode.Properties.ReadOnly = true;
            this.txtcode.Size = new System.Drawing.Size(194, 28);
            this.txtcode.StyleController = this.layoutControl1;
            this.txtcode.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(738, 436);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.layoutControlGroup1.AppearanceGroup.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup1.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup1.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(398, 416);
            this.layoutControlGroup1.Text = "معلومات ";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dgv;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(374, 365);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceGroup.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.layoutControlGroup2.AppearanceGroup.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup2.AppearanceGroup.Options.UseBorderColor = true;
            this.layoutControlGroup2.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup2.AppearanceItemCaption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.layoutControlGroup2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(398, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(320, 416);
            this.layoutControlGroup2.Text = "بيانات ";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.txtcode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(296, 32);
            this.layoutControlItem2.Text = "الكود :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(86, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.txtNameCategory;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(296, 333);
            this.layoutControlItem3.Text = "اسم المجموعه:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(86, 19);
            // 
            // FrmCategory
            // 
            this.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmCategory";
            this.Size = new System.Drawing.Size(738, 504);
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvlist;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodeCategory;
        private DevExpress.XtraGrid.Columns.GridColumn ColNameCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoEdit;
        private DevExpress.XtraEditors.TextEdit txtNameCategory;
        private DevExpress.XtraEditors.SpinEdit txtcode;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

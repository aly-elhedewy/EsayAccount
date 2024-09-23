namespace EsayAccount.ModelStore
{
    partial class FrmStore
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStore));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dgv = new DevExpress.XtraGrid.GridControl();
            this.dgvlist = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColCodeStore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameStore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNameBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColBranchCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtcode = new DevExpress.XtraEditors.SpinEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.CbBranch = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dgv);
            this.layoutControl1.Controls.Add(this.txtcode);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.CbBranch);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 65);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(772, 368);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dgv
            // 
            this.dgv.Location = new System.Drawing.Point(24, 51);
            this.dgv.MainView = this.dgvlist;
            this.dgv.Name = "dgv";
            this.dgv.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoEdit});
            this.dgv.Size = new System.Drawing.Size(452, 293);
            this.dgv.TabIndex = 8;
            this.dgv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvlist});
            // 
            // dgvlist
            // 
            this.dgvlist.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dgvlist.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvlist.Appearance.Row.Font = new System.Drawing.Font("Calibri", 12F);
            this.dgvlist.Appearance.Row.Options.UseFont = true;
            this.dgvlist.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColCodeStore,
            this.colNameStore,
            this.ColNameBranch,
            this.ColBranchCode,
            this.colEdit});
            this.dgvlist.GridControl = this.dgv;
            this.dgvlist.Name = "dgvlist";
            // 
            // ColCodeStore
            // 
            this.ColCodeStore.Caption = "كود المخزن";
            this.ColCodeStore.FieldName = "CodeStore";
            this.ColCodeStore.Name = "ColCodeStore";
            this.ColCodeStore.OptionsColumn.AllowEdit = false;
            this.ColCodeStore.Visible = true;
            this.ColCodeStore.VisibleIndex = 0;
            this.ColCodeStore.Width = 80;
            // 
            // colNameStore
            // 
            this.colNameStore.Caption = "اسم المخزن";
            this.colNameStore.FieldName = "NameStore";
            this.colNameStore.Name = "colNameStore";
            this.colNameStore.OptionsColumn.AllowEdit = false;
            this.colNameStore.Visible = true;
            this.colNameStore.VisibleIndex = 1;
            this.colNameStore.Width = 100;
            // 
            // ColNameBranch
            // 
            this.ColNameBranch.Caption = "اسم الفرع";
            this.ColNameBranch.FieldName = "BranchName";
            this.ColNameBranch.Name = "ColNameBranch";
            this.ColNameBranch.Visible = true;
            this.ColNameBranch.VisibleIndex = 2;
            this.ColNameBranch.Width = 96;
            // 
            // ColBranchCode
            // 
            this.ColBranchCode.Caption = "كود الفرع";
            this.ColBranchCode.FieldName = "BranchCode";
            this.ColBranchCode.Name = "ColBranchCode";
            this.ColBranchCode.Visible = true;
            this.ColBranchCode.VisibleIndex = 3;
            this.ColBranchCode.Width = 76;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "تعديل";
            this.colEdit.ColumnEdit = this.repoEdit;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 4;
            this.colEdit.Width = 74;
            // 
            // repoEdit
            // 
            this.repoEdit.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repoEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repoEdit.Name = "repoEdit";
            this.repoEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repoEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoEdit_ButtonClick);
            // 
            // txtcode
            // 
            this.txtcode.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtcode.Location = new System.Drawing.Point(504, 51);
            this.txtcode.Name = "txtcode";
            this.txtcode.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Properties.Appearance.Options.UseFont = true;
            this.txtcode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtcode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtcode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtcode.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtcode.Properties.ReadOnly = true;
            this.txtcode.Size = new System.Drawing.Size(157, 28);
            this.txtcode.StyleController = this.layoutControl1;
            this.txtcode.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(504, 83);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Properties.Appearance.Options.UseTextOptions = true;
            this.txtName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtName.Size = new System.Drawing.Size(157, 28);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 6;
            // 
            // CbBranch
            // 
            this.CbBranch.EditValue = " ";
            this.CbBranch.Location = new System.Drawing.Point(504, 115);
            this.CbBranch.Name = "CbBranch";
            this.CbBranch.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.CbBranch.Properties.Appearance.Options.UseFont = true;
            this.CbBranch.Properties.Appearance.Options.UseTextOptions = true;
            this.CbBranch.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CbBranch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CbBranch.Properties.DisplayMember = "Name";
            this.CbBranch.Properties.NullText = "";
            this.CbBranch.Properties.PopupView = this.gridLookUpEdit1View;
            this.CbBranch.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch;
            this.CbBranch.Properties.ValueMember = "Code";
            this.CbBranch.Size = new System.Drawing.Size(157, 28);
            this.CbBranch.StyleController = this.layoutControl1;
            this.CbBranch.TabIndex = 6;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.FocusedRow.Font = new System.Drawing.Font("Calibri", 12F);
            this.gridLookUpEdit1View.Appearance.FocusedRow.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Calibri", 12F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "كود الفرع";
            this.gridColumn1.FieldName = "Code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 158;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "اسم الفرع";
            this.gridColumn2.FieldName = "Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 526;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1,
            this.layoutControlGroup2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(772, 368);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(480, 348);
            this.layoutControlGroup1.Text = "معلومات ";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dgv;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(456, 297);
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
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(480, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(272, 348);
            this.layoutControlGroup2.Text = "بيانات ";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.txtcode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(248, 32);
            this.layoutControlItem2.Text = "كود المخزن :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 19);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.CbBranch;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(248, 233);
            this.layoutControlItem3.Text = "اسم الفرع :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 19);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.txtName;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopRight;
            this.layoutControlItem1.CustomizationFormText = "اسم المخزن :";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(248, 32);
            this.layoutControlItem1.Text = "اسم المخزن :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 19);
            // 
            // FrmStore
            // 
            this.Appearance.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "FrmStore";
            this.Size = new System.Drawing.Size(772, 462);
            this.Load += new System.EventHandler(this.FrmStore_Load);
            this.Controls.SetChildIndex(this.layoutControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl dgv;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvlist;
        private DevExpress.XtraGrid.Columns.GridColumn ColCodeStore;
        private DevExpress.XtraGrid.Columns.GridColumn colNameStore;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoEdit;
        private DevExpress.XtraEditors.SpinEdit txtcode;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn ColBranchCode;
        private DevExpress.XtraGrid.Columns.GridColumn ColNameBranch;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.GridLookUpEdit CbBranch;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}

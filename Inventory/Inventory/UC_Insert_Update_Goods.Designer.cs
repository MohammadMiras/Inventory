namespace Cactus.Inventory.UI
{
    partial class UC_Insert_Update_Goods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Insert_Update_Goods));
            Janus.Windows.GridEX.GridEXLayout grdCategory_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGoodsWeight = new System.Windows.Forms.Label();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblGoodsCode = new System.Windows.Forms.Label();
            this.txtGoodsCode = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtGoodsName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtGoodsWeight = new Janus.Windows.GridEX.EditControls.EditBox();
            this.cmbUnit = new Janus.Windows.EditControls.UIComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grdCategory = new Janus.Windows.GridEX.GridEX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditCategory = new System.Windows.Forms.ToolStripButton();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.Size = new System.Drawing.Size(443, 356);
            this.tlpMain.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 309);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(437, 44);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(86, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ذخیره";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblGoodsWeight, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblGoodsName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblUnit, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblGoodsCode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtGoodsCode, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtGoodsName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtGoodsWeight, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmbUnit, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(437, 62);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblGoodsWeight
            // 
            this.lblGoodsWeight.AutoSize = true;
            this.lblGoodsWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGoodsWeight.Location = new System.Drawing.Point(200, 0);
            this.lblGoodsWeight.Name = "lblGoodsWeight";
            this.lblGoodsWeight.Size = new System.Drawing.Size(54, 30);
            this.lblGoodsWeight.TabIndex = 4;
            this.lblGoodsWeight.Text = "وزن  کالا";
            this.lblGoodsWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGoodsName.Location = new System.Drawing.Point(380, 30);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Size = new System.Drawing.Size(54, 27);
            this.lblGoodsName.TabIndex = 2;
            this.lblGoodsName.Text = "نام کالا";
            this.lblGoodsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnit.Location = new System.Drawing.Point(200, 30);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(54, 27);
            this.lblUnit.TabIndex = 6;
            this.lblUnit.Text = "واحد ";
            // 
            // lblGoodsCode
            // 
            this.lblGoodsCode.AutoSize = true;
            this.lblGoodsCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGoodsCode.Location = new System.Drawing.Point(380, 0);
            this.lblGoodsCode.Name = "lblGoodsCode";
            this.lblGoodsCode.Size = new System.Drawing.Size(54, 30);
            this.lblGoodsCode.TabIndex = 1;
            this.lblGoodsCode.Text = "کد کالا";
            this.lblGoodsCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGoodsCode
            // 
            this.txtGoodsCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGoodsCode.Location = new System.Drawing.Point(260, 3);
            this.txtGoodsCode.Name = "txtGoodsCode";
            this.txtGoodsCode.Size = new System.Drawing.Size(114, 22);
            this.txtGoodsCode.TabIndex = 1;
            this.txtGoodsCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtGoodsCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodeContact_txtNationalCode_KeyPress);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGoodsName.Location = new System.Drawing.Point(260, 33);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(114, 22);
            this.txtGoodsName.TabIndex = 3;
            this.txtGoodsName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtGoodsWeight
            // 
            this.txtGoodsWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGoodsWeight.Location = new System.Drawing.Point(80, 3);
            this.txtGoodsWeight.Name = "txtGoodsWeight";
            this.txtGoodsWeight.Size = new System.Drawing.Size(114, 22);
            this.txtGoodsWeight.TabIndex = 5;
            this.txtGoodsWeight.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtGoodsWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGoodsWeight_KeyPress);
            // 
            // cmbUnit
            // 
            this.cmbUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbUnit.Location = new System.Drawing.Point(80, 33);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(114, 21);
            this.cmbUnit.TabIndex = 7;
            this.cmbUnit.Text = "...انتخاب....";
            this.cmbUnit.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.cmbUnit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.cmbUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.grdCategory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(437, 232);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // grdCategory
            // 
            this.grdCategory.AlternatingColors = true;
            this.grdCategory.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdCategory.AlternatingRowFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque;
            this.grdCategory.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdCategory.ColumnAutoResize = true;
            grdCategory_DesignTimeLayout.LayoutString = resources.GetString("grdCategory_DesignTimeLayout.LayoutString");
            this.grdCategory.DesignTimeLayout = grdCategory_DesignTimeLayout;
            this.grdCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCategory.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCategory.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCategory.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdCategory.GroupByBoxVisible = false;
            this.grdCategory.Location = new System.Drawing.Point(3, 28);
            this.grdCategory.Name = "grdCategory";
            this.grdCategory.Size = new System.Drawing.Size(431, 201);
            this.grdCategory.TabIndex = 2;
            this.grdCategory.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdCategory.TabStop = false;
            this.grdCategory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdCategory.CellValueChanged += new Janus.Windows.GridEX.ColumnActionEventHandler(this.GrdCategory_CellValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewCategory,
            this.toolStripSeparator2,
            this.btnDeleteCategory,
            this.toolStripSeparator1,
            this.btnEditCategory});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(437, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCategory.Image")));
            this.btnNewCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(23, 22);
            this.btnNewCategory.Text = "افزودن دسته بندی";
            this.btnNewCategory.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewCategory.Click += new System.EventHandler(this.BtnAddCategory_ButtonClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.Image")));
            this.btnDeleteCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteCategory.Text = "حذف دسته بندی ";
            this.btnDeleteCategory.Click += new System.EventHandler(this.DeleteCategory_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnEditCategory.Image")));
            this.btnEditCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(23, 22);
            this.btnEditCategory.Text = "ویرایش ذسته بندی ";
            this.btnEditCategory.Click += new System.EventHandler(this.BtnEditCategory_Click);
            // 
            // UC_Insert_Update_Goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Insert_Update_Goods";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(443, 356);
            this.Load += new System.EventHandler(this.UC_Insert_Update_Goods_Load);
            this.tlpMain.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategory)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label lblGoodsCode;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.Label lblGoodsWeight;
        private Janus.Windows.GridEX.EditControls.EditBox txtGoodsCode;
        private Janus.Windows.GridEX.EditControls.EditBox txtGoodsName;
        private Janus.Windows.GridEX.EditControls.EditBox txtGoodsWeight;
        private Janus.Windows.GridEX.GridEX grdCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Janus.Windows.EditControls.UIButton btnSave;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDeleteCategory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEditCategory;
        private System.Windows.Forms.Label lblUnit;
        private Janus.Windows.EditControls.UIComboBox cmbUnit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

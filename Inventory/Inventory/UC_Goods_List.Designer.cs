namespace Cactus.Inventory.UI
{
    partial class UC_Goods_List
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Goods_List));
            Janus.Windows.GridEX.GridEXLayout grdGoods_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new Janus.Windows.EditControls.UIButton();
            this.btnUpdate = new Janus.Windows.EditControls.UIButton();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.btnResat = new Janus.Windows.EditControls.UIButton();
            this.btnConfirmation = new Janus.Windows.EditControls.UIButton();
            this.btnRemove = new Janus.Windows.EditControls.UIButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGoodsCode = new System.Windows.Forms.Label();
            this.txtGoodsCode = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtGoodsName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grdGoods = new Janus.Windows.GridEX.GridEX();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Separator0 = new System.Windows.Forms.ToolStripSeparator();
            this.INew = new System.Windows.Forms.ToolStripMenuItem();
            this.Speraator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Iedit = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.IDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpMain.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGoods)).BeginInit();
            this.cmsGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 815F));
            this.tlpMain.Controls.Add(this.tlpFooter, 0, 2);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpMain.Size = new System.Drawing.Size(815, 393);
            this.tlpMain.TabIndex = 1;
            // 
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 7;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Controls.Add(this.btnNew, 0, 0);
            this.tlpFooter.Controls.Add(this.btnUpdate, 1, 0);
            this.tlpFooter.Controls.Add(this.btnSearch, 3, 0);
            this.tlpFooter.Controls.Add(this.btnResat, 4, 0);
            this.tlpFooter.Controls.Add(this.btnConfirmation, 5, 0);
            this.tlpFooter.Controls.Add(this.btnRemove, 2, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(3, 333);
            this.tlpFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(809, 56);
            this.tlpFooter.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNew.Location = new System.Drawing.Point(690, 4);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(116, 48);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جدید";
            this.btnNew.ToolTipText = "F5";
            this.btnNew.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdate.Location = new System.Drawing.Point(568, 4);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 48);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.ToolTipText = "F6";
            this.btnUpdate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Location = new System.Drawing.Point(324, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 48);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.ToolTipText = "F8";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnResat
            // 
            this.btnResat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResat.Image = ((System.Drawing.Image)(resources.GetObject("btnResat.Image")));
            this.btnResat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnResat.Location = new System.Drawing.Point(202, 4);
            this.btnResat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResat.Name = "btnResat";
            this.btnResat.Size = new System.Drawing.Size(116, 48);
            this.btnResat.TabIndex = 4;
            this.btnResat.Text = "بروزرسانی";
            this.btnResat.ToolTipText = "F9";
            this.btnResat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnResat.Click += new System.EventHandler(this.BtnResat_Click);
            // 
            // btnConfirmation
            // 
            this.btnConfirmation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmation.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmation.Image")));
            this.btnConfirmation.ImageSize = new System.Drawing.Size(25, 25);
            this.btnConfirmation.Location = new System.Drawing.Point(80, 4);
            this.btnConfirmation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(116, 48);
            this.btnConfirmation.TabIndex = 4;
            this.btnConfirmation.Text = "تایید ";
            this.btnConfirmation.ToolTipText = "F12";
            this.btnConfirmation.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnConfirmation.Click += new System.EventHandler(this.BtnConfirmation_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRemove.Location = new System.Drawing.Point(446, 4);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(116, 48);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "حذف ";
            this.btnRemove.ToolTipText = "F7";
            this.btnRemove.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnRemove.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblGoodsCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGoodsCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGoodsName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblGoodsName, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 36);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblGoodsCode
            // 
            this.lblGoodsCode.AutoSize = true;
            this.lblGoodsCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGoodsCode.Location = new System.Drawing.Point(736, 0);
            this.lblGoodsCode.Name = "lblGoodsCode";
            this.lblGoodsCode.Size = new System.Drawing.Size(70, 36);
            this.lblGoodsCode.TabIndex = 0;
            this.lblGoodsCode.Text = "کد کالا";
            this.lblGoodsCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGoodsCode
            // 
            this.txtGoodsCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGoodsCode.Location = new System.Drawing.Point(589, 4);
            this.txtGoodsCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGoodsCode.Name = "txtGoodsCode";
            this.txtGoodsCode.Size = new System.Drawing.Size(141, 23);
            this.txtGoodsCode.TabIndex = 0;
            this.txtGoodsCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtGoodsCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventEnteringNumberInTextBox_KeyPress);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGoodsName.Location = new System.Drawing.Point(372, 4);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(132, 23);
            this.txtGoodsName.TabIndex = 1;
            this.txtGoodsName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGoodsName.Location = new System.Drawing.Point(510, 0);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Size = new System.Drawing.Size(73, 36);
            this.lblGoodsName.TabIndex = 1;
            this.lblGoodsName.Text = "نام کالا";
            this.lblGoodsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.grdGoods, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(809, 277);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // grdGoods
            // 
            this.grdGoods.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdGoods.AlternatingColors = true;
            this.grdGoods.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdGoods.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdGoods.ColumnAutoResize = true;
            this.grdGoods.ContextMenuStrip = this.cmsGrid;
            grdGoods_DesignTimeLayout.LayoutString = resources.GetString("grdGoods_DesignTimeLayout.LayoutString");
            this.grdGoods.DesignTimeLayout = grdGoods_DesignTimeLayout;
            this.grdGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGoods.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdGoods.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdGoods.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdGoods.GroupByBoxVisible = false;
            this.grdGoods.Location = new System.Drawing.Point(3, 16);
            this.grdGoods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdGoods.Name = "grdGoods";
            this.grdGoods.Size = new System.Drawing.Size(803, 257);
            this.grdGoods.TabIndex = 2;
            this.grdGoods.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdGoods.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdGoods.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.GrdGoods_RowDoubleClick);
            this.grdGoods.CellValueChanged += new Janus.Windows.GridEX.ColumnActionEventHandler(this.GrdGoods_CellValueChanged);
            // 
            // cmsGrid
            // 
            this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator0,
            this.INew,
            this.Speraator1,
            this.Iedit,
            this.Separator2,
            this.IDelete});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsGrid.Size = new System.Drawing.Size(130, 88);
            // 
            // Separator0
            // 
            this.Separator0.Name = "Separator0";
            this.Separator0.Size = new System.Drawing.Size(126, 6);
            // 
            // INew
            // 
            this.INew.Image = ((System.Drawing.Image)(resources.GetObject("INew.Image")));
            this.INew.Name = "INew";
            this.INew.Size = new System.Drawing.Size(129, 22);
            this.INew.Text = "افزودن ";
            this.INew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // Speraator1
            // 
            this.Speraator1.Name = "Speraator1";
            this.Speraator1.Size = new System.Drawing.Size(126, 6);
            // 
            // Iedit
            // 
            this.Iedit.Image = ((System.Drawing.Image)(resources.GetObject("Iedit.Image")));
            this.Iedit.Name = "Iedit";
            this.Iedit.Size = new System.Drawing.Size(129, 22);
            this.Iedit.Text = "ویرایش";
            this.Iedit.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(126, 6);
            // 
            // IDelete
            // 
            this.IDelete.Image = ((System.Drawing.Image)(resources.GetObject("IDelete.Image")));
            this.IDelete.Name = "IDelete";
            this.IDelete.Size = new System.Drawing.Size(129, 22);
            this.IDelete.Text = "حذف کردن ";
            this.IDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // UC_Goods_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Goods_List";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(815, 393);
            this.Load += new System.EventHandler(this.UC_Goods_List_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpFooter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGoods)).EndInit();
            this.cmsGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGoodsCode;
        private Janus.Windows.GridEX.EditControls.EditBox txtGoodsCode;
        private Janus.Windows.GridEX.EditControls.EditBox txtGoodsName;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Janus.Windows.GridEX.GridEX grdGoods;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private Janus.Windows.EditControls.UIButton btnNew;
        private Janus.Windows.EditControls.UIButton btnUpdate;
        private Janus.Windows.EditControls.UIButton btnRemove;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIButton btnResat;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripSeparator Separator0;
        private System.Windows.Forms.ToolStripMenuItem INew;
        private System.Windows.Forms.ToolStripSeparator Speraator1;
        private System.Windows.Forms.ToolStripMenuItem Iedit;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripMenuItem IDelete;
        private Janus.Windows.EditControls.UIButton btnConfirmation;
    }
}

namespace Cactus.Inventory.UI
{
    partial class UC_Transaction_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Transaction_List));
            Janus.Windows.GridEX.GridEXLayout grdTransaction_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodeOrder = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.Label();
            this.lblUntilDate = new System.Windows.Forms.Label();
            this.txtNumber = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtCustomer = new Janus.Windows.GridEX.EditControls.EditBox();
            this.btnSelectCustomer = new Janus.Windows.EditControls.UIButton();
            this.lblInventory = new System.Windows.Forms.Label();
            this.cmbInventory = new Janus.Windows.EditControls.UIComboBox();
            this.txtFromDate = new Janus.Windows.GridEX.EditControls.MaskedEditBox();
            this.txtUntilDate = new Janus.Windows.GridEX.EditControls.MaskedEditBox();
            this.tblFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new Janus.Windows.EditControls.UIButton();
            this.btnUpdate = new Janus.Windows.EditControls.UIButton();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            this.btnPrint = new Janus.Windows.EditControls.UIButton();
            this.btnResat = new Janus.Windows.EditControls.UIButton();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.grdTransaction = new Janus.Windows.GridEX.GridEX();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Separator0 = new System.Windows.Forms.ToolStripSeparator();
            this.INew = new System.Windows.Forms.ToolStripMenuItem();
            this.Speraator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Iedit = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.IDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tot = new Janus.Windows.Common.JanusSuperTip(this.components);
            this.tlpMain.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.tblFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaction)).BeginInit();
            this.cmsGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpMain.Controls.Add(this.tblFooter, 0, 2);
            this.tlpMain.Controls.Add(this.grdTransaction, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpMain.Size = new System.Drawing.Size(808, 444);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 8;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Controls.Add(this.lblCodeOrder, 0, 0);
            this.tlpHeader.Controls.Add(this.lblCustomer, 0, 1);
            this.tlpHeader.Controls.Add(this.FromDate, 3, 0);
            this.tlpHeader.Controls.Add(this.lblUntilDate, 3, 1);
            this.tlpHeader.Controls.Add(this.txtNumber, 1, 0);
            this.tlpHeader.Controls.Add(this.txtCustomer, 1, 1);
            this.tlpHeader.Controls.Add(this.btnSelectCustomer, 2, 1);
            this.tlpHeader.Controls.Add(this.lblInventory, 5, 0);
            this.tlpHeader.Controls.Add(this.cmbInventory, 6, 0);
            this.tlpHeader.Controls.Add(this.txtFromDate, 4, 0);
            this.tlpHeader.Controls.Add(this.txtUntilDate, 4, 1);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 2;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
            this.tlpHeader.Size = new System.Drawing.Size(802, 53);
            this.tlpHeader.TabIndex = 0;
            // 
            // lblCodeOrder
            // 
            this.lblCodeOrder.AutoSize = true;
            this.lblCodeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodeOrder.Location = new System.Drawing.Point(720, 0);
            this.lblCodeOrder.Name = "lblCodeOrder";
            this.lblCodeOrder.Size = new System.Drawing.Size(79, 27);
            this.lblCodeOrder.TabIndex = 0;
            this.lblCodeOrder.Text = "کد سفارش";
            this.lblCodeOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.Location = new System.Drawing.Point(720, 27);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(79, 26);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "مشتری";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FromDate
            // 
            this.FromDate.AutoSize = true;
            this.FromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FromDate.Location = new System.Drawing.Point(500, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(55, 27);
            this.FromDate.TabIndex = 5;
            this.FromDate.Text = "از تاریخ";
            this.FromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUntilDate
            // 
            this.lblUntilDate.AutoSize = true;
            this.lblUntilDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUntilDate.Location = new System.Drawing.Point(500, 27);
            this.lblUntilDate.Name = "lblUntilDate";
            this.lblUntilDate.Size = new System.Drawing.Size(55, 26);
            this.lblUntilDate.TabIndex = 6;
            this.lblUntilDate.Text = "تا تاریخ";
            this.lblUntilDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumber
            // 
            this.txtNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(590, 3);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(124, 22);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodeContact_txtNationalCode_KeyPress);
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(99)))));
            this.txtCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(590, 30);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(124, 22);
            this.txtCustomer.TabIndex = 3;
            this.txtCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectCustomer.Image")));
            this.btnSelectCustomer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectCustomer.Location = new System.Drawing.Point(561, 30);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(23, 20);
            this.btnSelectCustomer.TabIndex = 4;
            this.btnSelectCustomer.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelectCustomer.Click += new System.EventHandler(this.BtnSelectCustomer_Click);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInventory.Location = new System.Drawing.Point(309, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(55, 27);
            this.lblInventory.TabIndex = 9;
            this.lblInventory.Text = "انبار";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbInventory
            // 
            this.cmbInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbInventory.Location = new System.Drawing.Point(179, 3);
            this.cmbInventory.Name = "cmbInventory";
            this.cmbInventory.Size = new System.Drawing.Size(124, 21);
            this.cmbInventory.TabIndex = 10;
            this.cmbInventory.Text = "....انتخاب...";
            this.cmbInventory.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.cmbInventory.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cmbInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbInventory_KeyPress);
            // 
            // txtFromDate
            // 
            this.txtFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFromDate.Location = new System.Drawing.Point(370, 3);
            this.txtFromDate.Mask = "0000/00/00";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(124, 22);
            this.txtFromDate.TabIndex = 11;
            // 
            // txtUntilDate
            // 
            this.txtUntilDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUntilDate.Location = new System.Drawing.Point(370, 30);
            this.txtUntilDate.Mask = "0000/00/00";
            this.txtUntilDate.MaxLength = 8;
            this.txtUntilDate.Name = "txtUntilDate";
            this.txtUntilDate.Size = new System.Drawing.Size(124, 22);
            this.txtUntilDate.TabIndex = 12;
            // 
            // tblFooter
            // 
            this.tblFooter.ColumnCount = 7;
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Controls.Add(this.btnNew, 0, 0);
            this.tblFooter.Controls.Add(this.btnUpdate, 1, 0);
            this.tblFooter.Controls.Add(this.btnDelete, 2, 0);
            this.tblFooter.Controls.Add(this.btnPrint, 3, 0);
            this.tblFooter.Controls.Add(this.btnResat, 5, 0);
            this.tblFooter.Controls.Add(this.btnSearch, 4, 0);
            this.tblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFooter.Location = new System.Drawing.Point(3, 383);
            this.tblFooter.Name = "tblFooter";
            this.tblFooter.RowCount = 1;
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Size = new System.Drawing.Size(802, 58);
            this.tblFooter.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNew.Location = new System.Drawing.Point(683, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(116, 52);
            this.btnNew.TabIndex = 0;
            this.btnNew.Tag = "";
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
            this.btnUpdate.Location = new System.Drawing.Point(561, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 52);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.ToolTipText = "F6";
            this.btnUpdate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(439, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 52);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.ToolTipText = "F7";
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrint.Location = new System.Drawing.Point(317, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 52);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.ToolTipText = "Ctrl + P";
            this.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnResat
            // 
            this.btnResat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResat.Image = ((System.Drawing.Image)(resources.GetObject("btnResat.Image")));
            this.btnResat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnResat.Location = new System.Drawing.Point(73, 3);
            this.btnResat.Name = "btnResat";
            this.btnResat.Size = new System.Drawing.Size(116, 52);
            this.btnResat.TabIndex = 5;
            this.btnResat.Text = "بروزرسانی";
            this.btnResat.ToolTipText = "F9";
            this.btnResat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnResat.Click += new System.EventHandler(this.BtnResat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Location = new System.Drawing.Point(195, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 52);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.ToolTipText = "F8";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // grdTransaction
            // 
            this.grdTransaction.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdTransaction.AlternatingColors = true;
            this.grdTransaction.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdTransaction.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdTransaction.ColumnAutoResize = true;
            this.grdTransaction.ContextMenuStrip = this.cmsGrid;
            grdTransaction_DesignTimeLayout.LayoutString = resources.GetString("grdTransaction_DesignTimeLayout.LayoutString");
            this.grdTransaction.DesignTimeLayout = grdTransaction_DesignTimeLayout;
            this.grdTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTransaction.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdTransaction.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdTransaction.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdTransaction.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTransaction.GroupByBoxVisible = false;
            this.grdTransaction.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Empty;
            this.grdTransaction.HeaderFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdTransaction.HeaderFormatStyle.FontSize = 10F;
            this.grdTransaction.Location = new System.Drawing.Point(3, 62);
            this.grdTransaction.Name = "grdTransaction";
            this.grdTransaction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdTransaction.RowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid;
            this.grdTransaction.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdTransaction.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdTransaction.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdTransaction.Size = new System.Drawing.Size(802, 315);
            this.grdTransaction.TabIndex = 0;
            this.grdTransaction.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdTransaction.TabStop = false;
            this.grdTransaction.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // cmsGrid
            // 
            this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator0,
            this.INew,
            this.Speraator1,
            this.Iedit,
            this.Separator2,
            this.IDelete,
            this.toolStripSeparator1,
            this.tsmiPrint});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsGrid.Size = new System.Drawing.Size(130, 116);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsmiPrint.Image")));
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.Size = new System.Drawing.Size(129, 22);
            this.tsmiPrint.Text = "چاپ";
            this.tsmiPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // tot
            // 
            this.tot.AutoPopDelay = 2000;
            this.tot.ForeColor = System.Drawing.Color.Red;
            this.tot.ImageList = null;
            // 
            // UC_Transaction_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "UC_Transaction_List";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(808, 444);
            this.Load += new System.EventHandler(this.UC_Transaction_List_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.tblFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaction)).EndInit();
            this.cmsGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label lblCodeOrder;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label FromDate;
        private System.Windows.Forms.Label lblUntilDate;
        private Janus.Windows.GridEX.EditControls.EditBox txtNumber;
        private Janus.Windows.GridEX.EditControls.EditBox txtCustomer;
        private System.Windows.Forms.TableLayoutPanel tblFooter;
        private Janus.Windows.EditControls.UIButton btnNew;
        private Janus.Windows.EditControls.UIButton btnUpdate;
        private Janus.Windows.EditControls.UIButton btnDelete;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIButton btnResat;
        private Janus.Windows.EditControls.UIButton btnSelectCustomer;
        private Janus.Windows.GridEX.GridEX grdTransaction;
        private System.Windows.Forms.Label lblInventory;
        private Janus.Windows.EditControls.UIComboBox cmbInventory;
        private Janus.Windows.EditControls.UIButton btnPrint;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripSeparator Separator0;
        private System.Windows.Forms.ToolStripMenuItem INew;
        private System.Windows.Forms.ToolStripSeparator Speraator1;
        private System.Windows.Forms.ToolStripMenuItem Iedit;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripMenuItem IDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private Janus.Windows.GridEX.EditControls.MaskedEditBox txtFromDate;
        private Janus.Windows.GridEX.EditControls.MaskedEditBox txtUntilDate;
        private Janus.Windows.Common.JanusSuperTip tot;
    }
}

namespace Cactus.Inventory.UI
{
    partial class UC_Transaction_Insert_Update
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
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Transaction_Insert_Update));
            Janus.Windows.GridEX.GridEXLayout grdTransactionDetail_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpHader = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.txtNumber = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtCustomer = new Janus.Windows.GridEX.EditControls.EditBox();
            this.cmbInventory = new Janus.Windows.EditControls.UIComboBox();
            this.cmbTransactionType = new Janus.Windows.EditControls.UIComboBox();
            this.btnSelectCutomer = new Janus.Windows.EditControls.UIButton();
            this.txtData = new Janus.Windows.GridEX.EditControls.MaskedEditBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grdTransactionDetail = new Janus.Windows.GridEX.GridEX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tsPhone = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCalculations = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.btnResat = new Janus.Windows.EditControls.UIButton();
            this.tlpMain.SuspendLayout();
            this.tlpHader.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionDetail)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tsPhone.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpMain.Controls.Add(this.tlpHader, 0, 0);
            this.tlpMain.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tlpMain.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.Size = new System.Drawing.Size(654, 430);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpHader
            // 
            this.tlpHader.ColumnCount = 8;
            this.tlpHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tlpHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tlpHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHader.Controls.Add(this.lblNumber, 0, 0);
            this.tlpHader.Controls.Add(this.lblInventory, 3, 0);
            this.tlpHader.Controls.Add(this.lblDate, 5, 0);
            this.tlpHader.Controls.Add(this.label5, 0, 1);
            this.tlpHader.Controls.Add(this.lblTransactionType, 3, 1);
            this.tlpHader.Controls.Add(this.txtNumber, 1, 0);
            this.tlpHader.Controls.Add(this.txtCustomer, 1, 1);
            this.tlpHader.Controls.Add(this.cmbInventory, 4, 0);
            this.tlpHader.Controls.Add(this.cmbTransactionType, 4, 1);
            this.tlpHader.Controls.Add(this.btnSelectCutomer, 2, 1);
            this.tlpHader.Controls.Add(this.txtData, 6, 0);
            this.tlpHader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHader.Location = new System.Drawing.Point(3, 3);
            this.tlpHader.Name = "tlpHader";
            this.tlpHader.RowCount = 2;
            this.tlpHader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.tlpHader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tlpHader.Size = new System.Drawing.Size(648, 52);
            this.tlpHader.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumber.Location = new System.Drawing.Point(554, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(91, 26);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "شماره سفارش";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInventory.Location = new System.Drawing.Point(325, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(66, 26);
            this.lblInventory.TabIndex = 2;
            this.lblInventory.Text = "انبار";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(137, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 26);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "تاریخ";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(554, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "طرف حساب";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTransactionType.Location = new System.Drawing.Point(325, 26);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(66, 26);
            this.lblTransactionType.TabIndex = 5;
            this.lblTransactionType.Text = "نوع فاکتور";
            this.lblTransactionType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNumber
            // 
            this.txtNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumber.Location = new System.Drawing.Point(432, 3);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(116, 22);
            this.txtNumber.TabIndex = 6;
            this.txtNumber.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodeContact_txtNationalCode_KeyPress);
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(204)))), ((int)(((byte)(99)))));
            this.txtCustomer.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Flat;
            this.txtCustomer.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtCustomer.DisabledForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomer.FlatBorderColor = System.Drawing.Color.Gray;
            this.txtCustomer.Location = new System.Drawing.Point(432, 29);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(116, 22);
            this.txtCustomer.TabIndex = 7;
            this.txtCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodeContact_txtNationalCode_KeyPress);
            // 
            // cmbInventory
            // 
            this.cmbInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbInventory.Location = new System.Drawing.Point(206, 3);
            this.cmbInventory.Name = "cmbInventory";
            this.cmbInventory.Size = new System.Drawing.Size(113, 20);
            this.cmbInventory.TabIndex = 10;
            this.cmbInventory.Text = "...انتخاب انبار...";
            this.cmbInventory.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cmbInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox_KeyPress);
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.Dock = System.Windows.Forms.DockStyle.Fill;
            uiComboBoxItem1.FormatStyle.Alpha = 0;
            uiComboBoxItem1.IsSeparator = false;
            uiComboBoxItem1.Text = "رسید";
            uiComboBoxItem1.Value = 1;
            uiComboBoxItem2.FormatStyle.Alpha = 0;
            uiComboBoxItem2.IsSeparator = false;
            uiComboBoxItem2.Text = "حواله";
            uiComboBoxItem2.Value = 2;
            this.cmbTransactionType.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2});
            this.cmbTransactionType.Location = new System.Drawing.Point(206, 29);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(113, 20);
            this.cmbTransactionType.TabIndex = 10;
            this.cmbTransactionType.Text = "...نوع فاکتور...";
            this.cmbTransactionType.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cmbTransactionType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodeContact_txtNationalCode_KeyPress);
            // 
            // btnSelectCutomer
            // 
            this.btnSelectCutomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectCutomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectCutomer.Image")));
            this.btnSelectCutomer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectCutomer.Location = new System.Drawing.Point(397, 29);
            this.btnSelectCutomer.Name = "btnSelectCutomer";
            this.btnSelectCutomer.Size = new System.Drawing.Size(29, 20);
            this.btnSelectCutomer.TabIndex = 11;
            this.btnSelectCutomer.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Empty;
            this.btnSelectCutomer.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelectCutomer.Click += new System.EventHandler(this.BtnSelectCutomer_Click);
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.Location = new System.Drawing.Point(12, 3);
            this.txtData.Mask = "0000/00/00";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(119, 22);
            this.txtData.TabIndex = 12;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.grdTransactionDetail, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(648, 316);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // grdTransactionDetail
            // 
            this.grdTransactionDetail.AlternatingColors = true;
            this.grdTransactionDetail.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdTransactionDetail.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.grdTransactionDetail.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdTransactionDetail.AutoEdit = true;
            this.grdTransactionDetail.ColumnAutoResize = true;
            grdTransactionDetail_DesignTimeLayout.LayoutString = resources.GetString("grdTransactionDetail_DesignTimeLayout.LayoutString");
            this.grdTransactionDetail.DesignTimeLayout = grdTransactionDetail_DesignTimeLayout;
            this.grdTransactionDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdTransactionDetail.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
            this.grdTransactionDetail.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.grdTransactionDetail.GroupByBoxVisible = false;
            this.grdTransactionDetail.Location = new System.Drawing.Point(3, 35);
            this.grdTransactionDetail.Name = "grdTransactionDetail";
            this.grdTransactionDetail.Size = new System.Drawing.Size(642, 278);
            this.grdTransactionDetail.TabIndex = 2;
            this.grdTransactionDetail.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdTransactionDetail.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdTransactionDetail.RecordUpdated += new System.EventHandler(this.GrdTransactionDetail_RecordUpdated);
            this.grdTransactionDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GrdTransactionDetail_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tsPhone, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 26);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tsPhone
            // 
            this.tsPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsPhone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.toolStripSeparator1,
            this.btnRemove,
            this.toolStripSeparator3,
            this.btnCalculations});
            this.tsPhone.Location = new System.Drawing.Point(0, 0);
            this.tsPhone.Name = "tsPhone";
            this.tsPhone.Size = new System.Drawing.Size(642, 26);
            this.tsPhone.TabIndex = 2;
            this.tsPhone.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 23);
            this.btnAdd.Text = "افزودن ردیف";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // btnRemove
            // 
            this.btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(23, 23);
            this.btnRemove.Text = "حذف ردیف";
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // btnCalculations
            // 
            this.btnCalculations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalculations.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculations.Image")));
            this.btnCalculations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalculations.Name = "btnCalculations";
            this.btnCalculations.Size = new System.Drawing.Size(23, 23);
            this.btnCalculations.Text = "محاسبات";
            this.btnCalculations.Click += new System.EventHandler(this.BtnCalculations_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnResat, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 383);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(648, 44);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(539, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ثبت";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnResat
            // 
            this.btnResat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResat.Image = ((System.Drawing.Image)(resources.GetObject("btnResat.Image")));
            this.btnResat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnResat.Location = new System.Drawing.Point(427, 3);
            this.btnResat.Name = "btnResat";
            this.btnResat.Size = new System.Drawing.Size(106, 38);
            this.btnResat.TabIndex = 1;
            this.btnResat.Text = "بروز رسانی ";
            this.btnResat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnResat.Click += new System.EventHandler(this.BtnResat_Click);
            // 
            // UC_Transaction_Insert_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Transaction_Insert_Update";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(654, 430);
            this.Load += new System.EventHandler(this.UC_Transaction_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpHader.ResumeLayout(false);
            this.tlpHader.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionDetail)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tsPhone.ResumeLayout(false);
            this.tsPhone.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpHader;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTransactionType;
        private Janus.Windows.GridEX.EditControls.EditBox txtNumber;
        private Janus.Windows.GridEX.EditControls.EditBox txtCustomer;
        private Janus.Windows.EditControls.UIComboBox cmbInventory;
        private Janus.Windows.EditControls.UIComboBox cmbTransactionType;
        private Janus.Windows.EditControls.UIButton btnSelectCutomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Janus.Windows.EditControls.UIButton btnSave;
        private Janus.Windows.EditControls.UIButton btnResat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Janus.Windows.GridEX.GridEX grdTransactionDetail;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip tsPhone;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnCalculations;
        private Janus.Windows.GridEX.EditControls.MaskedEditBox txtData;
    }
}

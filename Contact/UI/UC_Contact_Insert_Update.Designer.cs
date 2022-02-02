namespace Cactus.Contact.UI
{
    partial class UC_Contact_Insert_Update
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
            Janus.Windows.GridEX.GridEXLayout grdAddres_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Contact_Insert_Update));
            Janus.Windows.GridEX.GridEXLayout grdphone_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference grdphone_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ValueList.Item0.Image");
            Janus.Windows.Common.Layouts.JanusLayoutReference grdphone_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ValueList.Item1.Image");
            Janus.Windows.Common.Layouts.JanusLayoutReference grdphone_DesignTimeLayout_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ValueList.Item2.Image");
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grdAddres = new Janus.Windows.GridEX.GridEX();
            this.tsPhone = new System.Windows.Forms.ToolStrip();
            this.btnAddPhone = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRemovePhone = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditPhone = new System.Windows.Forms.ToolStripButton();
            this.tsAddres = new System.Windows.Forms.ToolStrip();
            this.btnAddAddres = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.butRemoveAddres = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditAddres = new System.Windows.Forms.ToolStripButton();
            this.grdphone = new Janus.Windows.GridEX.GridEX();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.txtContactCode = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.lblFathername = new System.Windows.Forms.Label();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.tlpFoter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddres)).BeginInit();
            this.tsPhone.SuspendLayout();
            this.tsAddres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdphone)).BeginInit();
            this.tlpHeader.SuspendLayout();
            this.tlpFoter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tlpMain.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpMain.Controls.Add(this.tlpFoter, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpMain.Size = new System.Drawing.Size(786, 325);
            this.tlpMain.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.grdAddres, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tsPhone, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tsAddres, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.grdphone, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(780, 200);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // grdAddres
            // 
            this.grdAddres.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdAddres.AlternatingColors = true;
            this.grdAddres.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdAddres.AlternatingRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.grdAddres.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdAddres.ColumnAutoResize = true;
            grdAddres_DesignTimeLayout.LayoutString = resources.GetString("grdAddres_DesignTimeLayout.LayoutString");
            this.grdAddres.DesignTimeLayout = grdAddres_DesignTimeLayout;
            this.grdAddres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdAddres.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdAddres.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdAddres.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdAddres.GroupByBoxVisible = false;
            this.grdAddres.Location = new System.Drawing.Point(3, 36);
            this.grdAddres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdAddres.Name = "grdAddres";
            this.grdAddres.Size = new System.Drawing.Size(384, 160);
            this.grdAddres.TabIndex = 3;
            this.grdAddres.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdAddres.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdAddres.RecordUpdated += new System.EventHandler(this.GridAddres_RecordUpdated);
            // 
            // tsPhone
            // 
            this.tsPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsPhone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddPhone,
            this.toolStripSeparator1,
            this.btnRemovePhone,
            this.toolStripSeparator3,
            this.btnEditPhone});
            this.tsPhone.Location = new System.Drawing.Point(390, 0);
            this.tsPhone.Name = "tsPhone";
            this.tsPhone.Size = new System.Drawing.Size(390, 32);
            this.tsPhone.TabIndex = 1;
            this.tsPhone.Text = "toolStrip1";
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPhone.Image")));
            this.btnAddPhone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(23, 29);
            this.btnAddPhone.Text = "اضافه کردن تلفن ";
            this.btnAddPhone.Click += new System.EventHandler(this.BtnAddPhone_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // btnRemovePhone
            // 
            this.btnRemovePhone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemovePhone.Image = ((System.Drawing.Image)(resources.GetObject("btnRemovePhone.Image")));
            this.btnRemovePhone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemovePhone.Name = "btnRemovePhone";
            this.btnRemovePhone.Size = new System.Drawing.Size(23, 29);
            this.btnRemovePhone.Text = "حذف تلفن";
            this.btnRemovePhone.Click += new System.EventHandler(this.BtnRemovePhone_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // btnEditPhone
            // 
            this.btnEditPhone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditPhone.Image = ((System.Drawing.Image)(resources.GetObject("btnEditPhone.Image")));
            this.btnEditPhone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditPhone.Name = "btnEditPhone";
            this.btnEditPhone.Size = new System.Drawing.Size(23, 29);
            this.btnEditPhone.Text = "ویرایش لیست تلفن ";
            this.btnEditPhone.Click += new System.EventHandler(this.BtnEditPhone_Click);
            // 
            // tsAddres
            // 
            this.tsAddres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsAddres.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAddres,
            this.toolStripSeparator2,
            this.butRemoveAddres,
            this.toolStripSeparator4,
            this.btnEditAddres});
            this.tsAddres.Location = new System.Drawing.Point(0, 0);
            this.tsAddres.Name = "tsAddres";
            this.tsAddres.Size = new System.Drawing.Size(390, 32);
            this.tsAddres.TabIndex = 3;
            this.tsAddres.Text = "toolStrip2";
            // 
            // btnAddAddres
            // 
            this.btnAddAddres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddAddres.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAddres.Image")));
            this.btnAddAddres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAddres.Name = "btnAddAddres";
            this.btnAddAddres.Size = new System.Drawing.Size(23, 29);
            this.btnAddAddres.Text = "اضافه کردن آدرس ";
            this.btnAddAddres.ToolTipText = "اضافه کردن ";
            this.btnAddAddres.Click += new System.EventHandler(this.BtnAddAddres_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // butRemoveAddres
            // 
            this.butRemoveAddres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.butRemoveAddres.Image = ((System.Drawing.Image)(resources.GetObject("butRemoveAddres.Image")));
            this.butRemoveAddres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.butRemoveAddres.Name = "butRemoveAddres";
            this.butRemoveAddres.Size = new System.Drawing.Size(23, 29);
            this.butRemoveAddres.Text = "حذف کردن";
            this.butRemoveAddres.Click += new System.EventHandler(this.ButRemoveAddres_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // btnEditAddres
            // 
            this.btnEditAddres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditAddres.Image = ((System.Drawing.Image)(resources.GetObject("btnEditAddres.Image")));
            this.btnEditAddres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditAddres.Name = "btnEditAddres";
            this.btnEditAddres.Size = new System.Drawing.Size(23, 29);
            this.btnEditAddres.Text = "ویرایش لیست ادرس";
            this.btnEditAddres.Click += new System.EventHandler(this.BtnEditAddres_Click);
            // 
            // grdphone
            // 
            this.grdphone.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdphone.AlternatingColors = true;
            this.grdphone.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdphone.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdphone.ColumnAutoResize = true;
            grdphone_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("grdphone_DesignTimeLayout_Reference_0.Instance")));
            grdphone_DesignTimeLayout_Reference_1.Instance = ((object)(resources.GetObject("grdphone_DesignTimeLayout_Reference_1.Instance")));
            grdphone_DesignTimeLayout_Reference_2.Instance = ((object)(resources.GetObject("grdphone_DesignTimeLayout_Reference_2.Instance")));
            grdphone_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            grdphone_DesignTimeLayout_Reference_0,
            grdphone_DesignTimeLayout_Reference_1,
            grdphone_DesignTimeLayout_Reference_2});
            grdphone_DesignTimeLayout.LayoutString = resources.GetString("grdphone_DesignTimeLayout.LayoutString");
            this.grdphone.DesignTimeLayout = grdphone_DesignTimeLayout;
            this.grdphone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdphone.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdphone.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdphone.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdphone.GroupByBoxVisible = false;
            this.grdphone.Location = new System.Drawing.Point(393, 36);
            this.grdphone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdphone.Name = "grdphone";
            this.grdphone.Size = new System.Drawing.Size(384, 160);
            this.grdphone.TabIndex = 2;
            this.grdphone.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdphone.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdphone.RecordUpdated += new System.EventHandler(this.Gridphone_RecordUpdated);
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 7;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Controls.Add(this.lblCustomerCode, 0, 0);
            this.tlpHeader.Controls.Add(this.txtContactCode, 1, 0);
            this.tlpHeader.Controls.Add(this.txtFirstName, 3, 0);
            this.tlpHeader.Controls.Add(this.lblFirstName, 2, 0);
            this.tlpHeader.Controls.Add(this.txtLastName, 3, 1);
            this.tlpHeader.Controls.Add(this.lblLastName, 2, 1);
            this.tlpHeader.Controls.Add(this.txtFatherName, 5, 0);
            this.tlpHeader.Controls.Add(this.lblFathername, 4, 0);
            this.tlpHeader.Controls.Add(this.lblNationalCode, 0, 1);
            this.tlpHeader.Controls.Add(this.txtNationalCode, 1, 1);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 2;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpHeader.Size = new System.Drawing.Size(780, 63);
            this.tlpHeader.TabIndex = 0;
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerCode.Location = new System.Drawing.Point(697, 0);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(80, 31);
            this.lblCustomerCode.TabIndex = 0;
            this.lblCustomerCode.Text = "کد شخص";
            this.lblCustomerCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContactCode
            // 
            this.txtContactCode.Location = new System.Drawing.Point(572, 3);
            this.txtContactCode.MaxLength = 4;
            this.txtContactCode.Multiline = true;
            this.txtContactCode.Name = "txtContactCode";
            this.txtContactCode.Size = new System.Drawing.Size(119, 25);
            this.txtContactCode.TabIndex = 1;
            this.txtContactCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodeContact_txtNationalCode_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(348, 4);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.MaxLength = 250;
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(119, 23);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NO_Number_Enter_KeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.Location = new System.Drawing.Point(473, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(93, 31);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "نام  ";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(348, 35);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.MaxLength = 250;
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(119, 23);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NO_Number_Enter_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastName.Location = new System.Drawing.Point(473, 31);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(93, 32);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "نام خانوادگی  ";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(147, 4);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFatherName.MaxLength = 50;
            this.txtFatherName.Multiline = true;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(119, 23);
            this.txtFatherName.TabIndex = 4;
            this.txtFatherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NO_Number_Enter_KeyPress);
            // 
            // lblFathername
            // 
            this.lblFathername.AutoSize = true;
            this.lblFathername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFathername.Location = new System.Drawing.Point(272, 0);
            this.lblFathername.Name = "lblFathername";
            this.lblFathername.Size = new System.Drawing.Size(70, 31);
            this.lblFathername.TabIndex = 0;
            this.lblFathername.Text = "نام پدر  ";
            this.lblFathername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNationalCode.Location = new System.Drawing.Point(697, 31);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(80, 32);
            this.lblNationalCode.TabIndex = 0;
            this.lblNationalCode.Text = "کد ملی ";
            this.lblNationalCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNationalCode.Location = new System.Drawing.Point(572, 35);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationalCode.MaxLength = 50;
            this.txtNationalCode.Multiline = true;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(119, 24);
            this.txtNationalCode.TabIndex = 5;
            this.txtNationalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodeContact_txtNationalCode_KeyPress);
            // 
            // tlpFoter
            // 
            this.tlpFoter.ColumnCount = 2;
            this.tlpFoter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFoter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFoter.Controls.Add(this.btnSave, 0, 0);
            this.tlpFoter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFoter.Location = new System.Drawing.Point(3, 280);
            this.tlpFoter.Name = "tlpFoter";
            this.tlpFoter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpFoter.RowCount = 1;
            this.tlpFoter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFoter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpFoter.Size = new System.Drawing.Size(780, 42);
            this.tlpFoter.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.AfterText;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "  ذخیره ";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // UC_Contact_Insert_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Contact_Insert_Update";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(786, 325);
            this.Load += new System.EventHandler(this.UC_Contact_Insert_Update_Load);
            this.tlpMain.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAddres)).EndInit();
            this.tsPhone.ResumeLayout(false);
            this.tsPhone.PerformLayout();
            this.tsAddres.ResumeLayout(false);
            this.tsAddres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdphone)).EndInit();
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.tlpFoter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Janus.Windows.GridEX.GridEX grdAddres;
        private System.Windows.Forms.ToolStrip tsPhone;
        private System.Windows.Forms.ToolStripButton btnAddPhone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRemovePhone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnEditPhone;
        private System.Windows.Forms.ToolStrip tsAddres;
        private System.Windows.Forms.ToolStripButton btnAddAddres;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton butRemoveAddres;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnEditAddres;
        private Janus.Windows.GridEX.GridEX grdphone;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.TextBox txtContactCode;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label lblFathername;
        private System.Windows.Forms.Label lblNationalCode;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.TableLayoutPanel tlpFoter;
        private Janus.Windows.EditControls.UIButton btnSave;
    }
}

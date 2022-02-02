namespace Cactus.Contact.UI
{
    partial class UC_Contact_List
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
            Janus.Windows.GridEX.GridEXLayout grdContact_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Contact_List));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdContact = new Janus.Windows.GridEX.GridEX();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.INew = new System.Windows.Forms.ToolStripMenuItem();
            this.Speraator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Iedit = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.IDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new Janus.Windows.EditControls.UIButton();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            this.btnUpdate = new Janus.Windows.EditControls.UIButton();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.btnResat = new Janus.Windows.EditControls.UIButton();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.txtLastName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtFirstName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lblFirastName = new System.Windows.Forms.Label();
            this.txtCode = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtFatherName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lblNationalCode = new System.Windows.Forms.Label();
            this.txtNationalCode = new Janus.Windows.GridEX.EditControls.EditBox();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).BeginInit();
            this.cmsGrid.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.grdContact, 0, 2);
            this.tlpMain.Controls.Add(this.tlpFooter, 0, 2);
            this.tlpMain.Controls.Add(this.tlpHeader, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpMain.Size = new System.Drawing.Size(892, 467);
            this.tlpMain.TabIndex = 4;
            // 
            // grdContact
            // 
            this.grdContact.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdContact.AlternatingColors = true;
            this.grdContact.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdContact.ColumnAutoResize = true;
            this.grdContact.ContextMenuStrip = this.cmsGrid;
            grdContact_DesignTimeLayout.LayoutString = resources.GetString("grdContact_DesignTimeLayout.LayoutString");
            this.grdContact.DesignTimeLayout = grdContact_DesignTimeLayout;
            this.grdContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdContact.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdContact.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdContact.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdContact.GroupByBoxVisible = false;
            this.grdContact.Location = new System.Drawing.Point(3, 79);
            this.grdContact.Name = "grdContact";
            this.grdContact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdContact.RowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdContact.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.grdContact.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdContact.Size = new System.Drawing.Size(886, 321);
            this.grdContact.TabIndex = 0;
            this.grdContact.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdContact.TabStop = false;
            this.grdContact.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdContact.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.GrdContact_RowDoubleClick);
            // 
            // cmsGrid
            // 
            this.cmsGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.INew,
            this.Speraator1,
            this.Iedit,
            this.Separator2,
            this.IDelete});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsGrid.Size = new System.Drawing.Size(130, 82);
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
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 6;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpFooter.Controls.Add(this.btnNew, 0, 0);
            this.tlpFooter.Controls.Add(this.btnDelete, 2, 0);
            this.tlpFooter.Controls.Add(this.btnUpdate, 1, 0);
            this.tlpFooter.Controls.Add(this.btnSearch, 3, 0);
            this.tlpFooter.Controls.Add(this.btnResat, 4, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(3, 406);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(886, 58);
            this.tlpFooter.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNew.Location = new System.Drawing.Point(767, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(116, 52);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جدید";
            this.btnNew.ToolTipText = "F5";
            this.btnNew.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(523, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 52);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف ";
            this.btnDelete.ToolTipText = "F7";
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdate.Location = new System.Drawing.Point(645, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 52);
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
            this.btnSearch.Location = new System.Drawing.Point(401, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 52);
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
            this.btnResat.Location = new System.Drawing.Point(279, 3);
            this.btnResat.Name = "btnResat";
            this.btnResat.Size = new System.Drawing.Size(116, 52);
            this.btnResat.TabIndex = 4;
            this.btnResat.Text = "بروزرسانی";
            this.btnResat.ToolTipText = "F9";
            this.btnResat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnResat.Click += new System.EventHandler(this.BtnResat_Click);
            // 
            // tlpHeader
            // 
            this.tlpHeader.ColumnCount = 7;
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpHeader.Controls.Add(this.lblLastName, 4, 0);
            this.tlpHeader.Controls.Add(this.lblCustomerCode, 0, 0);
            this.tlpHeader.Controls.Add(this.txtLastName, 5, 0);
            this.tlpHeader.Controls.Add(this.txtFirstName, 3, 0);
            this.tlpHeader.Controls.Add(this.lblFirastName, 2, 0);
            this.tlpHeader.Controls.Add(this.txtCode, 1, 0);
            this.tlpHeader.Controls.Add(this.lblFatherName, 0, 1);
            this.tlpHeader.Controls.Add(this.txtFatherName, 1, 1);
            this.tlpHeader.Controls.Add(this.lblNationalCode, 2, 1);
            this.tlpHeader.Controls.Add(this.txtNationalCode, 3, 1);
            this.tlpHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHeader.Location = new System.Drawing.Point(3, 3);
            this.tlpHeader.Name = "tlpHeader";
            this.tlpHeader.RowCount = 3;
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpHeader.Size = new System.Drawing.Size(886, 69);
            this.tlpHeader.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastName.Location = new System.Drawing.Point(339, 5);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(12, 5, 3, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(98, 27);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "نام خانوادگی ";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerCode.Location = new System.Drawing.Point(805, 5);
            this.lblCustomerCode.Margin = new System.Windows.Forms.Padding(12, 5, 3, 0);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(69, 27);
            this.lblCustomerCode.TabIndex = 0;
            this.lblCustomerCode.Text = "کد شخص ";
            this.lblCustomerCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLastName.Location = new System.Drawing.Point(198, 3);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(135, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Location = new System.Drawing.Point(452, 3);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(135, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirastName
            // 
            this.lblFirastName.AutoSize = true;
            this.lblFirastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirastName.Location = new System.Drawing.Point(593, 5);
            this.lblFirastName.Margin = new System.Windows.Forms.Padding(12, 5, 3, 0);
            this.lblFirastName.Name = "lblFirastName";
            this.lblFirastName.Size = new System.Drawing.Size(56, 27);
            this.lblFirastName.TabIndex = 2;
            this.lblFirastName.Text = "نام";
            this.lblFirastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(664, 3);
            this.txtCode.MaxLength = 4;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(135, 22);
            this.txtCode.TabIndex = 1;
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFatherName.Location = new System.Drawing.Point(805, 37);
            this.lblFatherName.Margin = new System.Windows.Forms.Padding(12, 5, 3, 0);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(69, 27);
            this.lblFatherName.TabIndex = 5;
            this.lblFatherName.Text = "نام پدر ";
            this.lblFatherName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFatherName.Location = new System.Drawing.Point(664, 35);
            this.txtFatherName.MaxLength = 50;
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(135, 22);
            this.txtFatherName.TabIndex = 5;
            // 
            // lblNationalCode
            // 
            this.lblNationalCode.AutoSize = true;
            this.lblNationalCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNationalCode.Location = new System.Drawing.Point(593, 37);
            this.lblNationalCode.Margin = new System.Windows.Forms.Padding(12, 5, 3, 0);
            this.lblNationalCode.Name = "lblNationalCode";
            this.lblNationalCode.Size = new System.Drawing.Size(56, 27);
            this.lblNationalCode.TabIndex = 6;
            this.lblNationalCode.Text = "کد ملی ";
            this.lblNationalCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNationalCode.Location = new System.Drawing.Point(452, 35);
            this.txtNationalCode.MaxLength = 50;
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(135, 22);
            this.txtNationalCode.TabIndex = 7;
            // 
            // UC_Contact_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Contact_List";
            this.Size = new System.Drawing.Size(892, 467);
            this.Load += new System.EventHandler(this.UC_Contact_List_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdContact)).EndInit();
            this.cmsGrid.ResumeLayout(false);
            this.tlpFooter.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.tlpHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private Janus.Windows.GridEX.GridEX grdContact;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private Janus.Windows.EditControls.UIButton btnNew;
        private Janus.Windows.EditControls.UIButton btnDelete;
        private Janus.Windows.EditControls.UIButton btnUpdate;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIButton btnResat;
        private System.Windows.Forms.TableLayoutPanel tlpHeader;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCustomerCode;
        private Janus.Windows.GridEX.EditControls.EditBox txtLastName;
        private Janus.Windows.GridEX.EditControls.EditBox txtFirstName;
        private System.Windows.Forms.Label lblFirastName;
        private Janus.Windows.GridEX.EditControls.EditBox txtCode;
        private System.Windows.Forms.Label lblFatherName;
        private Janus.Windows.GridEX.EditControls.EditBox txtFatherName;
        private System.Windows.Forms.Label lblNationalCode;
        private Janus.Windows.GridEX.EditControls.EditBox txtNationalCode;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripMenuItem INew;
        private System.Windows.Forms.ToolStripSeparator Speraator1;
        private System.Windows.Forms.ToolStripMenuItem Iedit;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripMenuItem IDelete;
    }
}

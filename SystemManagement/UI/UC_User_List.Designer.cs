namespace Cactus.SystemManagement.UI
{
    partial class UC_User_List
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
            Janus.Windows.GridEX.GridEXLayout grdUser_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_User_List));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdUser = new Janus.Windows.GridEX.GridEX();
            this.tlbHader = new System.Windows.Forms.TableLayoutPanel();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUserName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.tblFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new Janus.Windows.EditControls.UIButton();
            this.btnUpdate = new Janus.Windows.EditControls.UIButton();
            this.btnResat = new Janus.Windows.EditControls.UIButton();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).BeginInit();
            this.tlbHader.SuspendLayout();
            this.tblFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblMain.Controls.Add(this.grdUser, 0, 1);
            this.tblMain.Controls.Add(this.tlbHader, 0, 0);
            this.tblMain.Controls.Add(this.tblFooter, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tblMain.Size = new System.Drawing.Size(880, 520);
            this.tblMain.TabIndex = 0;
            // 
            // grdUser
            // 
            this.grdUser.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdUser.AlternatingColors = true;
            this.grdUser.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdUser.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdUser.ColumnAutoResize = true;
            grdUser_DesignTimeLayout.LayoutString = resources.GetString("grdUser_DesignTimeLayout.LayoutString");
            this.grdUser.DesignTimeLayout = grdUser_DesignTimeLayout;
            this.grdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUser.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdUser.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdUser.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdUser.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUser.GroupByBoxVisible = false;
            this.grdUser.HeaderFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Empty;
            this.grdUser.HeaderFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdUser.HeaderFormatStyle.FontSize = 10F;
            this.grdUser.Location = new System.Drawing.Point(3, 41);
            this.grdUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdUser.Name = "grdUser";
            this.grdUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grdUser.RowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Solid;
            this.grdUser.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowPosition;
            this.grdUser.RowHeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.grdUser.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.grdUser.Size = new System.Drawing.Size(874, 411);
            this.grdUser.TabIndex = 0;
            this.grdUser.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdUser.TabStop = false;
            this.grdUser.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // tlbHader
            // 
            this.tlbHader.ColumnCount = 3;
            this.tlbHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tlbHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlbHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbHader.Controls.Add(this.lblUser, 0, 0);
            this.tlbHader.Controls.Add(this.txtUserName, 1, 0);
            this.tlbHader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbHader.Location = new System.Drawing.Point(3, 4);
            this.tlbHader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tlbHader.Name = "tlbHader";
            this.tlbHader.RowCount = 1;
            this.tlbHader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbHader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlbHader.Size = new System.Drawing.Size(874, 29);
            this.tlbHader.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Location = new System.Drawing.Point(788, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(83, 29);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "نام کاربری";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(638, 4);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(144, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // tblFooter
            // 
            this.tblFooter.ColumnCount = 6;
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Controls.Add(this.btnNew, 0, 0);
            this.tblFooter.Controls.Add(this.btnUpdate, 1, 0);
            this.tblFooter.Controls.Add(this.btnResat, 4, 0);
            this.tblFooter.Controls.Add(this.btnSearch, 3, 0);
            this.tblFooter.Controls.Add(this.btnDelete, 2, 0);
            this.tblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFooter.Location = new System.Drawing.Point(3, 460);
            this.tblFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblFooter.Name = "tblFooter";
            this.tblFooter.RowCount = 1;
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Size = new System.Drawing.Size(874, 56);
            this.tblFooter.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNew.Location = new System.Drawing.Point(760, 4);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 48);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "جدید";
            this.btnNew.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdate.Location = new System.Drawing.Point(643, 4);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 48);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnResat
            // 
            this.btnResat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResat.Image = ((System.Drawing.Image)(resources.GetObject("btnResat.Image")));
            this.btnResat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnResat.Location = new System.Drawing.Point(292, 4);
            this.btnResat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResat.Name = "btnResat";
            this.btnResat.Size = new System.Drawing.Size(111, 48);
            this.btnResat.TabIndex = 4;
            this.btnResat.Text = "بروز رسانی";
            this.btnResat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnResat.Click += new System.EventHandler(this.BtnResat_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Location = new System.Drawing.Point(409, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 48);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(526, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 48);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "حذف";
            this.btnDelete.ToolTipText = "F7";
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // UC_User_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_User_List";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(880, 520);
            this.Load += new System.EventHandler(this.UC_User_List_Load);
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUser)).EndInit();
            this.tlbHader.ResumeLayout(false);
            this.tlbHader.PerformLayout();
            this.tblFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private Janus.Windows.GridEX.GridEX grdUser;
        private System.Windows.Forms.TableLayoutPanel tlbHader;
        private System.Windows.Forms.Label lblUser;
        private Janus.Windows.GridEX.EditControls.EditBox txtUserName;
        private System.Windows.Forms.TableLayoutPanel tblFooter;
        private Janus.Windows.EditControls.UIButton btnNew;
        private Janus.Windows.EditControls.UIButton btnUpdate;
        private Janus.Windows.EditControls.UIButton btnResat;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIButton btnDelete;
    }
}

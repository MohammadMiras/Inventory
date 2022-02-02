namespace Cactus.SystemManagement.UI 
{
    partial class UC_Insert_Update_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Insert_Update_User));
            Janus.Windows.GridEX.GridEXLayout grdRole_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.txtPassword = new Janus.Windows.GridEX.EditControls.EditBox();
            this.tblFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.tblBody = new System.Windows.Forms.TableLayoutPanel();
            this.grdRole = new Janus.Windows.GridEX.GridEX();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewRole = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEditRole = new System.Windows.Forms.ToolStripButton();
            this.tblMain.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.tblFooter.SuspendLayout();
            this.tblBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRole)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.tblHeader, 0, 0);
            this.tblMain.Controls.Add(this.tblFooter, 0, 2);
            this.tblMain.Controls.Add(this.tblBody, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(382, 390);
            this.tblMain.TabIndex = 1;
            // 
            // tblHeader
            // 
            this.tblHeader.ColumnCount = 3;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblHeader.Controls.Add(this.lblUserName, 0, 0);
            this.tblHeader.Controls.Add(this.tblPassword, 0, 1);
            this.tblHeader.Controls.Add(this.txtUserName, 1, 0);
            this.tblHeader.Controls.Add(this.txtPassword, 1, 1);
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeader.Location = new System.Drawing.Point(3, 4);
            this.tblHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 3;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.Size = new System.Drawing.Size(376, 61);
            this.tblHeader.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Location = new System.Drawing.Point(290, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 28);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "نام کاربری";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblPassword
            // 
            this.tblPassword.AutoSize = true;
            this.tblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPassword.Location = new System.Drawing.Point(290, 28);
            this.tblPassword.Name = "tblPassword";
            this.tblPassword.Size = new System.Drawing.Size(83, 28);
            this.tblPassword.TabIndex = 0;
            this.tblPassword.Text = "رمز عبور ";
            this.tblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Location = new System.Drawing.Point(126, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Location = new System.Drawing.Point(126, 31);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(158, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // tblFooter
            // 
            this.tblFooter.ColumnCount = 2;
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tblFooter.Controls.Add(this.btnSave, 1, 0);
            this.tblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFooter.Location = new System.Drawing.Point(3, 345);
            this.tblFooter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblFooter.Name = "tblFooter";
            this.tblFooter.RowCount = 1;
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblFooter.Size = new System.Drawing.Size(376, 41);
            this.tblFooter.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ثبت";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tblBody
            // 
            this.tblBody.ColumnCount = 1;
            this.tblBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblBody.Controls.Add(this.grdRole, 0, 1);
            this.tblBody.Controls.Add(this.toolStrip1, 0, 0);
            this.tblBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBody.Location = new System.Drawing.Point(3, 72);
            this.tblBody.Name = "tblBody";
            this.tblBody.RowCount = 2;
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBody.Size = new System.Drawing.Size(376, 266);
            this.tblBody.TabIndex = 1;
            // 
            // grdRole
            // 
            this.grdRole.AlternatingColors = true;
            this.grdRole.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdRole.AlternatingRowFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque;
            this.grdRole.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdRole.ColumnAutoResize = true;
            grdRole_DesignTimeLayout.LayoutString = resources.GetString("grdRole_DesignTimeLayout.LayoutString");
            this.grdRole.DesignTimeLayout = grdRole_DesignTimeLayout;
            this.grdRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRole.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdRole.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdRole.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdRole.GroupByBoxVisible = false;
            this.grdRole.Location = new System.Drawing.Point(3, 30);
            this.grdRole.Name = "grdRole";
            this.grdRole.Size = new System.Drawing.Size(370, 233);
            this.grdRole.TabIndex = 6;
            this.grdRole.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdRole.TabStop = false;
            this.grdRole.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdRole.CellValueChanged += new Janus.Windows.GridEX.ColumnActionEventHandler(this.GrdRole_CellValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewRole,
            this.toolStripSeparator2,
            this.btnEditRole});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(376, 27);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewRole
            // 
            this.btnNewRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewRole.Image = ((System.Drawing.Image)(resources.GetObject("btnNewRole.Image")));
            this.btnNewRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewRole.Name = "btnNewRole";
            this.btnNewRole.Size = new System.Drawing.Size(23, 24);
            this.btnNewRole.Text = "افزودن نقش";
            this.btnNewRole.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNewRole.Click += new System.EventHandler(this.BtnNewRole_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnEditRole
            // 
            this.btnEditRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditRole.Image = ((System.Drawing.Image)(resources.GetObject("btnEditRole.Image")));
            this.btnEditRole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditRole.Name = "btnEditRole";
            this.btnEditRole.Size = new System.Drawing.Size(23, 24);
            this.btnEditRole.Text = "ویرایش نقش ";
            this.btnEditRole.Click += new System.EventHandler(this.BtnEditRole_Click);
            // 
            // UC_Insert_Update_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "UC_Insert_Update_User";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(382, 390);
            this.Load += new System.EventHandler(this.UC_Insert_Update_User_Load);
            this.tblMain.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.tblFooter.ResumeLayout(false);
            this.tblBody.ResumeLayout(false);
            this.tblBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRole)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label tblPassword;
        private Janus.Windows.GridEX.EditControls.EditBox txtUserName;
        private Janus.Windows.GridEX.EditControls.EditBox txtPassword;
        private System.Windows.Forms.TableLayoutPanel tblFooter;
        private Janus.Windows.EditControls.UIButton btnSave;
        private System.Windows.Forms.TableLayoutPanel tblBody;
        private Janus.Windows.GridEX.GridEX grdRole;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewRole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEditRole;
    }
}

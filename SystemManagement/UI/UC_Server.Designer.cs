namespace Cactus.SystemManagement.UI
{
    partial class UC_Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Server));
            this.tlbMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblBody = new System.Windows.Forms.TableLayoutPanel();
            this.tblServer = new System.Windows.Forms.TableLayoutPanel();
            this.lblNameServer = new System.Windows.Forms.Label();
            this.cmbServerName = new Janus.Windows.EditControls.UIComboBox();
            this.tblUserServer = new System.Windows.Forms.TableLayoutPanel();
            this.lblUnServe = new System.Windows.Forms.Label();
            this.txtUserServer = new Janus.Windows.GridEX.EditControls.EditBox();
            this.tblPassword = new System.Windows.Forms.TableLayoutPanel();
            this.lblPasswordServer = new System.Windows.Forms.Label();
            this.txtPassword = new Janus.Windows.GridEX.EditControls.EditBox();
            this.tblNameServer = new System.Windows.Forms.TableLayoutPanel();
            this.lblNameDatabase = new System.Windows.Forms.Label();
            this.cmbDataBaseName = new Janus.Windows.EditControls.UIComboBox();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCloseWindoiw = new System.Windows.Forms.PictureBox();
            this.tlbMain.SuspendLayout();
            this.tblFooter.SuspendLayout();
            this.tblBody.SuspendLayout();
            this.tblServer.SuspendLayout();
            this.tblUserServer.SuspendLayout();
            this.tblPassword.SuspendLayout();
            this.tblNameServer.SuspendLayout();
            this.tblHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseWindoiw)).BeginInit();
            this.SuspendLayout();
            // 
            // tlbMain
            // 
            this.tlbMain.ColumnCount = 1;
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlbMain.Controls.Add(this.tblFooter, 0, 2);
            this.tlbMain.Controls.Add(this.tblBody, 0, 1);
            this.tlbMain.Controls.Add(this.tblHeader, 0, 0);
            this.tlbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbMain.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlbMain.Location = new System.Drawing.Point(0, 0);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tlbMain.RowCount = 3;
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.tlbMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlbMain.Size = new System.Drawing.Size(316, 354);
            this.tlbMain.TabIndex = 3;
            // 
            // tblFooter
            // 
            this.tblFooter.ColumnCount = 3;
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tblFooter.Controls.Add(this.btnSave, 2, 0);
            this.tblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFooter.Location = new System.Drawing.Point(3, 313);
            this.tblFooter.Name = "tblFooter";
            this.tblFooter.RowCount = 1;
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Size = new System.Drawing.Size(310, 38);
            this.tblFooter.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(120)))), ((int)(((byte)(113)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(106)))), ((int)(((byte)(138)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveConnection_Click);
            // 
            // tblBody
            // 
            this.tblBody.ColumnCount = 1;
            this.tblBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBody.Controls.Add(this.tblServer, 0, 0);
            this.tblBody.Controls.Add(this.tblUserServer, 0, 1);
            this.tblBody.Controls.Add(this.tblPassword, 0, 2);
            this.tblBody.Controls.Add(this.tblNameServer, 0, 3);
            this.tblBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBody.Location = new System.Drawing.Point(3, 70);
            this.tblBody.Name = "tblBody";
            this.tblBody.RowCount = 5;
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBody.Size = new System.Drawing.Size(310, 237);
            this.tblBody.TabIndex = 1;
            // 
            // tblServer
            // 
            this.tblServer.ColumnCount = 1;
            this.tblServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblServer.Controls.Add(this.lblNameServer, 0, 0);
            this.tblServer.Controls.Add(this.cmbServerName, 0, 1);
            this.tblServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblServer.Location = new System.Drawing.Point(3, 3);
            this.tblServer.Name = "tblServer";
            this.tblServer.RowCount = 2;
            this.tblServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblServer.Size = new System.Drawing.Size(304, 51);
            this.tblServer.TabIndex = 0;
            // 
            // lblNameServer
            // 
            this.lblNameServer.AutoSize = true;
            this.lblNameServer.ForeColor = System.Drawing.Color.White;
            this.lblNameServer.Location = new System.Drawing.Point(261, 0);
            this.lblNameServer.Name = "lblNameServer";
            this.lblNameServer.Size = new System.Drawing.Size(40, 16);
            this.lblNameServer.TabIndex = 0;
            this.lblNameServer.Text = "سرور ";
            // 
            // cmbServerName
            // 
            this.cmbServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbServerName.Location = new System.Drawing.Point(3, 23);
            this.cmbServerName.Name = "cmbServerName";
            this.cmbServerName.Size = new System.Drawing.Size(298, 25);
            this.cmbServerName.TabIndex = 2;
            this.cmbServerName.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.cmbServerName.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cmbServerName.SelectedItemChanged += new System.EventHandler(this.CmbServerName_SelectedItemChanged);
            // 
            // tblUserServer
            // 
            this.tblUserServer.ColumnCount = 1;
            this.tblUserServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUserServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblUserServer.Controls.Add(this.lblUnServe, 0, 0);
            this.tblUserServer.Controls.Add(this.txtUserServer, 0, 1);
            this.tblUserServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUserServer.Location = new System.Drawing.Point(3, 60);
            this.tblUserServer.Name = "tblUserServer";
            this.tblUserServer.RowCount = 2;
            this.tblUserServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblUserServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUserServer.Size = new System.Drawing.Size(304, 54);
            this.tblUserServer.TabIndex = 0;
            // 
            // lblUnServe
            // 
            this.lblUnServe.AutoSize = true;
            this.lblUnServe.ForeColor = System.Drawing.Color.White;
            this.lblUnServe.Location = new System.Drawing.Point(202, 0);
            this.lblUnServe.Name = "lblUnServe";
            this.lblUnServe.Size = new System.Drawing.Size(99, 16);
            this.lblUnServe.TabIndex = 0;
            this.lblUnServe.Text = "نام کاربری سرور ";
            // 
            // txtUserServer
            // 
            this.txtUserServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserServer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserServer.Location = new System.Drawing.Point(3, 23);
            this.txtUserServer.Name = "txtUserServer";
            this.txtUserServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUserServer.Size = new System.Drawing.Size(298, 26);
            this.txtUserServer.TabIndex = 1;
            this.txtUserServer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // tblPassword
            // 
            this.tblPassword.ColumnCount = 1;
            this.tblPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPassword.Controls.Add(this.lblPasswordServer, 0, 0);
            this.tblPassword.Controls.Add(this.txtPassword, 0, 1);
            this.tblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPassword.Location = new System.Drawing.Point(3, 120);
            this.tblPassword.Name = "tblPassword";
            this.tblPassword.RowCount = 2;
            this.tblPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPassword.Size = new System.Drawing.Size(304, 54);
            this.tblPassword.TabIndex = 0;
            // 
            // lblPasswordServer
            // 
            this.lblPasswordServer.AutoSize = true;
            this.lblPasswordServer.ForeColor = System.Drawing.Color.White;
            this.lblPasswordServer.Location = new System.Drawing.Point(248, 0);
            this.lblPasswordServer.Name = "lblPasswordServer";
            this.lblPasswordServer.Size = new System.Drawing.Size(53, 16);
            this.lblPasswordServer.TabIndex = 0;
            this.lblPasswordServer.Text = "رمز عبور";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(3, 23);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(298, 26);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // tblNameServer
            // 
            this.tblNameServer.ColumnCount = 1;
            this.tblNameServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNameServer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblNameServer.Controls.Add(this.lblNameDatabase, 0, 0);
            this.tblNameServer.Controls.Add(this.cmbDataBaseName, 0, 1);
            this.tblNameServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNameServer.Location = new System.Drawing.Point(3, 180);
            this.tblNameServer.Name = "tblNameServer";
            this.tblNameServer.RowCount = 2;
            this.tblNameServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblNameServer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNameServer.Size = new System.Drawing.Size(304, 51);
            this.tblNameServer.TabIndex = 0;
            // 
            // lblNameDatabase
            // 
            this.lblNameDatabase.AutoSize = true;
            this.lblNameDatabase.ForeColor = System.Drawing.Color.White;
            this.lblNameDatabase.Location = new System.Drawing.Point(215, 0);
            this.lblNameDatabase.Name = "lblNameDatabase";
            this.lblNameDatabase.Size = new System.Drawing.Size(86, 16);
            this.lblNameDatabase.TabIndex = 0;
            this.lblNameDatabase.Text = "نام پایگاه داده ";
            // 
            // cmbDataBaseName
            // 
            this.cmbDataBaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDataBaseName.Location = new System.Drawing.Point(3, 23);
            this.cmbDataBaseName.Name = "cmbDataBaseName";
            this.cmbDataBaseName.Size = new System.Drawing.Size(298, 25);
            this.cmbDataBaseName.TabIndex = 5;
            this.cmbDataBaseName.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.cmbDataBaseName.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // tblHeader
            // 
            this.tblHeader.ColumnCount = 3;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblHeader.Controls.Add(this.pictureBox1, 2, 0);
            this.tblHeader.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeader.Location = new System.Drawing.Point(3, 3);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 1;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tblHeader.Size = new System.Drawing.Size(310, 61);
            this.tblHeader.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnCloseWindoiw, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(272, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(35, 55);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCloseWindoiw
            // 
            this.btnCloseWindoiw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseWindoiw.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseWindoiw.Image")));
            this.btnCloseWindoiw.Location = new System.Drawing.Point(3, 3);
            this.btnCloseWindoiw.Name = "btnCloseWindoiw";
            this.btnCloseWindoiw.Size = new System.Drawing.Size(29, 29);
            this.btnCloseWindoiw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseWindoiw.TabIndex = 0;
            this.btnCloseWindoiw.TabStop = false;
            this.btnCloseWindoiw.Click += new System.EventHandler(this.BtnCloseWindiow_Click);
            // 
            // UC_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlbMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Server";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(316, 354);
            this.Load += new System.EventHandler(this.UC_ServerSetup_Load);
            this.tlbMain.ResumeLayout(false);
            this.tblFooter.ResumeLayout(false);
            this.tblBody.ResumeLayout(false);
            this.tblServer.ResumeLayout(false);
            this.tblServer.PerformLayout();
            this.tblUserServer.ResumeLayout(false);
            this.tblUserServer.PerformLayout();
            this.tblPassword.ResumeLayout(false);
            this.tblPassword.PerformLayout();
            this.tblNameServer.ResumeLayout(false);
            this.tblNameServer.PerformLayout();
            this.tblHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseWindoiw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlbMain;
        private System.Windows.Forms.TableLayoutPanel tblFooter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tblBody;
        private System.Windows.Forms.TableLayoutPanel tblServer;
        private System.Windows.Forms.Label lblNameServer;
        private Janus.Windows.EditControls.UIComboBox cmbServerName;
        private System.Windows.Forms.TableLayoutPanel tblUserServer;
        private System.Windows.Forms.Label lblUnServe;
        private Janus.Windows.GridEX.EditControls.EditBox txtUserServer;
        private System.Windows.Forms.TableLayoutPanel tblPassword;
        private System.Windows.Forms.Label lblPasswordServer;
        private Janus.Windows.GridEX.EditControls.EditBox txtPassword;
        private System.Windows.Forms.TableLayoutPanel tblNameServer;
        private System.Windows.Forms.Label lblNameDatabase;
        private Janus.Windows.EditControls.UIComboBox cmbDataBaseName;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox btnCloseWindoiw;
    }
}

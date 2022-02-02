namespace Cactus.Core.UI.UserControls
{
    partial class UC_Start_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Start_App));
            this.TblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUserSetup = new Janus.Windows.EditControls.UIButton();
            this.btnInventory = new Janus.Windows.EditControls.UIButton();
            this.btnCustomer = new Janus.Windows.EditControls.UIButton();
            this.btnSystemManagement = new Janus.Windows.EditControls.UIButton();
            this.btnExit = new Janus.Windows.EditControls.UIButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TblMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblMain
            // 
            this.TblMain.BackColor = System.Drawing.Color.Transparent;
            this.TblMain.ColumnCount = 1;
            this.TblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.TblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblMain.Location = new System.Drawing.Point(0, 0);
            this.TblMain.Name = "TblMain";
            this.TblMain.RowCount = 1;
            this.TblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TblMain.Size = new System.Drawing.Size(380, 200);
            this.TblMain.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 194);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 188);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnUserSetup
            // 
            this.btnUserSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserSetup.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnUserSetup.Image")));
            this.btnUserSetup.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUserSetup.Location = new System.Drawing.Point(3, 120);
            this.btnUserSetup.Name = "btnUserSetup";
            this.btnUserSetup.Size = new System.Drawing.Size(121, 33);
            this.btnUserSetup.TabIndex = 3;
            this.btnUserSetup.Text = "ویرایش کاربر";
            this.btnUserSetup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnUserSetup.Click += new System.EventHandler(this.btnUserSetup_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.DarkRed;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInventory.FlatBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInventory.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnInventory.Location = new System.Drawing.Point(3, 3);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(121, 33);
            this.btnInventory.StateStyles.FormatStyle.BackColor = System.Drawing.Color.Red;
            this.btnInventory.StateStyles.HotFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnInventory.StateStyles.PressedFormatStyle.BackColorGradient = System.Drawing.Color.Fuchsia;
            this.btnInventory.StateStyles.SelectedFormatStyle.BackColorGradient = System.Drawing.Color.Maroon;
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "انبار";
            this.btnInventory.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCustomer.Location = new System.Drawing.Point(3, 42);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(121, 33);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "اشخاص";
            this.btnCustomer.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSystemManagement
            // 
            this.btnSystemManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSystemManagement.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemManagement.Image")));
            this.btnSystemManagement.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSystemManagement.Location = new System.Drawing.Point(3, 81);
            this.btnSystemManagement.Name = "btnSystemManagement";
            this.btnSystemManagement.Size = new System.Drawing.Size(121, 33);
            this.btnSystemManagement.TabIndex = 2;
            this.btnSystemManagement.Text = "مدیریت سیستم ";
            this.btnSystemManagement.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSystemManagement.Click += new System.EventHandler(this.btnSystemManagement_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(3, 159);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "خروج کاربر";
            this.btnExit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnSystemManagement, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnCustomer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnInventory, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnUserSetup, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(244, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(127, 188);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.TblMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Start";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(380, 200);
            this.Load += new System.EventHandler(this.Start_Load);
            this.TblMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TblMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Janus.Windows.EditControls.UIButton btnExit;
        private Janus.Windows.EditControls.UIButton btnSystemManagement;
        private Janus.Windows.EditControls.UIButton btnCustomer;
        private Janus.Windows.EditControls.UIButton btnInventory;
        private Janus.Windows.EditControls.UIButton btnUserSetup;
    }
}

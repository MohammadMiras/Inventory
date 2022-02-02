namespace Cactus.Inventory.UI
{
    partial class UC_Inventory_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inventory_List));
            Janus.Windows.GridEX.GridEXLayout grdInventory_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new Janus.Windows.EditControls.UIButton();
            this.btnDelete = new Janus.Windows.EditControls.UIButton();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.btnResat = new Janus.Windows.EditControls.UIButton();
            this.btnUpdate = new Janus.Windows.EditControls.UIButton();
            this.grdInventory = new Janus.Windows.GridEX.GridEX();
            this.cmsGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Separator0 = new System.Windows.Forms.ToolStripSeparator();
            this.INew = new System.Windows.Forms.ToolStripMenuItem();
            this.Speraator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Iedit = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.IDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tblHader = new System.Windows.Forms.TableLayoutPanel();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new Janus.Windows.GridEX.EditControls.EditBox();
            this.tlpMain.SuspendLayout();
            this.tblFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdInventory)).BeginInit();
            this.cmsGrid.SuspendLayout();
            this.tblHader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tblFooter, 0, 2);
            this.tlpMain.Controls.Add(this.grdInventory, 0, 1);
            this.tlpMain.Controls.Add(this.tblHader, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlpMain.Size = new System.Drawing.Size(734, 342);
            this.tlpMain.TabIndex = 0;
            // 
            // tblFooter
            // 
            this.tblFooter.ColumnCount = 6;
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Controls.Add(this.btnNew, 0, 0);
            this.tblFooter.Controls.Add(this.btnDelete, 2, 0);
            this.tblFooter.Controls.Add(this.btnSearch, 3, 0);
            this.tblFooter.Controls.Add(this.btnResat, 4, 0);
            this.tblFooter.Controls.Add(this.btnUpdate, 1, 0);
            this.tblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFooter.Location = new System.Drawing.Point(3, 287);
            this.tblFooter.Name = "tblFooter";
            this.tblFooter.RowCount = 1;
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Size = new System.Drawing.Size(728, 52);
            this.tblFooter.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNew.Location = new System.Drawing.Point(609, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(116, 46);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "جدید";
            this.btnNew.ToolTipText = "F5";
            this.btnNew.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(365, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.ToolTipText = "F7";
            this.btnDelete.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Location = new System.Drawing.Point(243, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 46);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.ToolTipText = "F8";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnResat
            // 
            this.btnResat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResat.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResat.Image = ((System.Drawing.Image)(resources.GetObject("btnResat.Image")));
            this.btnResat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnResat.Location = new System.Drawing.Point(121, 3);
            this.btnResat.Name = "btnResat";
            this.btnResat.Size = new System.Drawing.Size(116, 46);
            this.btnResat.TabIndex = 5;
            this.btnResat.Text = "بروزرسانی";
            this.btnResat.ToolTipText = "F9";
            this.btnResat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnResat.Click += new System.EventHandler(this.BtnResat_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdate.Location = new System.Drawing.Point(487, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 46);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.ToolTipText = "F6";
            this.btnUpdate.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // grdInventory
            // 
            this.grdInventory.AlternatingColors = true;
            this.grdInventory.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdInventory.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdInventory.ColumnAutoResize = true;
            this.grdInventory.ContextMenuStrip = this.cmsGrid;
            grdInventory_DesignTimeLayout.LayoutString = resources.GetString("grdInventory_DesignTimeLayout.LayoutString");
            this.grdInventory.DesignTimeLayout = grdInventory_DesignTimeLayout;
            this.grdInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdInventory.GroupByBoxVisible = false;
            this.grdInventory.Location = new System.Drawing.Point(3, 44);
            this.grdInventory.Name = "grdInventory";
            this.grdInventory.Size = new System.Drawing.Size(728, 237);
            this.grdInventory.TabIndex = 1;
            this.grdInventory.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdInventory.UseCompatibleTextRendering = false;
            this.grdInventory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
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
            this.toolStripSeparator1});
            this.cmsGrid.Name = "cmsGrid";
            this.cmsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmsGrid.Size = new System.Drawing.Size(130, 94);
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
            // tblHader
            // 
            this.tblHader.ColumnCount = 5;
            this.tblHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tblHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tblHader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHader.Controls.Add(this.lblCode, 0, 0);
            this.tblHader.Controls.Add(this.txtCode, 1, 0);
            this.tblHader.Controls.Add(this.lblTitle, 2, 0);
            this.tblHader.Controls.Add(this.txtTitle, 3, 0);
            this.tblHader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHader.Location = new System.Drawing.Point(3, 3);
            this.tblHader.Name = "tblHader";
            this.tblHader.RowCount = 1;
            this.tblHader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHader.Size = new System.Drawing.Size(728, 35);
            this.tblHader.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCode.Location = new System.Drawing.Point(681, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(44, 35);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "کد انبار";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(558, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(117, 22);
            this.txtCode.TabIndex = 1;
            this.txtCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
            this.txtCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventEnteringNumberInTextBox_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(498, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 35);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "عنوان ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(374, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(118, 22);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // UC_Inventory_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Inventory_List";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(734, 342);
            this.Load += new System.EventHandler(this.UC_Inventory_List_Load);
            this.tlpMain.ResumeLayout(false);
            this.tblFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdInventory)).EndInit();
            this.cmsGrid.ResumeLayout(false);
            this.tblHader.ResumeLayout(false);
            this.tblHader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tblHader;
        private System.Windows.Forms.Label lblCode;
        private Janus.Windows.GridEX.EditControls.EditBox txtCode;
        private Janus.Windows.GridEX.GridEX grdInventory;
        private System.Windows.Forms.TableLayoutPanel tblFooter;
        private Janus.Windows.EditControls.UIButton btnDelete;
        private Janus.Windows.EditControls.UIButton btnUpdate;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIButton btnResat;
        private Janus.Windows.EditControls.UIButton btnNew;
        private System.Windows.Forms.ContextMenuStrip cmsGrid;
        private System.Windows.Forms.ToolStripSeparator Separator0;
        private System.Windows.Forms.ToolStripMenuItem INew;
        private System.Windows.Forms.ToolStripSeparator Speraator1;
        private System.Windows.Forms.ToolStripMenuItem Iedit;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripMenuItem IDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblTitle;
        private Janus.Windows.GridEX.EditControls.EditBox txtTitle;
    }
}

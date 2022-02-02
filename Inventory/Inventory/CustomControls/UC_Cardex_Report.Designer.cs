namespace Cactus.Inventory.UI.CustomControls
{
    partial class UC_Cardex_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cardex_Report));
            Janus.Windows.GridEX.GridEXLayout grdCardex_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tblControlsData = new System.Windows.Forms.TableLayoutPanel();
            this.cmbInventory = new Janus.Windows.EditControls.UIComboBox();
            this.lblInventory = new System.Windows.Forms.Label();
            this.btnSelectGoods = new Janus.Windows.EditControls.UIButton();
            this.txtGoodsName = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lblGoods = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.txtFromDate = new Janus.Windows.GridEX.EditControls.MaskedEditBox();
            this.txtToDate = new Janus.Windows.GridEX.EditControls.MaskedEditBox();
            this.btnResat = new Janus.Windows.EditControls.UIButton();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdCardex = new Janus.Windows.GridEX.GridEX();
            this.tblFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.btnPrint = new Janus.Windows.EditControls.UIButton();
            this.tblControlsData.SuspendLayout();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCardex)).BeginInit();
            this.tblFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblControlsData
            // 
            this.tblControlsData.ColumnCount = 10;
            this.tblControlsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tblControlsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tblControlsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tblControlsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblControlsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblControlsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblControlsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tblControlsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblControlsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tblControlsData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlsData.Controls.Add(this.cmbInventory, 1, 0);
            this.tblControlsData.Controls.Add(this.lblInventory, 0, 0);
            this.tblControlsData.Controls.Add(this.btnSelectGoods, 4, 0);
            this.tblControlsData.Controls.Add(this.txtGoodsName, 3, 0);
            this.tblControlsData.Controls.Add(this.lblGoods, 2, 0);
            this.tblControlsData.Controls.Add(this.lblToDate, 7, 0);
            this.tblControlsData.Controls.Add(this.lblFromDate, 5, 0);
            this.tblControlsData.Controls.Add(this.txtFromDate, 6, 0);
            this.tblControlsData.Controls.Add(this.txtToDate, 8, 0);
            this.tblControlsData.Location = new System.Drawing.Point(6, 4);
            this.tblControlsData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblControlsData.Name = "tblControlsData";
            this.tblControlsData.RowCount = 2;
            this.tblControlsData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblControlsData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControlsData.Size = new System.Drawing.Size(803, 38);
            this.tblControlsData.TabIndex = 2;
            // 
            // cmbInventory
            // 
            this.cmbInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbInventory.Location = new System.Drawing.Point(638, 4);
            this.cmbInventory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbInventory.Name = "cmbInventory";
            this.cmbInventory.Size = new System.Drawing.Size(115, 25);
            this.cmbInventory.TabIndex = 2;
            this.cmbInventory.Text = "...انتخاب...";
            this.cmbInventory.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.cmbInventory.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cmbInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbInventory_KeyPress_1);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInventory.Location = new System.Drawing.Point(759, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(41, 33);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "انبار";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectGoods
            // 
            this.btnSelectGoods.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSelectGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelectGoods.Location = new System.Drawing.Point(421, 4);
            this.btnSelectGoods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectGoods.Name = "btnSelectGoods";
            this.btnSelectGoods.Size = new System.Drawing.Size(24, 25);
            this.btnSelectGoods.TabIndex = 3;
            this.btnSelectGoods.Text = "...";
            this.btnSelectGoods.TextVerticalAlignment = Janus.Windows.EditControls.TextAlignment.Empty;
            this.btnSelectGoods.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSelectGoods.WordWrap = false;
            this.btnSelectGoods.Click += new System.EventHandler(this.BtnSelectGoods_Click);
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.BackColor = System.Drawing.Color.Gold;
            this.txtGoodsName.ButtonFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsName.DisabledBackColor = System.Drawing.Color.White;
            this.txtGoodsName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGoodsName.Location = new System.Drawing.Point(451, 4);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.ReadOnly = true;
            this.txtGoodsName.Size = new System.Drawing.Size(134, 23);
            this.txtGoodsName.TabIndex = 4;
            this.txtGoodsName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblGoods
            // 
            this.lblGoods.AutoSize = true;
            this.lblGoods.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGoods.Location = new System.Drawing.Point(591, 0);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Size = new System.Drawing.Size(41, 33);
            this.lblGoods.TabIndex = 0;
            this.lblGoods.Text = "کالا";
            this.lblGoods.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToDate.Location = new System.Drawing.Point(180, 0);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(54, 33);
            this.lblToDate.TabIndex = 5;
            this.lblToDate.Text = "تا تاریخ ";
            this.lblToDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFromDate.Location = new System.Drawing.Point(361, 0);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(54, 33);
            this.lblFromDate.TabIndex = 5;
            this.lblFromDate.Text = "از تاریخ";
            this.lblFromDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFromDate
            // 
            this.txtFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFromDate.Location = new System.Drawing.Point(240, 3);
            this.txtFromDate.Mask = "0000/00/00";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(115, 23);
            this.txtFromDate.TabIndex = 6;
            // 
            // txtToDate
            // 
            this.txtToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtToDate.Location = new System.Drawing.Point(59, 3);
            this.txtToDate.Mask = "0000/00/00";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(115, 23);
            this.txtToDate.TabIndex = 7;
            // 
            // btnResat
            // 
            this.btnResat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResat.Image = ((System.Drawing.Image)(resources.GetObject("btnResat.Image")));
            this.btnResat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnResat.Location = new System.Drawing.Point(443, 4);
            this.btnResat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResat.Name = "btnResat";
            this.btnResat.Size = new System.Drawing.Size(116, 42);
            this.btnResat.TabIndex = 3;
            this.btnResat.Text = "بروزرسانی";
            this.btnResat.ToolTipText = "s";
            this.btnResat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnResat.Click += new System.EventHandler(this.BtnResat_Click);
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.grdCardex, 0, 1);
            this.tblMain.Controls.Add(this.tblControlsData, 0, 0);
            this.tblMain.Controls.Add(this.tblFooter, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblMain.Size = new System.Drawing.Size(812, 327);
            this.tblMain.TabIndex = 4;
            // 
            // grdCardex
            // 
            this.grdCardex.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdCardex.AlternatingColors = true;
            this.grdCardex.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdCardex.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdCardex.ColumnAutoResize = true;
            grdCardex_DesignTimeLayout.LayoutString = resources.GetString("grdCardex_DesignTimeLayout.LayoutString");
            this.grdCardex.DesignTimeLayout = grdCardex_DesignTimeLayout;
            this.grdCardex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCardex.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdCardex.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdCardex.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdCardex.GroupByBoxFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(59)))), ((int)(((byte)(206)))));
            this.grdCardex.GroupByBoxFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(59)))), ((int)(((byte)(206)))));
            this.grdCardex.GroupByBoxInfoFormatStyle.BackColor = System.Drawing.Color.Empty;
            this.grdCardex.GroupByBoxVisible = false;
            this.grdCardex.GroupRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(59)))), ((int)(((byte)(206)))));
            this.grdCardex.GroupTotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(59)))), ((int)(((byte)(206)))));
            this.grdCardex.Location = new System.Drawing.Point(3, 50);
            this.grdCardex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdCardex.Name = "grdCardex";
            this.grdCardex.Size = new System.Drawing.Size(806, 217);
            this.grdCardex.TabIndex = 3;
            this.grdCardex.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdCardex.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // tblFooter
            // 
            this.tblFooter.BackColor = System.Drawing.Color.Transparent;
            this.tblFooter.ColumnCount = 4;
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Controls.Add(this.btnSearch, 0, 0);
            this.tblFooter.Controls.Add(this.btnPrint, 1, 0);
            this.tblFooter.Controls.Add(this.btnResat, 2, 0);
            this.tblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFooter.Location = new System.Drawing.Point(3, 274);
            this.tblFooter.Name = "tblFooter";
            this.tblFooter.RowCount = 1;
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Size = new System.Drawing.Size(806, 50);
            this.tblFooter.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSearch.Location = new System.Drawing.Point(687, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 42);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.ToolTipText = "F8";
            this.btnSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrint.Location = new System.Drawing.Point(565, 4);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(116, 42);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.ToolTipText = "Ctrl +P";
            this.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnPrint.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // UC_Cardex_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Cardex_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(812, 327);
            this.Load += new System.EventHandler(this.UC_Report_Load);
            this.tblControlsData.ResumeLayout(false);
            this.tblControlsData.PerformLayout();
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCardex)).EndInit();
            this.tblFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tblControlsData;
        private Janus.Windows.GridEX.EditControls.EditBox txtGoodsName;
        private Janus.Windows.EditControls.UIComboBox cmbInventory;
        private System.Windows.Forms.Label lblGoods;
        private System.Windows.Forms.Label lblInventory;
        private Janus.Windows.EditControls.UIButton btnSelectGoods;
        private Janus.Windows.EditControls.UIButton btnResat;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblFooter;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private Janus.Windows.GridEX.EditControls.MaskedEditBox txtFromDate;
        private Janus.Windows.GridEX.EditControls.MaskedEditBox txtToDate;
        private Janus.Windows.GridEX.GridEX grdCardex;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIButton btnPrint;
    }
}

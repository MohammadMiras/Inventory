namespace Cactus.Inventory.UI.CustomControls
{
    partial class UC_Stock_Inventory_Report
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
            Janus.Windows.GridEX.GridEXLayout grdCardex_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Stock_Inventory_Report));
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdCardex = new Janus.Windows.GridEX.GridEX();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblInventory = new System.Windows.Forms.Label();
            this.cmbInventory = new Janus.Windows.EditControls.UIComboBox();
            this.tblFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new Janus.Windows.EditControls.UIButton();
            this.btnResat = new Janus.Windows.EditControls.UIButton();
            this.btnPrint = new Janus.Windows.EditControls.UIButton();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCardex)).BeginInit();
            this.tblHeader.SuspendLayout();
            this.tblFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.grdCardex, 0, 1);
            this.tblMain.Controls.Add(this.tblHeader, 0, 0);
            this.tblMain.Controls.Add(this.tblFooter, 0, 2);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(812, 327);
            this.tblMain.TabIndex = 0;
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
            this.grdCardex.Location = new System.Drawing.Point(3, 42);
            this.grdCardex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdCardex.Name = "grdCardex";
            this.grdCardex.Size = new System.Drawing.Size(806, 226);
            this.grdCardex.TabIndex = 4;
            this.grdCardex.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdCardex.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // tblHeader
            // 
            this.tblHeader.ColumnCount = 3;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.Controls.Add(this.lblInventory, 0, 0);
            this.tblHeader.Controls.Add(this.cmbInventory, 1, 0);
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeader.Location = new System.Drawing.Point(3, 4);
            this.tblHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 1;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblHeader.Size = new System.Drawing.Size(806, 30);
            this.tblHeader.TabIndex = 0;
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInventory.Location = new System.Drawing.Point(764, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(39, 30);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "انبار ";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbInventory
            // 
            this.cmbInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbInventory.Location = new System.Drawing.Point(632, 3);
            this.cmbInventory.Name = "cmbInventory";
            this.cmbInventory.Size = new System.Drawing.Size(126, 24);
            this.cmbInventory.TabIndex = 1;
            this.cmbInventory.Text = "...انتخاب...";
            this.cmbInventory.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.cmbInventory.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.cmbInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbInventory_KeyPress);
            // 
            // tblFooter
            // 
            this.tblFooter.ColumnCount = 4;
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Controls.Add(this.btnSearch, 0, 0);
            this.tblFooter.Controls.Add(this.btnResat, 2, 0);
            this.tblFooter.Controls.Add(this.btnPrint, 1, 0);
            this.tblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFooter.Location = new System.Drawing.Point(3, 275);
            this.tblFooter.Name = "tblFooter";
            this.tblFooter.RowCount = 1;
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Size = new System.Drawing.Size(806, 49);
            this.tblFooter.TabIndex = 1;
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
            this.btnSearch.Size = new System.Drawing.Size(116, 41);
            this.btnSearch.TabIndex = 5;
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
            this.btnResat.Location = new System.Drawing.Point(443, 4);
            this.btnResat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResat.Name = "btnResat";
            this.btnResat.Size = new System.Drawing.Size(116, 41);
            this.btnResat.TabIndex = 4;
            this.btnResat.Text = "بروزرسانی ";
            this.btnResat.ToolTipText = "F9";
            this.btnResat.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnResat.Click += new System.EventHandler(this.BtnResat_Click);
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
            this.btnPrint.Size = new System.Drawing.Size(116, 41);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "چاپ";
            this.btnPrint.ToolTipText = "Ctrl+P";
            this.btnPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // UC_Stock_Inventory_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Stock_Inventory_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(812, 327);
            this.Load += new System.EventHandler(this.UC_Stock_Inventory_Report_Load);
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCardex)).EndInit();
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.tblFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.TableLayoutPanel tblFooter;
        private Janus.Windows.EditControls.UIButton btnPrint;
        private Janus.Windows.EditControls.UIButton btnSearch;
        private Janus.Windows.EditControls.UIButton btnResat;
        private System.Windows.Forms.Label lblInventory;
        private Janus.Windows.EditControls.UIComboBox cmbInventory;
        private Janus.Windows.GridEX.GridEX grdCardex;
    }
}

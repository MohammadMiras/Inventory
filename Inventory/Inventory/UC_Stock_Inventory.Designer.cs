namespace Cactus.Inventory.UI
{
    partial class UC_Stock_Inventory
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
            Janus.Windows.GridEX.GridEXLayout grdGoodsStock_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Stock_Inventory));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.grdGoodsStock = new Janus.Windows.GridEX.GridEX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblCodeInventory = new System.Windows.Forms.Label();
            this.lblTxtxTitle = new System.Windows.Forms.Label();
            this.lblTitleInventory = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGoodsStock)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.grdGoodsStock, 0, 1);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tlpMain.Size = new System.Drawing.Size(384, 228);
            this.tlpMain.TabIndex = 0;
            // 
            // grdGoodsStock
            // 
            this.grdGoodsStock.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.grdGoodsStock.AlternatingColors = true;
            this.grdGoodsStock.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdGoodsStock.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdGoodsStock.BackColor = System.Drawing.Color.White;
            this.grdGoodsStock.ColumnAutoResize = true;
            grdGoodsStock_DesignTimeLayout.LayoutString = resources.GetString("grdGoodsStock_DesignTimeLayout.LayoutString");
            this.grdGoodsStock.DesignTimeLayout = grdGoodsStock_DesignTimeLayout;
            this.grdGoodsStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGoodsStock.FlatBorderColor = System.Drawing.Color.White;
            this.grdGoodsStock.GridLineColor = System.Drawing.SystemColors.Control;
            this.grdGoodsStock.GroupByBoxVisible = false;
            this.grdGoodsStock.Location = new System.Drawing.Point(3, 49);
            this.grdGoodsStock.Name = "grdGoodsStock";
            this.grdGoodsStock.Size = new System.Drawing.Size(378, 164);
            this.grdGoodsStock.TabIndex = 0;
            this.grdGoodsStock.TreeLineColor = System.Drawing.Color.Transparent;
            this.grdGoodsStock.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdGoodsStock.DoubleClick += new System.EventHandler(this.GrdGoodsStock_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblCode, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCodeInventory, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTxtxTitle, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitleInventory, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 40);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCode.Location = new System.Drawing.Point(310, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(65, 40);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "کد انبار:";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodeInventory
            // 
            this.lblCodeInventory.AutoSize = true;
            this.lblCodeInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodeInventory.Location = new System.Drawing.Point(250, 0);
            this.lblCodeInventory.Name = "lblCodeInventory";
            this.lblCodeInventory.Size = new System.Drawing.Size(54, 40);
            this.lblCodeInventory.TabIndex = 0;
            this.lblCodeInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTxtxTitle
            // 
            this.lblTxtxTitle.AutoSize = true;
            this.lblTxtxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTxtxTitle.Location = new System.Drawing.Point(172, 0);
            this.lblTxtxTitle.Name = "lblTxtxTitle";
            this.lblTxtxTitle.Size = new System.Drawing.Size(72, 40);
            this.lblTxtxTitle.TabIndex = 0;
            this.lblTxtxTitle.Text = "عنوان انبار :";
            this.lblTxtxTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleInventory
            // 
            this.lblTitleInventory.AutoSize = true;
            this.lblTitleInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitleInventory.Location = new System.Drawing.Point(113, 0);
            this.lblTitleInventory.Name = "lblTitleInventory";
            this.lblTitleInventory.Size = new System.Drawing.Size(53, 40);
            this.lblTitleInventory.TabIndex = 0;
            this.lblTitleInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Stock_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "UC_Stock_Inventory";
            this.Size = new System.Drawing.Size(384, 228);
            this.Load += new System.EventHandler(this.UC_Stock_Inventory_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGoodsStock)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblCodeInventory;
        private System.Windows.Forms.Label lblTxtxTitle;
        private System.Windows.Forms.Label lblTitleInventory;
        private Janus.Windows.GridEX.GridEX grdGoodsStock;
    }
}

namespace Cactus.Inventory.UI
{
    partial class UC_Inventory_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inventory_Main));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnTransaction = new Janus.Windows.EditControls.UIButton();
            this.btnInventory = new Janus.Windows.EditControls.UIButton();
            this.btnGoods = new Janus.Windows.EditControls.UIButton();
            this.btnReport = new Janus.Windows.EditControls.UIButton();
            this.lblWelcom = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 328F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.tlpButtons, 1, 1);
            this.tlpMain.Controls.Add(this.lblWelcom, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(331, 190);
            this.tlpMain.TabIndex = 2;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.btnTransaction, 1, 1);
            this.tlpButtons.Controls.Add(this.btnInventory, 0, 0);
            this.tlpButtons.Controls.Add(this.btnGoods, 1, 0);
            this.tlpButtons.Controls.Add(this.btnReport, 0, 1);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(5, 58);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 2;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Size = new System.Drawing.Size(322, 124);
            this.tlpButtons.TabIndex = 0;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTransaction.Location = new System.Drawing.Point(3, 65);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(155, 56);
            this.btnTransaction.TabIndex = 3;
            this.btnTransaction.Text = "حواله/رسید";
            this.btnTransaction.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnTransaction.Click += new System.EventHandler(this.BtnTransaction_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInventory.Location = new System.Drawing.Point(164, 3);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(155, 56);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "انبار";
            this.btnInventory.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // btnGoods
            // 
            this.btnGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnGoods.Image")));
            this.btnGoods.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGoods.Location = new System.Drawing.Point(3, 3);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(155, 56);
            this.btnGoods.TabIndex = 1;
            this.btnGoods.Text = "کالا";
            this.btnGoods.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnGoods.Click += new System.EventHandler(this.BtnGoods_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReport.Location = new System.Drawing.Point(164, 65);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(155, 56);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "گزارش";
            this.btnReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // lblWelcom
            // 
            this.lblWelcom.AutoSize = true;
            this.lblWelcom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcom.Location = new System.Drawing.Point(5, 0);
            this.lblWelcom.Name = "lblWelcom";
            this.lblWelcom.Size = new System.Drawing.Size(322, 55);
            this.lblWelcom.TabIndex = 1;
            this.lblWelcom.Text = "به سیستم انبار داری خوش آمدید";
            this.lblWelcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Inventory_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Inventory_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(331, 190);
            this.Load += new System.EventHandler(this.UC_Inventory_Main_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private Janus.Windows.EditControls.UIButton btnTransaction;
        private Janus.Windows.EditControls.UIButton btnInventory;
        private Janus.Windows.EditControls.UIButton btnGoods;
        private Janus.Windows.EditControls.UIButton btnReport;
        private System.Windows.Forms.Label lblWelcom;
    }
}

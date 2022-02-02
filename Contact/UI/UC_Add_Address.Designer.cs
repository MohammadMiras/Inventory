namespace Cactus.Contact.UI
{
    partial class UC_Add_Address
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Add_Address));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblAddressType = new System.Windows.Forms.Label();
            this.lblAddressTitle = new System.Windows.Forms.Label();
            this.txtAddressTitle = new Janus.Windows.GridEX.EditControls.EditBox();
            this.cmbAddressType = new Janus.Windows.EditControls.UIComboBox();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new Janus.Windows.EditControls.UIButton();
            this.tlpMain.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.tlpFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tblHeader, 0, 0);
            this.tlpMain.Controls.Add(this.tlpFooter, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpMain.Size = new System.Drawing.Size(242, 115);
            this.tlpMain.TabIndex = 2;
            // 
            // tblHeader
            // 
            this.tblHeader.ColumnCount = 2;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.Controls.Add(this.lblAddressType, 0, 0);
            this.tblHeader.Controls.Add(this.lblAddressTitle, 0, 1);
            this.tblHeader.Controls.Add(this.txtAddressTitle, 1, 1);
            this.tblHeader.Controls.Add(this.cmbAddressType, 1, 0);
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeader.Location = new System.Drawing.Point(8, 3);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 2;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblHeader.Size = new System.Drawing.Size(231, 61);
            this.tblHeader.TabIndex = 0;
            // 
            // lblAddressType
            // 
            this.lblAddressType.AutoSize = true;
            this.lblAddressType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddressType.Location = new System.Drawing.Point(167, 0);
            this.lblAddressType.Name = "lblAddressType";
            this.lblAddressType.Size = new System.Drawing.Size(61, 30);
            this.lblAddressType.TabIndex = 0;
            this.lblAddressType.Text = "نوع آدرس ";
            this.lblAddressType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAddressTitle
            // 
            this.lblAddressTitle.AutoSize = true;
            this.lblAddressTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddressTitle.Location = new System.Drawing.Point(167, 30);
            this.lblAddressTitle.Name = "lblAddressTitle";
            this.lblAddressTitle.Size = new System.Drawing.Size(61, 31);
            this.lblAddressTitle.TabIndex = 2;
            this.lblAddressTitle.Text = "آدرس";
            this.lblAddressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddressTitle
            // 
            this.txtAddressTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddressTitle.Location = new System.Drawing.Point(3, 33);
            this.txtAddressTitle.Name = "txtAddressTitle";
            this.txtAddressTitle.Size = new System.Drawing.Size(158, 22);
            this.txtAddressTitle.TabIndex = 3;
            this.txtAddressTitle.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // cmbAddressType
            // 
            this.cmbAddressType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbAddressType.Location = new System.Drawing.Point(3, 3);
            this.cmbAddressType.Name = "cmbAddressType";
            this.cmbAddressType.Size = new System.Drawing.Size(158, 24);
            this.cmbAddressType.TabIndex = 1;
            this.cmbAddressType.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // tlpFooter
            // 
            this.tlpFooter.ColumnCount = 3;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Controls.Add(this.btnAdd, 1, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(8, 75);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(231, 37);
            this.tlpFooter.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(70, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 31);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "اضافه ";
            this.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // UC_Add_Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Add_Address";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(242, 115);
            this.Load += new System.EventHandler(this.UC_Add_Address_Load);
            this.tlpMain.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.tlpFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Label lblAddressType;
        private System.Windows.Forms.Label lblAddressTitle;
        private Janus.Windows.GridEX.EditControls.EditBox txtAddressTitle;
        private Janus.Windows.EditControls.UIComboBox cmbAddressType;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private Janus.Windows.EditControls.UIButton btnAdd;
    }
}

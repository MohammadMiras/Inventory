namespace  Cactus.Contact.UI

{
    partial class UC_Add_Phone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Add_Phone));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lbPhoneType = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new Janus.Windows.GridEX.EditControls.EditBox();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.cmbPhoneType = new Janus.Windows.EditControls.UIComboBox();
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
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tblHeader, 0, 0);
            this.tlpMain.Controls.Add(this.tlpFooter, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlpMain.Size = new System.Drawing.Size(207, 102);
            this.tlpMain.TabIndex = 3;
            // 
            // tblHeader
            // 
            this.tblHeader.ColumnCount = 2;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tblHeader.Controls.Add(this.lbPhoneType, 0, 0);
            this.tblHeader.Controls.Add(this.txtPhoneNumber, 1, 1);
            this.tblHeader.Controls.Add(this.lblPhoneTitle, 0, 1);
            this.tblHeader.Controls.Add(this.cmbPhoneType, 1, 0);
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeader.Location = new System.Drawing.Point(6, 3);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 2;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.Size = new System.Drawing.Size(198, 56);
            this.tblHeader.TabIndex = 0;
            // 
            // lbPhoneType
            // 
            this.lbPhoneType.AutoSize = true;
            this.lbPhoneType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPhoneType.Location = new System.Drawing.Point(135, 0);
            this.lbPhoneType.Name = "lbPhoneType";
            this.lbPhoneType.Size = new System.Drawing.Size(60, 29);
            this.lbPhoneType.TabIndex = 0;
            this.lbPhoneType.Text = "نوع تلفن";
            this.lbPhoneType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneNumber.Location = new System.Drawing.Point(3, 32);
            this.txtPhoneNumber.MaxLength = 14;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(126, 22);
            this.txtPhoneNumber.TabIndex = 3;
            this.txtPhoneNumber.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhoneTitle.Location = new System.Drawing.Point(135, 29);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(60, 27);
            this.lblPhoneTitle.TabIndex = 2;
            this.lblPhoneTitle.Text = "تلفن";
            this.lblPhoneTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPhoneType
            // 
            this.cmbPhoneType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPhoneType.Location = new System.Drawing.Point(3, 3);
            this.cmbPhoneType.Name = "cmbPhoneType";
            this.cmbPhoneType.Size = new System.Drawing.Size(126, 23);
            this.cmbPhoneType.TabIndex = 1;
            this.cmbPhoneType.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // tlpFooter
            // 
            this.tlpFooter.BackColor = System.Drawing.Color.Transparent;
            this.tlpFooter.ColumnCount = 3;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Controls.Add(this.btnAdd, 1, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(6, 67);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(198, 32);
            this.tlpFooter.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(51, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "اضافه ";
            this.btnAdd.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // UC_Add_Phone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Add_Phone";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(207, 102);
            this.Load += new System.EventHandler(this.UC_Add_Phone_Load);
            this.tlpMain.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.tlpFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Label lbPhoneType;
        private Janus.Windows.GridEX.EditControls.EditBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneTitle;
        private Janus.Windows.EditControls.UIComboBox cmbPhoneType;
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private Janus.Windows.EditControls.UIButton btnAdd;
    }
}

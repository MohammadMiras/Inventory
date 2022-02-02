namespace Cactus.SystemManagement.UI
{
    partial class UC_Insert_Update_Role
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Insert_Update_Role));
            Janus.Windows.GridEX.GridEXLayout grdObj_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new Janus.Windows.GridEX.EditControls.EditBox();
            this.tblFooter = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new Janus.Windows.EditControls.UIButton();
            this.tblBody = new System.Windows.Forms.TableLayoutPanel();
            this.grdObj = new Janus.Windows.GridEX.GridEX();
            this.label1 = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblHeader.SuspendLayout();
            this.tblFooter.SuspendLayout();
            this.tblBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdObj)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Controls.Add(this.tblHeader, 0, 0);
            this.tblMain.Controls.Add(this.tblFooter, 0, 2);
            this.tblMain.Controls.Add(this.tblBody, 0, 1);
            this.tblMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tblMain.Size = new System.Drawing.Size(339, 353);
            this.tblMain.TabIndex = 1;
            // 
            // tblHeader
            // 
            this.tblHeader.ColumnCount = 3;
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeader.Controls.Add(this.lblTitle, 0, 1);
            this.tblHeader.Controls.Add(this.txtTitle, 1, 1);
            this.tblHeader.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHeader.Location = new System.Drawing.Point(3, 3);
            this.tblHeader.Name = "tblHeader";
            this.tblHeader.RowCount = 2;
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.17808F));
            this.tblHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.82191F));
            this.tblHeader.Size = new System.Drawing.Size(333, 34);
            this.tblHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(276, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = " عنوان ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(156, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(114, 21);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // tblFooter
            // 
            this.tblFooter.ColumnCount = 2;
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tblFooter.Controls.Add(this.btnSave, 1, 0);
            this.tblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFooter.Location = new System.Drawing.Point(3, 307);
            this.tblFooter.Name = "tblFooter";
            this.tblFooter.RowCount = 1;
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblFooter.Size = new System.Drawing.Size(333, 43);
            this.tblFooter.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 37);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "ثبت";
            this.btnSave.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // tblBody
            // 
            this.tblBody.ColumnCount = 1;
            this.tblBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblBody.Controls.Add(this.grdObj, 0, 1);
            this.tblBody.Controls.Add(this.label1, 0, 0);
            this.tblBody.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tblBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBody.Location = new System.Drawing.Point(3, 43);
            this.tblBody.Name = "tblBody";
            this.tblBody.RowCount = 2;
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBody.Size = new System.Drawing.Size(333, 258);
            this.tblBody.TabIndex = 1;
            // 
            // grdObj
            // 
            this.grdObj.AlternatingColors = true;
            this.grdObj.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.grdObj.AlternatingRowFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Opaque;
            this.grdObj.AlternatingRowFormatStyle.BackgroundGradientMode = Janus.Windows.GridEX.BackgroundGradientMode.Vertical;
            this.grdObj.ColumnAutoResize = true;
            this.grdObj.Cursor = System.Windows.Forms.Cursors.Default;
            grdObj_DesignTimeLayout.LayoutString = resources.GetString("grdObj_DesignTimeLayout.LayoutString");
            this.grdObj.DesignTimeLayout = grdObj_DesignTimeLayout;
            this.grdObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdObj.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdObj.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.grdObj.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.grdObj.GroupByBoxVisible = false;
            this.grdObj.Location = new System.Drawing.Point(3, 41);
            this.grdObj.Name = "grdObj";
            this.grdObj.Size = new System.Drawing.Size(327, 214);
            this.grdObj.TabIndex = 7;
            this.grdObj.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.grdObj.TabStop = false;
            this.grdObj.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.grdObj.CellValueChanged += new Janus.Windows.GridEX.ColumnActionEventHandler(this.GrdObj_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "تعیین  عدم دسترسی به بخش های سیستم ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Insert_Update_Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "UC_Insert_Update_Role";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(339, 353);
            this.Load += new System.EventHandler(this.UC_Insert_Update_Role_Load);
            this.tblMain.ResumeLayout(false);
            this.tblHeader.ResumeLayout(false);
            this.tblHeader.PerformLayout();
            this.tblFooter.ResumeLayout(false);
            this.tblBody.ResumeLayout(false);
            this.tblBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdObj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblHeader;
        private System.Windows.Forms.Label lblTitle;
        private Janus.Windows.GridEX.EditControls.EditBox txtTitle;
        private System.Windows.Forms.TableLayoutPanel tblFooter;
        private Janus.Windows.EditControls.UIButton btnSave;
        private System.Windows.Forms.TableLayoutPanel tblBody;
        private Janus.Windows.GridEX.GridEX grdObj;
        private System.Windows.Forms.Label label1;
    }
}

namespace Cactus.SystemManagement.UI 
{
    partial class UC_System_Management
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("کاربران");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ویرایش رشته اتصال ");
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblBody = new System.Windows.Forms.TableLayoutPanel();
            this.TreeView2 = new System.Windows.Forms.TreeView();
            this.GbControl = new Janus.Windows.EditControls.UIGroupBox();
            this.tblMain.SuspendLayout();
            this.tblBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GbControl)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblMain.Controls.Add(this.tblBody, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 3;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tblMain.Size = new System.Drawing.Size(889, 590);
            this.tblMain.TabIndex = 2;
            // 
            // tblBody
            // 
            this.tblBody.ColumnCount = 2;
            this.tblBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tblBody.Controls.Add(this.TreeView2, 1, 0);
            this.tblBody.Controls.Add(this.GbControl, 0, 0);
            this.tblBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBody.Location = new System.Drawing.Point(3, 10);
            this.tblBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tblBody.Name = "tblBody";
            this.tblBody.RowCount = 1;
            this.tblBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBody.Size = new System.Drawing.Size(883, 570);
            this.tblBody.TabIndex = 0;
            // 
            // TreeView2
            // 
            this.TreeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView2.Location = new System.Drawing.Point(3, 3);
            this.TreeView2.Name = "TreeView2";
            treeNode1.Name = "Users";
            treeNode1.Text = "کاربران";
            treeNode2.Name = "AddConection";
            treeNode2.Text = "ویرایش رشته اتصال ";
            this.TreeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.TreeView2.Size = new System.Drawing.Size(169, 564);
            this.TreeView2.TabIndex = 1;
            this.TreeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView2_AfterSelect);
            // 
            // GbControl
            // 
            this.GbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbControl.Location = new System.Drawing.Point(178, 3);
            this.GbControl.Name = "GbControl";
            this.GbControl.Size = new System.Drawing.Size(702, 564);
            this.GbControl.TabIndex = 2;
            // 
            // UC_System_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "UC_System_Management";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(889, 590);
            this.Load += new System.EventHandler(this.UC_System_Management_Load);
            this.tblMain.ResumeLayout(false);
            this.tblBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GbControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.TableLayoutPanel tblBody;
        private System.Windows.Forms.TreeView TreeView2;
        private Janus.Windows.EditControls.UIGroupBox GbControl;
    }
}

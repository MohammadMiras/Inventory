namespace Cactus.Inventory.UI
{
    partial class UC_Report
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("موجودی انبار ");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("کاردکس");
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage4 = new Janus.Windows.UI.Tab.UITabPage();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.tblHome = new System.Windows.Forms.TableLayoutPanel();
            this.tblMainControls = new System.Windows.Forms.TableLayoutPanel();
            this.gbReport = new Janus.Windows.EditControls.UIGroupBox();
            this.tblHome.SuspendLayout();
            this.tblMainControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbReport)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.Location = new System.Drawing.Point(0, 0);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.Size = new System.Drawing.Size(0, 0);
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "New Tab";
            // 
            // uiTabPage4
            // 
            this.uiTabPage4.Location = new System.Drawing.Point(0, 0);
            this.uiTabPage4.Name = "uiTabPage4";
            this.uiTabPage4.Size = new System.Drawing.Size(0, 0);
            this.uiTabPage4.TabStop = true;
            this.uiTabPage4.Text = "New Tab";
            // 
            // trvMenu
            // 
            this.trvMenu.BackColor = System.Drawing.SystemColors.Window;
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvMenu.ItemHeight = 25;
            this.trvMenu.Location = new System.Drawing.Point(3, 3);
            this.trvMenu.Name = "trvMenu";
            treeNode1.BackColor = System.Drawing.Color.Transparent;
            treeNode1.ForeColor = System.Drawing.Color.Black;
            treeNode1.Name = "nodeStock";
            treeNode1.NodeFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "موجودی انبار ";
            treeNode2.Name = "nodeCardex";
            treeNode2.NodeFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.Text = "کاردکس";
            this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.trvMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trvMenu.Size = new System.Drawing.Size(144, 328);
            this.trvMenu.TabIndex = 3;
            this.trvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreevMenu_AfterSelect);
            // 
            // tblHome
            // 
            this.tblHome.ColumnCount = 1;
            this.tblHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHome.Controls.Add(this.tblMainControls, 0, 1);
            this.tblHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHome.Location = new System.Drawing.Point(0, 0);
            this.tblHome.Name = "tblHome";
            this.tblHome.RowCount = 3;
            this.tblHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tblHome.Size = new System.Drawing.Size(945, 350);
            this.tblHome.TabIndex = 4;
            // 
            // tblMainControls
            // 
            this.tblMainControls.ColumnCount = 2;
            this.tblMainControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblMainControls.Controls.Add(this.trvMenu, 1, 0);
            this.tblMainControls.Controls.Add(this.gbReport, 0, 0);
            this.tblMainControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainControls.Location = new System.Drawing.Point(3, 8);
            this.tblMainControls.Name = "tblMainControls";
            this.tblMainControls.RowCount = 1;
            this.tblMainControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainControls.Size = new System.Drawing.Size(939, 334);
            this.tblMainControls.TabIndex = 0;
            // 
            // gbReport
            // 
            this.gbReport.BackColor = System.Drawing.Color.Transparent;
            this.gbReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReport.Location = new System.Drawing.Point(153, 3);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(783, 328);
            this.gbReport.TabIndex = 0;
            this.gbReport.Text = "    ";
            this.gbReport.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2007;
            // 
            // UC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblHome);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(945, 350);
            this.Load += new System.EventHandler(this.UC_Report_Load);
            this.tblHome.ResumeLayout(false);
            this.tblMainControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage4;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.TableLayoutPanel tblHome;
        private System.Windows.Forms.TableLayoutPanel tblMainControls;
        private Janus.Windows.EditControls.UIGroupBox gbReport;
    }
}

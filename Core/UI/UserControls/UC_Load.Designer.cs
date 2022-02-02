namespace UI.UserControls
{
    partial class UC_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Load));
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoading
            // 
            this.pbLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(0, 0);
            this.pbLoading.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(271, 249);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoading.TabIndex = 3;
            this.pbLoading.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoading.Location = new System.Drawing.Point(0, 0);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Padding = new System.Windows.Forms.Padding(0, 0, 0, 35);
            this.lblLoading.Size = new System.Drawing.Size(271, 249);
            this.lblLoading.TabIndex = 4;
            this.lblLoading.Text = "در حال بارگزاری...";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UC_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pbLoading);
            this.Name = "UC_Load";
            this.Size = new System.Drawing.Size(271, 249);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lblLoading;
    }
}

namespace OnlineStoreProject
{
    partial class frmSearchProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlSearchProduct1 = new OnlineStoreProject.ctrlSearchProduct();
            this.SuspendLayout();
            // 
            // ctrlSearchProduct1
            // 
            this.ctrlSearchProduct1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlSearchProduct1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchProduct1.Location = new System.Drawing.Point(8, 29);
            this.ctrlSearchProduct1.Name = "ctrlSearchProduct1";
            this.ctrlSearchProduct1.Size = new System.Drawing.Size(836, 731);
            this.ctrlSearchProduct1.TabIndex = 0;
            // 
            // frmSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 759);
            this.Controls.Add(this.ctrlSearchProduct1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchProduct";
            this.Text = "Search Product";
            this.Load += new System.EventHandler(this.frmSearchProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSearchProduct ctrlSearchProduct1;
    }
}
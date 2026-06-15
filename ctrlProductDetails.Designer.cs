namespace OnlineStoreProject
{
    partial class ctrlProductDetails
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
            this.ctrlProductCardInfos1 = new OnlineStoreProject.ctrlProductCardInfos();
            this.SuspendLayout();
            // 
            // ctrlProductCardInfos1
            // 
            this.ctrlProductCardInfos1.BackColor = System.Drawing.Color.White;
            this.ctrlProductCardInfos1.Location = new System.Drawing.Point(29, 12);
            this.ctrlProductCardInfos1.Name = "ctrlProductCardInfos1";
            this.ctrlProductCardInfos1.Size = new System.Drawing.Size(772, 570);
            this.ctrlProductCardInfos1.TabIndex = 0;
            // 
            // ctrlProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 610);
            this.Controls.Add(this.ctrlProductCardInfos1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ctrlProductDetails";
            this.Text = "Product Details";
            this.Load += new System.EventHandler(this.ctrlProductDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlProductCardInfos ctrlProductCardInfos1;
    }
}
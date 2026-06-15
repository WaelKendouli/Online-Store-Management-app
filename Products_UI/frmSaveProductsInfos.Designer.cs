namespace OnlineStoreProject.Products_UI
{
    partial class frmSaveProductsInfos
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
            this.ctrlSaveProductInfos1 = new OnlineStoreProject.ctrlSaveProductInfos();
            this.SuspendLayout();
            // 
            // ctrlSaveProductInfos1
            // 
            this.ctrlSaveProductInfos1.BackColor = System.Drawing.Color.White;
            this.ctrlSaveProductInfos1.Location = new System.Drawing.Point(59, 27);
            this.ctrlSaveProductInfos1.Name = "ctrlSaveProductInfos1";
            this.ctrlSaveProductInfos1.Size = new System.Drawing.Size(1038, 553);
            this.ctrlSaveProductInfos1.TabIndex = 0;
            this.ctrlSaveProductInfos1.OnProductInfosSaved += new System.EventHandler<LogicLayer.Events.ProductEventArgs>(this.ctrlSaveProductInfos1_OnProductInfosSaved);
            // 
            // frmSaveProductsInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1170, 625);
            this.Controls.Add(this.ctrlSaveProductInfos1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveProductsInfos";
            this.Text = "frmSaveProductsInfos";
            this.Load += new System.EventHandler(this.frmSaveProductsInfos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSaveProductInfos ctrlSaveProductInfos1;
    }
}
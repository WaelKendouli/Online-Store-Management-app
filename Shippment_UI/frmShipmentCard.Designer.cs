namespace OnlineStoreProject.Shippment_UI
{
    partial class frmShipmentCard
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
            this.ctrlShipmentCard1 = new OnlineStoreProject.ctrlShipmentCard();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // ctrlShipmentCard1
            // 
            this.ctrlShipmentCard1.BackColor = System.Drawing.Color.White;
            this.ctrlShipmentCard1.Location = new System.Drawing.Point(27, 82);
            this.ctrlShipmentCard1.Name = "ctrlShipmentCard1";
            this.ctrlShipmentCard1.Size = new System.Drawing.Size(926, 584);
            this.ctrlShipmentCard1.TabIndex = 0;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiLabel1.Location = new System.Drawing.Point(295, 24);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(435, 45);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Shipment details";
            // 
            // frmShipmentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 678);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.ctrlShipmentCard1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShipmentCard";
            this.Text = "Shipment Card";
            this.Load += new System.EventHandler(this.frmShipmentCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShipmentCard ctrlShipmentCard1;
        private Sunny.UI.UILabel uiLabel1;
    }
}
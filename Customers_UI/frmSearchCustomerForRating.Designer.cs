namespace OnlineStoreProject
{
    partial class frmSearchCustomerForRating
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
            this.ctrlSearchCustomer1 = new OnlineStoreProject.ctrlSearchCustomer();
            this.SuspendLayout();
            // 
            // ctrlSearchCustomer1
            // 
            this.ctrlSearchCustomer1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchCustomer1.Location = new System.Drawing.Point(23, 12);
            this.ctrlSearchCustomer1.Name = "ctrlSearchCustomer1";
            this.ctrlSearchCustomer1.Size = new System.Drawing.Size(1030, 631);
            this.ctrlSearchCustomer1.TabIndex = 0;
            this.ctrlSearchCustomer1.OnSearchedPerformed += new System.EventHandler<LogicLayer.Events.clsCustomerEventsArgs>(this.ctrlSearchCustomer1_OnSearchedPerformed);
            // 
            // frmSearchCustomerForRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1078, 647);
            this.Controls.Add(this.ctrlSearchCustomer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchCustomerForRating";
            this.Text = "Search Customer For Rating";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSearchCustomer ctrlSearchCustomer1;
    }
}
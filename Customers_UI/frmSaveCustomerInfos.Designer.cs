namespace OnlineStoreProject.Customers_UI
{
    partial class frmSaveCustomerInfos
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.ctrlSaveICustomerInfo1 = new OnlineStoreProject.ctrlSaveICustomerInfo();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.FillColor = System.Drawing.Color.Red;
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiPanel1.FillColorGradient = true;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(242, 611);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlSaveICustomerInfo1
            // 
            this.ctrlSaveICustomerInfo1.AutoSize = true;
            this.ctrlSaveICustomerInfo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlSaveICustomerInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlSaveICustomerInfo1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSaveICustomerInfo1.Location = new System.Drawing.Point(272, 95);
            this.ctrlSaveICustomerInfo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ctrlSaveICustomerInfo1.Name = "ctrlSaveICustomerInfo1";
            this.ctrlSaveICustomerInfo1.Size = new System.Drawing.Size(961, 411);
            this.ctrlSaveICustomerInfo1.TabIndex = 1;
            this.ctrlSaveICustomerInfo1.OnCustomerSaved += new System.EventHandler<LogicLayer.Events.clsCustomerEventsArgs>(this.ctrlSaveICustomerInfo1_OnCustomerSaved);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiLabel1.Location = new System.Drawing.Point(280, 22);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(1135, 57);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Save customer informaton";
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // frmSaveCustomerInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1629, 611);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.ctrlSaveICustomerInfo1);
            this.Controls.Add(this.uiPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveCustomerInfos";
            this.Text = "Save Customer Infos";
            this.Load += new System.EventHandler(this.frmSaveCustomerInfos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private ctrlSaveICustomerInfo ctrlSaveICustomerInfo1;
        private Sunny.UI.UILabel uiLabel1;
    }
}
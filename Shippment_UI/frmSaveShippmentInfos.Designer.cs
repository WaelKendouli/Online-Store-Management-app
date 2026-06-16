namespace OnlineStoreProject.Shippment_UI
{
    partial class frmSaveShippmentInfos
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
            this.ctrlSaveShippementInfo1 = new OnlineStoreProject.ctrlSaveShippementInfo();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // ctrlSaveShippementInfo1
            // 
            this.ctrlSaveShippementInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlSaveShippementInfo1.Location = new System.Drawing.Point(156, 99);
            this.ctrlSaveShippementInfo1.Name = "ctrlSaveShippementInfo1";
            this.ctrlSaveShippementInfo1.Size = new System.Drawing.Size(852, 579);
            this.ctrlSaveShippementInfo1.TabIndex = 0;
            this.ctrlSaveShippementInfo1.OnShippementInfoConfirmed += new System.EventHandler<LogicLayer.Events.ShipmentsEventArgs>(this.ctrlSaveShippementInfo1_OnShippementInfoConfirmed);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.FillColor = System.Drawing.Color.DodgerBlue;
            this.uiPanel1.FillColor2 = System.Drawing.Color.Navy;
            this.uiPanel1.FillColorGradient = true;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(134, 715);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Navy;
            this.uiLabel1.Location = new System.Drawing.Point(367, 21);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(424, 62);
            this.uiLabel1.TabIndex = 2;
            this.uiLabel1.Text = "Saving shippment ";
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // frmSaveShippmentInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 715);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.ctrlSaveShippementInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveShippmentInfos";
            this.Text = "Save Shippment Infos";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSaveShippementInfo ctrlSaveShippementInfo1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel1;
    }
}
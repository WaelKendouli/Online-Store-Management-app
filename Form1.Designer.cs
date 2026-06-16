namespace OnlineStoreProject
{
    partial class Form1
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
            this.btnProductManagement = new Sunny.UI.UIButton();
            this.btnCustomerManagement = new Sunny.UI.UIButton();
            this.btnShippment = new Sunny.UI.UIButton();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnShippment);
            this.uiPanel1.Controls.Add(this.btnProductManagement);
            this.uiPanel1.Controls.Add(this.btnCustomerManagement);
            this.uiPanel1.FillColor = System.Drawing.Color.Indigo;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPanel1.Location = new System.Drawing.Point(2, 3);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(415, 634);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductManagement.FillColor = System.Drawing.Color.Indigo;
            this.btnProductManagement.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.btnProductManagement.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagement.ForeHoverColor = System.Drawing.Color.Black;
            this.btnProductManagement.Location = new System.Drawing.Point(3, 131);
            this.btnProductManagement.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Radius = 0;
            this.btnProductManagement.RectColor = System.Drawing.Color.Indigo;
            this.btnProductManagement.RectDisableColor = System.Drawing.Color.Lavender;
            this.btnProductManagement.Size = new System.Drawing.Size(322, 76);
            this.btnProductManagement.TabIndex = 2;
            this.btnProductManagement.Text = "Products management";
            this.btnProductManagement.TipsFont = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click);
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerManagement.FillColor = System.Drawing.Color.Indigo;
            this.btnCustomerManagement.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.btnCustomerManagement.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerManagement.ForeHoverColor = System.Drawing.Color.Black;
            this.btnCustomerManagement.Location = new System.Drawing.Point(3, 32);
            this.btnCustomerManagement.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Radius = 0;
            this.btnCustomerManagement.RectColor = System.Drawing.Color.Indigo;
            this.btnCustomerManagement.RectDisableColor = System.Drawing.Color.Lavender;
            this.btnCustomerManagement.Size = new System.Drawing.Size(322, 76);
            this.btnCustomerManagement.TabIndex = 1;
            this.btnCustomerManagement.Text = "Customers management";
            this.btnCustomerManagement.TipsFont = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerManagement.Click += new System.EventHandler(this.btnCustomerManagement_Click);
            // 
            // btnShippment
            // 
            this.btnShippment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShippment.FillColor = System.Drawing.Color.Indigo;
            this.btnShippment.FillHoverColor = System.Drawing.Color.MediumPurple;
            this.btnShippment.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShippment.ForeHoverColor = System.Drawing.Color.Black;
            this.btnShippment.Location = new System.Drawing.Point(10, 250);
            this.btnShippment.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShippment.Name = "btnShippment";
            this.btnShippment.Radius = 0;
            this.btnShippment.RectColor = System.Drawing.Color.Indigo;
            this.btnShippment.RectDisableColor = System.Drawing.Color.Lavender;
            this.btnShippment.Size = new System.Drawing.Size(322, 76);
            this.btnShippment.TabIndex = 3;
            this.btnShippment.Text = "Shippment management";
            this.btnShippment.TipsFont = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 642);
            this.Controls.Add(this.uiPanel1);
            this.Name = "Form1";
            this.Text = "Main Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btnCustomerManagement;
        private Sunny.UI.UIButton btnProductManagement;
        private Sunny.UI.UIButton btnShippment;
    }
}


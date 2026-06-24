namespace OnlineStoreProject.Orders_UI
{
    partial class frmSaveOrderForCustomer
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
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtAmount = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lbTitle = new Sunny.UI.UILabel();
            this.btnOrderProduct = new Sunny.UI.UIButton();
            this.btnPlus = new Sunny.UI.UIButton();
            this.btnMinus = new Sunny.UI.UIButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlSearchProduct1
            // 
            this.ctrlSearchProduct1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ctrlSearchProduct1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchProduct1.Location = new System.Drawing.Point(12, 98);
            this.ctrlSearchProduct1.Name = "ctrlSearchProduct1";
            this.ctrlSearchProduct1.Size = new System.Drawing.Size(812, 731);
            this.ctrlSearchProduct1.TabIndex = 0;
            this.ctrlSearchProduct1.OnProductSelected += new System.EventHandler<LogicLayer.Events.ProductEventArgs>(this.ctrlSearchProduct1_OnProductSelected);
            this.ctrlSearchProduct1.Load += new System.EventHandler(this.ctrlSearchProduct1_Load);
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(875, 102);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(345, 34);
            this.numQuantity.TabIndex = 1;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(875, 272);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Padding = new System.Windows.Forms.Padding(5);
            this.txtAmount.Radius = 50;
            this.txtAmount.ShowText = false;
            this.txtAmount.Size = new System.Drawing.Size(384, 56);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtAmount.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(869, 41);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(159, 42);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "Quantity";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbTitle.Location = new System.Drawing.Point(458, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(405, 56);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Order product";
            this.lbTitle.Click += new System.EventHandler(this.uiLabel3_Click);
            // 
            // btnOrderProduct
            // 
            this.btnOrderProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOrderProduct.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOrderProduct.FillColorGradient = true;
            this.btnOrderProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOrderProduct.Location = new System.Drawing.Point(875, 393);
            this.btnOrderProduct.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOrderProduct.Name = "btnOrderProduct";
            this.btnOrderProduct.Radius = 25;
            this.btnOrderProduct.Size = new System.Drawing.Size(384, 92);
            this.btnOrderProduct.TabIndex = 6;
            this.btnOrderProduct.Text = "Order this product";
            this.btnOrderProduct.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOrderProduct.Click += new System.EventHandler(this.btnOrderProduct_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlus.Location = new System.Drawing.Point(915, 155);
            this.btnPlus.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(100, 35);
            this.btnPlus.TabIndex = 7;
            this.btnPlus.Text = "+";
            this.btnPlus.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnMinus.Location = new System.Drawing.Point(1103, 155);
            this.btnMinus.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(100, 35);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.Text = "-";
            this.btnMinus.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(869, 225);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(159, 42);
            this.uiLabel4.TabIndex = 9;
            this.uiLabel4.Text = "Amount";
            // 
            // frmSaveOrderForCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 841);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnOrderProduct);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.ctrlSearchProduct1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSaveOrderForCustomer";
            this.Text = "frmSaveOrderForCustomer";
            this.Load += new System.EventHandler(this.frmSaveOrderForCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSearchProduct ctrlSearchProduct1;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private Sunny.UI.UITextBox txtAmount;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lbTitle;
        private Sunny.UI.UIButton btnOrderProduct;
        private Sunny.UI.UIButton btnPlus;
        private Sunny.UI.UIButton btnMinus;
        private Sunny.UI.UILabel uiLabel4;
    }
}
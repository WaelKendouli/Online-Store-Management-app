namespace OnlineStoreProject
{
    partial class ctrlSaveProductInfos
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txtPrice = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.txtQuantity = new Sunny.UI.UITextBox();
            this.cbImagesPaths = new Sunny.UI.UIComboBox();
            this.pbProducts = new System.Windows.Forms.PictureBox();
            this.btnAddPhoto = new Sunny.UI.UIButton();
            this.lbCategoryText = new Sunny.UI.UILabel();
            this.cbCategories = new Sunny.UI.UIComboBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txtDescription = new Sunny.UI.UIRichTextBox();
            this.btnSave = new Sunny.UI.UIButton();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(185, 83);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.Radius = 30;
            this.txtName.RectColor = System.Drawing.Color.Green;
            this.txtName.ShowText = false;
            this.txtName.Size = new System.Drawing.Size(267, 42);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtName.Watermark = "";
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(52, 92);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 33);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Name :";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Green;
            this.uiLabel2.Location = new System.Drawing.Point(336, 15);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(359, 62);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "Save product infos ";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(52, 172);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 35);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "Price :";
            // 
            // txtPrice
            // 
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPrice.Location = new System.Drawing.Point(185, 162);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Padding = new System.Windows.Forms.Padding(5);
            this.txtPrice.Radius = 30;
            this.txtPrice.RectColor = System.Drawing.Color.Green;
            this.txtPrice.ShowText = false;
            this.txtPrice.Size = new System.Drawing.Size(267, 42);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtPrice.Watermark = "";
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(39, 236);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(113, 44);
            this.uiLabel4.TabIndex = 6;
            this.uiLabel4.Text = "Quantity :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(185, 240);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuantity.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(5);
            this.txtQuantity.Radius = 30;
            this.txtQuantity.RectColor = System.Drawing.Color.Green;
            this.txtQuantity.ShowText = false;
            this.txtQuantity.Size = new System.Drawing.Size(267, 42);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtQuantity.Watermark = "";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // cbImagesPaths
            // 
            this.cbImagesPaths.DataSource = null;
            this.cbImagesPaths.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbImagesPaths.FillColor = System.Drawing.Color.White;
            this.cbImagesPaths.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbImagesPaths.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbImagesPaths.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbImagesPaths.Location = new System.Drawing.Point(472, 82);
            this.cbImagesPaths.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbImagesPaths.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbImagesPaths.Name = "cbImagesPaths";
            this.cbImagesPaths.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbImagesPaths.Radius = 20;
            this.cbImagesPaths.RectColor = System.Drawing.Color.Green;
            this.cbImagesPaths.Size = new System.Drawing.Size(308, 43);
            this.cbImagesPaths.SymbolSize = 24;
            this.cbImagesPaths.TabIndex = 7;
            this.cbImagesPaths.Text = "Images";
            this.cbImagesPaths.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbImagesPaths.Watermark = "";
            this.cbImagesPaths.SelectedIndexChanged += new System.EventHandler(this.cbImagesPaths_SelectedIndexChanged);
            // 
            // pbProducts
            // 
            this.pbProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProducts.Location = new System.Drawing.Point(801, 76);
            this.pbProducts.Name = "pbProducts";
            this.pbProducts.Size = new System.Drawing.Size(174, 184);
            this.pbProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProducts.TabIndex = 8;
            this.pbProducts.TabStop = false;
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPhoto.FillColor = System.Drawing.Color.Green;
            this.btnAddPhoto.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddPhoto.FillColorGradient = true;
            this.btnAddPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddPhoto.Location = new System.Drawing.Point(487, 149);
            this.btnAddPhoto.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Radius = 30;
            this.btnAddPhoto.Size = new System.Drawing.Size(213, 55);
            this.btnAddPhoto.TabIndex = 9;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // lbCategoryText
            // 
            this.lbCategoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoryText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbCategoryText.Location = new System.Drawing.Point(482, 279);
            this.lbCategoryText.Name = "lbCategoryText";
            this.lbCategoryText.Size = new System.Drawing.Size(340, 37);
            this.lbCategoryText.TabIndex = 10;
            this.lbCategoryText.Text = "Choose primary category :";
            // 
            // cbCategories
            // 
            this.cbCategories.DataSource = null;
            this.cbCategories.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbCategories.FillColor = System.Drawing.Color.White;
            this.cbCategories.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategories.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbCategories.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbCategories.Location = new System.Drawing.Point(702, 321);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategories.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCategories.Radius = 20;
            this.cbCategories.RectColor = System.Drawing.Color.Green;
            this.cbCategories.Size = new System.Drawing.Size(293, 43);
            this.cbCategories.SymbolSize = 24;
            this.cbCategories.TabIndex = 8;
            this.cbCategories.Text = "Categories";
            this.cbCategories.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCategories.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(32, 307);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(168, 33);
            this.uiLabel6.TabIndex = 12;
            this.uiLabel6.Text = "Description :";
            // 
            // txtDescription
            // 
            this.txtDescription.FillColor = System.Drawing.Color.White;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescription.Location = new System.Drawing.Point(37, 354);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(2);
            this.txtDescription.Radius = 30;
            this.txtDescription.RectColor = System.Drawing.Color.Green;
            this.txtDescription.ShowText = false;
            this.txtDescription.Size = new System.Drawing.Size(657, 180);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FillColor = System.Drawing.Color.Green;
            this.btnSave.FillColor2 = System.Drawing.Color.LimeGreen;
            this.btnSave.FillColorGradient = true;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(801, 431);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 40;
            this.btnSave.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.RectHoverColor = System.Drawing.Color.MediumTurquoise;
            this.btnSave.Size = new System.Drawing.Size(214, 82);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save infos";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // ctrlSaveProductInfos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.lbCategoryText);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.pbProducts);
            this.Controls.Add(this.cbImagesPaths);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.txtName);
            this.Name = "ctrlSaveProductInfos";
            this.Size = new System.Drawing.Size(1038, 553);
            this.Load += new System.EventHandler(this.ctrlSaveProductInfos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtPrice;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox txtQuantity;
        private Sunny.UI.UIComboBox cbImagesPaths;
        private System.Windows.Forms.PictureBox pbProducts;
        private Sunny.UI.UIButton btnAddPhoto;
        private Sunny.UI.UILabel lbCategoryText;
        private Sunny.UI.UIComboBox cbCategories;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIRichTextBox txtDescription;
        private Sunny.UI.UIButton btnSave;
        private System.Windows.Forms.ErrorProvider epCheck;
    }
}

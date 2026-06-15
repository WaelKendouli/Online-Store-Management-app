namespace OnlineStoreProject
{
    partial class ctrlSearchProduct
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.cbCategory = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnSearch = new Sunny.UI.UIButton();
            this.cbItems = new Sunny.UI.UIComboBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.ctrlProductCardInfos1 = new OnlineStoreProject.ctrlProductCardInfos();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.AutoSize = true;
            this.uiPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uiPanel1.Controls.Add(this.cbCategory);
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.btnSearch);
            this.uiPanel1.Controls.Add(this.cbItems);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(19, 16);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Radius = 50;
            this.uiPanel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uiPanel1.Size = new System.Drawing.Size(582, 121);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.DataSource = null;
            this.cbCategory.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbCategory.FillColor = System.Drawing.Color.White;
            this.cbCategory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbCategory.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.ForeColor = System.Drawing.Color.Green;
            this.cbCategory.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbCategory.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbCategory.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbCategory.ItemSelectForeColor = System.Drawing.Color.White;
            this.cbCategory.Location = new System.Drawing.Point(212, 73);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCategory.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbCategory.Radius = 43;
            this.cbCategory.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbCategory.Size = new System.Drawing.Size(242, 43);
            this.cbCategory.SymbolSize = 24;
            this.cbCategory.TabIndex = 4;
            this.cbCategory.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbCategory.Watermark = "";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(16, 83);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(199, 33);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "Select a Category :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.Green;
            this.btnSearch.FillColorGradient = true;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(459, 23);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 35;
            this.btnSearch.RectColor = System.Drawing.Color.Green;
            this.btnSearch.Size = new System.Drawing.Size(120, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbItems
            // 
            this.cbItems.BackColor = System.Drawing.Color.Transparent;
            this.cbItems.DataSource = null;
            this.cbItems.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbItems.FillColor = System.Drawing.Color.White;
            this.cbItems.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbItems.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItems.ForeColor = System.Drawing.Color.Green;
            this.cbItems.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbItems.ItemRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbItems.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbItems.ItemSelectForeColor = System.Drawing.Color.White;
            this.cbItems.Location = new System.Drawing.Point(194, 23);
            this.cbItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbItems.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbItems.Name = "cbItems";
            this.cbItems.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbItems.Radius = 43;
            this.cbItems.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbItems.Size = new System.Drawing.Size(248, 43);
            this.cbItems.SymbolSize = 24;
            this.cbItems.TabIndex = 1;
            this.cbItems.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbItems.Watermark = "";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(16, 33);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(199, 33);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Select a product :";
            // 
            // ctrlProductCardInfos1
            // 
            this.ctrlProductCardInfos1.BackColor = System.Drawing.Color.White;
            this.ctrlProductCardInfos1.Location = new System.Drawing.Point(19, 158);
            this.ctrlProductCardInfos1.Name = "ctrlProductCardInfos1";
            this.ctrlProductCardInfos1.Size = new System.Drawing.Size(772, 570);
            this.ctrlProductCardInfos1.TabIndex = 0;
            this.ctrlProductCardInfos1.Load += new System.EventHandler(this.ctrlProductCardInfos1_Load);
            // 
            // ctrlSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.ctrlProductCardInfos1);
            this.Name = "ctrlSearchProduct";
            this.Size = new System.Drawing.Size(836, 731);
            this.Load += new System.EventHandler(this.ctrlSearchProduct_Load);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlProductCardInfos ctrlProductCardInfos1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIComboBox cbItems;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UIComboBox cbCategory;
        private Sunny.UI.UILabel uiLabel2;
    }
}

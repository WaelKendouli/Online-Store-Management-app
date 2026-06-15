namespace OnlineStoreProject.Products_UI
{
    partial class frmProductsManagemts
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProducts = new Sunny.UI.UIDataGridView();
            this.cmsOptions = new Sunny.UI.UIContextMenuStrip(this.components);
            this.productDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnThisListIntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteThisProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeOrderTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeRatingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateThisProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbItems = new Sunny.UI.UIComboBox();
            this.txtInput = new Sunny.UI.UITextBox();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnSearch = new Sunny.UI.UIButton();
            this.btnAddNew = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ContextMenuStrip = this.cmsOptions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(12, 251);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProducts.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvProducts.ScrollBarStyleInherited = false;
            this.dgvProducts.SelectedIndex = -1;
            this.dgvProducts.Size = new System.Drawing.Size(1392, 536);
            this.dgvProducts.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProducts.TabIndex = 0;
            // 
            // cmsOptions
            // 
            this.cmsOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmsOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productDetailsToolStripMenuItem,
            this.turnThisListIntoToolStripMenuItem,
            this.deleteThisProductToolStripMenuItem,
            this.addNewProductToolStripMenuItem,
            this.seeOrderTrackToolStripMenuItem,
            this.seeRatingsToolStripMenuItem,
            this.updateThisProductToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(253, 272);
            // 
            // productDetailsToolStripMenuItem
            // 
            this.productDetailsToolStripMenuItem.Name = "productDetailsToolStripMenuItem";
            this.productDetailsToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.productDetailsToolStripMenuItem.Text = "Product Details";
            this.productDetailsToolStripMenuItem.Click += new System.EventHandler(this.productDetailsToolStripMenuItem_Click);
            // 
            // turnThisListIntoToolStripMenuItem
            // 
            this.turnThisListIntoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLDocumentToolStripMenuItem,
            this.pDFFileToolStripMenuItem,
            this.jSONFileToolStripMenuItem});
            this.turnThisListIntoToolStripMenuItem.Name = "turnThisListIntoToolStripMenuItem";
            this.turnThisListIntoToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.turnThisListIntoToolStripMenuItem.Text = "Turn this List into";
            this.turnThisListIntoToolStripMenuItem.Click += new System.EventHandler(this.turnThisListIntoToolStripMenuItem_Click);
            // 
            // xMLDocumentToolStripMenuItem
            // 
            this.xMLDocumentToolStripMenuItem.Name = "xMLDocumentToolStripMenuItem";
            this.xMLDocumentToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.xMLDocumentToolStripMenuItem.Text = "XML document";
            this.xMLDocumentToolStripMenuItem.Click += new System.EventHandler(this.xMLDocumentToolStripMenuItem_Click);
            // 
            // pDFFileToolStripMenuItem
            // 
            this.pDFFileToolStripMenuItem.Name = "pDFFileToolStripMenuItem";
            this.pDFFileToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.pDFFileToolStripMenuItem.Text = "PDF file";
            this.pDFFileToolStripMenuItem.Click += new System.EventHandler(this.pDFFileToolStripMenuItem_Click);
            // 
            // jSONFileToolStripMenuItem
            // 
            this.jSONFileToolStripMenuItem.Name = "jSONFileToolStripMenuItem";
            this.jSONFileToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.jSONFileToolStripMenuItem.Text = "JSON file";
            this.jSONFileToolStripMenuItem.Click += new System.EventHandler(this.jSONFileToolStripMenuItem_Click);
            // 
            // deleteThisProductToolStripMenuItem
            // 
            this.deleteThisProductToolStripMenuItem.Name = "deleteThisProductToolStripMenuItem";
            this.deleteThisProductToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.deleteThisProductToolStripMenuItem.Text = "Delete this product";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.addNewProductToolStripMenuItem.Text = "Add new product";
            // 
            // seeOrderTrackToolStripMenuItem
            // 
            this.seeOrderTrackToolStripMenuItem.Name = "seeOrderTrackToolStripMenuItem";
            this.seeOrderTrackToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.seeOrderTrackToolStripMenuItem.Text = "See order track";
            // 
            // seeRatingsToolStripMenuItem
            // 
            this.seeRatingsToolStripMenuItem.Name = "seeRatingsToolStripMenuItem";
            this.seeRatingsToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.seeRatingsToolStripMenuItem.Text = "See ratings ";
            // 
            // updateThisProductToolStripMenuItem
            // 
            this.updateThisProductToolStripMenuItem.Name = "updateThisProductToolStripMenuItem";
            this.updateThisProductToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.updateThisProductToolStripMenuItem.Text = "Update this product";
            this.updateThisProductToolStripMenuItem.Click += new System.EventHandler(this.updateThisProductToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // cbItems
            // 
            this.cbItems.DataSource = null;
            this.cbItems.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbItems.FillColor = System.Drawing.Color.White;
            this.cbItems.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItems.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbItems.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbItems.Location = new System.Drawing.Point(13, 195);
            this.cbItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbItems.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbItems.Name = "cbItems";
            this.cbItems.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbItems.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbItems.Size = new System.Drawing.Size(313, 48);
            this.cbItems.SymbolSize = 24;
            this.cbItems.TabIndex = 1;
            this.cbItems.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbItems.Watermark = "";
            // 
            // txtInput
            // 
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtInput.Location = new System.Drawing.Point(344, 195);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.Padding = new System.Windows.Forms.Padding(5);
            this.txtInput.Radius = 30;
            this.txtInput.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtInput.ShowText = false;
            this.txtInput.Size = new System.Drawing.Size(529, 48);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInput.Watermark = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnSearch);
            this.uiPanel1.Controls.Add(this.btnAddNew);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(5, 3);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1421, 96);
            this.uiPanel1.TabIndex = 3;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.FillHoverColor = System.Drawing.Color.Green;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(339, 9);
            this.btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Radius = 50;
            this.btnSearch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSearch.Size = new System.Drawing.Size(297, 64);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search Product";
            this.btnSearch.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNew.FillHoverColor = System.Drawing.Color.Green;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(24, 9);
            this.btnAddNew.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Radius = 50;
            this.btnAddNew.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNew.Size = new System.Drawing.Size(297, 64);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add new Product";
            this.btnAddNew.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.Green;
            this.uiLabel1.Location = new System.Drawing.Point(429, 116);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(540, 74);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "Products list";
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // frmProductsManagemts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1429, 814);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.dgvProducts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductsManagemts";
            this.Text = "Products Managemts";
            this.Load += new System.EventHandler(this.frmProductsManagemts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvProducts;
        private Sunny.UI.UIComboBox cbItems;
        private Sunny.UI.UITextBox txtInput;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnAddNew;
        private Sunny.UI.UIContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem productDetailsToolStripMenuItem;
        private Sunny.UI.UIButton btnSearch;
        private System.Windows.Forms.ToolStripMenuItem turnThisListIntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeOrderTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeRatingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateThisProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONFileToolStripMenuItem;
    }
}
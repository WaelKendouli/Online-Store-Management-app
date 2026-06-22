namespace OnlineStoreProject
{
    partial class frmCustomersManagement
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
            this.tpLisiting = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbItems = new Sunny.UI.UIComboBox();
            this.txtInput = new Sunny.UI.UITextBox();
            this.dgvTable = new Sunny.UI.UIDataGridView();
            this.tpCrudOperations = new System.Windows.Forms.TabPage();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnRatings = new Sunny.UI.UIButton();
            this.btnSearchCustomer = new Sunny.UI.UIButton();
            this.btnAddNewCustomer = new Sunny.UI.UIButton();
            this.uiOptions = new Sunny.UI.UIContextMenuStrip(this.components);
            this.updateThisCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteThisCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasedProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seeRatingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShippementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tpLisiting.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.tpCrudOperations.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.uiOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpLisiting
            // 
            this.tpLisiting.Controls.Add(this.tabPage1);
            this.tpLisiting.Controls.Add(this.tpCrudOperations);
            this.tpLisiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpLisiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLisiting.Location = new System.Drawing.Point(0, 0);
            this.tpLisiting.Name = "tpLisiting";
            this.tpLisiting.SelectedIndex = 0;
            this.tpLisiting.Size = new System.Drawing.Size(1341, 697);
            this.tpLisiting.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.cbItems);
            this.tabPage1.Controls.Add(this.txtInput);
            this.tabPage1.Controls.Add(this.dgvTable);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1333, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "List of customers";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cbItems
            // 
            this.cbItems.DataSource = null;
            this.cbItems.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbItems.FillColor = System.Drawing.Color.White;
            this.cbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbItems.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbItems.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbItems.Location = new System.Drawing.Point(38, 50);
            this.cbItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbItems.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbItems.Name = "cbItems";
            this.cbItems.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbItems.Size = new System.Drawing.Size(294, 44);
            this.cbItems.SymbolSize = 24;
            this.cbItems.TabIndex = 3;
            this.cbItems.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbItems.Watermark = "";
            // 
            // txtInput
            // 
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtInput.Location = new System.Drawing.Point(363, 50);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.Padding = new System.Windows.Forms.Padding(5);
            this.txtInput.Radius = 44;
            this.txtInput.RectColor = System.Drawing.Color.Red;
            this.txtInput.ShowText = false;
            this.txtInput.Size = new System.Drawing.Size(351, 44);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInput.Watermark = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTable.EnableHeadersVisualStyles = false;
            this.dgvTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvTable.GridColor = System.Drawing.Color.Black;
            this.dgvTable.Location = new System.Drawing.Point(29, 112);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RectColor = System.Drawing.Color.Red;
            this.dgvTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTable.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvTable.ScrollBarColor = System.Drawing.Color.Red;
            this.dgvTable.ScrollBarRectColor = System.Drawing.Color.Red;
            this.dgvTable.ScrollBarStyleInherited = false;
            this.dgvTable.SelectedIndex = -1;
            this.dgvTable.Size = new System.Drawing.Size(1273, 630);
            this.dgvTable.StripeEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvTable.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvTable.Style = Sunny.UI.UIStyle.Custom;
            this.dgvTable.TabIndex = 0;
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellContentClick);
            // 
            // tpCrudOperations
            // 
            this.tpCrudOperations.Controls.Add(this.uiPanel1);
            this.tpCrudOperations.Location = new System.Drawing.Point(4, 47);
            this.tpCrudOperations.Name = "tpCrudOperations";
            this.tpCrudOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tpCrudOperations.Size = new System.Drawing.Size(1333, 646);
            this.tpCrudOperations.TabIndex = 1;
            this.tpCrudOperations.Text = "Mangement tools";
            this.tpCrudOperations.UseVisualStyleBackColor = true;
            this.tpCrudOperations.Click += new System.EventHandler(this.tpCrudOperations_Click);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnRatings);
            this.uiPanel1.Controls.Add(this.btnSearchCustomer);
            this.uiPanel1.Controls.Add(this.btnAddNewCustomer);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiPanel1.FillColorGradient = true;
            this.uiPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(4, 8);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(368, 767);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRatings
            // 
            this.btnRatings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRatings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRatings.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRatings.ForeHoverColor = System.Drawing.Color.Black;
            this.btnRatings.Location = new System.Drawing.Point(4, 265);
            this.btnRatings.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRatings.Name = "btnRatings";
            this.btnRatings.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRatings.Size = new System.Drawing.Size(287, 92);
            this.btnRatings.TabIndex = 3;
            this.btnRatings.Text = "Ratings";
            this.btnRatings.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRatings.Click += new System.EventHandler(this.btnRatings_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchCustomer.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeHoverColor = System.Drawing.Color.Black;
            this.btnSearchCustomer.Location = new System.Drawing.Point(4, 157);
            this.btnSearchCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchCustomer.Size = new System.Drawing.Size(287, 92);
            this.btnSearchCustomer.TabIndex = 2;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddNewCustomer.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeHoverColor = System.Drawing.Color.Black;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(4, 38);
            this.btnAddNewCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddNewCustomer.Size = new System.Drawing.Size(287, 92);
            this.btnAddNewCustomer.TabIndex = 1;
            this.btnAddNewCustomer.Text = "Add new Customer";
            this.btnAddNewCustomer.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // uiOptions
            // 
            this.uiOptions.BackColor = System.Drawing.Color.White;
            this.uiOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uiOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateThisCustomerToolStripMenuItem,
            this.deleteThisCustomerToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.seeRatingsToolStripMenuItem,
            this.addShippementToolStripMenuItem,
            this.toolStripMenuItem2});
            this.uiOptions.Name = "uiOptions";
            this.uiOptions.Size = new System.Drawing.Size(273, 184);
            // 
            // updateThisCustomerToolStripMenuItem
            // 
            this.updateThisCustomerToolStripMenuItem.Name = "updateThisCustomerToolStripMenuItem";
            this.updateThisCustomerToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.updateThisCustomerToolStripMenuItem.Text = "Update this customer ";
            this.updateThisCustomerToolStripMenuItem.Click += new System.EventHandler(this.updateThisCustomerToolStripMenuItem_Click);
            // 
            // deleteThisCustomerToolStripMenuItem
            // 
            this.deleteThisCustomerToolStripMenuItem.Name = "deleteThisCustomerToolStripMenuItem";
            this.deleteThisCustomerToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.deleteThisCustomerToolStripMenuItem.Text = "Delete this customer";
            this.deleteThisCustomerToolStripMenuItem.Click += new System.EventHandler(this.deleteThisCustomerToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersHistoryToolStripMenuItem,
            this.purchasedProductsToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // ordersHistoryToolStripMenuItem
            // 
            this.ordersHistoryToolStripMenuItem.Name = "ordersHistoryToolStripMenuItem";
            this.ordersHistoryToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.ordersHistoryToolStripMenuItem.Text = "Orders history";
            // 
            // purchasedProductsToolStripMenuItem
            // 
            this.purchasedProductsToolStripMenuItem.Name = "purchasedProductsToolStripMenuItem";
            this.purchasedProductsToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.purchasedProductsToolStripMenuItem.Text = "Purchased products ";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(277, 30);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // seeRatingsToolStripMenuItem
            // 
            this.seeRatingsToolStripMenuItem.Name = "seeRatingsToolStripMenuItem";
            this.seeRatingsToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.seeRatingsToolStripMenuItem.Text = "See Ratings";
            // 
            // addShippementToolStripMenuItem
            // 
            this.addShippementToolStripMenuItem.Name = "addShippementToolStripMenuItem";
            this.addShippementToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.addShippementToolStripMenuItem.Text = "Add shippement";
            this.addShippementToolStripMenuItem.Click += new System.EventHandler(this.addShippementToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(272, 30);
            this.toolStripMenuItem2.Text = " Add order";
            // 
            // frmCustomersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 697);
            this.ContextMenuStrip = this.uiOptions;
            this.Controls.Add(this.tpLisiting);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomersManagement";
            this.Text = "frmCustomersManagement";
            this.Load += new System.EventHandler(this.frmCustomersManagement_Load);
            this.tpLisiting.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.tpCrudOperations.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.uiOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpLisiting;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpCrudOperations;
        private Sunny.UI.UIDataGridView dgvTable;
        private Sunny.UI.UITextBox txtInput;
        private Sunny.UI.UIComboBox cbItems;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIButton btnAddNewCustomer;
        private Sunny.UI.UIContextMenuStrip uiOptions;
        private System.Windows.Forms.ToolStripMenuItem updateThisCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteThisCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasedProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seeRatingsToolStripMenuItem;
        private Sunny.UI.UIButton btnSearchCustomer;
        private Sunny.UI.UIButton btnRatings;
        private System.Windows.Forms.ToolStripMenuItem addShippementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}
namespace OnlineStoreProject.Orders_UI
{
    partial class frmOrdersHistory
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
            this.dgvOrdersHistory = new Sunny.UI.UIDataGridView();
            this.cbItems = new Sunny.UI.UIComboBox();
            this.txtInput = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cmsOptions = new Sunny.UI.UIContextMenuStrip(this.components);
            this.updateThisOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewOrderForThisCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnThisTableIntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersHistory)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrdersHistory
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvOrdersHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdersHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdersHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdersHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrdersHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdersHistory.ContextMenuStrip = this.cmsOptions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrdersHistory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrdersHistory.EnableHeadersVisualStyles = false;
            this.dgvOrdersHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvOrdersHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvOrdersHistory.Location = new System.Drawing.Point(30, 169);
            this.dgvOrdersHistory.Name = "dgvOrdersHistory";
            this.dgvOrdersHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdersHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrdersHistory.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvOrdersHistory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvOrdersHistory.RowTemplate.Height = 24;
            this.dgvOrdersHistory.SelectedIndex = -1;
            this.dgvOrdersHistory.Size = new System.Drawing.Size(1330, 570);
            this.dgvOrdersHistory.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvOrdersHistory.TabIndex = 0;
            // 
            // cbItems
            // 
            this.cbItems.DataSource = null;
            this.cbItems.FillColor = System.Drawing.Color.White;
            this.cbItems.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItems.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbItems.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbItems.Location = new System.Drawing.Point(30, 115);
            this.cbItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbItems.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbItems.Name = "cbItems";
            this.cbItems.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbItems.Size = new System.Drawing.Size(396, 46);
            this.cbItems.SymbolSize = 24;
            this.cbItems.TabIndex = 1;
            this.cbItems.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbItems.Watermark = "";
            // 
            // txtInput
            // 
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtInput.Location = new System.Drawing.Point(451, 115);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.Padding = new System.Windows.Forms.Padding(5);
            this.txtInput.Radius = 25;
            this.txtInput.ShowText = false;
            this.txtInput.Size = new System.Drawing.Size(574, 46);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInput.Watermark = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.MediumBlue;
            this.uiLabel1.Location = new System.Drawing.Point(473, 35);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(346, 50);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "Orders History";
            // 
            // cmsOptions
            // 
            this.cmsOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.cmsOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmsOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateThisOrderToolStripMenuItem,
            this.addNewOrderForThisCustomerToolStripMenuItem,
            this.turnThisTableIntoToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(364, 122);
            // 
            // updateThisOrderToolStripMenuItem
            // 
            this.updateThisOrderToolStripMenuItem.Name = "updateThisOrderToolStripMenuItem";
            this.updateThisOrderToolStripMenuItem.Size = new System.Drawing.Size(363, 30);
            this.updateThisOrderToolStripMenuItem.Text = "Update this Order";
            this.updateThisOrderToolStripMenuItem.Click += new System.EventHandler(this.updateThisOrderToolStripMenuItem_Click);
            // 
            // addNewOrderForThisCustomerToolStripMenuItem
            // 
            this.addNewOrderForThisCustomerToolStripMenuItem.Name = "addNewOrderForThisCustomerToolStripMenuItem";
            this.addNewOrderForThisCustomerToolStripMenuItem.Size = new System.Drawing.Size(363, 30);
            this.addNewOrderForThisCustomerToolStripMenuItem.Text = "Add new Order for this customer";
            this.addNewOrderForThisCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewOrderForThisCustomerToolStripMenuItem_Click);
            // 
            // turnThisTableIntoToolStripMenuItem
            // 
            this.turnThisTableIntoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFFileToolStripMenuItem,
            this.xMLFileToolStripMenuItem,
            this.jSONFileToolStripMenuItem});
            this.turnThisTableIntoToolStripMenuItem.Name = "turnThisTableIntoToolStripMenuItem";
            this.turnThisTableIntoToolStripMenuItem.Size = new System.Drawing.Size(363, 30);
            this.turnThisTableIntoToolStripMenuItem.Text = "Turn this table into";
            // 
            // pDFFileToolStripMenuItem
            // 
            this.pDFFileToolStripMenuItem.Name = "pDFFileToolStripMenuItem";
            this.pDFFileToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.pDFFileToolStripMenuItem.Text = "PDF file";
            this.pDFFileToolStripMenuItem.Click += new System.EventHandler(this.pDFFileToolStripMenuItem_Click);
            // 
            // xMLFileToolStripMenuItem
            // 
            this.xMLFileToolStripMenuItem.Name = "xMLFileToolStripMenuItem";
            this.xMLFileToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.xMLFileToolStripMenuItem.Text = "XML file";
            this.xMLFileToolStripMenuItem.Click += new System.EventHandler(this.xMLFileToolStripMenuItem_Click);
            // 
            // jSONFileToolStripMenuItem
            // 
            this.jSONFileToolStripMenuItem.Name = "jSONFileToolStripMenuItem";
            this.jSONFileToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.jSONFileToolStripMenuItem.Text = "JSON file";
            // 
            // frmOrdersHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1372, 751);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.dgvOrdersHistory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrdersHistory";
            this.Text = "Orders History";
            this.Load += new System.EventHandler(this.frmOrdersHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdersHistory)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvOrdersHistory;
        private Sunny.UI.UIComboBox cbItems;
        private Sunny.UI.UITextBox txtInput;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem updateThisOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewOrderForThisCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnThisTableIntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONFileToolStripMenuItem;
    }
}
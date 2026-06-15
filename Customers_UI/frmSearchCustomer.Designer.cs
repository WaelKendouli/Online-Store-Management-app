namespace OnlineStoreProject
{
    partial class frmSearchCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ctrlSearchCustomer1 = new OnlineStoreProject.ctrlSearchCustomer();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.dgvCustomerHistory = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlSearchCustomer1
            // 
            this.ctrlSearchCustomer1.BackColor = System.Drawing.Color.White;
            this.ctrlSearchCustomer1.Location = new System.Drawing.Point(12, 12);
            this.ctrlSearchCustomer1.Name = "ctrlSearchCustomer1";
            this.ctrlSearchCustomer1.Size = new System.Drawing.Size(1030, 631);
            this.ctrlSearchCustomer1.TabIndex = 0;
            this.ctrlSearchCustomer1.OnSearchedPerformed += new System.EventHandler<LogicLayer.Events.clsCustomerEventsArgs>(this.ctrlSearchCustomer1_OnSearchedPerformed);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.uiLabel1.Location = new System.Drawing.Point(23, 656);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(477, 42);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "Customer purchase history :";
            // 
            // dgvCustomerHistory
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvCustomerHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCustomerHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomerHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomerHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomerHistory.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCustomerHistory.EnableHeadersVisualStyles = false;
            this.dgvCustomerHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvCustomerHistory.GridColor = System.Drawing.Color.Black;
            this.dgvCustomerHistory.Location = new System.Drawing.Point(30, 701);
            this.dgvCustomerHistory.Name = "dgvCustomerHistory";
            this.dgvCustomerHistory.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvCustomerHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomerHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCustomerHistory.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvCustomerHistory.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCustomerHistory.RowTemplate.Height = 24;
            this.dgvCustomerHistory.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvCustomerHistory.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvCustomerHistory.ScrollBarStyleInherited = false;
            this.dgvCustomerHistory.SelectedIndex = -1;
            this.dgvCustomerHistory.Size = new System.Drawing.Size(995, 287);
            this.dgvCustomerHistory.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvCustomerHistory.TabIndex = 2;
            // 
            // frmSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 1000);
            this.Controls.Add(this.dgvCustomerHistory);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.ctrlSearchCustomer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchCustomer";
            this.Text = "Search Customer";
            this.Load += new System.EventHandler(this.frmSearchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSearchCustomer ctrlSearchCustomer1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDataGridView dgvCustomerHistory;
    }
}
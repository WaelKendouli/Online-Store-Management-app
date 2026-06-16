namespace OnlineStoreProject.Shippment_UI
{
    partial class frmShippmentManagement
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
            this.dgvShipments = new Sunny.UI.UIDataGridView();
            this.cbItems = new Sunny.UI.UIComboBox();
            this.txtInput = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.btnAddNewShipment = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShipments
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvShipments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShipments.BackgroundColor = System.Drawing.Color.White;
            this.dgvShipments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShipments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvShipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShipments.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvShipments.EnableHeadersVisualStyles = false;
            this.dgvShipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvShipments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgvShipments.Location = new System.Drawing.Point(21, 177);
            this.dgvShipments.Name = "dgvShipments";
            this.dgvShipments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShipments.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvShipments.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgvShipments.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvShipments.RowTemplate.Height = 24;
            this.dgvShipments.SelectedIndex = -1;
            this.dgvShipments.Size = new System.Drawing.Size(1149, 551);
            this.dgvShipments.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgvShipments.TabIndex = 0;
            // 
            // cbItems
            // 
            this.cbItems.DataSource = null;
            this.cbItems.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbItems.FillColor = System.Drawing.Color.White;
            this.cbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItems.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbItems.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbItems.Location = new System.Drawing.Point(21, 112);
            this.cbItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbItems.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbItems.Name = "cbItems";
            this.cbItems.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbItems.Size = new System.Drawing.Size(434, 57);
            this.cbItems.SymbolSize = 24;
            this.cbItems.TabIndex = 1;
            this.cbItems.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbItems.Watermark = "";
            // 
            // txtInput
            // 
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(489, 111);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtInput.Name = "txtInput";
            this.txtInput.Padding = new System.Windows.Forms.Padding(5);
            this.txtInput.Radius = 35;
            this.txtInput.ShowText = false;
            this.txtInput.Size = new System.Drawing.Size(340, 57);
            this.txtInput.TabIndex = 2;
            this.txtInput.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtInput.Watermark = "";
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiLabel1.Location = new System.Drawing.Point(340, 31);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(457, 51);
            this.uiLabel1.TabIndex = 3;
            this.uiLabel1.Text = "Manage shippments ";
            // 
            // btnAddNewShipment
            // 
            this.btnAddNewShipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewShipment.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddNewShipment.FillColorGradient = true;
            this.btnAddNewShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddNewShipment.Location = new System.Drawing.Point(951, 112);
            this.btnAddNewShipment.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAddNewShipment.Name = "btnAddNewShipment";
            this.btnAddNewShipment.Radius = 30;
            this.btnAddNewShipment.Size = new System.Drawing.Size(219, 56);
            this.btnAddNewShipment.TabIndex = 4;
            this.btnAddNewShipment.Text = "Add new shipment";
            this.btnAddNewShipment.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnAddNewShipment.Click += new System.EventHandler(this.btnAddNewShipment_Click);
            // 
            // frmShippmentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 754);
            this.Controls.Add(this.btnAddNewShipment);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.dgvShipments);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShippmentManagement";
            this.Text = "frmShippmentManagement";
            this.Load += new System.EventHandler(this.frmShippmentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShipments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIDataGridView dgvShipments;
        private Sunny.UI.UIComboBox cbItems;
        private Sunny.UI.UITextBox txtInput;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnAddNewShipment;
    }
}
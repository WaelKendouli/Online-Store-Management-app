namespace OnlineStoreProject
{
    partial class ctrlSaveShippementInfo
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txt_Shipping_Carrier = new Sunny.UI.UITextBox();
            this.txt_carrier_service_level = new Sunny.UI.UITextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.txt_tracking_number = new Sunny.UI.UILabel();
            this.txt_tracking_url = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.txt_shipping_notes = new Sunny.UI.UIRichTextBox();
            this.txt_shipping_updates = new Sunny.UI.UITextBox();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.txt_shipping_cost = new Sunny.UI.UITextBox();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.cbShippmentStatus = new Sunny.UI.UIComboBox();
            this.epCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new Sunny.UI.UIButton();
            this.dtpActualDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEstimatedDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(18, 11);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(238, 43);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "Shipping Carrier";
            // 
            // txt_Shipping_Carrier
            // 
            this.txt_Shipping_Carrier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Shipping_Carrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Shipping_Carrier.Location = new System.Drawing.Point(23, 59);
            this.txt_Shipping_Carrier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Shipping_Carrier.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_Shipping_Carrier.Name = "txt_Shipping_Carrier";
            this.txt_Shipping_Carrier.Padding = new System.Windows.Forms.Padding(5);
            this.txt_Shipping_Carrier.ShowText = false;
            this.txt_Shipping_Carrier.Size = new System.Drawing.Size(320, 43);
            this.txt_Shipping_Carrier.TabIndex = 1;
            this.txt_Shipping_Carrier.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_Shipping_Carrier.Watermark = "";
            this.txt_Shipping_Carrier.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Shipping_Carrier_Validating);
            // 
            // txt_carrier_service_level
            // 
            this.txt_carrier_service_level.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_carrier_service_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carrier_service_level.Location = new System.Drawing.Point(459, 59);
            this.txt_carrier_service_level.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_carrier_service_level.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_carrier_service_level.Name = "txt_carrier_service_level";
            this.txt_carrier_service_level.Padding = new System.Windows.Forms.Padding(5);
            this.txt_carrier_service_level.ShowText = false;
            this.txt_carrier_service_level.Size = new System.Drawing.Size(381, 43);
            this.txt_carrier_service_level.TabIndex = 3;
            this.txt_carrier_service_level.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_carrier_service_level.Watermark = "";
            this.txt_carrier_service_level.Validating += new System.ComponentModel.CancelEventHandler(this.txt_carrier_service_level_Validating);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.Location = new System.Drawing.Point(439, 11);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(277, 43);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "carrier service level";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(18, 125);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(243, 43);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "tracking number";
            // 
            // txt_tracking_number
            // 
            this.txt_tracking_number.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tracking_number.ForeColor = System.Drawing.Color.Gray;
            this.txt_tracking_number.Location = new System.Drawing.Point(256, 131);
            this.txt_tracking_number.Name = "txt_tracking_number";
            this.txt_tracking_number.Size = new System.Drawing.Size(476, 30);
            this.txt_tracking_number.TabIndex = 5;
            this.txt_tracking_number.Text = "XXXX-XXXX-XXXX";
            // 
            // txt_tracking_url
            // 
            this.txt_tracking_url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tracking_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tracking_url.Location = new System.Drawing.Point(222, 174);
            this.txt_tracking_url.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tracking_url.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_tracking_url.Name = "txt_tracking_url";
            this.txt_tracking_url.Padding = new System.Windows.Forms.Padding(5);
            this.txt_tracking_url.ShowText = false;
            this.txt_tracking_url.Size = new System.Drawing.Size(555, 43);
            this.txt_tracking_url.TabIndex = 7;
            this.txt_tracking_url.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_tracking_url.Watermark = "";
            this.txt_tracking_url.Validating += new System.ComponentModel.CancelEventHandler(this.txt_tracking_url_Validating);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(18, 174);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(156, 43);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "tracking url";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiLabel6.Location = new System.Drawing.Point(19, 227);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(177, 50);
            this.uiLabel6.TabIndex = 8;
            this.uiLabel6.Text = "Actual Delivery Date";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiLabel9.Location = new System.Drawing.Point(400, 222);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(184, 55);
            this.uiLabel9.TabIndex = 10;
            this.uiLabel9.Text = "estimated delivery date";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(353, 290);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(210, 43);
            this.uiLabel10.TabIndex = 12;
            this.uiLabel10.Text = "Shipping Notes";
            // 
            // txt_shipping_notes
            // 
            this.txt_shipping_notes.FillColor = System.Drawing.Color.White;
            this.txt_shipping_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_shipping_notes.Location = new System.Drawing.Point(570, 293);
            this.txt_shipping_notes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_shipping_notes.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_shipping_notes.Name = "txt_shipping_notes";
            this.txt_shipping_notes.Padding = new System.Windows.Forms.Padding(2);
            this.txt_shipping_notes.ShowText = false;
            this.txt_shipping_notes.Size = new System.Drawing.Size(270, 102);
            this.txt_shipping_notes.TabIndex = 13;
            this.txt_shipping_notes.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_shipping_updates
            // 
            this.txt_shipping_updates.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_shipping_updates.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_shipping_updates.Location = new System.Drawing.Point(23, 341);
            this.txt_shipping_updates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_shipping_updates.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_shipping_updates.Name = "txt_shipping_updates";
            this.txt_shipping_updates.Padding = new System.Windows.Forms.Padding(5);
            this.txt_shipping_updates.ShowText = false;
            this.txt_shipping_updates.Size = new System.Drawing.Size(366, 43);
            this.txt_shipping_updates.TabIndex = 15;
            this.txt_shipping_updates.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_shipping_updates.Watermark = "";
            this.txt_shipping_updates.Validating += new System.ComponentModel.CancelEventHandler(this.txt_shipping_updates_Validating);
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.uiLabel11.Location = new System.Drawing.Point(18, 293);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(243, 43);
            this.uiLabel11.TabIndex = 14;
            this.uiLabel11.Text = "Shipping Updates";
            // 
            // txt_shipping_cost
            // 
            this.txt_shipping_cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_shipping_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_shipping_cost.Location = new System.Drawing.Point(181, 416);
            this.txt_shipping_cost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_shipping_cost.MinimumSize = new System.Drawing.Size(1, 16);
            this.txt_shipping_cost.Name = "txt_shipping_cost";
            this.txt_shipping_cost.Padding = new System.Windows.Forms.Padding(5);
            this.txt_shipping_cost.ShowText = false;
            this.txt_shipping_cost.Size = new System.Drawing.Size(203, 43);
            this.txt_shipping_cost.TabIndex = 17;
            this.txt_shipping_cost.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txt_shipping_cost.Watermark = "";
            this.txt_shipping_cost.Validating += new System.ComponentModel.CancelEventHandler(this.txt_shipping_cost_Validating);
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel12.Location = new System.Drawing.Point(34, 416);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(128, 43);
            this.uiLabel12.TabIndex = 16;
            this.uiLabel12.Text = "Cost";
            // 
            // uiLabel13
            // 
            this.uiLabel13.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel13.Location = new System.Drawing.Point(435, 416);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(128, 43);
            this.uiLabel13.TabIndex = 18;
            this.uiLabel13.Text = "Status";
            // 
            // cbShippmentStatus
            // 
            this.cbShippmentStatus.DataSource = null;
            this.cbShippmentStatus.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbShippmentStatus.FillColor = System.Drawing.Color.White;
            this.cbShippmentStatus.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShippmentStatus.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbShippmentStatus.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbShippmentStatus.Location = new System.Drawing.Point(570, 416);
            this.cbShippmentStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbShippmentStatus.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbShippmentStatus.Name = "cbShippmentStatus";
            this.cbShippmentStatus.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbShippmentStatus.Size = new System.Drawing.Size(270, 39);
            this.cbShippmentStatus.SymbolSize = 24;
            this.cbShippmentStatus.TabIndex = 19;
            this.cbShippmentStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbShippmentStatus.Watermark = "";
            // 
            // epCheck
            // 
            this.epCheck.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(615, 497);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 25;
            this.btnSave.Size = new System.Drawing.Size(193, 56);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpActualDeliveryDate
            // 
            this.dtpActualDeliveryDate.Location = new System.Drawing.Point(206, 244);
            this.dtpActualDeliveryDate.Name = "dtpActualDeliveryDate";
            this.dtpActualDeliveryDate.Size = new System.Drawing.Size(155, 22);
            this.dtpActualDeliveryDate.TabIndex = 21;
            // 
            // dtpEstimatedDate
            // 
            this.dtpEstimatedDate.Location = new System.Drawing.Point(615, 244);
            this.dtpEstimatedDate.Name = "dtpEstimatedDate";
            this.dtpEstimatedDate.Size = new System.Drawing.Size(153, 22);
            this.dtpEstimatedDate.TabIndex = 22;
            // 
            // ctrlSaveShippementInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dtpEstimatedDate);
            this.Controls.Add(this.dtpActualDeliveryDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbShippmentStatus);
            this.Controls.Add(this.uiLabel13);
            this.Controls.Add(this.txt_shipping_cost);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.txt_shipping_updates);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.txt_shipping_notes);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.txt_tracking_url);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.txt_tracking_number);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.txt_carrier_service_level);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.txt_Shipping_Carrier);
            this.Controls.Add(this.uiLabel1);
            this.Name = "ctrlSaveShippementInfo";
            this.Size = new System.Drawing.Size(852, 579);
            this.Load += new System.EventHandler(this.ctrlSaveShippementInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txt_Shipping_Carrier;
        private Sunny.UI.UITextBox txt_carrier_service_level;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel txt_tracking_number;
        private Sunny.UI.UITextBox txt_tracking_url;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIRichTextBox txt_shipping_notes;
        private Sunny.UI.UITextBox txt_shipping_updates;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UITextBox txt_shipping_cost;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UIComboBox cbShippmentStatus;
        private System.Windows.Forms.ErrorProvider epCheck;
        private Sunny.UI.UIButton btnSave;
        private System.Windows.Forms.DateTimePicker dtpEstimatedDate;
        private System.Windows.Forms.DateTimePicker dtpActualDeliveryDate;
    }
}

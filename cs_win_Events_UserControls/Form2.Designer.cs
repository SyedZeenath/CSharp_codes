namespace cs_win_Events_UserControls
{
    partial class Form2
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
            this.dateTimePickerExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.labelExpiryDate = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.vcrUserControl1 = new cs_win_Events_UserControls.VCRUserControl();
            this.SuspendLayout();
            // 
            // dateTimePickerExpiryDate
            // 
            this.dateTimePickerExpiryDate.Location = new System.Drawing.Point(451, 191);
            this.dateTimePickerExpiryDate.Name = "dateTimePickerExpiryDate";
            this.dateTimePickerExpiryDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerExpiryDate.TabIndex = 15;
            // 
            // labelExpiryDate
            // 
            this.labelExpiryDate.AutoSize = true;
            this.labelExpiryDate.Location = new System.Drawing.Point(448, 171);
            this.labelExpiryDate.Name = "labelExpiryDate";
            this.labelExpiryDate.Size = new System.Drawing.Size(80, 17);
            this.labelExpiryDate.TabIndex = 14;
            this.labelExpiryDate.Text = "Expiry Date";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(448, 101);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 17);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(451, 121);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(95, 22);
            this.textBoxPrice.TabIndex = 12;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(451, 53);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(313, 22);
            this.textBoxProductName.TabIndex = 11;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(448, 33);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(98, 17);
            this.labelProductName.TabIndex = 10;
            this.labelProductName.Text = "Product Name";
            // 
            // vcrUserControl1
            // 
            this.vcrUserControl1.Location = new System.Drawing.Point(63, 33);
            this.vcrUserControl1.Name = "vcrUserControl1";
            this.vcrUserControl1.Size = new System.Drawing.Size(311, 303);
            this.vcrUserControl1.TabIndex = 16;
            this.vcrUserControl1.TextOnFirst = "FirstCustomer";
            this.vcrUserControl1.TextOnLast = "Last";
            this.vcrUserControl1.TextOnNext = "Next";
            this.vcrUserControl1.TextOnPrevious = "Previous";
            this.vcrUserControl1.ToolTipOnFirst = "Move to first customer";
            this.vcrUserControl1.ToolTipOnLast = "Move to last customer";
            this.vcrUserControl1.ToolTipOnNext = "Move to next customer";
            this.vcrUserControl1.ToolTipOnPrevious = "Move to previous customer";
            this.vcrUserControl1.OnFirstButtonClick += new cs_win_Events_UserControls.VCRButtonClickHandler(this.vcrUserControl1_OnFirstButtonClick);
            this.vcrUserControl1.OnPreviousButtonClick += new cs_win_Events_UserControls.VCRButtonClickHandler(this.vcrUserControl1_OnPreviousButtonClick);
            this.vcrUserControl1.OnNextButtonClick += new cs_win_Events_UserControls.VCRButtonClickHandler(this.vcrUserControl1_OnNextButtonClick);
            this.vcrUserControl1.OnLastButtonClick += new cs_win_Events_UserControls.VCRButtonClickHandler(this.vcrUserControl1_OnLastButtonClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.vcrUserControl1);
            this.Controls.Add(this.dateTimePickerExpiryDate);
            this.Controls.Add(this.labelExpiryDate);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelProductName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerExpiryDate;
        private System.Windows.Forms.Label labelExpiryDate;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProductName;
        private VCRUserControl vcrUserControl1;
    }
}
namespace Aklan_International
{
    partial class FrmSetUnitPrice
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
            this.lblSingleSheetStrip = new System.Windows.Forms.Label();
            this.lbl12SheetStrip = new System.Windows.Forms.Label();
            this.lblSingleCurrent = new System.Windows.Forms.Label();
            this.lblSingleNewPrice = new System.Windows.Forms.Label();
            this.tbxSingleCurrentPrice = new System.Windows.Forms.TextBox();
            this.tbxSingleNewPrice = new System.Windows.Forms.TextBox();
            this.lbl12Current = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx12Current = new System.Windows.Forms.TextBox();
            this.tbx12New = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSingleSheetStrip
            // 
            this.lblSingleSheetStrip.AutoSize = true;
            this.lblSingleSheetStrip.Location = new System.Drawing.Point(28, 36);
            this.lblSingleSheetStrip.Name = "lblSingleSheetStrip";
            this.lblSingleSheetStrip.Size = new System.Drawing.Size(85, 13);
            this.lblSingleSheetStrip.TabIndex = 0;
            this.lblSingleSheetStrip.Text = "Sigle Sheet Strip";
            // 
            // lbl12SheetStrip
            // 
            this.lbl12SheetStrip.AutoSize = true;
            this.lbl12SheetStrip.Location = new System.Drawing.Point(28, 133);
            this.lbl12SheetStrip.Name = "lbl12SheetStrip";
            this.lbl12SheetStrip.Size = new System.Drawing.Size(79, 13);
            this.lbl12SheetStrip.TabIndex = 1;
            this.lbl12SheetStrip.Text = "12 Sheets Strip";
            // 
            // lblSingleCurrent
            // 
            this.lblSingleCurrent.AutoSize = true;
            this.lblSingleCurrent.Location = new System.Drawing.Point(76, 62);
            this.lblSingleCurrent.Name = "lblSingleCurrent";
            this.lblSingleCurrent.Size = new System.Drawing.Size(68, 13);
            this.lblSingleCurrent.TabIndex = 2;
            this.lblSingleCurrent.Text = "Current Price";
            // 
            // lblSingleNewPrice
            // 
            this.lblSingleNewPrice.AutoSize = true;
            this.lblSingleNewPrice.Location = new System.Drawing.Point(76, 101);
            this.lblSingleNewPrice.Name = "lblSingleNewPrice";
            this.lblSingleNewPrice.Size = new System.Drawing.Size(84, 13);
            this.lblSingleNewPrice.TabIndex = 3;
            this.lblSingleNewPrice.Text = "Enter New Price";
            // 
            // tbxSingleCurrentPrice
            // 
            this.tbxSingleCurrentPrice.Enabled = false;
            this.tbxSingleCurrentPrice.Location = new System.Drawing.Point(191, 59);
            this.tbxSingleCurrentPrice.Name = "tbxSingleCurrentPrice";
            this.tbxSingleCurrentPrice.ReadOnly = true;
            this.tbxSingleCurrentPrice.Size = new System.Drawing.Size(239, 20);
            this.tbxSingleCurrentPrice.TabIndex = 4;
            this.tbxSingleCurrentPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxSingleNewPrice
            // 
            this.tbxSingleNewPrice.Location = new System.Drawing.Point(191, 98);
            this.tbxSingleNewPrice.Name = "tbxSingleNewPrice";
            this.tbxSingleNewPrice.Size = new System.Drawing.Size(239, 20);
            this.tbxSingleNewPrice.TabIndex = 5;
            this.tbxSingleNewPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxSingleNewPrice.TextChanged += new System.EventHandler(this.tbxSingleNewPrice_TextChanged);
            // 
            // lbl12Current
            // 
            this.lbl12Current.AutoSize = true;
            this.lbl12Current.Location = new System.Drawing.Point(76, 161);
            this.lbl12Current.Name = "lbl12Current";
            this.lbl12Current.Size = new System.Drawing.Size(68, 13);
            this.lbl12Current.TabIndex = 6;
            this.lbl12Current.Text = "Current Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter New Price";
            // 
            // tbx12Current
            // 
            this.tbx12Current.Enabled = false;
            this.tbx12Current.Location = new System.Drawing.Point(191, 158);
            this.tbx12Current.Name = "tbx12Current";
            this.tbx12Current.ReadOnly = true;
            this.tbx12Current.Size = new System.Drawing.Size(239, 20);
            this.tbx12Current.TabIndex = 8;
            this.tbx12Current.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx12New
            // 
            this.tbx12New.Location = new System.Drawing.Point(191, 193);
            this.tbx12New.Name = "tbx12New";
            this.tbx12New.Size = new System.Drawing.Size(239, 20);
            this.tbx12New.TabIndex = 9;
            this.tbx12New.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbx12New.TextChanged += new System.EventHandler(this.tbx12New_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(220, 264);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(328, 264);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmSetUnitPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbx12New);
            this.Controls.Add(this.tbx12Current);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl12Current);
            this.Controls.Add(this.tbxSingleNewPrice);
            this.Controls.Add(this.tbxSingleCurrentPrice);
            this.Controls.Add(this.lblSingleNewPrice);
            this.Controls.Add(this.lblSingleCurrent);
            this.Controls.Add(this.lbl12SheetStrip);
            this.Controls.Add(this.lblSingleSheetStrip);
            this.Name = "FrmSetUnitPrice";
            this.Text = "Set Unit Price";
            this.Load += new System.EventHandler(this.FrmSetUnitPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSingleSheetStrip;
        private System.Windows.Forms.Label lbl12SheetStrip;
        private System.Windows.Forms.Label lblSingleCurrent;
        private System.Windows.Forms.Label lblSingleNewPrice;
        private System.Windows.Forms.TextBox tbxSingleCurrentPrice;
        private System.Windows.Forms.TextBox tbxSingleNewPrice;
        private System.Windows.Forms.Label lbl12Current;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx12Current;
        private System.Windows.Forms.TextBox tbx12New;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}
namespace ConversionTool
{
    partial class ConversionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label signedLabel;
            System.Windows.Forms.Label unsignedLabel;
            System.Windows.Forms.Label hexLabel;
            System.Windows.Forms.Label binaryHiWordLabel;
            System.Windows.Forms.Label binaryLowWordLabel;
            System.Windows.Forms.Label widthLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionForm));
            this.signedIntEntry = new System.Windows.Forms.TextBox();
            this.bitWidthBox = new System.Windows.Forms.ComboBox();
            this.unsignedIntEntry = new System.Windows.Forms.TextBox();
            this.hexEntry = new System.Windows.Forms.TextBox();
            this.binaryByte8Entry = new System.Windows.Forms.TextBox();
            this.binaryByte7Entry = new System.Windows.Forms.TextBox();
            this.binaryByte6Entry = new System.Windows.Forms.TextBox();
            this.binaryByte5Entry = new System.Windows.Forms.TextBox();
            this.binaryByte4Entry = new System.Windows.Forms.TextBox();
            this.binaryByte3Entry = new System.Windows.Forms.TextBox();
            this.binaryByte2Entry = new System.Windows.Forms.TextBox();
            this.binaryByte1Entry = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.copySignedBtn = new System.Windows.Forms.Button();
            this.copyUnsignedBtn = new System.Windows.Forms.Button();
            this.copyHexBtn = new System.Windows.Forms.Button();
            this.pinCheckBox = new System.Windows.Forms.CheckBox();
            signedLabel = new System.Windows.Forms.Label();
            unsignedLabel = new System.Windows.Forms.Label();
            hexLabel = new System.Windows.Forms.Label();
            binaryHiWordLabel = new System.Windows.Forms.Label();
            binaryLowWordLabel = new System.Windows.Forms.Label();
            widthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signedLabel
            // 
            signedLabel.AutoSize = true;
            signedLabel.Location = new System.Drawing.Point(11, 15);
            signedLabel.Name = "signedLabel";
            signedLabel.Size = new System.Drawing.Size(83, 15);
            signedLabel.TabIndex = 6;
            signedLabel.Text = "Signed Integer";
            // 
            // unsignedLabel
            // 
            unsignedLabel.AutoSize = true;
            unsignedLabel.Location = new System.Drawing.Point(11, 44);
            unsignedLabel.Name = "unsignedLabel";
            unsignedLabel.Size = new System.Drawing.Size(97, 15);
            unsignedLabel.TabIndex = 7;
            unsignedLabel.Text = "Unsigned Integer";
            // 
            // hexLabel
            // 
            hexLabel.AutoSize = true;
            hexLabel.Location = new System.Drawing.Point(11, 73);
            hexLabel.Name = "hexLabel";
            hexLabel.Size = new System.Drawing.Size(76, 15);
            hexLabel.TabIndex = 8;
            hexLabel.Text = "Hexadecimal";
            // 
            // binaryHiWordLabel
            // 
            binaryHiWordLabel.AutoSize = true;
            binaryHiWordLabel.Location = new System.Drawing.Point(11, 107);
            binaryHiWordLabel.Name = "binaryHiWordLabel";
            binaryHiWordLabel.Size = new System.Drawing.Size(109, 15);
            binaryHiWordLabel.TabIndex = 17;
            binaryHiWordLabel.Text = "Binary (High Word)";
            // 
            // binaryLowWordLabel
            // 
            binaryLowWordLabel.AutoSize = true;
            binaryLowWordLabel.Location = new System.Drawing.Point(11, 136);
            binaryLowWordLabel.Name = "binaryLowWordLabel";
            binaryLowWordLabel.Size = new System.Drawing.Size(105, 15);
            binaryLowWordLabel.TabIndex = 18;
            binaryLowWordLabel.Text = "Binary (Low Word)";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new System.Drawing.Point(443, 47);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new System.Drawing.Size(56, 15);
            widthLabel.TabIndex = 23;
            widthLabel.Text = "Bit Width";
            // 
            // signedIntEntry
            // 
            this.signedIntEntry.Location = new System.Drawing.Point(126, 12);
            this.signedIntEntry.Name = "signedIntEntry";
            this.signedIntEntry.Size = new System.Drawing.Size(206, 23);
            this.signedIntEntry.TabIndex = 0;
            this.signedIntEntry.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // bitWidthBox
            // 
            this.bitWidthBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bitWidthBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bitWidthBox.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64"});
            this.bitWidthBox.Location = new System.Drawing.Point(505, 44);
            this.bitWidthBox.MaxDropDownItems = 5;
            this.bitWidthBox.Name = "bitWidthBox";
            this.bitWidthBox.Size = new System.Drawing.Size(39, 23);
            this.bitWidthBox.TabIndex = 1;
            this.bitWidthBox.SelectedIndexChanged += new System.EventHandler(this.OnBitWidthSelect);
            // 
            // unsignedIntEntry
            // 
            this.unsignedIntEntry.Location = new System.Drawing.Point(126, 41);
            this.unsignedIntEntry.Name = "unsignedIntEntry";
            this.unsignedIntEntry.Size = new System.Drawing.Size(206, 23);
            this.unsignedIntEntry.TabIndex = 2;
            this.unsignedIntEntry.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // hexEntry
            // 
            this.hexEntry.Location = new System.Drawing.Point(126, 70);
            this.hexEntry.Name = "hexEntry";
            this.hexEntry.Size = new System.Drawing.Size(206, 23);
            this.hexEntry.TabIndex = 3;
            this.hexEntry.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // binaryByte8Entry
            // 
            this.binaryByte8Entry.Location = new System.Drawing.Point(126, 104);
            this.binaryByte8Entry.Name = "binaryByte8Entry";
            this.binaryByte8Entry.ReadOnly = true;
            this.binaryByte8Entry.Size = new System.Drawing.Size(100, 23);
            this.binaryByte8Entry.TabIndex = 5;
            // 
            // binaryByte7Entry
            // 
            this.binaryByte7Entry.Location = new System.Drawing.Point(232, 104);
            this.binaryByte7Entry.Name = "binaryByte7Entry";
            this.binaryByte7Entry.ReadOnly = true;
            this.binaryByte7Entry.Size = new System.Drawing.Size(100, 23);
            this.binaryByte7Entry.TabIndex = 10;
            // 
            // binaryByte6Entry
            // 
            this.binaryByte6Entry.Location = new System.Drawing.Point(338, 104);
            this.binaryByte6Entry.Name = "binaryByte6Entry";
            this.binaryByte6Entry.ReadOnly = true;
            this.binaryByte6Entry.Size = new System.Drawing.Size(100, 23);
            this.binaryByte6Entry.TabIndex = 11;
            // 
            // binaryByte5Entry
            // 
            this.binaryByte5Entry.Location = new System.Drawing.Point(444, 104);
            this.binaryByte5Entry.Name = "binaryByte5Entry";
            this.binaryByte5Entry.ReadOnly = true;
            this.binaryByte5Entry.Size = new System.Drawing.Size(100, 23);
            this.binaryByte5Entry.TabIndex = 12;
            // 
            // binaryByte4Entry
            // 
            this.binaryByte4Entry.Location = new System.Drawing.Point(126, 133);
            this.binaryByte4Entry.Name = "binaryByte4Entry";
            this.binaryByte4Entry.ReadOnly = true;
            this.binaryByte4Entry.Size = new System.Drawing.Size(100, 23);
            this.binaryByte4Entry.TabIndex = 13;
            // 
            // binaryByte3Entry
            // 
            this.binaryByte3Entry.Location = new System.Drawing.Point(232, 133);
            this.binaryByte3Entry.Name = "binaryByte3Entry";
            this.binaryByte3Entry.ReadOnly = true;
            this.binaryByte3Entry.Size = new System.Drawing.Size(100, 23);
            this.binaryByte3Entry.TabIndex = 14;
            // 
            // binaryByte2Entry
            // 
            this.binaryByte2Entry.Location = new System.Drawing.Point(338, 133);
            this.binaryByte2Entry.Name = "binaryByte2Entry";
            this.binaryByte2Entry.ReadOnly = true;
            this.binaryByte2Entry.Size = new System.Drawing.Size(100, 23);
            this.binaryByte2Entry.TabIndex = 15;
            // 
            // binaryByte1Entry
            // 
            this.binaryByte1Entry.Location = new System.Drawing.Point(444, 133);
            this.binaryByte1Entry.Name = "binaryByte1Entry";
            this.binaryByte1Entry.ReadOnly = true;
            this.binaryByte1Entry.Size = new System.Drawing.Size(100, 23);
            this.binaryByte1Entry.TabIndex = 16;
            // 
            // resetBtn
            // 
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.Location = new System.Drawing.Point(444, 72);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(100, 24);
            this.resetBtn.TabIndex = 19;
            this.resetBtn.Text = "Clear";
            this.resetBtn.UseMnemonic = false;
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.OnReset);
            // 
            // copySignedBtn
            // 
            this.copySignedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copySignedBtn.Location = new System.Drawing.Point(338, 12);
            this.copySignedBtn.Name = "copySignedBtn";
            this.copySignedBtn.Size = new System.Drawing.Size(100, 24);
            this.copySignedBtn.TabIndex = 20;
            this.copySignedBtn.Text = "Copy";
            this.copySignedBtn.UseVisualStyleBackColor = true;
            this.copySignedBtn.Click += new System.EventHandler(this.Copy);
            // 
            // copyUnsignedBtn
            // 
            this.copyUnsignedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyUnsignedBtn.Location = new System.Drawing.Point(338, 42);
            this.copyUnsignedBtn.Name = "copyUnsignedBtn";
            this.copyUnsignedBtn.Size = new System.Drawing.Size(100, 24);
            this.copyUnsignedBtn.TabIndex = 21;
            this.copyUnsignedBtn.Text = "Copy";
            this.copyUnsignedBtn.UseVisualStyleBackColor = true;
            this.copyUnsignedBtn.Click += new System.EventHandler(this.Copy);
            // 
            // copyHexBtn
            // 
            this.copyHexBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyHexBtn.Location = new System.Drawing.Point(338, 72);
            this.copyHexBtn.Name = "copyHexBtn";
            this.copyHexBtn.Size = new System.Drawing.Size(100, 24);
            this.copyHexBtn.TabIndex = 22;
            this.copyHexBtn.Text = "Copy";
            this.copyHexBtn.UseVisualStyleBackColor = true;
            this.copyHexBtn.Click += new System.EventHandler(this.Copy);
            // 
            // pinCheckBox
            // 
            this.pinCheckBox.AutoSize = true;
            this.pinCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pinCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinCheckBox.Location = new System.Drawing.Point(443, 14);
            this.pinCheckBox.Name = "pinCheckBox";
            this.pinCheckBox.Size = new System.Drawing.Size(101, 19);
            this.pinCheckBox.TabIndex = 24;
            this.pinCheckBox.Text = "Stay On Top    ";
            this.pinCheckBox.UseVisualStyleBackColor = true;
            this.pinCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckChange);
            // 
            // ConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 172);
            this.Controls.Add(this.pinCheckBox);
            this.Controls.Add(widthLabel);
            this.Controls.Add(this.copyHexBtn);
            this.Controls.Add(this.copyUnsignedBtn);
            this.Controls.Add(this.copySignedBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(binaryLowWordLabel);
            this.Controls.Add(binaryHiWordLabel);
            this.Controls.Add(this.binaryByte1Entry);
            this.Controls.Add(this.binaryByte2Entry);
            this.Controls.Add(this.binaryByte3Entry);
            this.Controls.Add(this.binaryByte4Entry);
            this.Controls.Add(this.binaryByte5Entry);
            this.Controls.Add(this.binaryByte6Entry);
            this.Controls.Add(this.binaryByte7Entry);
            this.Controls.Add(hexLabel);
            this.Controls.Add(unsignedLabel);
            this.Controls.Add(signedLabel);
            this.Controls.Add(this.binaryByte8Entry);
            this.Controls.Add(this.hexEntry);
            this.Controls.Add(this.unsignedIntEntry);
            this.Controls.Add(this.bitWidthBox);
            this.Controls.Add(this.signedIntEntry);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConversionForm";
            this.Text = "Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox signedIntEntry;
        private ComboBox bitWidthBox;
        private TextBox unsignedIntEntry;
        private TextBox hexEntry;
        private TextBox binaryByte8Entry;
        private TextBox binaryByte7Entry;
        private TextBox binaryByte6Entry;
        private TextBox binaryByte5Entry;
        private TextBox binaryByte4Entry;
        private TextBox binaryByte3Entry;
        private TextBox binaryByte2Entry;
        private TextBox binaryByte1Entry;
        private TextBox[] binaryEntries;
        private Button resetBtn;
        private string lastModified = "signedIntEntry";
        private bool lockChange = false; // prevent event where updating field updates another field updates current field ...
        private Button copySignedBtn;
        private Button copyUnsignedBtn;
        private Button copyHexBtn;
        private CheckBox pinCheckBox;
    }
}
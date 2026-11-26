namespace Punk_Stocks.Forms
{
    partial class AlertForm
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
            this.promptLabel = new System.Windows.Forms.Label();
            this.directionComboBox = new System.Windows.Forms.ComboBox();
            this.targetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentPriceLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumericUpDown)).BeginInit();
            this.SuspendLayout();
            //
            // promptLabel
            //
            this.promptLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promptLabel.Location = new System.Drawing.Point(12, 12);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(296, 23);
            this.promptLabel.TabIndex = 0;
            this.promptLabel.Text = "Alert me when the price goes:";
            this.promptLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // directionComboBox
            //
            this.directionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directionComboBox.FormattingEnabled = true;
            this.directionComboBox.Location = new System.Drawing.Point(15, 45);
            this.directionComboBox.Name = "directionComboBox";
            this.directionComboBox.Size = new System.Drawing.Size(110, 21);
            this.directionComboBox.TabIndex = 1;
            //
            // targetNumericUpDown
            //
            this.targetNumericUpDown.DecimalPlaces = 2;
            this.targetNumericUpDown.Location = new System.Drawing.Point(135, 46);
            this.targetNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.targetNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.targetNumericUpDown.Name = "targetNumericUpDown";
            this.targetNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.targetNumericUpDown.TabIndex = 2;
            this.targetNumericUpDown.ThousandsSeparator = true;
            this.targetNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            //
            // currentPriceLabel
            //
            this.currentPriceLabel.AutoSize = true;
            this.currentPriceLabel.ForeColor = System.Drawing.Color.DimGray;
            this.currentPriceLabel.Location = new System.Drawing.Point(12, 78);
            this.currentPriceLabel.Name = "currentPriceLabel";
            this.currentPriceLabel.Size = new System.Drawing.Size(72, 13);
            this.currentPriceLabel.TabIndex = 3;
            this.currentPriceLabel.Text = "Current price:";
            //
            // okButton
            //
            this.okButton.Location = new System.Drawing.Point(122, 108);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(90, 30);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            //
            // cancelButton
            //
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(218, 108);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 30);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            //
            // AlertForm
            //
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(320, 150);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.currentPriceLabel);
            this.Controls.Add(this.targetNumericUpDown);
            this.Controls.Add(this.directionComboBox);
            this.Controls.Add(this.promptLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add alert";
            ((System.ComponentModel.ISupportInitialize)(this.targetNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.ComboBox directionComboBox;
        private System.Windows.Forms.NumericUpDown targetNumericUpDown;
        private System.Windows.Forms.Label currentPriceLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

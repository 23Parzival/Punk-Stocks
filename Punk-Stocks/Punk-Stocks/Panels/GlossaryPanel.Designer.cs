namespace Punk_Stocks.Panels
{
    partial class GlossaryPanel
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.definitionPanel = new System.Windows.Forms.Panel();
            this.definitionLabel = new System.Windows.Forms.Label();
            this.termLabel = new System.Windows.Forms.Label();
            this.termsListBox = new System.Windows.Forms.ListBox();
            this.searchPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.definitionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.titleLabel.Size = new System.Drawing.Size(900, 60);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Glossary";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.Location = new System.Drawing.Point(0, 60);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(900, 45);
            this.searchPanel.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(80, 11);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(250, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(15, 14);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(41, 13);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search";
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.definitionPanel);
            this.bodyPanel.Controls.Add(this.termsListBox);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 105);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.bodyPanel.Size = new System.Drawing.Size(900, 549);
            this.bodyPanel.TabIndex = 2;
            // 
            // definitionPanel
            // 
            this.definitionPanel.BackColor = System.Drawing.Color.White;
            this.definitionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.definitionPanel.Controls.Add(this.definitionLabel);
            this.definitionPanel.Controls.Add(this.termLabel);
            this.definitionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.definitionPanel.Location = new System.Drawing.Point(265, 0);
            this.definitionPanel.Name = "definitionPanel";
            this.definitionPanel.Padding = new System.Windows.Forms.Padding(15);
            this.definitionPanel.Size = new System.Drawing.Size(620, 534);
            this.definitionPanel.TabIndex = 1;
            // 
            // definitionLabel
            // 
            this.definitionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.definitionLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.definitionLabel.Location = new System.Drawing.Point(15, 55);
            this.definitionLabel.Name = "definitionLabel";
            this.definitionLabel.Size = new System.Drawing.Size(588, 462);
            this.definitionLabel.TabIndex = 1;
            // 
            // termLabel
            // 
            this.termLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.termLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termLabel.Location = new System.Drawing.Point(15, 15);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(588, 40);
            this.termLabel.TabIndex = 0;
            // 
            // termsListBox
            // 
            this.termsListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.termsListBox.FormattingEnabled = true;
            this.termsListBox.IntegralHeight = false;
            this.termsListBox.Location = new System.Drawing.Point(15, 0);
            this.termsListBox.Name = "termsListBox";
            this.termsListBox.Size = new System.Drawing.Size(250, 534);
            this.termsListBox.TabIndex = 0;
            this.termsListBox.SelectedIndexChanged += new System.EventHandler(this.termsListBox_SelectedIndexChanged);
            // 
            // GlossaryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "GlossaryPanel";
            this.Size = new System.Drawing.Size(900, 654);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.definitionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.ListBox termsListBox;
        private System.Windows.Forms.Panel definitionPanel;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Label definitionLabel;
    }
}

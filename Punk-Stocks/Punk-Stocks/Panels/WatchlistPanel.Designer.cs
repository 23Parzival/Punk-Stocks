namespace Punk_Stocks.Panels
{
    partial class WatchlistPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.watchlistGrid = new System.Windows.Forms.DataGridView();
            this.symbolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchlistGrid)).BeginInit();
            this.actionsPanel.SuspendLayout();
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
            this.titleLabel.Text = "Watchlist";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.watchlistGrid);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 60);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.gridPanel.Size = new System.Drawing.Size(900, 534);
            this.gridPanel.TabIndex = 1;
            // 
            // watchlistGrid
            // 
            this.watchlistGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.watchlistGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbolColumn,
            this.companyColumn,
            this.sectorColumn,
            this.priceColumn});
            this.watchlistGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.watchlistGrid.Location = new System.Drawing.Point(15, 0);
            this.watchlistGrid.Name = "watchlistGrid";
            this.watchlistGrid.Size = new System.Drawing.Size(870, 534);
            this.watchlistGrid.TabIndex = 0;
            // 
            // symbolColumn
            // 
            this.symbolColumn.DataPropertyName = "Symbol";
            this.symbolColumn.HeaderText = "Symbol";
            this.symbolColumn.Name = "symbolColumn";
            // 
            // companyColumn
            // 
            this.companyColumn.DataPropertyName = "CompanyName";
            this.companyColumn.FillWeight = 200F;
            this.companyColumn.HeaderText = "Company";
            this.companyColumn.Name = "companyColumn";
            // 
            // sectorColumn
            // 
            this.sectorColumn.DataPropertyName = "Sector";
            this.sectorColumn.HeaderText = "Sector";
            this.sectorColumn.Name = "sectorColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.DataPropertyName = "CurrentPrice";
            dataGridViewCellStyle1.Format = "C2";
            this.priceColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.removeButton);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsPanel.Location = new System.Drawing.Point(0, 594);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.actionsPanel.Size = new System.Drawing.Size(900, 60);
            this.actionsPanel.TabIndex = 2;
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.removeButton.Location = new System.Drawing.Point(735, 10);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(150, 35);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // WatchlistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "WatchlistPanel";
            this.Size = new System.Drawing.Size(900, 654);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watchlistGrid)).EndInit();
            this.actionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView watchlistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Button removeButton;
    }
}

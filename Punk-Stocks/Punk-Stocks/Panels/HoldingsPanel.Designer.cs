namespace Punk_Stocks.Panels
{
    partial class HoldingsPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.holdingsGrid = new System.Windows.Forms.DataGridView();
            this.symbolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holdingsGrid)).BeginInit();
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
            this.titleLabel.Text = "Holdings";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.holdingsGrid);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 60);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.gridPanel.Size = new System.Drawing.Size(900, 594);
            this.gridPanel.TabIndex = 1;
            // 
            // holdingsGrid
            // 
            this.holdingsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.holdingsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.symbolColumn,
            this.companyColumn,
            this.quantityColumn,
            this.avgCostColumn,
            this.priceColumn,
            this.marketValueColumn,
            this.profitColumn});
            this.holdingsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holdingsGrid.Location = new System.Drawing.Point(15, 0);
            this.holdingsGrid.Name = "holdingsGrid";
            this.holdingsGrid.Size = new System.Drawing.Size(870, 579);
            this.holdingsGrid.TabIndex = 0;
            this.holdingsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.holdingsGrid_CellFormatting);
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
            // quantityColumn
            // 
            this.quantityColumn.DataPropertyName = "Quantity";
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            // 
            // avgCostColumn
            // 
            this.avgCostColumn.DataPropertyName = "AvgCost";
            dataGridViewCellStyle1.Format = "C2";
            this.avgCostColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.avgCostColumn.HeaderText = "Avg. cost";
            this.avgCostColumn.Name = "avgCostColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.DataPropertyName = "CurrentPrice";
            dataGridViewCellStyle2.Format = "C2";
            this.priceColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            // 
            // marketValueColumn
            // 
            this.marketValueColumn.DataPropertyName = "MarketValue";
            dataGridViewCellStyle3.Format = "C2";
            this.marketValueColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.marketValueColumn.HeaderText = "Market value";
            this.marketValueColumn.Name = "marketValueColumn";
            // 
            // profitColumn
            // 
            this.profitColumn.DataPropertyName = "Profit";
            dataGridViewCellStyle4.Format = "C2";
            this.profitColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.profitColumn.HeaderText = "Profit";
            this.profitColumn.Name = "profitColumn";
            // 
            // HoldingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "HoldingsPanel";
            this.Size = new System.Drawing.Size(900, 654);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.holdingsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView holdingsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgCostColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marketValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitColumn;
    }
}

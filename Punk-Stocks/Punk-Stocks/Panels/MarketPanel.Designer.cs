namespace Punk_Stocks.Panels
{
    partial class MarketPanel
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.filterPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.sectorLabel = new System.Windows.Forms.Label();
            this.sectorComboBox = new System.Windows.Forms.ComboBox();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.stocksGrid = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.volatilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yieldColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tradePanel = new System.Windows.Forms.Panel();
            this.tradeFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buyButton = new System.Windows.Forms.Button();
            this.sellButton = new System.Windows.Forms.Button();
            this.watchButton = new System.Windows.Forms.Button();
            this.estimateLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.stockNameLabel = new System.Windows.Forms.Label();
            this.filterPanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stocksGrid)).BeginInit();
            this.tradePanel.SuspendLayout();
            this.tradeFlowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
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
            this.titleLabel.Text = "Market";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.searchLabel);
            this.filterPanel.Controls.Add(this.searchTextBox);
            this.filterPanel.Controls.Add(this.sectorLabel);
            this.filterPanel.Controls.Add(this.sectorComboBox);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 60);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.filterPanel.Size = new System.Drawing.Size(900, 40);
            this.filterPanel.TabIndex = 1;
            this.filterPanel.WrapContents = false;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(15, 7);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(65, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 20);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // sectorLabel
            // 
            this.sectorLabel.AutoSize = true;
            this.sectorLabel.Location = new System.Drawing.Point(288, 7);
            this.sectorLabel.Margin = new System.Windows.Forms.Padding(20, 7, 3, 0);
            this.sectorLabel.Name = "sectorLabel";
            this.sectorLabel.Size = new System.Drawing.Size(41, 13);
            this.sectorLabel.TabIndex = 2;
            this.sectorLabel.Text = "Sector:";
            // 
            // sectorComboBox
            // 
            this.sectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectorComboBox.FormattingEnabled = true;
            this.sectorComboBox.Location = new System.Drawing.Point(335, 3);
            this.sectorComboBox.Name = "sectorComboBox";
            this.sectorComboBox.Size = new System.Drawing.Size(180, 21);
            this.sectorComboBox.TabIndex = 3;
            this.sectorComboBox.SelectedIndexChanged += new System.EventHandler(this.sectorComboBox_SelectedIndexChanged);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.stocksGrid);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 100);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.gridPanel.Size = new System.Drawing.Size(900, 409);
            this.gridPanel.TabIndex = 2;
            // 
            // stocksGrid
            // 
            this.stocksGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocksGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.symbolColumn,
            this.companyColumn,
            this.sectorColumn,
            this.priceColumn,
            this.volatilityColumn,
            this.yieldColumn});
            this.stocksGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stocksGrid.Location = new System.Drawing.Point(15, 0);
            this.stocksGrid.Name = "stocksGrid";
            this.stocksGrid.Size = new System.Drawing.Size(870, 409);
            this.stocksGrid.TabIndex = 0;
            this.stocksGrid.SelectionChanged += new System.EventHandler(this.stocksGrid_SelectionChanged);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "StockID";
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // symbolColumn
            // 
            this.symbolColumn.DataPropertyName = "Symbol";
            this.symbolColumn.FillWeight = 60F;
            this.symbolColumn.HeaderText = "Symbol";
            this.symbolColumn.Name = "symbolColumn";
            // 
            // companyColumn
            // 
            this.companyColumn.DataPropertyName = "CompanyName";
            this.companyColumn.FillWeight = 160F;
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
            // volatilityColumn
            // 
            this.volatilityColumn.DataPropertyName = "Volatility";
            dataGridViewCellStyle2.Format = "P2";
            this.volatilityColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.volatilityColumn.HeaderText = "Volatility";
            this.volatilityColumn.Name = "volatilityColumn";
            // 
            // yieldColumn
            // 
            this.yieldColumn.DataPropertyName = "DividendYield";
            dataGridViewCellStyle3.Format = "P2";
            this.yieldColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.yieldColumn.HeaderText = "Dividend yield";
            this.yieldColumn.Name = "yieldColumn";
            // 
            // tradePanel
            // 
            this.tradePanel.Controls.Add(this.tradeFlowPanel);
            this.tradePanel.Controls.Add(this.descriptionLabel);
            this.tradePanel.Controls.Add(this.stockNameLabel);
            this.tradePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tradePanel.Location = new System.Drawing.Point(0, 509);
            this.tradePanel.Name = "tradePanel";
            this.tradePanel.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.tradePanel.Size = new System.Drawing.Size(900, 145);
            this.tradePanel.TabIndex = 3;
            // 
            // tradeFlowPanel
            // 
            this.tradeFlowPanel.Controls.Add(this.quantityLabel);
            this.tradeFlowPanel.Controls.Add(this.quantityNumericUpDown);
            this.tradeFlowPanel.Controls.Add(this.buyButton);
            this.tradeFlowPanel.Controls.Add(this.sellButton);
            this.tradeFlowPanel.Controls.Add(this.watchButton);
            this.tradeFlowPanel.Controls.Add(this.estimateLabel);
            this.tradeFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tradeFlowPanel.Location = new System.Drawing.Point(15, 85);
            this.tradeFlowPanel.Name = "tradeFlowPanel";
            this.tradeFlowPanel.Size = new System.Drawing.Size(870, 45);
            this.tradeFlowPanel.TabIndex = 2;
            this.tradeFlowPanel.WrapContents = false;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(3, 12);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(58, 9);
            this.quantityNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 9, 15, 3);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.quantityNumericUpDown.TabIndex = 1;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.ValueChanged += new System.EventHandler(this.quantityNumericUpDown_ValueChanged);
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.buyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyButton.FlatAppearance.BorderSize = 0;
            this.buyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyButton.ForeColor = System.Drawing.Color.White;
            this.buyButton.Location = new System.Drawing.Point(156, 3);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(100, 32);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.sellButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sellButton.FlatAppearance.BorderSize = 0;
            this.sellButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellButton.ForeColor = System.Drawing.Color.White;
            this.sellButton.Location = new System.Drawing.Point(262, 3);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(100, 32);
            this.sellButton.TabIndex = 3;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // watchButton
            // 
            this.watchButton.AutoSize = true;
            this.watchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.watchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchButton.Location = new System.Drawing.Point(368, 3);
            this.watchButton.MinimumSize = new System.Drawing.Size(130, 32);
            this.watchButton.Name = "watchButton";
            this.watchButton.Size = new System.Drawing.Size(130, 32);
            this.watchButton.TabIndex = 4;
            this.watchButton.Text = "Add to watchlist";
            this.watchButton.UseVisualStyleBackColor = true;
            this.watchButton.Click += new System.EventHandler(this.watchButton_Click);
            // 
            // estimateLabel
            // 
            this.estimateLabel.AutoSize = true;
            this.estimateLabel.Location = new System.Drawing.Point(516, 12);
            this.estimateLabel.Margin = new System.Windows.Forms.Padding(15, 12, 3, 0);
            this.estimateLabel.Name = "estimateLabel";
            this.estimateLabel.Size = new System.Drawing.Size(0, 13);
            this.estimateLabel.TabIndex = 5;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.descriptionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.descriptionLabel.Location = new System.Drawing.Point(15, 38);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(870, 47);
            this.descriptionLabel.TabIndex = 1;
            // 
            // stockNameLabel
            // 
            this.stockNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.stockNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameLabel.Location = new System.Drawing.Point(15, 10);
            this.stockNameLabel.Name = "stockNameLabel";
            this.stockNameLabel.Size = new System.Drawing.Size(870, 28);
            this.stockNameLabel.TabIndex = 0;
            this.stockNameLabel.Text = "Select a stock";
            // 
            // MarketPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.tradePanel);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "MarketPanel";
            this.Size = new System.Drawing.Size(900, 654);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stocksGrid)).EndInit();
            this.tradePanel.ResumeLayout(false);
            this.tradeFlowPanel.ResumeLayout(false);
            this.tradeFlowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.FlowLayoutPanel filterPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label sectorLabel;
        private System.Windows.Forms.ComboBox sectorComboBox;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView stocksGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn volatilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yieldColumn;
        private System.Windows.Forms.Panel tradePanel;
        private System.Windows.Forms.FlowLayoutPanel tradeFlowPanel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Button watchButton;
        private System.Windows.Forms.Label estimateLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label stockNameLabel;
    }
}

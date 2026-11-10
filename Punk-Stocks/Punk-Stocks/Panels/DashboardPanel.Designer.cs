namespace Punk_Stocks.Panels
{
    partial class DashboardPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cardsTable = new System.Windows.Forms.TableLayoutPanel();
            this.cashPanel = new System.Windows.Forms.Panel();
            this.cashValueLabel = new System.Windows.Forms.Label();
            this.cashCaptionLabel = new System.Windows.Forms.Label();
            this.holdingsPanel = new System.Windows.Forms.Panel();
            this.holdingsValueLabel = new System.Windows.Forms.Label();
            this.holdingsCaptionLabel = new System.Windows.Forms.Label();
            this.netWorthPanel = new System.Windows.Forms.Panel();
            this.netWorthValueLabel = new System.Windows.Forms.Label();
            this.netWorthCaptionLabel = new System.Windows.Forms.Label();
            this.profitPanel = new System.Windows.Forms.Panel();
            this.profitValueLabel = new System.Windows.Forms.Label();
            this.profitCaptionLabel = new System.Windows.Forms.Label();
            this.recentLabel = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.recentGrid = new System.Windows.Forms.DataGridView();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardsTable.SuspendLayout();
            this.cashPanel.SuspendLayout();
            this.holdingsPanel.SuspendLayout();
            this.netWorthPanel.SuspendLayout();
            this.profitPanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentGrid)).BeginInit();
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
            this.titleLabel.Text = "Dashboard";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardsTable
            // 
            this.cardsTable.ColumnCount = 4;
            this.cardsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cardsTable.Controls.Add(this.cashPanel, 0, 0);
            this.cardsTable.Controls.Add(this.holdingsPanel, 1, 0);
            this.cardsTable.Controls.Add(this.netWorthPanel, 2, 0);
            this.cardsTable.Controls.Add(this.profitPanel, 3, 0);
            this.cardsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardsTable.Location = new System.Drawing.Point(0, 60);
            this.cardsTable.Name = "cardsTable";
            this.cardsTable.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cardsTable.RowCount = 1;
            this.cardsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardsTable.Size = new System.Drawing.Size(900, 100);
            this.cardsTable.TabIndex = 1;
            // 
            // cashPanel
            // 
            this.cashPanel.BackColor = System.Drawing.Color.White;
            this.cashPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashPanel.Controls.Add(this.cashValueLabel);
            this.cashPanel.Controls.Add(this.cashCaptionLabel);
            this.cashPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashPanel.Location = new System.Drawing.Point(15, 5);
            this.cashPanel.Margin = new System.Windows.Forms.Padding(5);
            this.cashPanel.Name = "cashPanel";
            this.cashPanel.Size = new System.Drawing.Size(210, 90);
            this.cashPanel.TabIndex = 0;
            // 
            // cashValueLabel
            // 
            this.cashValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashValueLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashValueLabel.Location = new System.Drawing.Point(0, 30);
            this.cashValueLabel.Name = "cashValueLabel";
            this.cashValueLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.cashValueLabel.Size = new System.Drawing.Size(208, 58);
            this.cashValueLabel.TabIndex = 1;
            this.cashValueLabel.Text = "-";
            this.cashValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cashCaptionLabel
            // 
            this.cashCaptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cashCaptionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.cashCaptionLabel.Location = new System.Drawing.Point(0, 0);
            this.cashCaptionLabel.Name = "cashCaptionLabel";
            this.cashCaptionLabel.Padding = new System.Windows.Forms.Padding(10, 8, 0, 0);
            this.cashCaptionLabel.Size = new System.Drawing.Size(208, 30);
            this.cashCaptionLabel.TabIndex = 0;
            this.cashCaptionLabel.Text = "Cash";
            // 
            // holdingsPanel
            // 
            this.holdingsPanel.BackColor = System.Drawing.Color.White;
            this.holdingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holdingsPanel.Controls.Add(this.holdingsValueLabel);
            this.holdingsPanel.Controls.Add(this.holdingsCaptionLabel);
            this.holdingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holdingsPanel.Location = new System.Drawing.Point(235, 5);
            this.holdingsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.holdingsPanel.Name = "holdingsPanel";
            this.holdingsPanel.Size = new System.Drawing.Size(210, 90);
            this.holdingsPanel.TabIndex = 1;
            // 
            // holdingsValueLabel
            // 
            this.holdingsValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.holdingsValueLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdingsValueLabel.Location = new System.Drawing.Point(0, 30);
            this.holdingsValueLabel.Name = "holdingsValueLabel";
            this.holdingsValueLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.holdingsValueLabel.Size = new System.Drawing.Size(208, 58);
            this.holdingsValueLabel.TabIndex = 1;
            this.holdingsValueLabel.Text = "-";
            this.holdingsValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // holdingsCaptionLabel
            // 
            this.holdingsCaptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.holdingsCaptionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.holdingsCaptionLabel.Location = new System.Drawing.Point(0, 0);
            this.holdingsCaptionLabel.Name = "holdingsCaptionLabel";
            this.holdingsCaptionLabel.Padding = new System.Windows.Forms.Padding(10, 8, 0, 0);
            this.holdingsCaptionLabel.Size = new System.Drawing.Size(208, 30);
            this.holdingsCaptionLabel.TabIndex = 0;
            this.holdingsCaptionLabel.Text = "Holdings value";
            // 
            // netWorthPanel
            // 
            this.netWorthPanel.BackColor = System.Drawing.Color.White;
            this.netWorthPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netWorthPanel.Controls.Add(this.netWorthValueLabel);
            this.netWorthPanel.Controls.Add(this.netWorthCaptionLabel);
            this.netWorthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netWorthPanel.Location = new System.Drawing.Point(455, 5);
            this.netWorthPanel.Margin = new System.Windows.Forms.Padding(5);
            this.netWorthPanel.Name = "netWorthPanel";
            this.netWorthPanel.Size = new System.Drawing.Size(210, 90);
            this.netWorthPanel.TabIndex = 2;
            // 
            // netWorthValueLabel
            // 
            this.netWorthValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netWorthValueLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netWorthValueLabel.Location = new System.Drawing.Point(0, 30);
            this.netWorthValueLabel.Name = "netWorthValueLabel";
            this.netWorthValueLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.netWorthValueLabel.Size = new System.Drawing.Size(208, 58);
            this.netWorthValueLabel.TabIndex = 1;
            this.netWorthValueLabel.Text = "-";
            this.netWorthValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // netWorthCaptionLabel
            // 
            this.netWorthCaptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.netWorthCaptionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.netWorthCaptionLabel.Location = new System.Drawing.Point(0, 0);
            this.netWorthCaptionLabel.Name = "netWorthCaptionLabel";
            this.netWorthCaptionLabel.Padding = new System.Windows.Forms.Padding(10, 8, 0, 0);
            this.netWorthCaptionLabel.Size = new System.Drawing.Size(208, 30);
            this.netWorthCaptionLabel.TabIndex = 0;
            this.netWorthCaptionLabel.Text = "Net worth";
            // 
            // profitPanel
            // 
            this.profitPanel.BackColor = System.Drawing.Color.White;
            this.profitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profitPanel.Controls.Add(this.profitValueLabel);
            this.profitPanel.Controls.Add(this.profitCaptionLabel);
            this.profitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profitPanel.Location = new System.Drawing.Point(675, 5);
            this.profitPanel.Margin = new System.Windows.Forms.Padding(5);
            this.profitPanel.Name = "profitPanel";
            this.profitPanel.Size = new System.Drawing.Size(210, 90);
            this.profitPanel.TabIndex = 3;
            // 
            // profitValueLabel
            // 
            this.profitValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profitValueLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profitValueLabel.Location = new System.Drawing.Point(0, 30);
            this.profitValueLabel.Name = "profitValueLabel";
            this.profitValueLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.profitValueLabel.Size = new System.Drawing.Size(208, 58);
            this.profitValueLabel.TabIndex = 1;
            this.profitValueLabel.Text = "-";
            this.profitValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profitCaptionLabel
            // 
            this.profitCaptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.profitCaptionLabel.ForeColor = System.Drawing.Color.DimGray;
            this.profitCaptionLabel.Location = new System.Drawing.Point(0, 0);
            this.profitCaptionLabel.Name = "profitCaptionLabel";
            this.profitCaptionLabel.Padding = new System.Windows.Forms.Padding(10, 8, 0, 0);
            this.profitCaptionLabel.Size = new System.Drawing.Size(208, 30);
            this.profitCaptionLabel.TabIndex = 0;
            this.profitCaptionLabel.Text = "Profit";
            // 
            // recentLabel
            // 
            this.recentLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.recentLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentLabel.Location = new System.Drawing.Point(0, 160);
            this.recentLabel.Name = "recentLabel";
            this.recentLabel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.recentLabel.Size = new System.Drawing.Size(900, 45);
            this.recentLabel.TabIndex = 2;
            this.recentLabel.Text = "Recent transactions";
            this.recentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.recentGrid);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 205);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.gridPanel.Size = new System.Drawing.Size(900, 449);
            this.gridPanel.TabIndex = 3;
            // 
            // recentGrid
            // 
            this.recentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateColumn,
            this.typeColumn,
            this.symbolColumn,
            this.quantityColumn,
            this.priceColumn,
            this.totalColumn});
            this.recentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentGrid.Location = new System.Drawing.Point(15, 0);
            this.recentGrid.Name = "recentGrid";
            this.recentGrid.Size = new System.Drawing.Size(870, 434);
            this.recentGrid.TabIndex = 0;
            // 
            // dateColumn
            // 
            this.dateColumn.DataPropertyName = "ExecutedAt";
            dataGridViewCellStyle4.Format = "g";
            this.dateColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.Name = "dateColumn";
            // 
            // typeColumn
            // 
            this.typeColumn.DataPropertyName = "Type";
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            // 
            // symbolColumn
            // 
            this.symbolColumn.DataPropertyName = "Symbol";
            this.symbolColumn.HeaderText = "Symbol";
            this.symbolColumn.Name = "symbolColumn";
            // 
            // quantityColumn
            // 
            this.quantityColumn.DataPropertyName = "Quantity";
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            // 
            // priceColumn
            // 
            this.priceColumn.DataPropertyName = "PricePerShare";
            dataGridViewCellStyle5.Format = "C2";
            this.priceColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.Name = "priceColumn";
            // 
            // totalColumn
            // 
            this.totalColumn.DataPropertyName = "Total";
            dataGridViewCellStyle6.Format = "C2";
            this.totalColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.totalColumn.HeaderText = "Total";
            this.totalColumn.Name = "totalColumn";
            // 
            // DashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.recentLabel);
            this.Controls.Add(this.cardsTable);
            this.Controls.Add(this.titleLabel);
            this.Name = "DashboardPanel";
            this.Size = new System.Drawing.Size(900, 654);
            this.cardsTable.ResumeLayout(false);
            this.cashPanel.ResumeLayout(false);
            this.holdingsPanel.ResumeLayout(false);
            this.netWorthPanel.ResumeLayout(false);
            this.profitPanel.ResumeLayout(false);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recentGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel cardsTable;
        private System.Windows.Forms.Panel cashPanel;
        private System.Windows.Forms.Label cashValueLabel;
        private System.Windows.Forms.Label cashCaptionLabel;
        private System.Windows.Forms.Panel holdingsPanel;
        private System.Windows.Forms.Label holdingsValueLabel;
        private System.Windows.Forms.Label holdingsCaptionLabel;
        private System.Windows.Forms.Panel netWorthPanel;
        private System.Windows.Forms.Label netWorthValueLabel;
        private System.Windows.Forms.Label netWorthCaptionLabel;
        private System.Windows.Forms.Panel profitPanel;
        private System.Windows.Forms.Label profitValueLabel;
        private System.Windows.Forms.Label profitCaptionLabel;
        private System.Windows.Forms.Label recentLabel;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView recentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalColumn;
    }
}

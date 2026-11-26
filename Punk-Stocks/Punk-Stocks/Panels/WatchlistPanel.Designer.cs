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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleLabel = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.watchlistGrid = new System.Windows.Forms.DataGridView();
            this.symbolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.alertsPanel = new System.Windows.Forms.Panel();
            this.alertsGrid = new System.Windows.Forms.DataGridView();
            this.alertSymbolColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alertPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alertsActionsPanel = new System.Windows.Forms.Panel();
            this.removeAlertButton = new System.Windows.Forms.Button();
            this.alertsTitleLabel = new System.Windows.Forms.Label();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.watchlistGrid)).BeginInit();
            this.actionsPanel.SuspendLayout();
            this.alertsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertsGrid)).BeginInit();
            this.alertsActionsPanel.SuspendLayout();
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
            this.gridPanel.Size = new System.Drawing.Size(900, 274);
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
            this.watchlistGrid.Size = new System.Drawing.Size(870, 274);
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
            this.actionsPanel.Location = new System.Drawing.Point(0, 334);
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
            // alertsPanel
            //
            this.alertsPanel.Controls.Add(this.alertsGrid);
            this.alertsPanel.Controls.Add(this.alertsActionsPanel);
            this.alertsPanel.Controls.Add(this.alertsTitleLabel);
            this.alertsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.alertsPanel.Location = new System.Drawing.Point(0, 394);
            this.alertsPanel.Name = "alertsPanel";
            this.alertsPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.alertsPanel.Size = new System.Drawing.Size(900, 260);
            this.alertsPanel.TabIndex = 3;
            //
            // alertsGrid
            //
            this.alertsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alertsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alertSymbolColumn,
            this.conditionColumn,
            this.targetColumn,
            this.alertPriceColumn,
            this.statusColumn});
            this.alertsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertsGrid.Location = new System.Drawing.Point(15, 35);
            this.alertsGrid.Name = "alertsGrid";
            this.alertsGrid.Size = new System.Drawing.Size(870, 165);
            this.alertsGrid.TabIndex = 1;
            //
            // alertSymbolColumn
            //
            this.alertSymbolColumn.DataPropertyName = "Symbol";
            this.alertSymbolColumn.HeaderText = "Symbol";
            this.alertSymbolColumn.Name = "alertSymbolColumn";
            //
            // conditionColumn
            //
            this.conditionColumn.DataPropertyName = "Condition";
            this.conditionColumn.HeaderText = "Condition";
            this.conditionColumn.Name = "conditionColumn";
            //
            // targetColumn
            //
            this.targetColumn.DataPropertyName = "TargetPrice";
            dataGridViewCellStyle2.Format = "C2";
            this.targetColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.targetColumn.HeaderText = "Target";
            this.targetColumn.Name = "targetColumn";
            //
            // alertPriceColumn
            //
            this.alertPriceColumn.DataPropertyName = "CurrentPrice";
            dataGridViewCellStyle3.Format = "C2";
            this.alertPriceColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.alertPriceColumn.HeaderText = "Price";
            this.alertPriceColumn.Name = "alertPriceColumn";
            //
            // statusColumn
            //
            this.statusColumn.DataPropertyName = "Status";
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.Name = "statusColumn";
            //
            // alertsActionsPanel
            //
            this.alertsActionsPanel.Controls.Add(this.removeAlertButton);
            this.alertsActionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.alertsActionsPanel.Location = new System.Drawing.Point(15, 200);
            this.alertsActionsPanel.Name = "alertsActionsPanel";
            this.alertsActionsPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.alertsActionsPanel.Size = new System.Drawing.Size(870, 60);
            this.alertsActionsPanel.TabIndex = 2;
            //
            // removeAlertButton
            //
            this.removeAlertButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.removeAlertButton.Location = new System.Drawing.Point(720, 10);
            this.removeAlertButton.Name = "removeAlertButton";
            this.removeAlertButton.Size = new System.Drawing.Size(150, 35);
            this.removeAlertButton.TabIndex = 0;
            this.removeAlertButton.Text = "Remove alert";
            this.removeAlertButton.UseVisualStyleBackColor = true;
            this.removeAlertButton.Click += new System.EventHandler(this.removeAlertButton_Click);
            //
            // alertsTitleLabel
            //
            this.alertsTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.alertsTitleLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertsTitleLabel.Location = new System.Drawing.Point(15, 0);
            this.alertsTitleLabel.Name = "alertsTitleLabel";
            this.alertsTitleLabel.Size = new System.Drawing.Size(870, 35);
            this.alertsTitleLabel.TabIndex = 0;
            this.alertsTitleLabel.Text = "Price alerts";
            this.alertsTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // WatchlistPanel
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.alertsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "WatchlistPanel";
            this.Size = new System.Drawing.Size(900, 654);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.watchlistGrid)).EndInit();
            this.actionsPanel.ResumeLayout(false);
            this.alertsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alertsGrid)).EndInit();
            this.alertsActionsPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel alertsPanel;
        private System.Windows.Forms.DataGridView alertsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn alertSymbolColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alertPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.Panel alertsActionsPanel;
        private System.Windows.Forms.Button removeAlertButton;
        private System.Windows.Forms.Label alertsTitleLabel;
    }
}

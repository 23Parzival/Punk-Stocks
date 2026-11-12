namespace Punk_Stocks.Panels
{
    partial class AdminPanel
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.actionsPanel = new System.Windows.Forms.Panel();
            this.resetCashButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.createdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
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
            this.titleLabel.Text = "Admin";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.usersGrid);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 60);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.gridPanel.Size = new System.Drawing.Size(900, 534);
            this.gridPanel.TabIndex = 1;
            // 
            // usersGrid
            // 
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.usernameColumn,
            this.cashColumn,
            this.adminColumn,
            this.createdColumn});
            this.usersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGrid.Location = new System.Drawing.Point(15, 0);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.Size = new System.Drawing.Size(870, 534);
            this.usersGrid.TabIndex = 0;
            // 
            // actionsPanel
            // 
            this.actionsPanel.Controls.Add(this.resetCashButton);
            this.actionsPanel.Controls.Add(this.deleteUserButton);
            this.actionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionsPanel.Location = new System.Drawing.Point(0, 594);
            this.actionsPanel.Name = "actionsPanel";
            this.actionsPanel.Padding = new System.Windows.Forms.Padding(15, 10, 15, 15);
            this.actionsPanel.Size = new System.Drawing.Size(900, 60);
            this.actionsPanel.TabIndex = 2;
            // 
            // resetCashButton
            // 
            this.resetCashButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.resetCashButton.Location = new System.Drawing.Point(585, 10);
            this.resetCashButton.Name = "resetCashButton";
            this.resetCashButton.Size = new System.Drawing.Size(150, 35);
            this.resetCashButton.TabIndex = 0;
            this.resetCashButton.Text = "Reset cash";
            this.resetCashButton.UseVisualStyleBackColor = true;
            this.resetCashButton.Click += new System.EventHandler(this.resetCashButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteUserButton.Location = new System.Drawing.Point(735, 10);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(150, 35);
            this.deleteUserButton.TabIndex = 1;
            this.deleteUserButton.Text = "Delete user";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "UserID";
            this.idColumn.FillWeight = 50F;
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            // 
            // usernameColumn
            // 
            this.usernameColumn.DataPropertyName = "Username";
            this.usernameColumn.FillWeight = 150F;
            this.usernameColumn.HeaderText = "Username";
            this.usernameColumn.Name = "usernameColumn";
            // 
            // cashColumn
            // 
            this.cashColumn.DataPropertyName = "CashBalance";
            dataGridViewCellStyle1.Format = "C2";
            this.cashColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cashColumn.HeaderText = "Cash";
            this.cashColumn.Name = "cashColumn";
            // 
            // adminColumn
            // 
            this.adminColumn.DataPropertyName = "IsAdmin";
            this.adminColumn.FillWeight = 50F;
            this.adminColumn.HeaderText = "Admin";
            this.adminColumn.Name = "adminColumn";
            // 
            // createdColumn
            // 
            this.createdColumn.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle2.Format = "g";
            this.createdColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.createdColumn.HeaderText = "Created";
            this.createdColumn.Name = "createdColumn";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.actionsPanel);
            this.Controls.Add(this.titleLabel);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(900, 654);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.actionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.Panel actionsPanel;
        private System.Windows.Forms.Button resetCashButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdColumn;
    }
}

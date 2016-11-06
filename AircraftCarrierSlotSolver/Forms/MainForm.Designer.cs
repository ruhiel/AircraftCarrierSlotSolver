namespace AircraftCarrierSlotSolver
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ShipSlotInfoDataGridView = new System.Windows.Forms.DataGridView();
			this.SettingButton = new System.Windows.Forms.DataGridViewButtonColumn();
			this.AddButton = new System.Windows.Forms.Button();
			this.CalcButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.airCraftSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.solverSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ShipSelectComboBox = new System.Windows.Forms.ComboBox();
			this.AirSuperiorityLabel = new System.Windows.Forms.Label();
			this.AirSuperiorityNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.AreaComboBox = new System.Windows.Forms.ComboBox();
			this.SuperiorityButton = new System.Windows.Forms.Button();
			this.SecureButton = new System.Windows.Forms.Button();
			this.shipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.slot1NumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slot1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slot2NumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slot2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slot3NumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slot3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slot4NumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.slot4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipSlotInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.MeringLabel = new System.Windows.Forms.Label();
			this.MerginNumericUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.ShipSlotInfoDataGridView)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AirSuperiorityNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.shipSlotInfoBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MerginNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// ShipSlotInfoDataGridView
			// 
			this.ShipSlotInfoDataGridView.AllowUserToAddRows = false;
			this.ShipSlotInfoDataGridView.AllowUserToResizeRows = false;
			this.ShipSlotInfoDataGridView.AutoGenerateColumns = false;
			this.ShipSlotInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ShipSlotInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shipNameDataGridViewTextBoxColumn,
            this.slot1NumDataGridViewTextBoxColumn,
            this.slot1DataGridViewTextBoxColumn,
            this.slot2NumDataGridViewTextBoxColumn,
            this.slot2DataGridViewTextBoxColumn,
            this.slot3NumDataGridViewTextBoxColumn,
            this.slot3DataGridViewTextBoxColumn,
            this.slot4NumDataGridViewTextBoxColumn,
            this.slot4DataGridViewTextBoxColumn,
            this.SettingButton});
			this.ShipSlotInfoDataGridView.DataSource = this.shipSlotInfoBindingSource;
			this.ShipSlotInfoDataGridView.Location = new System.Drawing.Point(12, 69);
			this.ShipSlotInfoDataGridView.Name = "ShipSlotInfoDataGridView";
			this.ShipSlotInfoDataGridView.RowTemplate.Height = 21;
			this.ShipSlotInfoDataGridView.Size = new System.Drawing.Size(913, 180);
			this.ShipSlotInfoDataGridView.TabIndex = 0;
			this.ShipSlotInfoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShipSlotInfoDataGridView_CellContentClick);
			this.ShipSlotInfoDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShipSlotInfoDataGridView_CellEndEdit);
			this.ShipSlotInfoDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ShipSlotInfoDataGridView_EditingControlShowing);
			this.ShipSlotInfoDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ShipSlotInfoDataGridView_RowsAdded);
			this.ShipSlotInfoDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ShipSlotInfoDataGridView_RowsRemoved);
			// 
			// SettingButton
			// 
			this.SettingButton.HeaderText = "設定";
			this.SettingButton.Name = "SettingButton";
			this.SettingButton.Text = "設定";
			this.SettingButton.UseColumnTextForButtonValue = true;
			this.SettingButton.Width = 50;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(139, 27);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = "追加";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// CalcButton
			// 
			this.CalcButton.Enabled = false;
			this.CalcButton.Location = new System.Drawing.Point(359, 27);
			this.CalcButton.Name = "CalcButton";
			this.CalcButton.Size = new System.Drawing.Size(75, 23);
			this.CalcButton.TabIndex = 2;
			this.CalcButton.Text = "計算";
			this.CalcButton.UseVisualStyleBackColor = true;
			this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(932, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airCraftSettingToolStripMenuItem,
            this.solverSettingToolStripMenuItem});
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.settingToolStripMenuItem.Text = "設定";
			// 
			// airCraftSettingToolStripMenuItem
			// 
			this.airCraftSettingToolStripMenuItem.Name = "airCraftSettingToolStripMenuItem";
			this.airCraftSettingToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.airCraftSettingToolStripMenuItem.Text = "艦載機設定";
			this.airCraftSettingToolStripMenuItem.Click += new System.EventHandler(this.airCraftSettingToolStripMenuItem_Click);
			// 
			// solverSettingToolStripMenuItem
			// 
			this.solverSettingToolStripMenuItem.Name = "solverSettingToolStripMenuItem";
			this.solverSettingToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.solverSettingToolStripMenuItem.Text = "ソルバ設定";
			this.solverSettingToolStripMenuItem.Click += new System.EventHandler(this.solverSettingToolStripMenuItem_Click);
			// 
			// ShipSelectComboBox
			// 
			this.ShipSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ShipSelectComboBox.FormattingEnabled = true;
			this.ShipSelectComboBox.Location = new System.Drawing.Point(12, 27);
			this.ShipSelectComboBox.Name = "ShipSelectComboBox";
			this.ShipSelectComboBox.Size = new System.Drawing.Size(121, 20);
			this.ShipSelectComboBox.TabIndex = 4;
			// 
			// AirSuperiorityLabel
			// 
			this.AirSuperiorityLabel.AutoSize = true;
			this.AirSuperiorityLabel.Location = new System.Drawing.Point(220, 31);
			this.AirSuperiorityLabel.Name = "AirSuperiorityLabel";
			this.AirSuperiorityLabel.Size = new System.Drawing.Size(65, 12);
			this.AirSuperiorityLabel.TabIndex = 5;
			this.AirSuperiorityLabel.Text = "目標制空値";
			// 
			// AirSuperiorityNumericUpDown
			// 
			this.AirSuperiorityNumericUpDown.Location = new System.Drawing.Point(291, 27);
			this.AirSuperiorityNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.AirSuperiorityNumericUpDown.Name = "AirSuperiorityNumericUpDown";
			this.AirSuperiorityNumericUpDown.Size = new System.Drawing.Size(53, 19);
			this.AirSuperiorityNumericUpDown.TabIndex = 6;
			// 
			// AreaComboBox
			// 
			this.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AreaComboBox.FormattingEnabled = true;
			this.AreaComboBox.Location = new System.Drawing.Point(453, 27);
			this.AreaComboBox.Name = "AreaComboBox";
			this.AreaComboBox.Size = new System.Drawing.Size(121, 20);
			this.AreaComboBox.TabIndex = 7;
			// 
			// SuperiorityButton
			// 
			this.SuperiorityButton.Location = new System.Drawing.Point(580, 27);
			this.SuperiorityButton.Name = "SuperiorityButton";
			this.SuperiorityButton.Size = new System.Drawing.Size(75, 23);
			this.SuperiorityButton.TabIndex = 8;
			this.SuperiorityButton.Text = "優勢";
			this.SuperiorityButton.UseVisualStyleBackColor = true;
			this.SuperiorityButton.Click += new System.EventHandler(this.SuperiorityButton_Click);
			// 
			// SecureButton
			// 
			this.SecureButton.Location = new System.Drawing.Point(661, 27);
			this.SecureButton.Name = "SecureButton";
			this.SecureButton.Size = new System.Drawing.Size(75, 23);
			this.SecureButton.TabIndex = 8;
			this.SecureButton.Text = "確保";
			this.SecureButton.UseVisualStyleBackColor = true;
			this.SecureButton.Click += new System.EventHandler(this.SecureButton_Click);
			// 
			// shipNameDataGridViewTextBoxColumn
			// 
			this.shipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName";
			this.shipNameDataGridViewTextBoxColumn.HeaderText = "艦娘";
			this.shipNameDataGridViewTextBoxColumn.Name = "shipNameDataGridViewTextBoxColumn";
			this.shipNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.shipNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.shipNameDataGridViewTextBoxColumn.Width = 120;
			// 
			// slot1NumDataGridViewTextBoxColumn
			// 
			this.slot1NumDataGridViewTextBoxColumn.DataPropertyName = "Slot1Num";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.slot1NumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
			this.slot1NumDataGridViewTextBoxColumn.HeaderText = "";
			this.slot1NumDataGridViewTextBoxColumn.Name = "slot1NumDataGridViewTextBoxColumn";
			this.slot1NumDataGridViewTextBoxColumn.ReadOnly = true;
			this.slot1NumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.slot1NumDataGridViewTextBoxColumn.Width = 20;
			// 
			// slot1DataGridViewTextBoxColumn
			// 
			this.slot1DataGridViewTextBoxColumn.DataPropertyName = "Slot1";
			this.slot1DataGridViewTextBoxColumn.HeaderText = "スロット1";
			this.slot1DataGridViewTextBoxColumn.Name = "slot1DataGridViewTextBoxColumn";
			this.slot1DataGridViewTextBoxColumn.ReadOnly = true;
			this.slot1DataGridViewTextBoxColumn.Width = 155;
			// 
			// slot2NumDataGridViewTextBoxColumn
			// 
			this.slot2NumDataGridViewTextBoxColumn.DataPropertyName = "Slot2Num";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.slot2NumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
			this.slot2NumDataGridViewTextBoxColumn.HeaderText = "";
			this.slot2NumDataGridViewTextBoxColumn.Name = "slot2NumDataGridViewTextBoxColumn";
			this.slot2NumDataGridViewTextBoxColumn.ReadOnly = true;
			this.slot2NumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.slot2NumDataGridViewTextBoxColumn.Width = 20;
			// 
			// slot2DataGridViewTextBoxColumn
			// 
			this.slot2DataGridViewTextBoxColumn.DataPropertyName = "Slot2";
			this.slot2DataGridViewTextBoxColumn.HeaderText = "スロット2";
			this.slot2DataGridViewTextBoxColumn.Name = "slot2DataGridViewTextBoxColumn";
			this.slot2DataGridViewTextBoxColumn.ReadOnly = true;
			this.slot2DataGridViewTextBoxColumn.Width = 155;
			// 
			// slot3NumDataGridViewTextBoxColumn
			// 
			this.slot3NumDataGridViewTextBoxColumn.DataPropertyName = "Slot3Num";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.slot3NumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
			this.slot3NumDataGridViewTextBoxColumn.HeaderText = "";
			this.slot3NumDataGridViewTextBoxColumn.Name = "slot3NumDataGridViewTextBoxColumn";
			this.slot3NumDataGridViewTextBoxColumn.ReadOnly = true;
			this.slot3NumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.slot3NumDataGridViewTextBoxColumn.Width = 20;
			// 
			// slot3DataGridViewTextBoxColumn
			// 
			this.slot3DataGridViewTextBoxColumn.DataPropertyName = "Slot3";
			this.slot3DataGridViewTextBoxColumn.HeaderText = "スロット3";
			this.slot3DataGridViewTextBoxColumn.Name = "slot3DataGridViewTextBoxColumn";
			this.slot3DataGridViewTextBoxColumn.ReadOnly = true;
			this.slot3DataGridViewTextBoxColumn.Width = 155;
			// 
			// slot4NumDataGridViewTextBoxColumn
			// 
			this.slot4NumDataGridViewTextBoxColumn.DataPropertyName = "Slot4Num";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.slot4NumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
			this.slot4NumDataGridViewTextBoxColumn.HeaderText = "";
			this.slot4NumDataGridViewTextBoxColumn.Name = "slot4NumDataGridViewTextBoxColumn";
			this.slot4NumDataGridViewTextBoxColumn.ReadOnly = true;
			this.slot4NumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.slot4NumDataGridViewTextBoxColumn.Width = 20;
			// 
			// slot4DataGridViewTextBoxColumn
			// 
			this.slot4DataGridViewTextBoxColumn.DataPropertyName = "Slot4";
			this.slot4DataGridViewTextBoxColumn.HeaderText = "スロット4";
			this.slot4DataGridViewTextBoxColumn.Name = "slot4DataGridViewTextBoxColumn";
			this.slot4DataGridViewTextBoxColumn.ReadOnly = true;
			this.slot4DataGridViewTextBoxColumn.Width = 155;
			// 
			// shipSlotInfoBindingSource
			// 
			this.shipSlotInfoBindingSource.DataSource = typeof(AircraftCarrierSlotSolver.ShipSlotInfo);
			// 
			// MeringLabel
			// 
			this.MeringLabel.AutoSize = true;
			this.MeringLabel.Location = new System.Drawing.Point(742, 32);
			this.MeringLabel.Name = "MeringLabel";
			this.MeringLabel.Size = new System.Drawing.Size(31, 12);
			this.MeringLabel.TabIndex = 5;
			this.MeringLabel.Text = "ゆとり";
			// 
			// MerginNumericUpDown
			// 
			this.MerginNumericUpDown.Location = new System.Drawing.Point(779, 30);
			this.MerginNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.MerginNumericUpDown.Name = "MerginNumericUpDown";
			this.MerginNumericUpDown.Size = new System.Drawing.Size(41, 19);
			this.MerginNumericUpDown.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 261);
			this.Controls.Add(this.SecureButton);
			this.Controls.Add(this.SuperiorityButton);
			this.Controls.Add(this.AreaComboBox);
			this.Controls.Add(this.MerginNumericUpDown);
			this.Controls.Add(this.AirSuperiorityNumericUpDown);
			this.Controls.Add(this.MeringLabel);
			this.Controls.Add(this.AirSuperiorityLabel);
			this.Controls.Add(this.ShipSelectComboBox);
			this.Controls.Add(this.CalcButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.ShipSlotInfoDataGridView);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "空母スロットソルバー";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ShipSlotInfoDataGridView)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AirSuperiorityNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.shipSlotInfoBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MerginNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView ShipSlotInfoDataGridView;
		private System.Windows.Forms.BindingSource shipSlotInfoBindingSource;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button CalcButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem airCraftSettingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem solverSettingToolStripMenuItem;
		private System.Windows.Forms.ComboBox ShipSelectComboBox;
		private System.Windows.Forms.Label AirSuperiorityLabel;
		private System.Windows.Forms.NumericUpDown AirSuperiorityNumericUpDown;
		private System.Windows.Forms.DataGridViewComboBoxColumn shipNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot1NumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot2NumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot3NumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot3DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot4NumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot4DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewButtonColumn SettingButton;
		private System.Windows.Forms.ComboBox AreaComboBox;
		private System.Windows.Forms.Button SuperiorityButton;
		private System.Windows.Forms.Button SecureButton;
		private System.Windows.Forms.Label MeringLabel;
		private System.Windows.Forms.NumericUpDown MerginNumericUpDown;
	}
}


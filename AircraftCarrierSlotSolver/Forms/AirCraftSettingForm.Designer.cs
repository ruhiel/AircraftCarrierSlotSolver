namespace AircraftCarrierSlotSolver.Forms
{
	partial class AirCraftSettingForm
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
			this.components = new System.ComponentModel.Container();
			this.AirCraftSettingDataGridView = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airCraftSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.OKButton = new System.Windows.Forms.Button();
			this.CruiserLimitLabel = new System.Windows.Forms.Label();
			this.CruiserLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.AirCraftComboBox = new System.Windows.Forms.ComboBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.AirCraftImprovementSettingDataGridView = new System.Windows.Forms.DataGridView();
			this.airCraftImprovementSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.improvementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.AirCraftSettingDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.airCraftSettingBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CruiserLimitNumericUpDown)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AirCraftImprovementSettingDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.airCraftImprovementSettingBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// AirCraftSettingDataGridView
			// 
			this.AirCraftSettingDataGridView.AllowUserToAddRows = false;
			this.AirCraftSettingDataGridView.AllowUserToDeleteRows = false;
			this.AirCraftSettingDataGridView.AllowUserToResizeRows = false;
			this.AirCraftSettingDataGridView.AutoGenerateColumns = false;
			this.AirCraftSettingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AirCraftSettingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
			this.AirCraftSettingDataGridView.DataSource = this.airCraftSettingBindingSource;
			this.AirCraftSettingDataGridView.Location = new System.Drawing.Point(6, 10);
			this.AirCraftSettingDataGridView.Name = "AirCraftSettingDataGridView";
			this.AirCraftSettingDataGridView.RowTemplate.Height = 21;
			this.AirCraftSettingDataGridView.Size = new System.Drawing.Size(306, 368);
			this.AirCraftSettingDataGridView.TabIndex = 0;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "艦載機";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.nameDataGridViewTextBoxColumn.Width = 150;
			// 
			// valueDataGridViewTextBoxColumn
			// 
			this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
			this.valueDataGridViewTextBoxColumn.HeaderText = "制限数";
			this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
			this.valueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.valueDataGridViewTextBoxColumn.Width = 60;
			// 
			// airCraftSettingBindingSource
			// 
			this.airCraftSettingBindingSource.DataSource = typeof(AircraftCarrierSlotSolver.AirCraftSetting);
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(100, 449);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 1;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// CruiserLimitLabel
			// 
			this.CruiserLimitLabel.AutoSize = true;
			this.CruiserLimitLabel.Location = new System.Drawing.Point(29, 425);
			this.CruiserLimitLabel.Name = "CruiserLimitLabel";
			this.CruiserLimitLabel.Size = new System.Drawing.Size(120, 12);
			this.CruiserLimitLabel.TabIndex = 2;
			this.CruiserLimitLabel.Text = "巡洋艦に積む水上機数";
			// 
			// CruiserLimitNumericUpDown
			// 
			this.CruiserLimitNumericUpDown.Location = new System.Drawing.Point(156, 422);
			this.CruiserLimitNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.CruiserLimitNumericUpDown.Name = "CruiserLimitNumericUpDown";
			this.CruiserLimitNumericUpDown.Size = new System.Drawing.Size(62, 19);
			this.CruiserLimitNumericUpDown.TabIndex = 3;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(326, 406);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.AirCraftSettingDataGridView);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(318, 380);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "未改修";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.AirCraftComboBox);
			this.tabPage2.Controls.Add(this.AddButton);
			this.tabPage2.Controls.Add(this.AirCraftImprovementSettingDataGridView);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(318, 380);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "改修済み";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// AirCraftComboBox
			// 
			this.AirCraftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AirCraftComboBox.FormattingEnabled = true;
			this.AirCraftComboBox.Location = new System.Drawing.Point(14, 8);
			this.AirCraftComboBox.Name = "AirCraftComboBox";
			this.AirCraftComboBox.Size = new System.Drawing.Size(216, 20);
			this.AirCraftComboBox.TabIndex = 2;
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(237, 7);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = "追加";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// AirCraftImprovementSettingDataGridView
			// 
			this.AirCraftImprovementSettingDataGridView.AllowUserToAddRows = false;
			this.AirCraftImprovementSettingDataGridView.AllowUserToResizeColumns = false;
			this.AirCraftImprovementSettingDataGridView.AllowUserToResizeRows = false;
			this.AirCraftImprovementSettingDataGridView.AutoGenerateColumns = false;
			this.AirCraftImprovementSettingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AirCraftImprovementSettingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.improvementDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn1});
			this.AirCraftImprovementSettingDataGridView.DataSource = this.airCraftImprovementSettingBindingSource;
			this.AirCraftImprovementSettingDataGridView.Location = new System.Drawing.Point(6, 40);
			this.AirCraftImprovementSettingDataGridView.Name = "AirCraftImprovementSettingDataGridView";
			this.AirCraftImprovementSettingDataGridView.RowTemplate.Height = 21;
			this.AirCraftImprovementSettingDataGridView.Size = new System.Drawing.Size(306, 334);
			this.AirCraftImprovementSettingDataGridView.TabIndex = 0;
			this.AirCraftImprovementSettingDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.AirCraftImprovementSettingDataGridView_CellValidating);
			// 
			// airCraftImprovementSettingBindingSource
			// 
			this.airCraftImprovementSettingBindingSource.DataSource = typeof(AircraftCarrierSlotSolver.AirCraftImprovementSetting);
			// 
			// nameDataGridViewTextBoxColumn1
			// 
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "艦載機";
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// improvementDataGridViewTextBoxColumn
			// 
			this.improvementDataGridViewTextBoxColumn.DataPropertyName = "Improvement";
			this.improvementDataGridViewTextBoxColumn.HeaderText = "改修値";
			this.improvementDataGridViewTextBoxColumn.Name = "improvementDataGridViewTextBoxColumn";
			this.improvementDataGridViewTextBoxColumn.Width = 70;
			// 
			// valueDataGridViewTextBoxColumn1
			// 
			this.valueDataGridViewTextBoxColumn1.DataPropertyName = "Value";
			this.valueDataGridViewTextBoxColumn1.HeaderText = "装備数";
			this.valueDataGridViewTextBoxColumn1.Name = "valueDataGridViewTextBoxColumn1";
			this.valueDataGridViewTextBoxColumn1.Width = 70;
			// 
			// AirCraftSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 478);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.CruiserLimitNumericUpDown);
			this.Controls.Add(this.CruiserLimitLabel);
			this.Controls.Add(this.OKButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AirCraftSettingForm";
			this.Text = "艦載機設定";
			this.Load += new System.EventHandler(this.AirCraftSettingForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.AirCraftSettingDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.airCraftSettingBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CruiserLimitNumericUpDown)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.AirCraftImprovementSettingDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.airCraftImprovementSettingBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView AirCraftSettingDataGridView;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.BindingSource airCraftSettingBindingSource;
		private System.Windows.Forms.Label CruiserLimitLabel;
		private System.Windows.Forms.NumericUpDown CruiserLimitNumericUpDown;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView AirCraftImprovementSettingDataGridView;
		private System.Windows.Forms.BindingSource airCraftImprovementSettingBindingSource;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.ComboBox AirCraftComboBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn improvementDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn1;
	}
}
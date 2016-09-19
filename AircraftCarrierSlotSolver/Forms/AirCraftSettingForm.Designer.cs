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
			this.OKButton = new System.Windows.Forms.Button();
			this.CruiserLimitLabel = new System.Windows.Forms.Label();
			this.CruiserLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.airCraftSettingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.AirCraftSettingDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CruiserLimitNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.airCraftSettingBindingSource)).BeginInit();
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
			this.AirCraftSettingDataGridView.Location = new System.Drawing.Point(12, 12);
			this.AirCraftSettingDataGridView.Name = "AirCraftSettingDataGridView";
			this.AirCraftSettingDataGridView.RowTemplate.Height = 21;
			this.AirCraftSettingDataGridView.Size = new System.Drawing.Size(276, 368);
			this.AirCraftSettingDataGridView.TabIndex = 0;
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(100, 428);
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
			this.CruiserLimitLabel.Location = new System.Drawing.Point(28, 400);
			this.CruiserLimitLabel.Name = "CruiserLimitLabel";
			this.CruiserLimitLabel.Size = new System.Drawing.Size(120, 12);
			this.CruiserLimitLabel.TabIndex = 2;
			this.CruiserLimitLabel.Text = "巡洋艦に積む水上機数";
			// 
			// CruiserLimitNumericUpDown
			// 
			this.CruiserLimitNumericUpDown.Location = new System.Drawing.Point(155, 397);
			this.CruiserLimitNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
			this.CruiserLimitNumericUpDown.Name = "CruiserLimitNumericUpDown";
			this.CruiserLimitNumericUpDown.Size = new System.Drawing.Size(62, 19);
			this.CruiserLimitNumericUpDown.TabIndex = 3;
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
			// AirCraftSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 478);
			this.Controls.Add(this.CruiserLimitNumericUpDown);
			this.Controls.Add(this.CruiserLimitLabel);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.AirCraftSettingDataGridView);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AirCraftSettingForm";
			this.Text = "AirCraftSettingForm";
			this.Load += new System.EventHandler(this.AirCraftSettingForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.AirCraftSettingDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CruiserLimitNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.airCraftSettingBindingSource)).EndInit();
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
	}
}
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
			this.ShipSlotInfoDataGridView = new System.Windows.Forms.DataGridView();
			this.AddButton = new System.Windows.Forms.Button();
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
			this.CalcButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ShipSlotInfoDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.shipSlotInfoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// ShipSlotInfoDataGridView
			// 
			this.ShipSlotInfoDataGridView.AllowUserToAddRows = false;
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
            this.slot4DataGridViewTextBoxColumn});
			this.ShipSlotInfoDataGridView.DataSource = this.shipSlotInfoBindingSource;
			this.ShipSlotInfoDataGridView.Location = new System.Drawing.Point(12, 31);
			this.ShipSlotInfoDataGridView.Name = "ShipSlotInfoDataGridView";
			this.ShipSlotInfoDataGridView.RowTemplate.Height = 21;
			this.ShipSlotInfoDataGridView.Size = new System.Drawing.Size(667, 180);
			this.ShipSlotInfoDataGridView.TabIndex = 0;
			this.ShipSlotInfoDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShipSlotInfoDataGridView_CellEndEdit);
			this.ShipSlotInfoDataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.ShipSlotInfoDataGridView_EditingControlShowing);
			// 
			// AddButton
			// 
			this.AddButton.Location = new System.Drawing.Point(12, 2);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = "追加";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// shipNameDataGridViewTextBoxColumn
			// 
			this.shipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName";
			this.shipNameDataGridViewTextBoxColumn.HeaderText = "ShipName";
			this.shipNameDataGridViewTextBoxColumn.Name = "shipNameDataGridViewTextBoxColumn";
			this.shipNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.shipNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// slot1NumDataGridViewTextBoxColumn
			// 
			this.slot1NumDataGridViewTextBoxColumn.DataPropertyName = "Slot1Num";
			this.slot1NumDataGridViewTextBoxColumn.HeaderText = "";
			this.slot1NumDataGridViewTextBoxColumn.Name = "slot1NumDataGridViewTextBoxColumn";
			this.slot1NumDataGridViewTextBoxColumn.Width = 30;
			// 
			// slot1DataGridViewTextBoxColumn
			// 
			this.slot1DataGridViewTextBoxColumn.DataPropertyName = "Slot1";
			this.slot1DataGridViewTextBoxColumn.HeaderText = "スロット1";
			this.slot1DataGridViewTextBoxColumn.Name = "slot1DataGridViewTextBoxColumn";
			// 
			// slot2NumDataGridViewTextBoxColumn
			// 
			this.slot2NumDataGridViewTextBoxColumn.DataPropertyName = "Slot2Num";
			this.slot2NumDataGridViewTextBoxColumn.HeaderText = "";
			this.slot2NumDataGridViewTextBoxColumn.Name = "slot2NumDataGridViewTextBoxColumn";
			this.slot2NumDataGridViewTextBoxColumn.Width = 30;
			// 
			// slot2DataGridViewTextBoxColumn
			// 
			this.slot2DataGridViewTextBoxColumn.DataPropertyName = "Slot2";
			this.slot2DataGridViewTextBoxColumn.HeaderText = "スロット2";
			this.slot2DataGridViewTextBoxColumn.Name = "slot2DataGridViewTextBoxColumn";
			// 
			// slot3NumDataGridViewTextBoxColumn
			// 
			this.slot3NumDataGridViewTextBoxColumn.DataPropertyName = "Slot3Num";
			this.slot3NumDataGridViewTextBoxColumn.HeaderText = "";
			this.slot3NumDataGridViewTextBoxColumn.Name = "slot3NumDataGridViewTextBoxColumn";
			this.slot3NumDataGridViewTextBoxColumn.Width = 30;
			// 
			// slot3DataGridViewTextBoxColumn
			// 
			this.slot3DataGridViewTextBoxColumn.DataPropertyName = "Slot3";
			this.slot3DataGridViewTextBoxColumn.HeaderText = "スロット3";
			this.slot3DataGridViewTextBoxColumn.Name = "slot3DataGridViewTextBoxColumn";
			// 
			// slot4NumDataGridViewTextBoxColumn
			// 
			this.slot4NumDataGridViewTextBoxColumn.DataPropertyName = "Slot4Num";
			this.slot4NumDataGridViewTextBoxColumn.HeaderText = "";
			this.slot4NumDataGridViewTextBoxColumn.Name = "slot4NumDataGridViewTextBoxColumn";
			this.slot4NumDataGridViewTextBoxColumn.Width = 30;
			// 
			// slot4DataGridViewTextBoxColumn
			// 
			this.slot4DataGridViewTextBoxColumn.DataPropertyName = "Slot4";
			this.slot4DataGridViewTextBoxColumn.HeaderText = "スロット4";
			this.slot4DataGridViewTextBoxColumn.Name = "slot4DataGridViewTextBoxColumn";
			// 
			// shipSlotInfoBindingSource
			// 
			this.shipSlotInfoBindingSource.DataSource = typeof(AircraftCarrierSlotSolver.ShipSlotInfo);
			// 
			// CalcButton
			// 
			this.CalcButton.Location = new System.Drawing.Point(93, 2);
			this.CalcButton.Name = "CalcButton";
			this.CalcButton.Size = new System.Drawing.Size(75, 23);
			this.CalcButton.TabIndex = 2;
			this.CalcButton.Text = "計算";
			this.CalcButton.UseVisualStyleBackColor = true;
			this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 261);
			this.Controls.Add(this.CalcButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.ShipSlotInfoDataGridView);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "空母スロットソルバー";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.ShipSlotInfoDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.shipSlotInfoBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView ShipSlotInfoDataGridView;
		private System.Windows.Forms.BindingSource shipSlotInfoBindingSource;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.DataGridViewComboBoxColumn shipNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot1NumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot2NumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot2DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot3NumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot3DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot4NumDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn slot4DataGridViewTextBoxColumn;
		private System.Windows.Forms.Button CalcButton;
	}
}


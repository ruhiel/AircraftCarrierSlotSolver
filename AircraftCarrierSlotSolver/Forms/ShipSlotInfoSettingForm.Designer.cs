namespace AircraftCarrierSlotSolver.Forms
{
	partial class ShipSlotInfoSettingForm
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
			this.AttackCheckBox = new System.Windows.Forms.CheckBox();
			this.SaiunCheckBox = new System.Windows.Forms.CheckBox();
			this.MaintenancePersonnelCheckBox = new System.Windows.Forms.CheckBox();
			this.MinimumCheckBox = new System.Windows.Forms.CheckBox();
			this.OKButton = new System.Windows.Forms.Button();
			this.FirstSlotCheckBox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// AttackCheckBox
			// 
			this.AttackCheckBox.AutoSize = true;
			this.AttackCheckBox.Location = new System.Drawing.Point(12, 12);
			this.AttackCheckBox.Name = "AttackCheckBox";
			this.AttackCheckBox.Size = new System.Drawing.Size(48, 16);
			this.AttackCheckBox.TabIndex = 0;
			this.AttackCheckBox.Text = "攻撃";
			this.AttackCheckBox.UseVisualStyleBackColor = true;
			this.AttackCheckBox.CheckedChanged += new System.EventHandler(this.AttackCheckBox_CheckedChanged);
			// 
			// SaiunCheckBox
			// 
			this.SaiunCheckBox.AutoSize = true;
			this.SaiunCheckBox.Location = new System.Drawing.Point(12, 34);
			this.SaiunCheckBox.Name = "SaiunCheckBox";
			this.SaiunCheckBox.Size = new System.Drawing.Size(48, 16);
			this.SaiunCheckBox.TabIndex = 0;
			this.SaiunCheckBox.Text = "彩雲";
			this.SaiunCheckBox.UseVisualStyleBackColor = true;
			this.SaiunCheckBox.CheckedChanged += new System.EventHandler(this.SaiunCheckBox_CheckedChanged);
			// 
			// MaintenancePersonnelCheckBox
			// 
			this.MaintenancePersonnelCheckBox.AutoSize = true;
			this.MaintenancePersonnelCheckBox.Location = new System.Drawing.Point(12, 56);
			this.MaintenancePersonnelCheckBox.Name = "MaintenancePersonnelCheckBox";
			this.MaintenancePersonnelCheckBox.Size = new System.Drawing.Size(84, 16);
			this.MaintenancePersonnelCheckBox.TabIndex = 0;
			this.MaintenancePersonnelCheckBox.Text = "熟練整備員";
			this.MaintenancePersonnelCheckBox.UseVisualStyleBackColor = true;
			this.MaintenancePersonnelCheckBox.CheckedChanged += new System.EventHandler(this.MaintenancePersonnelCheckBox_CheckedChanged);
			// 
			// MinimumCheckBox
			// 
			this.MinimumCheckBox.AutoSize = true;
			this.MinimumCheckBox.Location = new System.Drawing.Point(12, 78);
			this.MinimumCheckBox.Name = "MinimumCheckBox";
			this.MinimumCheckBox.Size = new System.Drawing.Size(176, 16);
			this.MinimumCheckBox.TabIndex = 0;
			this.MinimumCheckBox.Text = "最小スロットに攻撃機を積まない";
			this.MinimumCheckBox.UseVisualStyleBackColor = true;
			this.MinimumCheckBox.CheckedChanged += new System.EventHandler(this.MinimumCheckBox_CheckedChanged);
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(64, 130);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 1;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// FirstSlotCheckBox
			// 
			this.FirstSlotCheckBox.AutoSize = true;
			this.FirstSlotCheckBox.Location = new System.Drawing.Point(12, 100);
			this.FirstSlotCheckBox.Name = "FirstSlotCheckBox";
			this.FirstSlotCheckBox.Size = new System.Drawing.Size(157, 16);
			this.FirstSlotCheckBox.TabIndex = 2;
			this.FirstSlotCheckBox.Text = "第一スロットに攻撃機を積む";
			this.FirstSlotCheckBox.UseVisualStyleBackColor = true;
			this.FirstSlotCheckBox.CheckedChanged += new System.EventHandler(this.FirstSlotCheckBox_CheckedChanged);
			// 
			// ShipSlotInfoSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(197, 165);
			this.Controls.Add(this.FirstSlotCheckBox);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.MinimumCheckBox);
			this.Controls.Add(this.MaintenancePersonnelCheckBox);
			this.Controls.Add(this.SaiunCheckBox);
			this.Controls.Add(this.AttackCheckBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ShipSlotInfoSettingForm";
			this.Text = "艦娘設定";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox AttackCheckBox;
		private System.Windows.Forms.CheckBox SaiunCheckBox;
		private System.Windows.Forms.CheckBox MaintenancePersonnelCheckBox;
		private System.Windows.Forms.CheckBox MinimumCheckBox;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.CheckBox FirstSlotCheckBox;
	}
}
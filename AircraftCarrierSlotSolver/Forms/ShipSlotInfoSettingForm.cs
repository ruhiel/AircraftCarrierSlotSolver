using System;
using System.Windows.Forms;

namespace AircraftCarrierSlotSolver.Forms
{
	public partial class ShipSlotInfoSettingForm : Form
	{
		private ShipSlotInfo shipSlotInfo;

		public ShipSlotInfoSettingForm(ShipSlotInfo shipSlotInfo)
		{
			InitializeComponent();
			this.shipSlotInfo = shipSlotInfo;
			this.AttackCheckBox.Checked = shipSlotInfo.Attack;
			this.SaiunCheckBox.Checked = shipSlotInfo.Saiun;
			this.MaintenancePersonnelCheckBox.Checked = shipSlotInfo.MaintenancePersonnel;
			this.MinimumCheckBox.Checked = shipSlotInfo.MinimumSlot;
			this.FirstSlotCheckBox.Checked = shipSlotInfo.FirstSlotAttack;
			this.OnlyAttackerCheckBox.Checked = shipSlotInfo.OnlyAttacker;
		}

		private void AttackCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			shipSlotInfo.Attack = (sender as CheckBox).Checked;
		}

		private void SaiunCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			shipSlotInfo.Saiun = (sender as CheckBox).Checked;
		}

		private void MaintenancePersonnelCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			shipSlotInfo.MaintenancePersonnel = (sender as CheckBox).Checked;
		}

		private void MinimumCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			shipSlotInfo.MinimumSlot = (sender as CheckBox).Checked;
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FirstSlotCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			shipSlotInfo.FirstSlotAttack = (sender as CheckBox).Checked;
		}

		private void OnlyAttackerCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			shipSlotInfo.OnlyAttacker = (sender as CheckBox).Checked;
		}
	}
}

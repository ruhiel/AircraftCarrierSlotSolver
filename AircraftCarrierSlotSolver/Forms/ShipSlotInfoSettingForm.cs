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
	}
}

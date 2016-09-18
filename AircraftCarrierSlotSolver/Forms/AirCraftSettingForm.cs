using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AircraftCarrierSlotSolver.Forms
{
	public partial class AirCraftSettingForm : Form
	{
		public AirCraftSettingForm()
		{
			InitializeComponent();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			var list = new List<AirCraftSetting>();

			foreach(DataGridViewRow row in AirCraftSettingDataGridView.Rows)
			{
				var item = row.DataBoundItem as AirCraftSetting;
				list.Add(item);
			}

			Settings.LoadFromXmlFile();

			Settings.Instance.Seigen = list.ToDictionary(x => x.Name, x => x.Value).ConvertDictionaryToList();

			Settings.SaveToXmlFile();

			Close();
		}

		private void AirCraftSettingForm_Load(object sender, EventArgs e)
		{
			Settings.LoadFromXmlFile();
			foreach (var record in Settings.Instance.Seigen)
			{
				this.airCraftSettingBindingSource.Add(new AirCraftSetting()
				{
					Name = record.Key,
					Value = record.Value
				});
			}
		}
	}
}

using AircraftCarrierSlotSolver;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

			foreach (DataGridViewRow row in AirCraftSettingDataGridView.Rows)
			{
				var item = row.DataBoundItem as AirCraftSetting;
				list.Add(item);
			}

			var list2 = new List<AirCraftImprovementSetting>();

			foreach (DataGridViewRow row in AirCraftImprovementSettingDataGridView.Rows)
			{
				var item = row.DataBoundItem as AirCraftImprovementSetting;
				list2.Add(item);
			}

			Settings.LoadFromXmlFile();

			Settings.Instance.AirCraftLimit = list.ToDictionary(x => x.Name, x => x.Value).ToList();
			Settings.Instance.CruiserSlotNum = (int)CruiserLimitNumericUpDown.Value;
			Settings.Instance.AirCraftImprovementLimit = list2.Select(x => new { Name = x.Name, Value = new KeyValuePair<int, int>(x.Improvement, x.Value) })
																.ToDictionary(y => y.Name, y => new KeyAndValue<int, int>(y.Value))
																.ToList();

			Settings.SaveToXmlFile();

			Close();
		}

		private void AirCraftSettingForm_Load(object sender, EventArgs e)
		{
			using (var parser = new CsvParser(new StreamReader("air.csv", new UTF8Encoding(false))))
			{
				parser.Configuration.HasHeaderRecord = true;
				parser.Configuration.RegisterClassMap<AirCraftMap>();

				using (var reader = new CsvReader(parser))
				{
					AirCraftComboBox.DataSource = reader.GetRecords<AirCraft>().Select(x => x.Name).ToList();
				}
			}

			Settings.LoadFromXmlFile();
			foreach (var record in Settings.Instance.AirCraftLimit)
			{
				this.airCraftSettingBindingSource.Add(new AirCraftSetting()
				{
					Name = record.Key,
					Value = record.Value
				});
			}

			CruiserLimitNumericUpDown.Value = Settings.Instance.CruiserSlotNum;

			foreach (var record in Settings.Instance.AirCraftImprovementLimit)
			{
				this.airCraftImprovementSettingBindingSource.Add(new AirCraftImprovementSetting(record.Key, record.Value.Key, record.Value.Value));
			}
				
		}

		private void AirCraftImprovementSettingDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;

			//新しい行のセルでなく、セルの内容が変更されている時だけ検証する
			if (e.RowIndex == dgv.NewRowIndex || !dgv.IsCurrentCellDirty)
			{
				return;
			}

			if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
			{
				int result;
				if (!int.TryParse(e.FormattedValue.ToString(), out result))
				{
					//行にエラーテキストを設定
					dgv.Rows[e.RowIndex].ErrorText = "数値が入力されていません。";
					//入力した値をキャンセル
					dgv.CancelEdit();
					//キャンセルする
					e.Cancel = true;
				}
				else
				{
					dgv.Rows[e.RowIndex].ErrorText = string.Empty;
				}
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			this.airCraftImprovementSettingBindingSource.Add(
				new AirCraftImprovementSetting(AirCraftComboBox.SelectedValue.ToString(), 1, 1)
			);
		}
	}
}

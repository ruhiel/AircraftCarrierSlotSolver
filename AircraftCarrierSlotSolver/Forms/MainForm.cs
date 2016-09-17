using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AircraftCarrierSlotSolver
{
	public partial class MainForm : Form
	{
		private List<AirCraft> _AirCraftList;
		private List<ShipInfo> _ShipInfoList;
		private DataGridViewComboBoxEditingControl dataGridViewComboBox = null;

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			var column = ShipSlotInfoDataGridView.Columns[0] as DataGridViewComboBoxColumn;

			using (var parser = new CsvParser(new StreamReader("air.csv", new UTF8Encoding(false))))
			{
				parser.Configuration.HasHeaderRecord = true;
				parser.Configuration.RegisterClassMap<AirCraftMap>();

				using (var reader = new CsvReader(parser))
				{
					_AirCraftList = reader.GetRecords<AirCraft>().ToList();
				}
			}

			using (var parser = new CsvParser(new StreamReader("slots.csv", new UTF8Encoding(false))))
			{
				parser.Configuration.HasHeaderRecord = true;
				parser.Configuration.RegisterClassMap<ShipInfoMap>();

				using (var reader = new CsvReader(parser))
				{
					_ShipInfoList = reader.GetRecords<ShipInfo>().ToList();
				}
			}

			column.DataSource = _ShipInfoList.Select(x => x.Name).ToList();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			this.shipSlotInfoBindingSource.Add(CreateShipSlotInfo("加賀改"));
		}

		private void ShipSlotInfoDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			//表示されているコントロールがDataGridViewComboBoxEditingControlか調べる
			if (e.Control is DataGridViewComboBoxEditingControl)
			{
				var dgv = sender as DataGridView;

				//該当する列か調べる
				if (dgv.CurrentCell.OwningColumn.DataPropertyName == "ShipName")
				{
					//編集のために表示されているコントロールを取得
					this.dataGridViewComboBox = e.Control as DataGridViewComboBoxEditingControl;
					//SelectedIndexChangedイベントハンドラを追加
					this.dataGridViewComboBox.SelectedIndexChanged += new EventHandler(dataGridViewComboBox_SelectedIndexChanged);
				}
			}
		}
		private void ShipSlotInfoDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			//SelectedIndexChangedイベントハンドラを削除
			if (this.dataGridViewComboBox != null)
			{
				this.dataGridViewComboBox.SelectedIndexChanged -= new EventHandler(dataGridViewComboBox_SelectedIndexChanged);
				this.dataGridViewComboBox = null;
			}
		}


		//DataGridViewに表示されているコンボボックスの
		//SelectedIndexChangedイベントハンドラ
		private void dataGridViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//選択されたアイテムを表示
			var rowIndex = ShipSlotInfoDataGridView.CurrentCell.RowIndex;
			var cb = sender as DataGridViewComboBoxEditingControl;
			var item = ShipSlotInfoDataGridView.Rows[rowIndex].DataBoundItem as ShipSlotInfo;
			var ship = _ShipInfoList.Where(x => x.Name == cb.SelectedItem?.ToString()).FirstOrDefault();
			if(ship == null)
			{
				return;
			}

			item.Slot1Num = ship.Slot1Num;
			item.Slot2Num = ship.Slot2Num;
			item.Slot3Num = ship.Slot3Num;
			item.Slot4Num = ship.Slot4Num;
			ShipSlotInfoDataGridView.InvalidateRow(rowIndex);
		}
		private ShipSlotInfo CreateShipSlotInfo(string name)
		{
			var ship = _ShipInfoList.Where(x => x.Name == name).First();
			return new ShipSlotInfo()
			{
				ShipName = ship.Name,
				Slot1Num = ship.Slot1Num,
				Slot2Num = ship.Slot2Num,
				Slot3Num = ship.Slot3Num,
				Slot4Num = ship.Slot4Num
			};
		}

		private void CalcButton_Click(object sender, EventArgs e)
		{
			using (StreamWriter writer = new StreamWriter(@"slot.lp", false, new UTF8Encoding(false)))
			{
				var shipSlotList = new List<ShipSlotInfo>();
				foreach (DataGridViewRow row in ShipSlotInfoDataGridView.Rows)
				{
					var item = row.DataBoundItem as ShipSlotInfo;
					shipSlotList.Add(item);
				}

				OutputTarget(writer, shipSlotList);

				OutputAirCondition(writer, shipSlotList);

				OutputSlotCondition(writer, shipSlotList);

				var dictionary = new Dictionary<string, int>()
				{
					{"震電改", 0},
					{"烈風改", 3},
					{"烈風(601)", 3}
				};

				OutputStockCondition(writer, shipSlotList, dictionary);

				OutputBinary(writer, shipSlotList);

				writer.WriteLine("end");
			}
		}

		private void OutputStockCondition(StreamWriter writer, List<ShipSlotInfo> shipSlotList, Dictionary<string, int> condition)
		{
			foreach(var dic in condition)
			{
				foreach (var record in GetIEnumerable(shipSlotList).Where(x => x.AirCraft.Item1.Name == dic.Key))
				{
					writer.WriteLine("+ " + record.SlotName);
				}
				writer.WriteLine("<= " + dic.Value);
				writer.WriteLine();
			}

		}

		private void OutputBinary(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			writer.WriteLine("binary");
			foreach (var record in GetIEnumerable(shipSlotList))
			{
				writer.WriteLine(record.SlotName + @" \ " + record.Ship.Item1.Name + " " + record.Slot.Item1 + " " + record.AirCraft.Item1.Name);
			}
			writer.WriteLine();

		}

		private void OutputTarget(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			writer.WriteLine("maximize");

			foreach(var record in GetIEnumerable(shipSlotList))
			{
				if(record.AirCraft.Item1.Type == "艦爆" || record.AirCraft.Item1.Type == "艦攻")
				{
					var text = "+ " + record.Power + " " + record.SlotName + @" \ " + record.Ship.Item1.Name + " " + record.Slot.Item1 + " " + record.AirCraft.Item1.Name;
					writer.WriteLine(text);
				}
			}

			writer.WriteLine();
		}

		private void OutputAirCondition(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			writer.WriteLine("subject to");

			foreach (var record in GetIEnumerable(shipSlotList))
			{
				var text = "+ " + record.AirSuperiorityPotential + " " + record.SlotName + @" \ " + record.Ship.Item1.Name + " " + record.Slot.Item1 + " " + record.AirCraft.Item1.Name;
				writer.WriteLine(text);
			}
			writer.WriteLine(">= 350");
			writer.WriteLine();
		}

		private void OutputSlotCondition(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			foreach(var group in GetIEnumerable(shipSlotList).GroupBy(x => new {Ship = x.Ship.Item2, Slot = x.Slot.Item2}))
			{
				foreach(var g in group)
				{
					var text = "+ " + g.SlotName;
					writer.WriteLine(text);
				}
				writer.WriteLine("= 1");
				writer.WriteLine();
			}
		}

		private IEnumerable<GeneratorInfo> GetIEnumerable(List<ShipSlotInfo> shipSlotList)
		{
			foreach (var ship in _ShipInfoList
				.Select((item, index) => Tuple.Create(item, index))
				.Where(x => shipSlotList.Select(y => y.ShipName).Contains(x.Item1.Name)))
			{
				foreach (var slot in ship.Item1.Slots.Select((item, index) => Tuple.Create(item, index)))
				{
					foreach (var aircraft in _AirCraftList.Select((item , index) => Tuple.Create(item,index)))
					{
						yield return new GeneratorInfo() { Ship = ship, Slot = slot, AirCraft = aircraft };
					}
				}
			}
		}
	}
}

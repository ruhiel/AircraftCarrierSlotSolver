using AircraftCarrierSlotSolver.Forms;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AircraftCarrierSlotSolver
{
	public partial class MainForm : Form
	{
		private List<AirCraft> _AirCraftList;
		private List<ShipInfo> _ShipInfoList;
		private List<Area> _AreaList;
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

			using (var parser = new CsvParser(new StreamReader("area.csv", new UTF8Encoding(false))))
			{
				parser.Configuration.HasHeaderRecord = true;
				parser.Configuration.RegisterClassMap<AreaMap>();

				using (var reader = new CsvReader(parser))
				{
					_AreaList = reader.GetRecords<Area>().ToList();
				}
			}

			column.DataSource = _ShipInfoList.Select(x => x.Name).ToList();
			ShipSelectComboBox.DataSource = _ShipInfoList.Select(x => x.Name).ToList();

			AreaComboBox.DataSource = _AreaList.Select(x => x.Name).ToList();

			if (!File.Exists(Properties.Resources.SettingFileName))
			{
				Settings.Instance.AirCraftLimit = _AirCraftList.ToDictionary(x => x.AirCraftName, _ => 0).ToList();
				Settings.Instance.AirCraftImprovementLimit = new List<KeyAndValue<string, KeyAndValue<int, int>>>();
				Settings.Instance.CruiserSlotNum = 1;
				Settings.Instance.HistoryShips = new List<string>();
				Settings.Instance.HistoryAirSuperiority = 0;
				Settings.SaveToXmlFile();
			}

			Settings.LoadFromXmlFile();

			foreach (var newItem in Settings.Instance.HistoryShips)
			{
				var shipSlot = CreateShipSlotInfo(newItem);
				if(shipSlot != null)
				{
					shipSlotInfoBindingSource.Add(shipSlot);
				}
			}

			AirSuperiorityNumericUpDown.Value = Settings.Instance.HistoryAirSuperiority;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			var newItem = ShipSelectComboBox.SelectedValue.ToString();
			var ship = Regex.Replace(newItem, "改.*", string.Empty);
			if (!GetRowItemList().Select(x => x.ShipName).Any(y => y.Contains(ship)))
			{
				var shipSlot = CreateShipSlotInfo(newItem);
				if (shipSlot != null)
				{
					shipSlotInfoBindingSource.Add(shipSlot);
				}
			}
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
			if (ship == null)
			{
				return;
			}

			item.Slot1Num = ship.Slot1Num;
			item.Slot1 = string.Empty;
			item.Slot2Num = ship.Slot2Num;
			item.Slot2 = string.Empty;
			item.Slot3Num = ship.Slot3Num;
			item.Slot3 = string.Empty;
			item.Slot4Num = ship.Slot4Num;
			item.Slot4 = string.Empty;
			foreach (DataGridViewCell cell in ShipSlotInfoDataGridView.Rows[rowIndex].Cells)
			{
				cell.Style.BackColor = Color.White;
			}

			ShipSlotInfoDataGridView.InvalidateRow(rowIndex);
		}

		private ShipSlotInfo CreateShipSlotInfo(string name)
		{
			var ship = _ShipInfoList.Where(x => x.Name == name).FirstOrDefault();

			return ship == null ? null : new ShipSlotInfo()
			{
				ShipName = ship.Name,
				Slot1Num = ship.Slot1Num,
				Slot2Num = ship.Slot2Num,
				Slot3Num = ship.Slot3Num,
				Slot4Num = ship.Slot4Num,
				Attack = false,
				Saiun = false,
				MaintenancePersonnel = false,
				MinimumSlot = false,
				FirstSlotAttack = false,
				OnlyAttacker = false
			};
		}

		private List<ShipSlotInfo> GetShipSlotInfoList()
		{
			var shipSlotList = new List<ShipSlotInfo>();

			for (int i = 0; i < ShipSlotInfoDataGridView.Rows.Count; i++)
			{
				var item = ShipSlotInfoDataGridView.Rows[i].DataBoundItem as ShipSlotInfo;
				item.Slot1 = item.Slot2 = item.Slot3 = item.Slot4 = string.Empty;
				foreach (DataGridViewCell cell in ShipSlotInfoDataGridView.Rows[i].Cells)
				{
					cell.Style.BackColor = Color.White;
				}

				ShipSlotInfoDataGridView.InvalidateRow(i);
				shipSlotList.Add(item);
			}

			return shipSlotList;
		}

		private void GenerateLPFile(List<ShipSlotInfo> shipSlotList)
		{
			using (StreamWriter writer = new StreamWriter(@"slot.lp", false, new UTF8Encoding(false)))
			{
				OutputTarget(writer, shipSlotList);

				OutputAirCondition(writer, shipSlotList);

				OutputSlotCondition(writer, shipSlotList);

				OutputStockCondition(writer, shipSlotList);

				OutputShipTypeCondition(writer, shipSlotList);

				OutputModeCondition(writer, shipSlotList);

				OutputBinary(writer, shipSlotList);

				writer.WriteLine("end");
			}
		}

		private void GenerateSolveFile(string dir)
		{
			using (StreamWriter writer = new StreamWriter(Path.Combine(dir, "solve.txt"), false, new UTF8Encoding(false)))
			{
				writer.WriteLine("read slot.lp");
				writer.WriteLine("optimize");
				writer.WriteLine("display solution");
				writer.WriteLine("quit");
			}
		}

		private List<string> CalcProcess(string dir)
		{
			var slotStringList = new List<string>();

			var logFile = Path.Combine(dir, "result.log");

			if (File.Exists(logFile))
			{
				File.Delete(logFile);
			}
			Settings.LoadFromXmlFile();

			var psi = new ProcessStartInfo();

			psi.FileName = Settings.Instance.SolverPath;
			psi.Arguments = "-b solve.txt" + " -l result.log";
			psi.WorkingDirectory = dir;

			var process = Process.Start(psi);

			process.WaitForExit();

			var log = Path.Combine(dir, "result.log");
			var regex = new Regex(@"(?<slot>slot_\d+_\d_\d+).+");
			using (StreamReader r = new StreamReader(log))
			{
				string line;
				while ((line = r.ReadLine()) != null)
				{
					var matches = regex.Matches(line);
					if (matches.Count > 0)
					{
						slotStringList.Add(matches[0].Groups["slot"].Value);
					}
				}
			}

			return slotStringList;
		}

		private void CalcResultViewProcess(List<string> slotStringList, List<ShipSlotInfo> shipSlotList)
		{
			foreach (var generatorInfo in slotStringList.Select(x => GetIEnumerable(shipSlotList).First(y => y.SlotName == x)))
			{
				var rowItem = GetRowItem(generatorInfo.Ship.Item1.Name);
				if (generatorInfo.Slot.Item2 == 0)
				{
					rowItem.Item1.Slot1 = generatorInfo.AirCraft.Item1.AirCraftName;

					ShipSlotInfoDataGridView.Rows[rowItem.Item2].Cells["slot1DataGridViewTextBoxColumn"].Style.BackColor = GetBackColor(generatorInfo.AirCraft.Item1);
				}
				else if (generatorInfo.Slot.Item2 == 1)
				{
					rowItem.Item1.Slot2 = generatorInfo.AirCraft.Item1.AirCraftName;

					ShipSlotInfoDataGridView.Rows[rowItem.Item2].Cells["slot2DataGridViewTextBoxColumn"].Style.BackColor = GetBackColor(generatorInfo.AirCraft.Item1);

				}
				else if (generatorInfo.Slot.Item2 == 2)
				{
					rowItem.Item1.Slot3 = generatorInfo.AirCraft.Item1.AirCraftName;

					ShipSlotInfoDataGridView.Rows[rowItem.Item2].Cells["slot3DataGridViewTextBoxColumn"].Style.BackColor = GetBackColor(generatorInfo.AirCraft.Item1);

				}
				else if (generatorInfo.Slot.Item2 == 3)
				{
					rowItem.Item1.Slot4 = generatorInfo.AirCraft.Item1.AirCraftName;

					ShipSlotInfoDataGridView.Rows[rowItem.Item2].Cells["slot4DataGridViewTextBoxColumn"].Style.BackColor = GetBackColor(generatorInfo.AirCraft.Item1);
				}

				ShipSlotInfoDataGridView.InvalidateRow(rowItem.Item2);
			}
		}

		private void SaveShipList()
		{
			Settings.LoadFromXmlFile();

			Settings.Instance.HistoryShips = GetRowItemList().Select(x => x.ShipName).ToList();

			Settings.Instance.HistoryAirSuperiority = (int)AirSuperiorityNumericUpDown.Value;

			Settings.SaveToXmlFile();
		}

		private void Calc()
		{
			try
			{
				var shipSlotList = GetShipSlotInfoList();

				GenerateLPFile(shipSlotList);

				var dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

				GenerateSolveFile(dir);

				var slotStringList = CalcProcess(dir);

				if (!slotStringList.Any())
				{
					MessageBox.Show("制空値を満たす解がありませんでした。");
					return;
				}

				CalcResultViewProcess(slotStringList, shipSlotList);

				SaveShipList();
			}
			catch (Exception ex)
			{
				MessageBox.Show("SCIPソルバーの実行に失敗しました。:" + ex.Message);

				return;
			}
		}

		private void CalcButton_Click(object sender, EventArgs e) => Calc();

		private Color GetBackColor(AirCraft aircraft)
		{
			switch (aircraft.Type)
			{
				case "艦戦":
				case "水戦":
				case "水爆":
					return Color.LightGreen;
				case "艦攻":
					return Color.LightBlue;
				case "艦爆":
					return Color.LightCyan;
				default:
					return Color.White;
			}
		}

		private void OutputShipTypeCondition(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			if (GetIEnumerable(shipSlotList).Any(x => x.Ship.Item1.Type == "巡洋艦"))
			{
				Settings.LoadFromXmlFile();

				// 水上機制限数
				foreach (var noEquipShipList in GetIEnumerable(shipSlotList)
					.Where(x => x.Ship.Item1.Type == "巡洋艦" && x.AirCraft.Item1.AirCraftName != "装備なし")
					.GroupBy(y => y.Ship.Item2))
				{
					foreach (var noEquipList in noEquipShipList)
					{
						writer.WriteLine("+ " + noEquipList.SlotName);
					}

					writer.WriteLine("<= " + Settings.Instance.CruiserSlotNum);
					writer.WriteLine();
				}
			}

		}

		private Tuple<ShipSlotInfo, int> GetRowItem(string shipName)
		{
			for (int i = 0; i < ShipSlotInfoDataGridView.Rows.Count; i++)
			{
				var item = ShipSlotInfoDataGridView.Rows[i].DataBoundItem as ShipSlotInfo;
				if (item.ShipName == shipName)
				{
					return Tuple.Create(item, i);
				}
			}

			throw new Exception("艦名が見つかりません");
		}

		private List<ShipSlotInfo> GetRowItemList()
		{
			var list = new List<ShipSlotInfo>();

			foreach (DataGridViewRow row in ShipSlotInfoDataGridView.Rows)
			{
				list.Add(row.DataBoundItem as ShipSlotInfo);
			}

			return list;
		}

		private void OutputStockCondition(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			Settings.LoadFromXmlFile();

			foreach (var dic in Settings.Instance.AirCraftLimit.ToDictionary())
			{
				var list = GetIEnumerable(shipSlotList).Where(x => x.AirCraft.Item1.AirCraftName == dic.Key);
				if (list.Any())
				{
					foreach (var record in list)
					{
						writer.WriteLine("+ " + record.SlotName);
					}
					writer.WriteLine("<= " + dic.Value);
					writer.WriteLine();
				}
			}

			foreach (var dic in Settings.Instance.AirCraftImprovementLimit)
			{
				var airCraft = new AirCraft(_AirCraftList.Find(x => x.Name == dic.Key));
				airCraft.Improvement = dic.Value.Key;

				var list = GetIEnumerable(shipSlotList).Where(x => x.AirCraft.Item1.AirCraftName == airCraft.AirCraftName);
				if (list.Any())
				{
					foreach (var record in list)
					{
						writer.WriteLine("+ " + record.SlotName);
					}
					writer.WriteLine("<= " + dic.Value.Value);
					writer.WriteLine();
				}
			}
		}

		private void OutputBinary(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			writer.WriteLine("binary");
			foreach (var record in GetIEnumerable(shipSlotList))
			{
				writer.WriteLine(record.SlotName + @" \ " + record.Ship.Item1.Name + " " + record.Slot.Item1 + " " + record.AirCraft.Item1.AirCraftName);
			}
			writer.WriteLine();

		}

		private void OutputTarget(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			writer.WriteLine("maximize");

			foreach (var record in GetIEnumerable(shipSlotList))
			{
				var text = "+ " + record.Power + " " + record.SlotName + @" \ " + record.Ship.Item1.Name + " " + record.Slot.Item1 + " " + record.AirCraft.Item1.AirCraftName + " 火力";
				writer.WriteLine(text);
				text = "+ " + record.AirCraft.Item1.Accuracy + " " + record.SlotName + @" \ " + record.Ship.Item1.Name + " " + record.Slot.Item1 + " " + record.AirCraft.Item1.AirCraftName + " 命中";
				writer.WriteLine(text);
				text = "+ " + record.AirCraft.Item1.Evasion + " " + record.SlotName + @" \ " + record.Ship.Item1.Name + " " + record.Slot.Item1 + " " + record.AirCraft.Item1.AirCraftName + " 回避";
				writer.WriteLine(text);
			}

			writer.WriteLine();
		}

		private void OutputAirCondition(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			writer.WriteLine("subject to");

			foreach (var record in GetIEnumerable(shipSlotList))
			{
				var text = "+ " + record.AirSuperiorityPotential + " " + record.SlotName + @" \ " + record.Ship.Item1.Name + " " + record.Slot.Item1 + " " + record.AirCraft.Item1.AirCraftName;
				writer.WriteLine(text);
			}
			writer.WriteLine(">= " + AirSuperiorityNumericUpDown.Value);
			writer.WriteLine();
		}

		private void OutputSlotCondition(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			foreach (var group in GetIEnumerable(shipSlotList).GroupBy(x => new { Ship = x.Ship.Item2, Slot = x.Slot.Item2 }))
			{
				foreach (var g in group)
				{
					var text = "+ " + g.SlotName;
					writer.WriteLine(text);
				}
				writer.WriteLine("= 1");
				writer.WriteLine();
			}
		}

		private void OutputModeCondition(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			var infoList = GetIEnumerable(shipSlotList);
			foreach (var info in shipSlotList.Where(x => x.Attack))
			{
				var list = infoList.Where(x => x.Ship.Item1.Name == info.ShipName && x.AirCraft.Item1.Attackable);
				if (list.Any())
				{
					foreach (var i in list)
					{
						var text = "+ " + i.SlotName + @" \ 攻撃機";
						writer.WriteLine(text);
					}
					writer.WriteLine(">= 1");
					writer.WriteLine();
				}
			}

			foreach (var info in shipSlotList.Where(x => x.FirstSlotAttack))
			{
				var list = infoList.Where(x => x.Ship.Item1.Name == info.ShipName && 
					x.Slot.Item2 == 0 &&
					x.AirCraft.Item1.Attackable);

				if (list.Any())
				{
					foreach (var i in list)
					{
						var text = "+ " + i.SlotName + @" \ 1スロ目攻撃機";
						writer.WriteLine(text);
					}
					writer.WriteLine(">= 1");
					writer.WriteLine();
				}
			}

			foreach (var info in shipSlotList.Where(x => x.OnlyAttacker))
			{
				var list = infoList.Where(x => x.Ship.Item1.Name == info.ShipName && x.AirCraft.Item1.Type == "艦戦");
				foreach (var i in list)
				{
					var text = "+ " + i.SlotName + @" \ 攻撃機のみ";
					writer.WriteLine(text);
				}
				writer.WriteLine("= 0");
				writer.WriteLine();
			}

			OutputEquipCondition(writer, shipSlotList);
		}

		private void OutputEquipCondition(StreamWriter writer, List<ShipSlotInfo> shipSlotList)
		{
			var infoList = GetIEnumerable(shipSlotList);
			foreach (var info in shipSlotList.Where(x => x.Saiun))
			{
				var min = info.MinSlotNum;

				var saiun = infoList.Where(x => x.Slot.Item1 == min && x.AirCraft.Item1.AirCraftName == "彩雲").First();
				writer.WriteLine("+ " + saiun.SlotName + @" = 1 \ " + "彩雲");
				writer.WriteLine();
			}

			foreach (var info in shipSlotList.Where(x => x.MaintenancePersonnel))
			{
				var min = info.MinSlotNum;

				var saiun = infoList.Where(x => x.Slot.Item1 == min && x.AirCraft.Item1.AirCraftName == "熟練整備員").First();
				writer.WriteLine("+ " + saiun.SlotName + @" = 1 \ " + "熟練整備員");
				writer.WriteLine();
			}

			foreach (var info in shipSlotList.Where(x => x.MinimumSlot))
			{
				var min = info.MinSlotNum;
				var list = infoList.Where(x => x.Slot.Item1 == min && (x.AirCraft.Item1.Type == "艦攻" || x.AirCraft.Item1.Type == "艦爆"));
				if (list.Any())
				{
					foreach (var i in list)
					{
						writer.WriteLine("+ " + i.SlotName + @" \ " + "最小スロット攻撃機");
					}
					writer.WriteLine("= 0");
					writer.WriteLine();
				}
			}
		}

		private IEnumerable<GeneratorInfo> GetIEnumerable(List<ShipSlotInfo> shipSlotList)
		{
			var noEquip = new List<AirCraft>()
			{
				// 所持数制限を受けないダミー装備
				new AirCraft("装備なし", "その他")
			};

			Settings.LoadFromXmlFile();

			foreach (var ship in _ShipInfoList
				.Select((item, index) => Tuple.Create(item, index))
				.Where(x => shipSlotList.Select(y => y.ShipName).Contains(x.Item1.Name)))
			{
				foreach (var slot in ship.Item1.Slots.Select((item, index) => Tuple.Create(item, index)))
				{
					foreach (var aircraft in GetAircraft(ship.Item1).Concat(noEquip).Select((item, index) => Tuple.Create(item, index)))
					{
						if (ship.Item1.SlotNum > slot.Item2)
						{
							yield return new GeneratorInfo() { Ship = ship, Slot = slot, AirCraft = aircraft };
						}
						else if (aircraft.Item1.AirCraftName == "装備なし")
						{
							yield return new GeneratorInfo() { Ship = ship, Slot = slot, AirCraft = aircraft };
						}
					}
				}
			}
		}

		private IEnumerable<AirCraft> GetAircraft(ShipInfo ship)
		{
			Func<AirCraft, bool> predicate = null;
			switch (ship.Type)
			{
				case "揚陸":
					predicate = (x) => x.Type == "艦戦" || x.Type == "その他";
					break;
				case "補給":
					predicate = (x) => x.Type == "艦攻" || x.Type == "その他";
					break;
				case "巡洋艦":
				case "潜母":
					predicate = (x) => x.Type == "水爆" || x.Type == "水戦" || x.Type == "その他";
					break;
				default:
					predicate = (x) => x.Type == "艦攻" || x.Type == "艦爆" || x.Type == "艦戦" || x.Type == "その他";
					break;
			}

			Settings.LoadFromXmlFile();

			return _AirCraftList.Where(x => Settings.Instance.AirCraftLimit.ToDictionary()[x.Name] != 0)
				.Concat(Settings.Instance.AirCraftImprovementLimit.Select(x =>
					{
						var airCraft = new AirCraft(_AirCraftList.Find(y => y.Name == x.Key));
						airCraft.Improvement = x.Value.Key;
						return airCraft;
					}
			)).Where(predicate);
		}

		private void airCraftSettingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new AirCraftSettingForm();
			form.ShowDialog();
		}

		private void solverSettingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var ofd = new OpenFileDialog())
			{
				//[ファイルの種類]に表示される選択肢を指定する
				//指定しないとすべてのファイルが表示される
				ofd.Filter = "実行ファイル|*.exe";
				//[ファイルの種類]ではじめに選択されるものを指定する
				//2番目の「すべてのファイル」が選択されているようにする
				ofd.FilterIndex = 1;
				//タイトルを設定する
				ofd.Title = "開くファイルを選択してください";
				//ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
				ofd.RestoreDirectory = true;
				//存在しないファイルの名前が指定されたとき警告を表示する
				//デフォルトでTrueなので指定する必要はない
				ofd.CheckFileExists = true;
				//存在しないパスが指定されたとき警告を表示する
				//デフォルトでTrueなので指定する必要はない
				ofd.CheckPathExists = true;

				// ダイアログを表示し、戻り値が [OK] の場合は、選択したファイルを表示する
				if (ofd.ShowDialog() == DialogResult.OK)
				{
					Settings.LoadFromXmlFile();

					Settings.Instance.SolverPath = ofd.FileName;

					Settings.SaveToXmlFile();
				}
			}
		}

		private void ShipSlotInfoDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) => ButtonEnableChange();

		private void ShipSlotInfoDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => ButtonEnableChange();

		private void ButtonEnableChange()
		{
			CalcButton.Enabled = ShipSlotInfoDataGridView.RowCount != 0;

			AddButton.Enabled = ShipSlotInfoDataGridView.RowCount < 6;
		}

		private void ShipSlotInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			//"Button"列ならば、ボタンがクリックされた
			if (dgv.Columns[e.ColumnIndex].Name == "SettingButton")
			{
				DataGridViewRow row = ShipSlotInfoDataGridView.Rows[e.RowIndex];

				var form = new ShipSlotInfoSettingForm(row.DataBoundItem as ShipSlotInfo);
				form.ShowDialog();
				Calc();
			}
		}

		private void SuperiorityButton_Click(object sender, EventArgs e)
		{
			AirSuperiorityNumericUpDown.Value = MerginNumericUpDown.Value + (decimal)(1.5 * _AreaList.Single(x => x.Name == AreaComboBox.SelectedValue.ToString()).AirSuperiorityPotential);
		}

		private void SecureButton_Click(object sender, EventArgs e)
		{
			AirSuperiorityNumericUpDown.Value = MerginNumericUpDown.Value + 3 * _AreaList.Single(x => x.Name == AreaComboBox.SelectedValue.ToString()).AirSuperiorityPotential;
		}
	}
}

using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AircraftCarrierSlotSolver
{
	[Serializable()]
	public class Settings
	{
		/// <summary>
		/// 装備制限
		/// </summary>
		public List<KeyAndValue<string, int>> AirCraftLimit
		{
			get; set;
		}

		/// <summary>
		/// ソルバーファイルパス
		/// </summary>
		public string SolverPath
		{
			get; set;
		}

		/// <summary>
		/// 巡洋艦に積む水上機の制限数
		/// </summary>
		public int CruiserSlotNum
		{
			get; set;
		}

		//Settingsクラスのただ一つのインスタンス
		[NonSerialized()]
		private static Settings _instance;
		[System.Xml.Serialization.XmlIgnore]
		public static Settings Instance
		{
			get
			{
				if (_instance == null)
					_instance = new Settings();
				return _instance;
			}
			set { _instance = value; }
		}

		/// <summary>
		/// 設定をXMLファイルから読み込み復元する
		/// </summary>
		public static void LoadFromXmlFile()
		{
			try
			{
				StreamReader sr = new StreamReader(Properties.Resources.SettingFileName, new UTF8Encoding(false));
				System.Xml.Serialization.XmlSerializer xs =
					new System.Xml.Serialization.XmlSerializer(typeof(Settings));
				//読み込んで逆シリアル化する
				object obj = xs.Deserialize(sr);
				sr.Close();

				Instance = (Settings)obj;
			}
			catch (Exception)
			{
			}
		}

		/// <summary>
		/// 現在の設定をXMLファイルに保存する
		/// </summary>
		public static void SaveToXmlFile()
		{
			try
			{
				StreamWriter sw = new StreamWriter(Properties.Resources.SettingFileName, false, new UTF8Encoding(false));
				System.Xml.Serialization.XmlSerializer xs =
					new System.Xml.Serialization.XmlSerializer(typeof(Settings));
				//シリアル化して書き込む
				xs.Serialize(sw, Instance);
				sw.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("設定の保存に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
namespace AircraftCarrierSlotSolver
{
	public class AirCraft
	{
		/// <summary>
		/// 名称
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 艦載機名称
		/// </summary>
		public string AirCraftName
		{
			get
			{
				return Name + (Improvement == 0 ? string.Empty : string.Format("(★{0})", Improvement));
			}
		}
		/// <summary>
		/// 種別
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// 攻撃可能か
		/// </summary>
		public bool Attackable => Type == "艦攻" || Type == "艦爆";

		/// <summary>
		/// 火力
		/// </summary>
		public int FirePower { get; set; }

		/// <summary>
		/// 改修値
		/// </summary>
		public int Improvement { get; set; }

		/// <summary>
		/// 対空
		/// </summary>
		public int AAValue { get; set; }

		/// <summary>
		/// 対空値
		/// </summary>
		public int AA {
			get
			{
				switch(Type)
				{
					case "艦戦":
						return (int)(AAValue + 0.2 * Improvement);
					case "艦爆":
						return (int)(AAValue + 0.25 * Improvement);
					default:
						return AAValue;
				}
			}
		}
		/// <summary>
		/// 爆装
		/// </summary>
		public int Bomber { get; set; }
		/// <summary>
		/// 雷装
		/// </summary>
		public int Torpedo { get; set; }
		/// <summary>
		/// 命中
		/// </summary>
		public int Accuracy { get; set; }
		/// <summary>
		/// 回避
		/// </summary>
		public int Evasion { get; set; }


		public AirCraft()
		{
			Improvement = 0;
		}

		public AirCraft(string name, string type, int firePower = 0, int aa = 0, int bomber = 0, int torpedo = 0, int accuracy = 0, int evasion = 0, int improvement = 0)
		{
			Name = name;
			Type = type;
			AAValue = aa;
			Bomber = bomber;
			Torpedo = torpedo;
			Accuracy = accuracy;
			Evasion = evasion;
			Improvement = improvement;
		}

		public AirCraft(AirCraft source)
		{
			Name = source.Name;
			Type = source.Type;
			AAValue = source.AAValue;
			Bomber = source.Bomber;
			Torpedo = source.Torpedo;
			Accuracy = source.Accuracy;
			Evasion = source.Evasion;
			Improvement = source.Improvement;
		}
	}
}

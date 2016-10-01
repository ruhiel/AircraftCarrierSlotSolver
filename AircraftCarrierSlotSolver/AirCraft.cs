using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierSlotSolver
{
	public class AirCraft
	{
		/// <summary>
		/// 名称
		/// </summary>
		public string Name { get; set; }
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
		/// 対空
		/// </summary>
		public int AA { get; set; }
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
	}
}

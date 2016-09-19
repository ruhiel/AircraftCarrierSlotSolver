using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierSlotSolver
{
	public class ShipInfo
	{
		/// <summary>
		/// 艦名
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 艦種
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// 火力
		/// </summary>
		public int FirePower { get; set; }
		/// <summary>
		/// スロット数
		/// </summary>
		public int SlotNum { get; set; }
		/// <summary>
		/// スロット数1
		/// </summary>
		public int Slot1Num { get; set; }
		/// <summary>
		/// スロット数2
		/// </summary>
		public int Slot2Num { get; set; }
		/// <summary>
		/// スロット数3
		/// </summary>
		public int Slot3Num { get; set; }
		/// <summary>
		/// スロット数4
		/// </summary>
		public int Slot4Num { get; set; }
		public int[] Slots => new int[] { Slot1Num, Slot2Num, Slot3Num, Slot4Num };
	}
}

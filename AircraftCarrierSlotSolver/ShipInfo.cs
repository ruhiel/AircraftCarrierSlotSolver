using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierSlotSolver
{
	public class ShipInfo
	{
		public string Name { get; set; }
		public int FirePower { get; set; }
		public int SlotNum { get; set; }
		public int Slot1Num { get; set; }
		public int Slot2Num { get; set; }
		public int Slot3Num { get; set; }
		public int Slot4Num { get; set; }
		public int[] Slots => new int[] { Slot1Num, Slot2Num, Slot3Num, Slot4Num };
	}
}

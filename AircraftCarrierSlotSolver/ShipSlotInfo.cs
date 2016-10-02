using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierSlotSolver
{
	public class ShipSlotInfo
	{
		public string ShipName { get; set; }
		public string Slot1 { get; set; }
		public int Slot1Num { get; set; }
		public string Slot2 { get; set; }
		public int Slot2Num { get; set; }
		public string Slot3 { get; set; }
		public int Slot3Num { get; set; }
		public string Slot4 { get; set; }
		public int Slot4Num { get; set; }
		public int MinSlotNum => new[] { Slot1Num, Slot2Num, Slot3Num, Slot4Num }.Min();
		public bool Attack { get; set; }
		public bool Saiun { get; set; }
		public bool MaintenancePersonnel { get; set; }
		public bool MinimumSlot { get; set; }
	}
}

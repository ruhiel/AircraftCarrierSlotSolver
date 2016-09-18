using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierSlotSolver
{
	public class ShipInfoMap : CsvClassMap<ShipInfo>
	{
		public ShipInfoMap()
		{
			Map(m => m.Name).Index(0);
			Map(m => m.Type).Index(1);
			Map(m => m.FirePower).Index(2);
			Map(m => m.SlotNum).Index(3);
			Map(m => m.Slot1Num).Index(4);
			Map(m => m.Slot2Num).Index(5);
			Map(m => m.Slot3Num).Index(6);
			Map(m => m.Slot4Num).Index(7);
		}
	}
}

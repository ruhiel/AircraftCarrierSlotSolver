using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierSlotSolver
{
	public class AirCraftMap : CsvClassMap<AirCraft>
	{
		public AirCraftMap()
		{
			Map(m => m.Name).Index(0);
			Map(m => m.Type).Index(1);
			Map(m => m.FirePower).Index(2);
			Map(m => m.AAValue).Index(3);
			Map(m => m.Bomber).Index(4);
			Map(m => m.Torpedo).Index(5);
			Map(m => m.Accuracy).Index(6);
			Map(m => m.Evasion).Index(7);
		}
	}
}

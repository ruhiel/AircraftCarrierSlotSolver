using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierSlotSolver
{
	public class GeneratorInfo
	{
		public Tuple<ShipInfo, int> Ship { get; set; }

		public Tuple<int, int> Slot { get; set; }

		public Tuple<AirCraft, int> AirCraft { get; set; }

		public string SlotName => string.Format("slot_{0}_{1}_{2}", Ship.Item2, Slot.Item2, AirCraft.Item2);

		public int Power
		{
			get
			{
				if (AirCraft.Item1.Type == "艦爆")
				{
					var pow = 1 * (25 + AirCraft.Item1.Bomber * Math.Sqrt(Slot.Item1));
					return (int)Math.Floor(pow);
				}
				else if (AirCraft.Item1.Type == "艦攻")
				{
					var pow = 1.15 * (25 + AirCraft.Item1.Torpedo * Math.Sqrt(Slot.Item1));
					return (int)Math.Floor(pow);
				}
				else
				{
					return 0;
				}
			}
		}

		public int AirSuperiorityPotential
		{
			get
			{
				var air = AirCraft.Item1.AA * Math.Sqrt(Slot.Item1);
				double bonus = 0;
				switch(AirCraft.Item1.Type)
				{
					case "艦攻":
					case "艦爆":
						bonus = 3;
						break;
					case "艦戦":
					case "水戦":
						bonus = 25;
						break;
					default:
						break;
				}

				return (int)Math.Floor(air + bonus);
			}
		}
	}
}

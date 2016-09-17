using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierSlotSolver
{
	public class AirCraft
	{
		public string Name { get; set; }
		public string Type { get; set; }
		public string FirePower { get; set; }
		public int AA { get; set; }
		public int Bomber { get; set; }
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

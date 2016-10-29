using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierSlotSolver
{
	public class AirCraftImprovementSetting
	{
		/// <summary>
		/// 艦載機名称
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 改修値
		/// </summary>
		public int Improvement { get; set; }

		/// <summary>
		/// 設定値
		/// </summary>
		public int Value { get; set; }

		public AirCraftImprovementSetting(string name, int improvement, int value)
		{
			Name = name;
			Improvement = improvement;
			Value = value;
		}
	}
}

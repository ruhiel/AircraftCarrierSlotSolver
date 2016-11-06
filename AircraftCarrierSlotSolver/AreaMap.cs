using CsvHelper.Configuration;

namespace AircraftCarrierSlotSolver
{
	public class AreaMap : CsvClassMap<Area>
	{
		public AreaMap()
		{
			Map(m => m.Name).Index(0);
			Map(m => m.AirSuperiorityPotential).Index(1);
		}
	}
}

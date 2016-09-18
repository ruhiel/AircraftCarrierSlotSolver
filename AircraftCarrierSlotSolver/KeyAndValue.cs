using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AircraftCarrierSlotSolver
{
	/// <summary>
	/// シリアル化できる、KeyValuePairに代わる構造体
	/// </summary>
	/// <typeparam name="TKey">Keyの型</typeparam>
	/// <typeparam name="TValue">Valueの型</typeparam>
	[Serializable]
	public struct KeyAndValue<TKey, TValue>
	{
		public TKey Key;
		public TValue Value;

		public KeyAndValue(KeyValuePair<TKey, TValue> pair)
		{
			Key = pair.Key;
			Value = pair.Value;
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AircraftCarrierSlotSolver
{
	public static class ConvertExtension
	{
		/// <summary>
		/// DictionaryをKeyAndValueのListに変換する
		/// </summary>
		/// <typeparam name="TKey">Dictionaryのキーの型</typeparam>
		/// <typeparam name="TValue">Dictionaryの値の型</typeparam>
		/// <param name="dic">変換するDictionary</param>
		/// <returns>変換されたKeyAndValueのList</returns>
		public static List<KeyAndValue<TKey, TValue>> ToList<TKey, TValue>(this Dictionary<TKey, TValue> dic)
		{
			var lst = new List<KeyAndValue<TKey, TValue>>();
			foreach (var pair in dic)
			{
				lst.Add(new KeyAndValue<TKey, TValue>(pair));
			}
			return lst;
		}

		/// <summary>
		/// KeyAndValueのListをDictionaryに変換する
		/// </summary>
		/// <typeparam name="TKey">KeyAndValueのKeyの型</typeparam>
		/// <typeparam name="TValue">KeyAndValueのValueの型</typeparam>
		/// <param name="lst">変換するKeyAndValueのList</param>
		/// <returns>変換されたDictionary</returns>
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue>(this List<KeyAndValue<TKey, TValue>> lst)
		{
			var dic = new Dictionary<TKey, TValue>();
			foreach (var pair in lst)
			{
				dic.Add(pair.Key, pair.Value);
			}
			return dic;
		}
	}
}

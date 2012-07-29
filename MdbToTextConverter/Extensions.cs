using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MdbToTextConverter
{
	internal static class Extensions
	{
		#region --Public Static Members--

		/// <summary>
		/// Returns original collection if it exists.  If original collection reference is null, returns empty collection
		/// of the appropriate type.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <returns></returns>
		public static IEnumerable<T> DefaultCollectionIfEmpty<T>(this IEnumerable<T> collection)
		{
			return collection ?? new List<T>();
		}

		/// <summary>
		/// Determines if the enum contains a particular value.  Only valid for enums decorated with Flags attribute.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="flags"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static bool Has<T>(this Enum flags, T value)
		{
			return (Convert.ToInt64(flags) & Convert.ToInt64(value)) == Convert.ToInt64(value);
		}

		#endregion --Public Static Members--
	}
}
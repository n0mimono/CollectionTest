using System;
using System.Collections;
using System.Collections.Generic;
using Custom.Linq.Fast;

namespace Custom.Linq {
	public static partial class FastLinq {
		#region Aggregate
		public static TAccumulate FastAggregate<TSource, TAccumulate> (this IList<TSource> source,
			TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
		{
			return source.Aggregate (seed, func);
		}

		public static TAccumulate FastAggregate<TSource, TAccumulate> (this TSource[] source,
			TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
		{
			return source.Aggregate (seed, func);
		}
		#endregion

		#region Any
		public static bool FastAny<TSource> (this IList<TSource> source)
		{
			return source.Any ();
		}

		public static bool FastAny<TSource> (this IList<TSource> source, Func<TSource, bool> predicate)
		{
			return source.Any (predicate);
		}

		public static bool FastAny<TSource> (this TSource[] source)
		{
			return source.Any ();
		}

		public static bool FastAny<TSource> (this TSource[] source, Func<TSource, bool> predicate)
		{
			return source.Any (predicate);
		}
		#endregion

		#region Average
		public static float FastAverage (this IList<float> source) {
			return source.Average ();
		}

		public static float FastAverage<TSource> (this IList<TSource> source, Func<TSource, float> selector)
		{
			return source.Average (selector);
		}

		public static float FastAverage (this float[] source) {
			return source.Average ();
		}

		public static float FastAverage<TSource> (this TSource[] source, Func<TSource, float> selector)
		{
			return source.Average (selector);
		}

		#endregion

		#region Count
		public static int FastCount<TSource> (this IList<TSource> source)
		{
			return source.Count ();
		}

		public static int FastCount<TSource> (this IList<TSource> source, Func<TSource, bool> predicate)
		{
			return source.Count (predicate);
		}

		public static int FastCount<TSource> (this TSource[] source)
		{
			return source.Count ();
		}

		public static int FastCount<TSource> (this TSource[] source, Func<TSource, bool> predicate)
		{
			return source.Count (predicate);
		}

		#endregion

		#region ElementAtOrDefault
		public static TSource FastElementAtOrDefault<TSource> (this IList<TSource> source, int index)
		{
			return source.ElementAtOrDefault (index);
		}

		public static TSource FastElementAtOrDefault<TSource> (this TSource[] source, int index)
		{
			return source.ElementAtOrDefault (index);
		}

		#endregion

		#region FirstOrDefault
		public static TSource FastFirstOrDefault<TSource> (this IList<TSource> source)
		{
			return source.FirstOrDefault ();
		}

		public static TSource FastFirstOrDefault<TSource> (this IList<TSource> source, Func<TSource, bool> predicate)
		{
			return source.FirstOrDefault (predicate);
		}

		public static TSource FastFirstOrDefault<TSource> (this TSource[] source)
		{
			return source.FirstOrDefault ();
		}

		public static TSource FastFirstOrDefault<TSource> (this TSource[] source, Func<TSource, bool> predicate)
		{
			return source.FirstOrDefault (predicate);
		}

		#endregion

		#region LastOrDefault
		public static TSource FastLastOrDefault<TSource> (this IList<TSource> source)
		{
			return source.LastOrDefault ();
		}

		public static TSource FastLastOrDefault<TSource> (this IList<TSource> source, Func<TSource, bool> predicate)
		{
			return source.LastOrDefault (predicate);
		}

		public static TSource FastLastOrDefault<TSource> (this TSource[] source)
		{
			return source.LastOrDefault ();
		}
		public static TSource FastLastOrDefault<TSource> (this TSource[] source, Func<TSource, bool> predicate)
		{
			return source.LastOrDefault (predicate);
		}
		#endregion

		#region Max
		public static int FastMax (this IList<int> source)
		{
			return source.Max ();
		}
		public static float FastMax (this IList<float> source)
		{
			return source.Max ();
		}
		public static int FastMax<TSource> (this IList<TSource> source, Func<TSource, int> selector)
		{
			return source.Max (selector);
		}
		public static float FastMax<TSource> (this IList<TSource> source, Func<TSource, float> selector)
		{
			return source.Max (selector);
		}

		public static int FastMax (this int[] source)
		{
			return source.Max ();
		}
		public static float FastMax (this float[] source)
		{
			return source.Max ();
		}
		public static int FastMax<TSource> (this TSource[] source, Func<TSource, int> selector)
		{
			return source.Max (selector);
		}
		public static float FastMax<TSource> (this TSource[] source, Func<TSource, float> selector)
		{
			return source.Max (selector);
		}
		#endregion

		#region Min
		public static int FastMin (this IList<int> source)
		{
			return source.Min ();
		}
		public static float FastMin (this IList<float> source)
		{
			return source.Min ();
		}
		public static int FastMin<TSource> (this IList<TSource> source, Func<TSource, int> selector)
		{
			return source.Min (selector);
		}
		public static float FastMin<TSource> (this IList<TSource> source, Func<TSource, float> selector)
		{
			return source.Min (selector);
		}

		public static int FastMin (this int[] source)
		{
			return source.Min ();
		}
		public static float FastMin (this float[] source)
		{
			return source.Min ();
		}
		public static int FastMin<TSource> (this TSource[] source, Func<TSource, int> selector)
		{
			return source.Min (selector);
		}
		public static float FastMin<TSource> (this TSource[] source, Func<TSource, float> selector)
		{
			return source.Min (selector);
		}
		#endregion

		#region Sum
		public static int FastSum (this IList<int> source)
		{
			return source.Sum ();
		}
		public static int FastSum<TSource> (this IList<TSource> source, Func<TSource, int> selector)
		{
			return source.Sum (selector);
		}
		public static float FastSum (this IList<float> source)
		{
			return source.Sum ();
		}
		public static float FastSum<TSource> (this IList<TSource> source, Func<TSource, float> selector)
		{
			return source.Sum (selector);
		}

		public static int FastSum (this int[] source)
		{
			return source.Sum ();
		}
		public static int FastSum<TSource> (this TSource[] source, Func<TSource, int> selector)
		{
			return source.Sum (selector);
		}
		public static float FastSum (this float[] source)
		{
			return source.Sum ();
		}
		public static float FastSum<TSource> (this TSource[] source, Func<TSource, float> selector)
		{
			return source.Sum (selector);
		}
		#endregion
	}
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace Custom.Linq.Fast {
	public static partial class FastLinq {
		#region Aggregate
		public static TAccumulate Aggregate<TSource, TAccumulate> (this TSource[] source,
			TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
		{
			TAccumulate folded = seed;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				folded = func (folded, element);
			}

			return folded;
		}
		#endregion

		#region Any
		public static bool Any<TSource> (this TSource[] source)
		{
			return source.Count () > 0;
		}

		public static bool Any<TSource> (this TSource[] source, Func<TSource, bool> predicate)
		{
			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				if (predicate (element))
					return true;
			}

			return false;
		}
		#endregion

		#region Average
		public static float Average (this float[] source) {
			float total = 0;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				total += element;
			}

			return total / count;
		}
		public static float Average<TSource> (this TSource[] source, Func<TSource, float> selector)
		{
			float total = 0;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				total += selector (element);
			}

			return total / count;
		}
		#endregion

		#region Count
		public static int Count<TSource> (this TSource[] source)
		{
			return source.Length;
		}
		public static int Count<TSource> (this TSource[] source, Func<TSource, bool> predicate)
		{
			int counter = 0;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				if (predicate (element))
					counter++;
			}

			return counter;
		}
		#endregion

		#region ElementAtOrDefault
		public static TSource ElementAtOrDefault<TSource> (this TSource[] source, int index)
		{
			if (index < 0)
				return default (TSource);

			return index < source.Count() ? source[index] : default (TSource);
		}
		#endregion

		#region FirstOrDefault
		public static TSource FirstOrDefault<TSource> (this TSource[] source)
		{
			int count = source.Count ();
			return count > 0 ? source[0] : default (TSource);
		}
		public static TSource FirstOrDefault<TSource> (this TSource[] source, Func<TSource, bool> predicate)
		{
			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				if (predicate (element))
					return element;
			}

			return default (TSource);
		}
		#endregion

		#region LastOrDefault
		public static TSource LastOrDefault<TSource> (this TSource[] source)
		{
			int count = source.Count ();
			return count > 0 ? source[count-1] : default (TSource);
		}
		public static TSource LastOrDefault<TSource> (this TSource[] source, Func<TSource, bool> predicate)
		{
			int count = source.Count();
			for (int i = count-1; i >= 0; i--) {
				var element = source [i];

				if (predicate (element))
					return element;
			}

			return default (TSource);
		}
		#endregion

		#region Max
		public static int Max (this int[] source)
		{
			var max = int.MinValue;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				max = Math.Max (element, max);
			}

			return max;
		}
		public static float Max (this float[] source)
		{
			var max = float.MinValue;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				max = Math.Max (element, max);
			}

			return max;
		}
		public static int Max<TSource> (this TSource[] source, Func<TSource, int> selector)
		{
			var max = int.MinValue;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				max = Math.Max (selector(element), max);
			}

			return max;
		}
		public static float Max<TSource> (this TSource[] source, Func<TSource, float> selector)
		{
			var max = float.MinValue;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				max = Math.Max (selector(element), max);
			}

			return max;
		}

		#endregion

		#region Min
		public static int Min (this int[] source)
		{
			var max = int.MaxValue;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				max = Math.Min (element, max);
			}

			return max;
		}
		public static float Min (this float[] source)
		{
			var max = float.MaxValue;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				max = Math.Min (element, max);
			}

			return max;
		}
		public static int Min<TSource> (this TSource[] source, Func<TSource, int> selector)
		{
			var max = int.MaxValue;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				max = Math.Min (selector(element), max);
			}

			return max;
		}
		public static float Min<TSource> (this TSource[] source, Func<TSource, float> selector)
		{
			var max = float.MaxValue;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				max = Math.Min (selector(element), max);
			}

			return max;
		}

		#endregion

		#region Sum
		public static int Sum (this int[] source)
		{
			int total = 0;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				total = checked (total + element);
			}

			return total;
		}
		public static int Sum<TSource> (this TSource[] source, Func<TSource, int> selector)
		{
			int total = 0;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				total = checked (total + selector(element));
			}

			return total;
		}
		public static float Sum (this float[] source)
		{
			float total = 0f;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				total = checked (total + element);
			}

			return total;
		}
		public static float Sum<TSource> (this TSource[] source, Func<TSource, float> selector)
		{
			float total = 0f;

			int count = source.Count();
			for (int i = 0; i < count; i++) {
				var element = source [i];

				total = checked (total + selector(element));
			}

			return total;
		}
		#endregion
	}
}
	
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CollectionTest : MonoBehaviour {

	public float threashold;
	public float value;

	private readonly int n = 100;
	private float[] array;

	private List<float> list;

	void Start() {
		Initilize ();
		test ().StartCoroutine ();
	}

	private IEnumerator test() {
		while (true) {
			switch (CollectionTestManager.choice) {
			case 0:
				value = GetByValueFromArray ();
				break;
			case 1:
				value = GetByValueFromListWithFirstOrDefault();
				break;
			case 2:
				value = GetByValueFromListWithFirstOrDefaultAndCachedPredicate ();
				break;
			case 3:
				value = GetByValueFromListWithForEach ();
				break;
			case 4:
				value = GetByValueFromListWithFor ();
				break;
			case 5:
				value = GetByValueFromArrayWithPredicate ();
				break;
			case 6:
				value = GetByValueFromListWithIterator ();
				break;
			case 7:
				value = GetByValueFromArrayWithForEach ();
				break;
			case 8:
				value = GetByValueFromArrayWithFirstOrDefaultAndCachedPredicate ();
				break;
			case 9:
				value = GetByValueFromArrayWithFirstOrDefault ();
				break;
			}
			yield return null;
		}
	}

	private void Initilize() {
		array = new float[n];
		list = new List<float> ();

		for (int i = 0; i < n; i++) {
			array [i] = (float)i;
			list.Add ((float)i);
		}

		threashold = Random.value * n;

		//list = Enumerable.Range (0, n).Select(i => (float)i).ToList ();

	}

	// 0
	private float GetByValueFromArray() {
		for (int i = 0; i < n; i++) {
			if (array [i] > threashold) {
				return array [i];
			}
		}
		return array [n-1];
	}

	// 1
	private float GetByValueFromListWithFirstOrDefault() {
		return list.FirstOrDefault (l => l > threashold);
	}

	// 2
	System.Func<float,bool> cachePredicate;
	private float GetByValueFromListWithFirstOrDefaultAndCachedPredicate() {
		if (cachePredicate == null) {
			cachePredicate = (value) => value > threashold;
		}
		return list.FirstOrDefault (cachePredicate);
	}

	// 3
	private float GetByValueFromListWithForEach() {
		foreach (var l in list) {
			if (l > threashold) {
				return l;
			}
		}
		return 0f;
	}

	// 4
	private float GetByValueFromListWithFor() {
		for (int i = 0; i < n; i++) {
			if (list [i] > threashold) {
				return list [i];
			}
		}
		return list [n - 1];
	}

	// 5
	private float GetByValueFromArrayWithPredicate() {
		for (int i = 0; i < n; i++) {
			System.Func<bool> predicate = () => array [i] > threashold;
			if (predicate()) {
				return array [i];
			}
		}
		return array [n - 1];
	}

	// 6
	private float GetByValueFromListWithIterator() {
		var iter = list.GetEnumerator ();

		float val = default(float);
		while (iter.MoveNext()) {
			val = iter.Current;
			if (val > threashold) return val;
		}

		return val;
	}

	// 7
	private float GetByValueFromArrayWithForEach() {
		foreach (var a in array) {
			if (a > threashold) {
				return a;
			}
		}
		return 0f;
	}

	// 8
	private float GetByValueFromArrayWithFirstOrDefaultAndCachedPredicate() {
		if (cachePredicate == null) {
			cachePredicate = (value) => value > threashold;
		}
		return array.FirstOrDefault (cachePredicate);
	}

	// 9
	private float GetByValueFromArrayWithFirstOrDefault() {
		return array.FirstOrDefault ((value) => value > threashold);
	}

}

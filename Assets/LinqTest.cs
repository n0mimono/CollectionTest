using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Custom.Linq;

public class LinqTest : MonoBehaviour {

	void Start() {
		List<int> list = new List<int> () { 6, 4, 9, 2, 5, 1 };

		int v = list.FastFirstOrDefault (l => l < 3);
		Debug.Log (v);

	}

}

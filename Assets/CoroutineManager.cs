using UnityEngine;
using System.Collections;

public class CoroutineManager : MonoBehaviour {
	private const int MaxNums = 1000;

	private IEnumerator[] routines;
	private int num;

	private static CoroutineManager instance;
	public static CoroutineManager Instance {
		get {
			if (instance == null) {
				GameObject obj = new GameObject (typeof(CoroutineManager).ToString());
				obj.hideFlags = HideFlags.HideAndDontSave;
				instance = obj.AddComponent<CoroutineManager> ();

				instance.routines = new IEnumerator[MaxNums];
				instance.num = 0;
			}
			return instance;
		}
	}

	void Update() {
		for (int i = 0; i < num; i++) {
			routines [i].MoveNext ();
		}
	}

	public void Add(IEnumerator routine) {
		if (num >= MaxNums) return;
		routines [num] = routine;
		num++;
	}

}

public static class CoroutineExtension {
	public static void StartCoroutine(this IEnumerator routine) {
		CoroutineManager.Instance.Add (routine);
	}
}

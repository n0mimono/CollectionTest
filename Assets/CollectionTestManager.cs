using UnityEngine;
using System.Collections;

public class CollectionTestManager : MonoBehaviour {
	public int m;

	public static int choice;
	public int curChoice;

	void Start() {
		for (int i = 0; i < m; i++) {
			CreateTest (i.ToString());
		}
	}

	public void CreateTest(string name) {
		GameObject obj = new GameObject (name);
		obj.AddComponent<CollectionTest> ();
		obj.transform.SetParent (transform);
	}

	[ContextMenu("Change Choice")]
	public void ChangeChoice() {
		curChoice++;
		choice = curChoice;
	}
}

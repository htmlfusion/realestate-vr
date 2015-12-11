using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class SetDoors : MonoBehaviour {
	public GameObject cursor;

	public void RecordDoorPosition() {
		Debug.Log (cursor.transform.position);
	}
}

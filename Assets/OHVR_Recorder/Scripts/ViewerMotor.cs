using UnityEngine;
using System.Collections;

public class ViewerMotor : MonoBehaviour {
		
	public GameObject Cursor; // Google Cardboard SDK: Cursor / GazePointer from CardboardMain Prefab
	private Vector3 goal;
	
	void Start() {
		this.goal = new Vector3(0f, 0f, 0f);
	}
	
	//Set navigation destination to the position of the cursor
	//Ex. Call this from an event trigger on the floor object
	public void SetDestinationToCursor() {
		this.goal = Cursor.transform.position;
		Debug.Log (this.goal);
	}
}

using UnityEngine;
using System.Collections;

public class Animations : MonoBehaviour {

	// Use this for initialization
	public string String1;
	public string String2;
	private bool open = false;
	private bool close = true;

	void Start () {
	
	}
	
	public void ChangeState(){

		if (close) {
			GetComponent<Animation> ().Play (String1);
			close = false;
			open = true;
		} else {
			GetComponent<Animation> ().Play (String2);
			close = true;
			open = false;
		}
	}
}

using UnityEngine;
using System.Collections;

public class DrawerAnimations : MonoBehaviour {

	public string String1;
	public string String2;
	private bool open = false;
	private bool close = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
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
}

using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {

	// Use this for initialization
	public float interactDistance =5f ;

		
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Mouse0)) 
		{
			Ray ray = new Ray (transform.position, transform.forward);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, interactDistance)) 
			{
				if (hit.collider.CompareTag ("Drawer_Doors")) 
				{
					hit.collider.transform.GetComponent<Animations> ().ChangeState ();
				}
			}
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InteractScript : MonoBehaviour {

	public float interactDistance = 3f;

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Mouse0))
		{
			Ray ray = new Ray(transform.position, transform.forward);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, interactDistance))
			{
				if(hit.collider.CompareTag("Door"))
				{
					hit.collider.transform.parent.GetComponent<DoorScript>().ChangeDoorState();
				}
				else if(hit.collider.CompareTag("NextLevel"))
				{
					SceneManager.LoadScene("main");
				}
			}
			
		}
	}
}

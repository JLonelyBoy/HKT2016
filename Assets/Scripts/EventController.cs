using UnityEngine;
using System.Collections;

public class EventController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static string EventPlay(){
		string selectedGameObjectname = "";
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit = new RaycastHit ();

			if (Physics.Raycast (ray, out hit)) {
				selectedGameObjectname = hit.collider.gameObject.name;
			}
		}
		return selectedGameObjectname;
	}
}

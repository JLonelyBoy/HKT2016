using UnityEngine;
using System.Collections;

public class SpereController : MonoBehaviour {
	SlideIn _slideIn;

	// Use this for initialization
	void Start () {
		_slideIn = GameObject.Find ("CatImage").GetComponent<SlideIn> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (EventController.EventPlay () == "Sphere" || EventController.EventPlay() == "NPC") {
			_slideIn.PictureSlideIn ();
		};
	}
}

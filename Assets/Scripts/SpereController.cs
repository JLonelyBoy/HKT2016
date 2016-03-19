using UnityEngine;
using System.Collections;

public class SpereController : MonoBehaviour {
	SlideIn _slideIn;
    GameObject _obj;
    Animator _anim;
    bool _isCutin = false;

	// Use this for initialization
	void Start () {
        //_slideIn = GameObject.Find ("CatImage").GetComponent<SlideIn> ();
        _obj = GameObject.Find("still_pizza1");
        _anim = _obj.GetComponent<Animator>();
        Debug.Log(_anim);
	}
	
	// Update is called once per frame
	void Update () {
		if (EventController.EventPlay () == "Sphere" || EventController.EventPlay() == "NPC" && _isCutin == false) {
			//_slideIn.PictureSlideIn ();
            _anim.SetTrigger("Trigger_tap1");
            _isCutin = true;
		};
	}
}

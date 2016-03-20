using UnityEngine;
using System.Collections;

public class FlyCam : MonoBehaviour {
    public Transform target;
    bool zoomFlg = false;
	// Use this for initialization
	void Start () {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("FlyCam"), "time", 5, "aesetype", iTween.EaseType.easeInOutSine));
        //iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("ZoomIn"), "time", 5, "aesetype", iTween.EaseType.easeInOutSine));
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
        if (EventController.EventPlay() == "Zoom")
        {
            zoomFlg = true;
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("ZoomIn"), "time", 5, "aesetype", iTween.EaseType.easeInOutSine));
        }
    }
}

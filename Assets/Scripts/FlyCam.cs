using UnityEngine;
using System.Collections;

public class FlyCam : MonoBehaviour {
    public Transform target;
	// Use this for initialization
	void Start () {
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("FlyCam"), "time", 5, "aesetype", iTween.EaseType.easeInOutSine));
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
	
	}
}

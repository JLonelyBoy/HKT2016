using UnityEngine;
using System.Collections;

public class ButtonAction : MonoBehaviour {
    bool isZoom = false;
    public void OnClick()
    {
        Debug.Log("Button touch");
        if (isZoom == false)
        {
            isZoom = true;
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("ZoomIn"), "time", 5, "aesetype", iTween.EaseType.easeInOutSine));
        }
        else
        {
            isZoom = false;
        }
    }

    public void testOnClick()
    {
        Debug.Log("Button touch");
        if (isZoom == false)
        {
            isZoom = true;
            iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath("ZoomIn"), "time", 5, "aesetype", iTween.EaseType.easeInOutSine));
        }
        else
        {
            isZoom = false;
        }
    }
}

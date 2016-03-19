using UnityEngine;
using System.Collections;

public class SlideIn : MonoBehaviour {
	public AnimationCurve animCurve = AnimationCurve.Linear(0, 0, 1, 1);
	public Vector3 inPosition; 
	public Vector3 outPosition;
	public float duration = 0.2f;

	public void PictureSlideIn(){
		StartCoroutine( StartSlidePanel(true) );
	}
		
	public void PictureSlideOut(){
		StartCoroutine( StartSlidePanel(false) );
	}

	private IEnumerator StartSlidePanel( bool isSlideIn ){
		inPosition = new Vector3 (0, 0, 0);
		float startTime = Time.time;
		Vector3 startPos = transform.localPosition;

		Vector3 moveDistance;

		if (isSlideIn) {
			moveDistance = (inPosition - startPos);
		} else {
			moveDistance = (outPosition - startPos);
		}

		while ((Time.time - startTime) < duration) {
			transform.localPosition = startPos + moveDistance * animCurve.Evaluate ((Time.time - startTime) / duration);
			yield return 0;
		}
		transform.localPosition = startPos + moveDistance;
		Application.LoadLevelAdditive ("CatScene");
	}
}

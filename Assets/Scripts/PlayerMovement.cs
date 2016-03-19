using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	//Player Speed
	public float speed = 600;

	Vector3 movement;

	//Player Animation Controller
	Animator anim;

	//FloorMask
	int floorMask;

	//Camera Ray 
	float CamRayLength = 100f;

	//Player Riggifbody
	Rigidbody PlayerRb;


	//Use this for prepare all element
	void Awake(){
		floorMask = LayerMask.GetMask("Floor");
		anim = GetComponent<Animator>();
		PlayerRb = GetComponent<Rigidbody>();
//		Debug.Log (AudioController.Instance.a);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		if (h != 0 || v != 0) {
			Debug.Log("Has Press");
		}

		movement.Set (h, 0f, v);
		movement = movement.normalized * speed * Time.deltaTime;
		PlayerRb.MovePosition(transform.position +  (movement * speed * Time.deltaTime));
		// Create a boolean that is true if either of the input axes is non-zero.
		bool walking = h != 0f || v != 0f;
				
		// Tell the animator whether or not the player is walking.
		anim.SetBool ("MoveForward", walking);

		Debug.Log (h + " , " + v);
		Debug.Log (walking);
		//		anim.SetBool ("IsJump", walking);

	}

}

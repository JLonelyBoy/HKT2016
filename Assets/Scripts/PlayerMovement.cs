using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    //Nav mesh Agent
    NavMeshAgent _agent;
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

    Vector3 lastframePos;


    //Use this for prepare all element
    void Start() {
        floorMask = LayerMask.GetMask("Floor");
        anim = GetComponent<Animator>();
        PlayerRb = GetComponent<Rigidbody>();
        _agent = GetComponent<NavMeshAgent>();
        lastframePos = transform.position;
             //		Debug.Log (AudioController.Instance.a);
    }


    // Update is called once per frame
    void Update() {
        Vector3 currentPos = transform.position;
        float distance = Vector3.Distance(lastframePos, currentPos);
        lastframePos = currentPos;
        float curSpeed = Mathf.Abs(distance) / Time.deltaTime;

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        if (h != 0 || v != 0) {
            Debug.Log("Has Press");
        }

        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        //PlayerRb.MovePosition(transform.position +  (movement * speed * Time.deltaTime));
        // Create a boolean that is true if either of the input axes is non-zero.
        //bool walking = h != 0f || v != 0f;
        bool walking = curSpeed > 0.1;

        // Tell the animator whether or not the player is walking.
        anim.SetBool("MoveForward", walking);

        Debug.Log(h + " , " + v);
        Debug.Log(walking);
        Move();
        //		anim.SetBool ("IsJump", walking);

    }

    void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (_agent != null)
                    _agent.SetDestination(hit.point);
            }
        }


    }

}

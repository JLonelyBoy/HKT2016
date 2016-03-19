using UnityEngine;
using System.Collections;

public class SpereController : MonoBehaviour {
	SlideIn _slideIn;
    GameObject _obj;
    Animator _anim;
    bool _isCutin = false;
    ParticleSystem par;

	// Use this for initialization
	void Start () {
        //_slideIn = GameObject.Find ("CatImage").GetComponent<SlideIn> ();
        _obj = GameObject.Find("still_pizza1");
        _anim = _obj.GetComponent<Animator>();
        par = GameObject.Find("Particle_star").GetComponent<ParticleSystem>();
        //par.enableEmission = false;
        Debug.Log(par);
	}
	
	// Update is called once per frame
	void Update () {
        if (EventController.EventPlay() == "Sphere" || EventController.EventPlay() == "NPC" && _isCutin == false)
        {
            //_slideIn.PictureSlideIn ();
            //bool _isPlaying = !_anim.GetCurrentAnimatorStateInfo(0).IsName("Trigger_tap1");
            //Debug.Log(_isPlaying);
            par.enableEmission = true;
            if (par.isPlaying)
            {
                par.Stop();
                par.Play();
            }
            else par.Play();
            par.enableEmission = false;

            _anim.SetBool("Trigger_tap1", true);
            //_anim.SetTrigger("Trigger_tap1");
            _isCutin = true;
        };
        //Debug.Log(_anim.GetCurrentAnimatorStateInfo(0).IsName("stillPizza1_mov1"));

    }
}

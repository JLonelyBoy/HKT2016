using UnityEngine;
using System.Collections;
using UnityEditor;

public class Genground : MonoBehaviour {

    public int vsize;
    public int hsize;
    Material _bMaterial;
    Material _wMaterail;
    GameObject _pref;
	// Use this for initialization
	void Start () {
        _bMaterial = Resources.Load("Materials/BlackGround.mat") as Material;
        _wMaterail = Resources.Load("Materials/WhiteGround.mat") as Material;
        

    }

    void init()
    {
        initGround();

    }

    void initGround()
    {

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using UnityEditor;

public class Genground : MonoBehaviour {

    public int vsize;
    public int hsize;
    GameObject _bMaterial;
    GameObject _wMaterail;
	// Use this for initialization
	void Start () {
        _bMaterial = AssetDatabase.LoadAssetAtPath("",typeof(GameObject));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

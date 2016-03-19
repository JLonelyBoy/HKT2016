using UnityEngine;
using System.Collections;
using UnityEditor;

public class ActionScript : MonoBehaviour {
    Collider _coll;
    Material _normal;
    Material _highlight;
	// Use this for initialization
	void Start () {
        _coll = GetComponent<Collider>();
        _normal = AssetDatabase.LoadAssetAtPath("Assets/Materials/BlackGround.mat", typeof(Material)) as Material;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (_coll.Raycast(ray, out hit, Mathf.Infinity)){
            
        }
    }
}

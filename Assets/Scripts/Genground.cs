using UnityEngine;
using System.Collections;
using UnityEditor;

public class Genground : MonoBehaviour {

    public int vsize;
    public int hsize;
    //Material _bMaterial;
    //Material _wMaterail;
    
	// Use this for initialization
	void Start () {
        //_bMaterial = AssetDatabase.LoadAssetAtPath("Assets/Materials/BlackGround.mat", typeof(Material)) as Material;
        //_wMaterail = AssetDatabase.LoadAssetAtPath("Assets/Materials/WhiteGround.mat",typeof(Material)) as Material;
        init();


    }

    void init()
    {
        initGround();
        initWall();
    }

    void initGround()
    {
        GameObject obj = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/WhiteTile.prefab", typeof(GameObject)) as GameObject;
        for (int i = 0; i < vsize; i++)
        {
            for (int j = 0; j < hsize; j++)
            {
                //Instantiate(obj, new Vector3(obj.transform.position.x + j, obj.transform.position.y, obj.transform.position.z + i), Quaternion.identity);
                if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                {
                    GameObject gObj = Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/WhiteTile.prefab", typeof(GameObject))  ,
                        new Vector3(obj.transform.position.x + j, obj.transform.position.y, obj.transform.position.z + i),
                        Quaternion.identity) as GameObject;
                    gObj.transform.parent = transform;
                    gObj.name = "Tile[" +i +"," + j +"]";
                }
                else
                {
                    GameObject gObj = Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/BlackTile.prefab", typeof(GameObject)),
                        new Vector3(obj.transform.position.x + j, obj.transform.position.y, obj.transform.position.z + i),         
                        Quaternion.identity) as GameObject;
                    gObj.transform.parent = transform;
                    gObj.name = "Tile[" + i + "," + j + "]";
                }
               
            }
        }
    }
    void initWall()
    {
        //hWall
        GameObject LWall = Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Wall.prefab", typeof(GameObject)), Vector3.zero, Quaternion.identity) as GameObject;
        Vector3 scale = new Vector3(0.01f, LWall.transform.localScale.y, hsize);
        Vector3 pos = new Vector3(0f, LWall.transform.localScale.y / 2f, hsize / 2f);
        LWall.transform.parent = transform;
        LWall.transform.position = pos;
        LWall.transform.localScale = scale;

        //rWall
        GameObject RWall = Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Wall.prefab", typeof(GameObject)),
            Vector3.zero,
            Quaternion.identity) as GameObject;
        pos.x = hsize;
        RWall.transform.parent = transform;
        RWall.transform.position = pos;
        RWall.transform.localScale = scale;

        //uWall
        GameObject UWall = Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Wall.prefab", typeof(GameObject)),
            Vector3.zero,
            Quaternion.identity) as GameObject;
        scale.x = vsize;
        scale.z = 0.01f;
        pos.x = vsize / 2f;
        pos.z = vsize;
        UWall.transform.parent = transform;
        UWall.transform.position = pos;
        UWall.transform.localScale = scale;

        //dWall
        GameObject DWall = Instantiate(AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Wall.prefab", typeof(GameObject)),
            Vector3.zero,
            Quaternion.identity) as GameObject;
        pos.z = 0;
        DWall.transform.parent = transform;
        DWall.transform.position = pos;
        DWall.transform.localScale = scale;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

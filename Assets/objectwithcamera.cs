using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectwithcamera : MonoBehaviour {

    public GameObject cameraObject;
   public static bool picked;
    public GameObject canvas1;
 
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
       
   
	}

    public void onObjectClickItem1(GameObject prefab)
    {   
        Debug.Log("clicked the object");
        if (!globalScript.mysticitem1 && !picked)
        {
            globalScript.mysticitem1 = true;
            globalScript.mysticitem2 = false;
            globalScript.mysticitem3 = false;
            globalScript.setObjectPicked(prefab);
            prefab.transform.SetParent(cameraObject.transform);
            prefab.GetComponent<Collider>().enabled = false;
            picked = true;
            
        }

    }


    public void onObjectClickItem2(GameObject prefab)
    {
        Debug.Log("clicked the object");
        if (!globalScript.mysticitem2 && !picked)
        {
            globalScript.mysticitem1 = false;
            globalScript.mysticitem2 = true;
            globalScript.mysticitem3 = false;
            globalScript.setObjectPicked(prefab);
            prefab.transform.SetParent(cameraObject.transform);
            prefab.GetComponent<Collider>().enabled = false;
            picked = true;
            
        }


    }

    public void onObjectClickItem3(GameObject prefab)
    {
        Debug.Log("clicked the object");
        if (!globalScript.mysticitem3 && !picked)
        {
            globalScript.mysticitem1 = false;
            globalScript.mysticitem2 = false;
            globalScript.mysticitem3 = true;
            globalScript.setObjectPicked(prefab);
            prefab.transform.SetParent(cameraObject.transform);
            prefab.GetComponent<Collider>().enabled = false;
            picked = true;
            
        }


    }


}

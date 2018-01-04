using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globalScript : MonoBehaviour {

    public static GameObject itemPicked;
    public static GameObject objectPickedContainer;
    public static bool mysticitem1, mysticitem2, mysticitem3;
    public static int itemsPlaced;
    public static bool closed;
    public AudioClip clip;
    AudioSource audiosource;

    // Use this for initialization
    void Start () {
        setItemsIntialStatus();
        itemsPlaced = 0;
        closed = true;
        audiosource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (itemsPlaced == 3 && closed)
        {
            Debug.Log("three items placed " + itemsPlaced);
            GetComponent<Animator>().Play("door_animation");
            audiosource.PlayOneShot(clip);
            doorplaysound.doorclosed = false;
            closed = false;
        }
    }


    public static void setItemsIntialStatus()
    {
        mysticitem1 = false;
        mysticitem2 = false;
        mysticitem3 = false;

    }
    
   public void setObjectTransformItem1(GameObject prefab)
    {
        if(itemPicked != null && itemPicked && mysticitem1)
        {
           
            getObjectPicked().transform.position = prefab.transform.position;
            getObjectPicked().transform.SetParent(prefab.transform);
            prefab.GetComponent<Collider>().enabled = false;
            objectwithcamera.picked = false; // because dropped here
            itemsPlaced = itemsPlaced + 1;
           
        }

    }
    public void setObjectTransformItem2(GameObject prefab)
    {
        if (itemPicked != null && itemPicked && mysticitem2)
        {
            
            getObjectPicked().transform.position = prefab.transform.position;
            getObjectPicked().transform.SetParent(prefab.transform);
            prefab.GetComponent<Collider>().enabled = false;
            objectwithcamera.picked = false; // because dropped here
            itemsPlaced = itemsPlaced + 1;
            
        }


    }

    public void setObjectTransformItem3(GameObject prefab)
    {
        if (itemPicked != null && itemPicked && mysticitem3)
        {
           
            getObjectPicked().transform.position = prefab.transform.position;
            getObjectPicked().transform.SetParent(prefab.transform);
            prefab.GetComponent<Collider>().enabled = false;
            objectwithcamera.picked = false; // because dropped here
            itemsPlaced = itemsPlaced + 1;
          
        }


    }

    public static void setObjectPicked(GameObject pickedItem)
    {
        itemPicked = pickedItem;
    }

    public static GameObject getObjectPicked()
    {
        return itemPicked;
    }

    public void playPlacedItem1Audio(AudioClip clip)
    {
        if (mysticitem1)
        {
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
    public void playPlacedItem2Audio(AudioClip clip)
    {
        if (mysticitem2)
        {
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
    public void playPlacedItem3Audio(AudioClip clip)
    {
        if (mysticitem3)
        {
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
}

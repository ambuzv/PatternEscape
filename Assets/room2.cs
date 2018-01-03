using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room2 : MonoBehaviour {
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject door;
    public GameObject waypoint;
    AudioSource audiosource;
    public AudioClip opendooraudio;
    public bool doorlock;
  public static  bool makedoorcloseSound;

    public AudioClip dooropenWinSound;

    //public Quaternion target = Quaternion.Euler(new Vector3(0, 30, 0));
    private enum States { normal, rotate1, rotate2, rotate3, door1};
    private States myState;
    private Quaternion rotation1; private int count1 = 0;
    private Quaternion rotation2; private int count2 = 0;
    private Quaternion rotation3; private int count3 = 0;
    private Quaternion rotation4;

   
    public void Rotate_object1(AudioClip clip)
    {
        myState = States.rotate1;
        rotation1 = object1.transform.rotation * Quaternion.Euler(0F, 0F, -90F);
        count1++;
        audiosource.PlayOneShot(clip);

    }

    public void Rotate_object2(AudioClip clip)
    {
        myState = States.rotate2;
        rotation2 = object2.transform.rotation * Quaternion.Euler(0F, 0F, -90F);
        count2++;
        audiosource.PlayOneShot(clip);

    }

    public void Rotate_object3(AudioClip clip)
    {
        myState = States.rotate3;
        rotation3 = object3.transform.rotation * Quaternion.Euler(0F, 0F, -90F);
        count3++;
        audiosource.PlayOneShot(clip);

    }

    public void Open_door()
    {
        if(doorlock == true)
        {
            AudioClip clip = opendooraudio;
            myState = States.door1;
            waypoint.SetActive(true);
            audiosource.PlayOneShot(clip);
            doorlock = false;
            makedoorcloseSound = false;
            audiosource.PlayOneShot(dooropenWinSound);
        }
      
    }

  

    // Use this for initialization
    void Start()
    {
        myState = States.normal;
        audiosource = GetComponent<AudioSource>();
        doorlock = true;
        makedoorcloseSound = true;
    }

    // Update is called once per frame
	void Update () {
        if (myState == States.rotate1)
        {
            object1.transform.rotation = Quaternion.Lerp(object1.transform.rotation, rotation1, 10 * Time.deltaTime);
        }

        else if (myState == States.rotate2)
        {
            object2.transform.rotation = Quaternion.Lerp(object2.transform.rotation, rotation2, 10 * Time.deltaTime);
        }

        else if (myState == States.rotate3)
        {
            object3.transform.rotation = Quaternion.Lerp(object3.transform.rotation, rotation3, 10 * Time.deltaTime);
        }
        else if (myState == States.door1)
        {
            door.transform.rotation = Quaternion.Lerp(door.transform.rotation, Quaternion.Euler(0F, 360F, 0F), 2 * Time.deltaTime);

        }
        if (count1 % 4 == 3 && count2 % 4 == 1 && count3 % 4 == 3)
        {
            Invoke("Open_door", 1);
            Debug.Log("open the door");
        }
    }

   
}

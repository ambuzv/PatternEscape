using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorplaysound : MonoBehaviour {

    public AudioClip clip,clipfun;
    
     AudioSource audiosource;
    public static bool doorclosed;
    public static bool played;

	// Use this for initialization
	void Start () {
        audiosource = GetComponent<AudioSource>();
        doorclosed = true;
        played = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!doorclosed && !played)
        {
            audiosource.PlayOneShot(clip);
            audiosource.PlayOneShot(clipfun);
            played = true;
        }
	}

}

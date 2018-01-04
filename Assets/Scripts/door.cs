using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour {
    AudioSource source;

    public void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void onDoorObjectClick(AudioClip clip)
    {
        if (room2.makedoorcloseSound)
        {
            source.PlayOneShot(clip);
        }
       
    }
}

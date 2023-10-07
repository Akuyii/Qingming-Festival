using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryAudioPlay : MonoBehaviour
{
    public bool isStoryPlay;
    public static StoryAudioPlay _instance;

    private void Awake()
    {
        _instance = this;
    }

    private void Update()
    {
        if (isStoryPlay)
        {
            this.GetComponent<AudioSource>().enabled = true;
        }
        else
        {
            this.GetComponent<AudioSource>().enabled = false;
        }
    }
}

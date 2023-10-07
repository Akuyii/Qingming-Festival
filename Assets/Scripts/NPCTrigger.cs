using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "NPC")
        {
            CanvasShow._instance.isDialogue = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "NPC")
        {
            CanvasShow._instance.isDialogue = false;
            StoryAudioPlay._instance.isStoryPlay = false;
        }
    }
}

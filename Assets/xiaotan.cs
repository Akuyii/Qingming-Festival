using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xiaotan : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTER");
        CanvasShow._instance.isXiaotan = true;
    }

    private void OnTriggerExit(Collider other)
    {
        CanvasShow._instance.isXiaotan = false;
    }
}

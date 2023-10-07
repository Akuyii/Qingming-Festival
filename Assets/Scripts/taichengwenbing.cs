using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taichengwenbing : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        CanvasShow._instance.isTaiCheng = true;
    }
    private void OnTriggerExit(Collider other)
    {
        CanvasShow._instance.isTaiCheng = false;
    }
}

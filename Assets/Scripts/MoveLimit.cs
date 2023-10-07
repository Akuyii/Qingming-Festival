using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 场景边界触发器
/// </summary>
public class MoveLimit : MonoBehaviour
{
    public bool isEnter;
    public static MoveLimit _instance;

    private void Awake()
    {
        _instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        isEnter = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isEnter = false;
    }
}

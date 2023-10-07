using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
/// <summary>
/// 戴上头盔 场景跳转
/// </summary>
public class PutOnHelmet : MonoBehaviour
{
    private GameObject player;
    private GameObject loadNextScene;
    private Transform HeadPoint;


    private void Start()
    {
        player = GameObject.Find("Player");
        loadNextScene = player.transform.Find("LoadNextScene").gameObject;
        HeadPoint = player.transform.Find("SteamVRObjects").GetChild(3).transform;
    }

    private void Update()
    {
        
        //Debug.Log(Vector3.Distance(HeadPoint.position, transform.position));
        if (Vector3.Distance(HeadPoint.position, transform.position) < 0.2f)
        {
            Invoke("LoadNextScene", 1f);
        }
    }
    /// <summary>
    /// 切换场景
    /// </summary>
    private void LoadNextScene()
    {
        SteamVR_LoadLevel load = loadNextScene.GetComponent<SteamVR_LoadLevel>();
        load.levelName = "QingMing";
        //this.gameObject.SetActive(false);
        load.Trigger();//切换场景
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR;
using UnityEngine.UI;
/// <summary>
/// 边界画布显示
/// 画布按钮点击方法
/// </summary>
public class CanvasShow : MonoBehaviour
{
    public GameObject LimitCanvas;//边界面板
    public GameObject MenuCanvas;//菜单面板
    public GameObject DialogueCanvas;//对话面板
    public GameObject StoryCanvas;//说书人故事内容面板
    public GameObject EventCanvas1;//事件面板
    public GameObject EventCanvas2;//事件面板

    public CanvasGroup limitCanvasGroup;
    public GameObject loadNextScene;

    public bool isDialogue;
    public bool isTaiCheng;
    public bool isXiaotan;
    public bool isShoulie;

    public static CanvasShow _instance;

    private void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        SteamVR_Actions.default_GrabGrip.onStateDown += Default_GrabGrip_onStateDown;
    }
    private void OnDisable()
    {
        SteamVR_Actions.default_GrabGrip.onStateDown -= Default_GrabGrip_onStateDown;
    }

    private void Update()
    {
        showLimitCanvas();
        showDialogueCanvas();
        showTaiChengSprite();
        showXiaoTanSprite();
    }

    private void showTaiChengSprite()
    {
        if (isTaiCheng)
        {
            EventCanvas1.SetActive(true);
        }
        else
        {
            EventCanvas1.SetActive(false);
        }
        
    }

    private void showXiaoTanSprite()
    {
        if (isXiaotan)
        {
            EventCanvas2.SetActive(true);
        }
        else
        {
            EventCanvas2.SetActive(false);
        }

    }

    private void Default_GrabGrip_onStateDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)
    {
        if (!MenuCanvas.activeInHierarchy)
        {
            MenuCanvas.SetActive(true);
        }
        else
        {
            MenuCanvas.SetActive(false);
        }

    }

    /// <summary>
    /// 边界面板显示与关闭
    /// </summary>
    private void showLimitCanvas()
    {
        //LimitCanvas
        if (MoveLimit._instance == null) return;
        if (MoveLimit._instance.isEnter)
        {
            LimitCanvas.SetActive(true);
            limitCanvasGroup.blocksRaycasts = true;
        }
        else
        {
            limitCanvasGroup.blocksRaycasts = false;
            LimitCanvas.SetActive(false);
        }
    }

    /// <summary>
    /// 对话面板
    /// </summary>
    private void showDialogueCanvas()
    {
        if (isDialogue)
        {
            DialogueCanvas.SetActive(true);
        }
        else
        {
            DialogueCanvas.SetActive(false);
        }
    }
    /// <summary>
    /// 故事按钮点击
    /// </summary>
    public void OnStoryButtonClick()
    {
        Debug.Log("OnStoryButtonClick");
        StoryCanvas.SetActive(true);
        StoryAudioPlay._instance.isStoryPlay = true;
    }

    /// <summary>
    /// 离开场景按钮点击
    /// </summary>
    public void OnLeaveButtonClick()
    {
        //Invoke("LoadNextScene", 2.3f);
        GameManager._instance.isAgain = true;
        LoadNextScene();
    }

    /// <summary>
    /// 继续体验按钮点击
    /// </summary>
    public void OnContinueButtonClick()
    {
        //Debug.Log("OnContinueButtonClick");
        MoveLimit._instance.isEnter = false;
        isDialogue = false;
        MenuCanvas.SetActive(false);
        StoryCanvas.SetActive(false);
    }


    /// <summary>
    /// 切换场景
    /// </summary>
    private void LoadNextScene()
    {
        SteamVR_LoadLevel load = loadNextScene.GetComponent<SteamVR_LoadLevel>();
        load.levelName = "Menuem";
        load.Trigger();//切换场景
    }

}

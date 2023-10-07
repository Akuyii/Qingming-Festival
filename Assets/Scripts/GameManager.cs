using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public bool isAgain;
    private GameObject player;
    public Transform playerAgainPoint;
    public static GameManager _instance;

    private void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this);
    }

    private void OnDisable()
    {
        isAgain = true;
    }
    private void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 1) isAgain = true; 
        else
        {
            if (isAgain)
            {
                Debug.Log("isAgain = true");
                GameObject.Find("HTC").GetComponent<Animator>().enabled = true;
                GameObject.Find("Player").transform.position = GameObject.Find("PlayerAgainPoint").transform.position;
                GameObject.Find("Player").transform.rotation = GameObject.Find("PlayerAgainPoint").transform.rotation;
                isAgain = false;
            }
            if (GameObject.Find("HTC").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Over"))
            {
                GameObject.Find("HTC").GetComponent<Animator>().enabled = false;
            }
        }
        
    }
}

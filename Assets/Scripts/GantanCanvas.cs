using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GantanCanvas : MonoBehaviour
{
    public Transform Player;
    public float BlinkTime;
    private float timer;
    public Image image;

    private void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    private void Update()
    {
        transform.LookAt(Player);


        timer += Time.deltaTime*5f;

        if (timer >= BlinkTime)
        {
            image.color = new Color(255, 255, 255, 0);
            Invoke("invokeTime",0.2f);
        }
        else
        {
            image.color = new Color(255, 255, 255, 255);
        }

    }

    private void invokeTime()
    {
        timer = 0;
    }

}

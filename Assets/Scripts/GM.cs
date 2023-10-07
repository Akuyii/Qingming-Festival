using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("GameManager_zjh")==null) Instantiate(gameManager);
    }
}

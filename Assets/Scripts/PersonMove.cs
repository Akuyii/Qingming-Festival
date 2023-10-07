using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonMove : MonoBehaviour
{
    public Transform movePoint;
    public Transform resetPoint;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, movePoint.position) > 0.5f)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, Time.deltaTime * speed);
        }
        else
        {
            transform.position = resetPoint.position;
        }
    }
}

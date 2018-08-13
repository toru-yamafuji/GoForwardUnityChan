using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{

    private float scrollspeed = -0.03f;
    private float deadLine = -16;
    private float startLine = 15.8f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(scrollspeed, 0, 0);

        if (transform.position.x < deadLine)
        {
            transform.position = new Vector2(startLine, 0);
        }

    }
}

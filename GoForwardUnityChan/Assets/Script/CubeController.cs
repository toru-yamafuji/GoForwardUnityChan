using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    private float speed = -0.2f;

    private float deadLine = -10;

    private float isGround = -4.35f;

    private AudioSource audioSource;

    private bool audioBool = false;



    // Use this for initialization
    void Start()
    {

        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed, 0, 0);

        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < isGround)
        {
            if (audioBool == false)
            {
                audioSource.Play();
                audioBool = true;
            }
        }


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision1");
        if (other.gameObject.tag == "Cube")
        {
            Debug.Log("Collision2");
            audioSource.Play();
        }
    }

}

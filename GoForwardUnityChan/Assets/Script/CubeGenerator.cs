using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{

    public GameObject cubePrefab;

    private float delta = 0;
    private float span = 1.0f;

    private float genPosX = 12;

    private float offsetY = 0.3f;
    private float spaceY = 6.9f;

    private float offsetX = 0.5f;
    private float spaceX = 0.4f;

    private int maxBlockNum = 4;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        delta += Time.deltaTime;

        if (delta > span)
        {
            delta = 0;

            int n = Random.Range(1, maxBlockNum + 1);

            for (int i = 0; i < n; i++)
            {
                GameObject go = Instantiate(cubePrefab) as GameObject;
                go.transform.position = new Vector2(genPosX, offsetY + spaceY * i);
            }


            span = offsetX + spaceX * n;
        }



    }
}

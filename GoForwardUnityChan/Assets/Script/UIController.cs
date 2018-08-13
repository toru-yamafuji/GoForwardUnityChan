using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    private GameObject gameOverText;
    private GameObject runLengthText;

    private float len = 0;

    private float speed = 0.03f;

    private bool isGameOver = false;

    // Use this for initialization
    void Start()
    {

        gameOverText = GameObject.Find("GameOver");
        runLengthText = GameObject.Find("RunLength");

    }

    // Update is called once per frame
    void Update()
    {

        if (isGameOver == false)
        {
            len += speed;
        }

        runLengthText.GetComponent<Text>().text = "Disctance " + len.ToString("F2") + "m";

        if (this.isGameOver == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("GameScene");
            }
        }

    }

    public void GameOver()
    {
        gameOverText.GetComponent<Text>().text = "GameOver";
        isGameOver = true;
    }

}

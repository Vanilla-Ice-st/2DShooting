using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Control : MonoBehaviour
{

    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;
    GameObject toResult;

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.toResult.SetActive(true);
    }

    public void AddScore()
    {
        if (this.gameOverText.GetComponent<Text>().text != "GameOver")
        this.score += 10;
    }

    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
        this.toResult = GameObject.Find("Button_RESULT");
        this.toResult.SetActive(false);
    }

    void Update()
    {
        scoreText.GetComponent<Text> ().text = "Score:" + score.ToString("D4");
    }
}

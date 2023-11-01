using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float time = 30.0f;
    public Text timerText;
    public bool isTimeUp;

    void Start()
    {
        isTimeUp = false;
    }

    void Update()
    {
        if (0 < time)
        {
            time -= Time.deltaTime;
            timerText.GetComponent<Text>().text = "TIME:" + time.ToString("F1");
        }
        else if(time < 0)
        {
            isTimeUp = true;
        }

        if (isTimeUp)
        {
            GameObject.Find("Canvas").GetComponent<UI_Control>().GameOver();
        }
    }
}
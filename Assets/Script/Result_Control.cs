using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result_Control : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("ResultScene", LoadSceneMode.Single);
    }
}
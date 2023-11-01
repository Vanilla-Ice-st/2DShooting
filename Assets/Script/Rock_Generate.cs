using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_Generate : MonoBehaviour
{

    public GameObject Prefab_Rock;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeatingは、指定した関数を一定時間毎に呼び出す関数
        // InvokeRepeating("関数名,初回呼び出しまでの秒数,次回呼び出しまでの秒数)
        InvokeRepeating("GenerateRock", 1, 0.5f);
    }

    void GenerateRock()
    {
        Instantiate(Prefab_Rock, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock_Generate : MonoBehaviour
{

    public GameObject Prefab_Rock;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating�́A�w�肵���֐�����莞�Ԗ��ɌĂяo���֐�
        // InvokeRepeating("�֐���,����Ăяo���܂ł̕b��,����Ăяo���܂ł̕b��)
        InvokeRepeating("GenerateRock", 1, 0.5f);
    }

    void GenerateRock()
    {
        Instantiate(Prefab_Rock, new Vector3(-2.5f + 5 * Random.value, 6, 0), Quaternion.identity);
    }

}

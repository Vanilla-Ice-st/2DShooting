using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TO DO 作成しただけで何も使っていない。可能であればロケットが左下から右上に飛んで行くのを10秒おきくらいで行う処理を作る

public class Title_Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}

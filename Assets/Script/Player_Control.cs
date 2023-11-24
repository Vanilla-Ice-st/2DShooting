using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Control : MonoBehaviour
{
    //隕石との当たり判定
    private Rigidbody2D rigidBody;

    public string TagHitRock = "Rock";

    void Start()
    {
        //　ビルドでの表示速度を決めるflame設定。startはスクリプトの順番を問わず全てのスクリプトで最初に読み込まれるため暫定でここに記載
        Application.targetFrameRate = 60;

        rigidBody = GetComponent<Rigidbody2D>();
    }

    public GameObject Prefab_bullet;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(+0.1f, 0, 0);
        }
        // キー押下時に一回だけ
        // Instantiate関数は、第一引数にPrefab、第二引数にインスタンスを生成する位置、第三引数にはインスタンスの回転角を指定
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Prefab_bullet, transform.position, Quaternion.identity);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(TagHitRock))
        {
            other.gameObject.SetActive(false);
        }
    }

}

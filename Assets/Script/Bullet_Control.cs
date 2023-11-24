using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet_Control : MonoBehaviour
{
    [Header("爆発のオブジェクト")]
    public GameObject explosionPrefab;

    void Update()
    {
        transform.Translate(0, 0.5f, 0);

        // 一定距離を移動した弾の削除
        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Rock"))
        {
            // スコアの加算
            GameObject.Find("Canvas").GetComponent<UI_Control>().AddScore();

            // 爆発エフェクト
            GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
            Destroy(effect, 1.0f);
            Destroy(collider2D.gameObject);
            Destroy(gameObject);
        }
    }
}

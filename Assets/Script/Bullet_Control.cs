using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet_Control : MonoBehaviour
{
    [Header("�����̃I�u�W�F�N�g")]
    public GameObject explosionPrefab;

    void Update()
    {
        transform.Translate(0, 0.5f, 0);

        // ��苗�����ړ������e�̍폜
        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Rock"))
        {
            // �X�R�A�̉��Z
            GameObject.Find("Canvas").GetComponent<UI_Control>().AddScore();

            // �����G�t�F�N�g
            GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
            Destroy(effect, 1.0f);
            Destroy(collider2D.gameObject);
            Destroy(gameObject);
        }
    }
}

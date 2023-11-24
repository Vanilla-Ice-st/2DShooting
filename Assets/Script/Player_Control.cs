using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Control : MonoBehaviour
{
    //覐΂Ƃ̓����蔻��
    private Rigidbody2D rigidBody;

    public string TagHitRock = "Rock";

    void Start()
    {
        //�@�r���h�ł̕\�����x�����߂�flame�ݒ�Bstart�̓X�N���v�g�̏��Ԃ��킸�S�ẴX�N���v�g�ōŏ��ɓǂݍ��܂�邽�ߎb��ł����ɋL��
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
        // �L�[�������Ɉ�񂾂�
        // Instantiate�֐��́A��������Prefab�A�������ɃC���X�^���X�𐶐�����ʒu�A��O�����ɂ̓C���X�^���X�̉�]�p���w��
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

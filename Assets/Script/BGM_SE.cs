using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_SE : MonoBehaviour
{
    public bool DontDestroyEnable = true;

    void Start()
    {
        if (DontDestroyEnable)
        {
            DontDestroyOnLoad(this);
        }
        
    }
}

//���� �Q�lURL��https://qiita.com/hiroyuki7/items/b11496a3b72e89affdd0
//BGM��scene�J�ڎ��ɓr�؂�čĐ�����Ȃ����Ƃ̑΍�ɖ{�X�N���v�g���쐬
//�f�X�g���C���Ȃ��Ă������́H�i���[�v���Ȃ���Ό��ʉ��Ȃ񂩂͍Đ����I������珟��ɏ������́H
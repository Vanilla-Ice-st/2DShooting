using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TO DO �쐬���������ŉ����g���Ă��Ȃ��B�\�ł���΃��P�b�g����������E��ɔ��ōs���̂�10�b�������炢�ōs�����������

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

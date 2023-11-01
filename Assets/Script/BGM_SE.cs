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

//質問 参考URL→https://qiita.com/hiroyuki7/items/b11496a3b72e89affdd0
//BGMがscene遷移時に途切れて再生されないことの対策に本スクリプトを作成
//デストロイしなくてもいいの？（ループしなければ効果音なんかは再生が終わったら勝手に消されるの？
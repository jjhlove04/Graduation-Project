using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager _instance = new DataManager();
    
        //플레이어 스테이터스
        [Header("플레이어 스테이터스")]
        [Tooltip("플레이어 체력")]
        public float playerHp;
        [Tooltip("플레이어 마나")]
        public float playerMp;
        [Tooltip("플레이어 공격력")]
        public float playerAD;
        [Tooltip("플레이어 마법공격력")]
        public float playerAP;
        [Tooltip("플레이어 경험치 드롭률")]
        public float playerDropExp;
        [Tooltip("플레이어 골드 드롭률")]
        public float playerDropGold;

    private void Awake() {
        _instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
}

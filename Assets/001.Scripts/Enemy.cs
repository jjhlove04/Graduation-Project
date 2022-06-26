using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float enemyHp;
    private float enemyAtk;
    private int enemyDef;
    private int dropGold;
    private int dropExp;

    public EnemyData _enemyData;
    public EnemyData EnemyData {set { _enemyData = value;}}

    private void Awake() {
        EnemyInit();
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.A))
        {
            EnemtUpGrade();
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("체력 : " + enemyHp);
            Debug.Log("공격력 : " +enemyAtk);
            Debug.Log("방어력 : " +enemyDef);
            Debug.Log("드롭골드 : " +dropGold);
            Debug.Log("드롭경험치 : " +dropExp);
        }
    }
    public void EnemyInit()
    {
        enemyHp = _enemyData.EnemyHp;
        enemyAtk = _enemyData.EnemyAtk;
        enemyDef = _enemyData.EnemyDef;
        dropGold = _enemyData.DropGold;
        dropExp = _enemyData.DropExp;
        
    }

    public void EnemtUpGrade()
    {
        enemyHp += _enemyData.EnemyHpInc;
        enemyHp = Mathf.Round(enemyHp*10) * 0.1f;
        enemyAtk += _enemyData.EnemyAtkInc;
        enemyAtk = Mathf.Round(enemyAtk*10)*0.1f;
        enemyDef += _enemyData.EnemyDefInc;
        dropGold += _enemyData.DropGoldInc;
        dropExp += _enemyData.DropExpInc;
        

    }

}

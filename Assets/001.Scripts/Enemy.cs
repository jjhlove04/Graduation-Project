using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : LivingEntity
{
    private float enemyHp;
    private float enemyAtk;
    private int enemyDef;
    private int dropGold;
    private int dropExp;

    public EnemyData _enemyData;
    public EnemyData EnemyData {set { _enemyData = value;}}

    public enum EnemyState{
        Idle,
        Attack,
        Damaged,
        Death
    }

    EnemyState enemyState;
    private void Awake() {
        EnemyInit();
    }

    private  void Start() {
        StageManager._instance.onNextStage.AddListener(EnemyUpGrade);
    }
    private void Update() {

    }
    ///<summary> 적 스탯 부여 함수 </summary>
    public void EnemyInit()
    {
        enemyHp = _enemyData.EnemyHp;
        enemyAtk = _enemyData.EnemyAtk;
        enemyDef = _enemyData.EnemyDef;
        dropGold = _enemyData.DropGold;
        dropExp = _enemyData.DropExp;
        
    }

    ///<summary> 적 업그레이드 실행 </summary>
    public void EnemyUpGrade()
    {
        enemyHp += _enemyData.EnemyHpInc;
        enemyHp = Mathf.Round(enemyHp*10) * 0.1f;
        enemyAtk += _enemyData.EnemyAtkInc;
        enemyAtk = Mathf.Round(enemyAtk*10)*0.1f;
        enemyDef += _enemyData.EnemyDefInc;
        dropGold += _enemyData.DropGoldInc;
        dropExp += _enemyData.DropExpInc;

        //스탯 오른거 확인
        Debug.Log("체력 : " + enemyHp);
        Debug.Log("공격력 : " +enemyAtk);
        Debug.Log("방어력 : " +enemyDef);
        Debug.Log("드롭골드 : " +dropGold);
        Debug.Log("드롭경험치 : " +dropExp);
        
    }
    ///<summary> 적 스택 부여 함수 </summary>
    public void Die(){
        StageManager._instance.CheckEnemyCount();
        gameObject.SetActive(false);
    }
    
}

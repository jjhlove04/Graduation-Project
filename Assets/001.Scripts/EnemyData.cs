using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyData",menuName ="Enemy")]
public class EnemyData : ScriptableObject
{
    public List<EnemyStatusData> _enemyList = new List<EnemyStatusData>();
    [System.Serializable]
    public class EnemyStatusData
    {
        public float _enemyHp;
        public float _enemyATK;
        public int _dropGlod;
        public int _dropEXP;
        
        public EnemyType _enemyType;
    }

    public enum EnemyType
    {
        boss,
        common,
        rare,
        epic
    }

}

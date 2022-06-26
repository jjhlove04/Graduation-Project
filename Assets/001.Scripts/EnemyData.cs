using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="EnemyData",menuName ="Enemy")]
public class EnemyData : ScriptableObject
{
        private GameObject _enemy;

        public float EnemyHp {get {return _enemyHp;}}
        [SerializeField]private float _enemyHp;

        public float EnemyHpInc {get {return _enemyHpInc;}}
        [SerializeField]private float _enemyHpInc;

        public float EnemyAtk {get {return _enemyAtk;}}
        [SerializeField]private float _enemyAtk;

        public float EnemyAtkInc {get {return _enemyAtkInc;}}
        [SerializeField]private float _enemyAtkInc;

        public int EnemyDef {get { return _enemyDef; }}
        [SerializeField]private int _enemyDef;       

        public int EnemyDefInc {get{return _enemyDefInc;}}
        [SerializeField]private int _enemyDefInc;
        
        public int DropGold {get{return _dropGlod;}}
        [SerializeField]private int _dropGlod;
        
        public int DropGoldInc {get {return _dropGlodInc;}}
        [SerializeField]private int _dropGlodInc;
        
        public int DropExp {get {return _dropEXP; }}
        [SerializeField]private int _dropEXP;
        
        public int DropExpInc {get { return _dropEXPInc;}}
        [SerializeField]private int _dropEXPInc;
        
        public EnemyTypes EnemyType {get {return _enemyTypes; }}
        [SerializeField]private EnemyTypes _enemyTypes;

    public enum EnemyTypes
    {
        boss,
        common,
        rare,
        epic
    }

}

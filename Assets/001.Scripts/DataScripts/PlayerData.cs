using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PlayerData",menuName ="Player")]
public class PlayerData : ScriptableObject
{
        public float PlayerHp {get {return _playerHP;}}
        [SerializeField]private float _playerHP;
        public float PlayerHpInc {get {return _playerHpInc;}}
        [SerializeField]private float _playerHpInc;
        public float PlayerMp {get {return _playerMP;}}
        [SerializeField]private float _playerMP;

        public float PlayerMpInc {get {return _playerMpInc;}}
        [SerializeField]private float _playerMpInc;

        public float PlayerAtk {get {return _playerAtk;}}
        [SerializeField]private float _playerAtk;

        public float PlayerAtkInc {get {return _playerAtkInc;}}
        [SerializeField]private float _playerAtkInc;
        public float PlayerAp {get {return _playerAp;}}
        [SerializeField]private float _playerAp;

        public float PlayerApInc {get {return _playerApInc;}}
        [SerializeField]private float _playerApInc;

        public int PlayerDef {get { return _playerDef; }}
        [SerializeField]private int _playerDef;       

        public int PlayerDefInc {get{return _playerDefInc;}}
        [SerializeField]private int _playerDefInc;
        public float HaveGold {get{return _haveGlod;}}
        [SerializeField]private float _haveGlod;
        
        public float GoldInc {get {return GlodInc;}}
        [SerializeField]private float GlodInc;
        
        public float HaveEXP {get {return _haveExp; }}
        [SerializeField]private float _haveExp;
        
        public float ExpInc {get { return _EXPInc;}}
        [SerializeField]private float _EXPInc;
}

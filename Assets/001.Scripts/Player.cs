using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : LivingEntity
{
    //현재 게임에서 사용될 체력
    float _playerCurHp; 
    //현재 게임에서 사용될 마나
    float _playerMaxMp;
    float _playerCurMp;

    
    float _playerAD;
    float _playerAP;

    
    float _playerMaxExp;
    float _playerCurExp;
    long _curHaveGold = 0;
    public GameObject detectPos;
    private Animator _playerAnimator;
    public int _playerRange;

    //플레이어의 데이터를 보낼곳
    public float playerHp {get {return startingHealth; }}
    public float playerMp {get{return _playerMaxMp; }}
    public float playerAd {get{return _playerAD; }}
    public float playerAp {get{return _playerAP; }}
    public float playerExp {get{return _playerMaxExp; }}
    int enemyLayer;

    public PlayerData _playerData;
    public PlayerData PlayerData {set {_playerData = value; }}
    
    [SerializeField] LayerMask _playerDetectedLayer;
    private void Awake()
    {
        playerInit();
    }
        void Start()
    {
        enemyLayer = 1 << LayerMask.NameToLayer("Enemy");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        DetectedEnemy();
    }

    public void DetectedEnemy()
    {
        Collider2D hitEnemie = Physics2D.OverlapCircle(detectPos.transform.position,_playerRange, enemyLayer);
        Debug.Log(hitEnemie.name);
    }

    //플레이어 정보 입력
    void playerInit()
    {
        startingHealth = _playerData.PlayerHp;
        _playerMaxMp = _playerData.PlayerMp;
        _playerAD = _playerData.PlayerAtk;
        _playerAP = _playerData.PlayerAp;
        _playerMaxExp = _playerData.HaveEXP;
    }
    public void PlayerLevelUp()
    {
        startingHealth += _playerData.PlayerHpInc;
        _playerMaxMp += _playerData.PlayerMpInc;
        _playerAD += _playerData.PlayerAtkInc;
        _playerAP += _playerData.PlayerApInc;
        //레벨업시 업그레이드 된 계수로 회복
        _playerCurHp = startingHealth;
        _playerCurMp = _playerMaxMp;
    }


    public void UPHP()
    {
        startingHealth += 5;
    }
    public void UPMP()
    {
        _playerMaxMp += 5;
    }
    public void UPAD()
    {
        _playerAD += 2;
    }
    public void UPAP()
    {
        _playerAP += 3; 
    }
    public void UPEXP()
    {
        _playerMaxExp += 0.5f;
    }

    








    private void OnDrawGizmos() {
        Gizmos.DrawWireCube(detectPos.transform.position,new Vector2(5,2));
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float _playerHp;
    float _playerMp;
    float _playerAD;
    float _playerAP;
    private Animator _playerAnimator;
    
    [SerializeField] LayerMask _playerDetectedLayer;
    private void Awake()
    {
        playerInit();
    }
    void Start()
    {

    }

    void Update()
    {
        Debug.DrawRay(this.transform.position, this.transform.right,Color.green,2);
    }

    public void DetectedEnemy()
    {
        RaycastHit hitInfo;
        if(Physics.Raycast(this.transform.position, this.transform.right, out hitInfo, 2,_playerDetectedLayer))
        {
            Debug.Log(hitInfo.transform.name);
        }
    }

    //플레이어 정보 입력
    void playerInit()
    {
        _playerHp = DataManager._instance.playerHp;
        _playerMp = DataManager._instance.playerMp;
        _playerAD = DataManager._instance.playerAD;
        _playerAP = DataManager._instance.playerAP;
    }
}

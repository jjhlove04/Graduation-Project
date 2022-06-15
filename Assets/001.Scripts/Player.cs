using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float _playerHp;
    public float _playerMp;
    public float _playerAD;
    public float _playerAP;
    private Animator _playerAnimator;
    
    [SerializeField] LayerMask _playerDetectedLayer;
    private void Awake()
    {
        
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
}

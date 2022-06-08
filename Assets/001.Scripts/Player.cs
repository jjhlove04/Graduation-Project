using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator _playerAnimator;
    private void Awake()
    {
        _playerAnimator.SetBool("IsAtk", true);
    }
    void Start()
    {

    }


    void Update()
    {

    }
}

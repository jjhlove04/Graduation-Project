using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class LivingEntity : MonoBehaviour, IDamageable
{
  public float startingHealth;
  public float health { get; protected set;}
  public bool dead { get; protected set;}

  public event Action OnDeath;

//0.1초안에 들어오는 중복데미지는 전부 무시
  private const float minTimeBetDamaged = 0.1f;
  private float lastDamageTime;

  protected bool IsInvulnerable
  {
    get
    {
      //마지막으로 공격을 당한 시점에서 0,1초가 지났는지 확인이 된다면 공격 
      //가능한 상태 아니면 true 반환해서 공격 받지 못하게 한다
      if(Time.time >= lastDamageTime + minTimeBetDamaged) return false;

      return true;
    }
  }
  protected virtual void OnEnable()
  {
    dead = false;
    health = startingHealth;
  }

  public virtual bool ApplyDamage(DamageMessage damageMessage)
  {
    if(IsInvulnerable||dead) 
    {
      return false;
    }

    lastDamageTime = Time.time;
    health -= damageMessage.damageAmount;
    
    if(health <= 0) Die();

    return true; 
  }

  public virtual void RestoreHealth(float heal)
  {
    if(dead) return;
    heal+= heal;
  }

  public virtual void Die()
  {
    if(OnDeath != null) OnDeath();
    dead = true;
  }






}
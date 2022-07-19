using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StageManager : MonoBehaviour
{
    public static StageManager _instance = new StageManager();
    public int currentStage = 1;
    public GameObject[] enemyCount;

    public UnityEvent onNextStage;

    private void Awake() {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
    }
    
    private void Update() {
        if(Input.GetKeyDown(KeyCode.C))
        {
            CheckEnemyCount();
            StageUp();
        }
    }

    public void CheckEnemyCount()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log(enemyCount.Length);
    }

    public void StageUp(){
        if(enemyCount.Length == 0)
        {
            onNextStage?.Invoke();
        }
    }
}

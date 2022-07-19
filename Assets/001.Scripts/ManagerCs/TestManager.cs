using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    
    private ObjectPool _objectPool;
    public GameObject enemyPrefab;
    public GameObject enemyContaierPos;
    
    private void Awake() {
        _objectPool = GetComponent<ObjectPool>();
    }
    private void Start() {
        CreateEnemyObject();
    }

    public void CreateEnemyObject()
    {
        GameObject[] enemyContainer = new GameObject[7];
        for(int i = 0; i < enemyContainer.Length; i++)
        {
            
            enemyContainer[i] = _objectPool.GetObject(enemyPrefab);
            enemyContainer[i].SetActive(false);
            enemyContainer[i].transform.SetParent(enemyContaierPos.transform);
        }
        
    }
}

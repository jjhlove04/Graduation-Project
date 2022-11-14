using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    
    public static DataManager _instance = new DataManager();
    Player _playerInfo;
    public float _inputPlayerMp;
    public float _inputPlayerAd;
  private void Awake() {
    _instance = this;
  }
    private void Start() {
        
    }
}

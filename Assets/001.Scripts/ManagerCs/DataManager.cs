using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager _instance = new DataManager();

    public float _inputPlayerHp;
  private void Awake() {
    _instance = this;
  }
    private void Start() {
      
    }
}

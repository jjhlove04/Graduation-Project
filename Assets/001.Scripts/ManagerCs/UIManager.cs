using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{   
    Player _playerInfo;

    public static UIManager _instance = new UIManager();

    [Header("상단 UI 관련 패널")]
    public Text _goldText;
    public int _goldAmount;

    [Header("플레이어 업그레이드 패널")]
    [Tooltip("업그레이드 버튼")]
    public Button[] _upGradeBtns;
    [Space(20)]

    [Tooltip("업그레이드 버튼 비용 텍스트")]
    public  Text[] _upGradePrices;
    [Space(20)]
    int _hpUpPrice = 10;
    int _mpUpPrice = 10;
    int _adUpPrice = 10;
    int _apUpPrice = 10;
    int _expUpPrice = 10;

    [Tooltip("Hp업그레이드")]
    public Text _upGradeHpText;

    [Tooltip("Mp업그레이드")]
    public Text _upGradeMpText;

    [Tooltip("공격력 업그레이드")]
    public Text _upGradeADText;

    [Tooltip("마법 공격력 업그레이드")]
    public Text _upGradeAPText;

    [Tooltip("골드 업그레이드")]
    public Text _upGradeGoldText;

    [Tooltip("경험치 업그레이드")]
    public Text _upGradeExpText;

    [Header("플레이어 전투 패널 관련")]
    public Slider _playerHpBar;
    public Slider _playerMpBar;
    public Slider _playerExpBar;
    private void Awake() {
        _instance = this;
        _playerInfo = FindObjectOfType<Player>();
        UIInit();
        for(int i = 0; i < _upGradeBtns.Length; i++)
        {
            int numIndex = 0;
            _upGradeBtns[i].onClick.AddListener(()=> UPGRADE(numIndex));
        }
        _upGradePrices[0].text = $"{_hpUpPrice}";
        _upGradePrices[1].text = $"{_mpUpPrice}";
        _upGradePrices[2].text = $"{_adUpPrice}";
        _upGradePrices[3].text = $"{_apUpPrice}";
        _upGradePrices[4].text = $"{_expUpPrice}";
    }
    void Start()
    {
        UIInit();
    }

    // Update is called once per frame
    void Update()
    {
        //_goldText.text = string.Format(("{0:#,###0}",_goldAmount).ToString());
    }

    public void UIInit()
    {
        
        float hp = _playerInfo.playerHp;
        float mp = _playerInfo.playerMp;
        float ad = _playerInfo.playerAd;
        _upGradeHpText.text = $"Hp 증가 {hp} -> <color=#A64B2A>{hp + 5}</color>";
        _upGradeMpText.text = $"Mp 증가 {mp} -> <color=#A64B2A>{mp + 5}</color>";
        _upGradeADText.text = $"AD 증가 {ad} -> <color=#A64B2A>{ad + 2}</color>";
    }

    public void UPGRADE(int index)
    {
            //체력 업그레이드
            if(index == 0)
            {
            _playerInfo.UPHP();
            _hpUpPrice = Mathf.RoundToInt(_hpUpPrice * 1.2f);
            _upGradePrices[0].text = $"{_hpUpPrice}";
            Debug.Log(_hpUpPrice);
            
            }  
            //마나 업그레이드
            if(index == 1)
            {
                _playerInfo.UPMP();
                _mpUpPrice = Mathf.RoundToInt(_mpUpPrice * 1.2f);
                _upGradePrices[1].text = $"{_mpUpPrice}";
            }
            //평타 공격력 업그레이드
            if(index == 2)
            {
                _playerInfo.UPAD();
                _adUpPrice = Mathf.RoundToInt(_adUpPrice * 1.2f);
                _upGradePrices[2].text = $"{_adUpPrice}";
            }
        
    }
}

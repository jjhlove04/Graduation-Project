using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="SkillData",menuName ="Skills")]
public class SkillData : ScriptableObject
{
    public List<Skills> _skillList = new List<Skills>();
    [System.Serializable]
    public class Skills
    {
        public GameObject _skill;
        public string _skillName;
        public float _skillDamage;
        public float _skillUseMana;
        public int _skillLevel;
        public int _skillPrice;
    }
}

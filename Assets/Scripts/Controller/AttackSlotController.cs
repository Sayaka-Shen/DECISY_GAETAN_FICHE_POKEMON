using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackSlotController : MonoBehaviour
{
    [SerializeField] private Text _txtName;
    [SerializeField] private Button _atkButton;

    private AttackData _data;
    
    void Awake()
    {
        _atkButton = GetComponent<Button>();
        _txtName = GetComponentInChildren<Text>();
    }

    public void Init(string name)
    {
        _data = DatabaseManager.GetInstance().GetAttackData(name);

        _txtName.text = _data.name;
    }
}

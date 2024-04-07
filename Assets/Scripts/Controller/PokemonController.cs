using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PokemonController : MonoBehaviour
{
    [SerializeField] private Text _txtName;
    [SerializeField] private Image _imgIcon;
    
    [Header("PV")]
    [SerializeField] private Text _txtPV;

    [SerializeField]private List<AttackSlotController> _atkSlot = new();
    
    public PokemonData _data;
    public int _currentLife;

    public void Init(PokemonData data)
    {
        _data = data;
        _txtName.text = data.name;
        _imgIcon.sprite = data.icon;
        
        _currentLife = data.statsBase.pv;

        foreach (AttackSlotController slot in _atkSlot)
        {
            var id = _atkSlot.IndexOf(slot);
            
            slot.Init(data.attacks[id].name);
        }
        
        updatePV();
    }

    public void updatePV()
    {
        _txtPV.text = $"{_currentLife} / {_data.statsBase.pv}";
    }
}

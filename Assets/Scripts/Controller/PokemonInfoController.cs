using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PokemonInfoController : MonoBehaviour
{
    [SerializeField] private Image _imgIcon;
    [SerializeField] private Text _txtName;
    [SerializeField] private Text _size;
    [SerializeField] private Text _weight;
    [SerializeField] private Text _type;
    [SerializeField] private Text _caption;

    [SerializeField] private Text _pv;
    [SerializeField] private Text _atk;
    [SerializeField] private Text _def;
    [SerializeField] private Text _atkSpe;
    [SerializeField] private Text _defSpe;
    [SerializeField] private Text _speed;

    [SerializeField] private TextMeshProUGUI choosePoké;
    [SerializeField] private Canvas fiche;
    [SerializeField] private Canvas battle;

    private int id = 0;
    private PokemonData _data;
    public List<PokemonData> _pokemonSelected = new();
    
    private DatabaseManager _databaseMgr;
    
    private void Awake()
    {
        _databaseMgr = FindObjectOfType<DatabaseManager>();
    }

    private void Start()
    {
        _data = _databaseMgr.GetData(id);

        UpdateInfo(_data);
    }

    public void GetNextPokemon()
    {
        if (id >= _databaseMgr._database.datas.Count - 1)
        {
            id = 0;
        }
        else
        {
            id++;
        }

        _data = _databaseMgr.GetData(id);
        UpdateInfo(_data);
    }
    

    private void UpdateInfo(PokemonData data)
    {
        /* data.DisplayName(); */
        
        _imgIcon.sprite = data.icon;
        _txtName.text = $"Nom : " + data.name;
        _size.text = $"Taille : " + data.pokeInfo.size.ToString() + " m";
        _weight.text = $"Poids : " + data.pokeInfo.weight.ToString() + " kg";
        _type.text = $"Type Pokémon : " + data.pokeInfo.types;
        _caption.text = data.caption;
        
        _pv.text = $"Pv : " + data.statsBase.pv.ToString();
        _atk.text = $"Attack : " + data.statsBase.atk.ToString();
        _def.text = $"Defense : " + data.statsBase.def.ToString();
        _atkSpe.text = $"Attack Special : " + data.statsBase.atkSpe.ToString();
        _defSpe.text = $"Defense Special : " + data.statsBase.defSpe.ToString();
        _speed.text = $"Speed : " + data.statsBase.speed.ToString();
    }

    public void choosePokemon()
    {
        if (_databaseMgr._database.datas[id].pokeInfo.isSelected == false)
        {
            _databaseMgr._database.datas[id].pokeInfo.isSelected = true;
            _pokemonSelected.Add(_databaseMgr._database.datas[id]);

            if (_pokemonSelected.Count > 2)
            {
                Debug.Log("You can't add more than 2 Pokémon !");
                fiche.gameObject.SetActive(false);
                battle.gameObject.SetActive(true);
            }
            else
            {
                Debug.Log($"{_databaseMgr._database.datas[id].name} à été séléctionné.");
            }
        }
        else
        {
            _databaseMgr._database.datas[id].pokeInfo.isSelected = false;
        }
    }
}

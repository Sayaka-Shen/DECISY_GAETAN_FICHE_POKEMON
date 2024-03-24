using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Random = Unity.Mathematics.Random;

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

    private int currentLife;
    private int statPoint;
    

    private int id = 0;
    private PokemonData _data;
    
    private DatabaseManager _databaseMgr;

    enum pokeType
    {
        Normal, 
        Feu,    
        Eau, 
        Électrik, 
        Plante, 
        Glace, 
        Combat, 
        Poison, 
        Sol, 
        Vol, 
        Psy, 
        Insecte, 
        Roche, 
        Spectre, 
        Dragon, 
        Ténèbres, 
        Acier, 
        Fée
    }
    
    private void Awake()
    {
        _databaseMgr = FindObjectOfType<DatabaseManager>();
    }

    private void Start()
    {
        _data = _databaseMgr.GetData(id);

        UpdateInfo(_data);

        StartCoroutine(DelayAttack());
        
        InitCurrentLife(_data);
        InitStatsPoint(_data);
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
        _imgIcon.sprite = data.icon;
        _txtName.text = $"Nom : " + data.name;
        _size.text = $"Taille : " + data.pokeInfo.size.ToString() + " m";
        _weight.text = $"Poids : " + data.pokeInfo.weight.ToString() + " kg";
        _type.text = $"Type Res : " + data.pokeInfo.resType + ", Type Weak : " + data.pokeInfo.weakType;
        _caption.text = data.pokeInfo.caption;
        
        _pv.text = $"Pv : " + data.statsBase.pv.ToString();
        _atk.text = $"Attack : " + data.statsBase.atk.ToString();
        _def.text = $"Defense : " + data.statsBase.def.ToString();
        _atkSpe.text = $"Attack Special : " + data.statsBase.atkSpe.ToString();
        _defSpe.text = $"Defense Special : " + data.statsBase.defSpe.ToString();
        _speed.text = $"Speed : " + data.statsBase.speed.ToString();
    }
    
    private void TakeDamage(int damage, string type)
    {
        if (currentLife > 0)
        {
            if(damage <= 0)
            {
                Debug.Log("Les damage ne peuvent pas être négatif.");
            }
            else
            {
                if (Array.Exists(_data.pokeInfo.weakType, element => element == type))
                {
                    currentLife -= damage * 2;
                }
                else if(Array.Exists(_data.pokeInfo.resType, element => element == type))
                {
                    currentLife -= damage / 2;
                }
                else
                {
                    currentLife -= damage;
                }
            }   
        }

        if (currentLife <= 0)
        {
           Debug.Log("Le pokémon est mort.");
        }

        if (damage > currentLife)
        {
            currentLife = 0;
        }
    }

    private void AttackOpponent(PokemonData data)
    {
        if (currentLife > 0 && _databaseMgr.GetData(2).statsBase.pv > 0)
        {
            TakeDamage(data.statsBase.atk, pokeType.Plante.ToString());
        }

        if (currentLife <= 0)
        {
            Debug.Log("Votre Pokémon ne peut plus attaquer !");
        }
    }
    
    private void InitCurrentLife(PokemonData data)
    {
        currentLife = data.statsBase.pv;
    }

    private void InitStatsPoint(PokemonData data)
    {
        statPoint = data.statsBase.pv + data.statsBase.atk + data.statsBase.def;
    }

    private bool IsPokemonAlive()
    {
        return currentLife <= 0;
    }

    private IEnumerator DelayAttack()
    {
        
        yield return new WaitForSeconds(1.25f);
        AttackOpponent(_data);
    }
}

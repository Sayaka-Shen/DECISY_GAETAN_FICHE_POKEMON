using System;   
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class DatabaseManager : MonoBehaviour
{
    public PokemonDataBase _database;

    public PokemonData GetData(int id)
    {
        return _database.datas[id];
    }

    private void Start()
    { 
        /* _database.CreateData(); */
    } 
}

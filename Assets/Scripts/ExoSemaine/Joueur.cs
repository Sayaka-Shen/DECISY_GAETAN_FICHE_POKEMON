using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    public string Nom;
    public int id;
    public int ip;

    public static int nbConnectedPlayers = 0;

    public void Start()
    {
        nbConnectedPlayers++; 
    }

    public void OnDisable()
    {
        nbConnectedPlayers--;
        
        Debug.Log($"Nombre de joueur : {nbConnectedPlayers}.");
    }
}

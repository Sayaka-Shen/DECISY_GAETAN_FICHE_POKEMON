using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueurManager : MonoBehaviour
{
    public GameObject joueurPrefab;

    public void CreatePlayer()
    {
       var newPlayer = Instantiate(joueurPrefab);
       newPlayer.AddComponent<Joueur>();
       
       Debug.Log($"Nombre de joueur connecter : {Joueur.nbConnectedPlayers}");
    }
}

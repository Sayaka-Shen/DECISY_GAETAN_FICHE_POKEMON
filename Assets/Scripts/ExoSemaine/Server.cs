using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Server
{
    public static string name;
    public static int ip;
    public static List<OnlinePlayer> onlinePlayers = new List<OnlinePlayer>();
    

    public static void DisplayOnlinePlayersInfos()
    {
        foreach (var players in onlinePlayers)
        {
            Debug.Log($"Le nom du joueur {players.name}, son ip est {players.ip}, son id est {players.id} et il a {players.ping} ");
        }
    }
}

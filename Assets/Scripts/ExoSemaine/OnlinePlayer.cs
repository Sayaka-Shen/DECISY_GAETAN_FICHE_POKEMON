using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlinePlayer : MonoBehaviour
{
    public string name;
    public int id;
    public int ip;
    public float ping;
    
    public OnlinePlayer(string name, int id, int ip, float ping)
    {
        this.name = name;
        this.id = id;
        this.ip = ip;
        this.ping = ping;
    }

    public void Start()
    {
        OnlinePlayer player1 = new OnlinePlayer("David", 455, 1220045, 12);
        OnlinePlayer player2 = new OnlinePlayer("Jérôme", 630, 459034, 35);
        
        Server.onlinePlayers.Add(player1);
        Server.onlinePlayers.Add(player2);
        
        Server.DisplayOnlinePlayersInfos();
    }
}

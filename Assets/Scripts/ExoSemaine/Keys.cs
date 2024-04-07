using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : Collectable
{
    public override void OnCollect()
    {
        Debug.Log($"Pièces récupérés !");
    }
}

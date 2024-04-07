using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Candy : MonoBehaviour
{
    public abstract void WriteCandyType();

    public void Start()
    {
        Caramel caramel1 = new Caramel();
        Chocolate chocolate1 = new Chocolate();
        Gummies gummies1 = new Gummies();

        Candy[] candies = {gummies1, chocolate1, caramel1};

        foreach (var candy in candies)
        {
            candy.WriteCandyType();
        }
    }
}

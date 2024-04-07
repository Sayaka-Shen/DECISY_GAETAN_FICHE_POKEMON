using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chien : Animal
{
    public override void EmitSound()
    {
        Debug.Log("Woof");
    }
}

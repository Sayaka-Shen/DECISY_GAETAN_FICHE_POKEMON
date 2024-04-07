using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chat : Animal
{
    public override void EmitSound()
    {
        Debug.Log("Miaou");
    }
}

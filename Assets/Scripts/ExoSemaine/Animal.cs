    using System;
using System.Collections;
using System.Collections.Generic;using UnityEditor.Compilation;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public abstract void EmitSound();

    public void Start()
    {
        Chat chat1 = new Chat();
        Chien chien1 = new Chien();
        
        chat1.EmitSound();
        chien1.EmitSound();
    }
}

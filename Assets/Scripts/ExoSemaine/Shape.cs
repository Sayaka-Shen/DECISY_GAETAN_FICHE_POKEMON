using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public virtual void WriteShape()
    {
        Debug.Log("Triangle");
    }

    public void Start()
    {
        Circle circle1 = new Circle();
        Square square1 = new Square();
        
        square1.WriteShape();
    }
}

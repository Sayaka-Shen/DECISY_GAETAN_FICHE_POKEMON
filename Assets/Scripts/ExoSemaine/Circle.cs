using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    public override void WriteShape()
    {
        base.WriteShape();
        Debug.Log("Cercle");
    }
}

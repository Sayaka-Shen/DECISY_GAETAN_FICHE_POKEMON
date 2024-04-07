using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Circle
{
    public override void WriteShape()
    {
        base.WriteShape();
        Debug.Log("Carré");
    }

}

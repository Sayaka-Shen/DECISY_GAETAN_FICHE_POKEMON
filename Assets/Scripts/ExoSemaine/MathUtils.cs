using System;
using UnityEngine;

public class MathUtils : MonoBehaviour
{
    public static int Sum()
    {
        return 2 + 2;
    }

    public static int Substract()
    {
        return 8 - 2;
    }

    public static int Multiply()
    {
        return 4 * 7;
    }

    public void Start()
    {
        Debug.Log(Multiply());
        Debug.Log(Substract());
        Debug.Log(Sum());
    }
}

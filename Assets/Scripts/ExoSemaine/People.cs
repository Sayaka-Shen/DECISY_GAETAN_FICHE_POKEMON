using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : MonoBehaviour
{
    public string name;
    public int age;

    public void Start()
    {
        Employee employee1 = new Employee();
        employee1.name = "Pedro";
        employee1.age = 35;
        employee1.number = 100;
        
        Debug.Log($"Mon employé s'appelle {employee1.name}, il a {employee1.age} ans et son nombre dans l'entreprise est {employee1.number}.");
    }
}

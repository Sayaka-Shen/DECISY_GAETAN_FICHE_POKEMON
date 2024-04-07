using System;
using UnityEngine;

public class ConfigManager : MonoBehaviour
{
    public string name = "David";
    public string langue = "Français";
    public float height = 1.90f;
    public float width = 50.8f;
    
    private static ConfigManager instance;
    
    private ConfigManager() {}    
    
    public static ConfigManager GetInstance()
    {
        if (instance == null)
        {
            instance = new ConfigManager();
        }

        return instance;
    }

    public void Start()
    {
        instance = this;
        
        Debug.Log(ConfigManager.GetInstance().name + " " + ConfigManager.GetInstance().langue + " " + ConfigManager.GetInstance().height + " " + ConfigManager.GetInstance().width);
        
        GetInstance().name = "James";
        GetInstance().langue = "Anglais";
        GetInstance().height = 1.80f;
        GetInstance().width = 40.5f;

        Debug.Log(ConfigManager.GetInstance().name + " " + ConfigManager.GetInstance().langue + " " + ConfigManager.GetInstance().height + " " + ConfigManager.GetInstance().width);
    }
}

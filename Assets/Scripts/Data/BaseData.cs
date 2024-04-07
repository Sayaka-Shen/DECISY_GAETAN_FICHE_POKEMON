using UnityEngine;

[System.Serializable]
public class BaseData
{
    public string name;
    [TextArea]public string caption;

    public virtual void DisplayName()
    {
        Debug.Log("Base : " + name);
    }
    
    public BaseData(string name, string caption)
    {
        this.name = name;
        this.caption = caption;
    }
}

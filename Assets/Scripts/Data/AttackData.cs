using UnityEngine;

[System.Serializable]
public class AttackData : BaseData
{
    public enum Categories
    {
        PHYSICAL,
        SPECIAL,
        STATUT,
    }
    
    public Categories category = Categories.PHYSICAL;
    public TYPES types;
    public int degat;
    
    public AttackData(string name, string caption) : base(name, caption)
    {
        this.name = name;
        this.caption = caption;
    }
    
    
    /* public override void DisplayName()
    {
        Debug.Log("Attaque : " + name);
        base.DisplayName();
    } */
}

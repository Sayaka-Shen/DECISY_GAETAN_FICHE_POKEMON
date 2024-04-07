using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
   public string name;
   public int id;

   public abstract void OnCollect();
}

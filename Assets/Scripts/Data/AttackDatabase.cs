using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewAttackDatabase", menuName = "Database/Attack", order = 0)]
public class AttackDatabase : ScriptableObject
{
    public List<AttackData> datas = new();
}

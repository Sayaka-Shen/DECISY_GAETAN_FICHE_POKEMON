using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public static DatabaseManager instance;
    
    public PokemonDataBase _database;
    public AttackDatabase _atkDatabase;

    public PokemonData GetData(int id)
    {
        var max = _database.datas.Count;
        id = id < 0 ? max - 1 : id >= max ? 0 : id;
        
        return _database?.datas[id];
    }

    public AttackData GetAttackData(string name)
    {
        return _atkDatabase?.datas.Find(x => x.name.ToLower().Contains(name.ToLower()));
    }

    private void Awake ()
    { 
        _database.initData();
        /* _database.CreateData(); */
    }

    public static DatabaseManager GetInstance()
    {
        if (instance == null)
        {
            instance = new();
        }
        
        return instance;
    }
}

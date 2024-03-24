using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "DataBase/Pokemon", order = 0)]
public class PokemonDataBase : ScriptableObject
{
    public List<PokemonData> datas = new();

    public void initData()
    {
        datas.RemoveAll(data => data.pokeInfo.idPoke <= 0);
    }
    
    /* public void CreateData()
    {
        if (!datas.Exists(data => data.pokeInfo.idPoke == 1))
        {
            PokemonData.Stats stats = datas[0].statsBase;

            PokemonData.Infos info = new()
            {
                idPoke = 1,
                size = 0.4f,
                weight = 30.0f,
                resType = ,
                weakType = ["Jerome", "Feu", "Eau"],
                caption = "Classified as an Electric-type Pokémon, Raichu is a large brown mouse with " +
                          "a lightning bolt-shaped tail, and yellow sacs on its cheek that can generate " +
                          "large amounts of electricity."
            };

            PokemonData pokeData = new("Raichu", null, info, stats);
            pokeData.statsBase = pokeData.GetStatsByLvl(40, 3);
            
            datas.Add(pokeData);
        }
    } */
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    public PokemonController pokemon;
    public PokemonController pokemonCPU;

    public PokemonInfoController pokeSelect;

    public void Start()
    {
        pokemon.Init(pokeSelect._pokemonSelected[0]);
        pokemonCPU.Init(pokeSelect._pokemonSelected[1]);
    }

    public void AttackOpponent()
    {
        if (pokemonCPU._data.statsBase.pv > 0)
        {
            pokemonCPU._currentLife -= pokemon._data.statsBase.atk / pokemonCPU._data.statsBase.def;
            pokemonCPU.updatePV();
        }
    }
}

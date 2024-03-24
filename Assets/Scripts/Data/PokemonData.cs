using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PokemonData
{
    [Serializable]
    public struct Stats
    {
        public int pv;
        public int atk;
        public int def;
        public int atkSpe;
        public int defSpe;
        public int speed;

        public Stats(int pv, int atk, int def, int atkSpe, int defSpe, int speed)
        {
            this.pv = pv;
            this.atk = atk;
            this.def = def;
            this.atkSpe = atkSpe;
            this.defSpe = defSpe;
            this.speed = speed;
        }       
        
        public Stats(Stats statsBase, int coeff)
        {
            this.pv = statsBase.pv * coeff;
            atk = statsBase.atk * coeff;
            def = statsBase.def * coeff;
            atkSpe = statsBase.atkSpe * coeff;
            defSpe = statsBase.defSpe * coeff;
            speed = statsBase.speed * coeff;
        }
    }

    [Serializable]
    public struct Infos
    {
        public int idPoke;
        public float size;
        public float weight;
        public string[] weakType;
        public string[] resType;
        public string caption;

        public Infos(int idPoke, float size, float weight, string[] resType, string[] weakType, string caption)
        {
            this.idPoke = idPoke;
            this.size = size;
            this.weight = weight;
            this.weakType = weakType;
            this.resType = resType;
            this.caption = caption;
        }
    }
    
    public string name;
    public Infos pokeInfo;
    public Sprite icon;
    
    public Stats statsBase;

    public PokemonData() { }

    public PokemonData(string name, Sprite icon, Infos info, Stats stats)
    {
        this.name = name;
        this.icon = icon;
        this.pokeInfo = info;
        
        this.statsBase = stats;
    }
    
    public Stats GetStatsByLvl(int lvl, int evolution)
    {
        return new(statsBase, (lvl * evolution / 10));
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PokemonData : BaseData
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
        public string category;
        public List<TYPES> types;
        public bool isSelected;

        public Infos(int idPoke, float size, float weight, TYPES[] types, string category, bool isSelected)
        {
            this.idPoke = idPoke;
            this.size = size;
            this.weight = weight;
            this.types = new(types);
            this.category = category;
            this.isSelected = isSelected;
        }
    }

    [Serializable]
    public struct AttackWrapper
    {
        public string name;
        public int level;

        public AttackWrapper(string name, int level)
        {
            this.name = name;
            this.level = level;
        }
    }
    
    public Infos pokeInfo;
    public Sprite icon;
    
    public Stats statsBase;

    public List<AttackWrapper> attacks = new();

    public PokemonData(Sprite icon, Infos info, Stats stats, string name, string caption) : base(name, caption)
    {
        this.name = name;
        this.caption = caption;
        this.icon = icon;
        this.pokeInfo = info;

        this.statsBase = stats;
    }
    
    public Stats GetStatsByLvl(int lvl, int evolution)
    {
        return new(statsBase, (lvl * evolution / 10));
    }

    /* public override void DisplayName()
    {
        Debug.Log("Pokémon : " + name);
        base.DisplayName();
    } */
}
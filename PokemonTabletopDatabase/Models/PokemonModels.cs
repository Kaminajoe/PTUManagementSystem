using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokemonTabletopDatabase.Models
{
    public class PokemonModels
    {
    }

    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public decimal MaleChance { get; set; }
        public decimal FemaleChance { get; set; }

        public List<Habitat> Habitats { get; set; }
        public int MinLevel { get; set; }
        public Nature Nature { get; set; }

        public List<Ability> BasicAbilities { get; set; }
        public List<Ability> AdvancedAbilities { get; set; }
        public List<Ability> HighAbilities { get; set; }

        public int HitPoints { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefence { get; set; }
        public int Speed { get; set; }

        public int Overland { get; set; }
        public int Swim { get; set; }
        public int HighJump { get; set; }
        public int LongJump { get; set; }
        public int? Fly { get; set; }
        public int? Burrow { get; set; }
        public int? Sky { get; set; }
        public int? Levitate { get; set; }
        public int? Teleport { get; set; }
        public int Power { get; set; }

        public string Athletics { get; set; }
        public string Acrobatics { get; set; }
        public string Combat { get; set; }
        public string Stealth { get; set; }
        public string Perception { get; set; }
        public string Focus { get; set; }
    }

    public class Habitat
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Attack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Frequency { get; set; }
        public string AC { get; set; }
        public DamageBase DamageBase { get; set; }
        public string Class { get; set; }
        public string Range { get; set; }
        public string Effect { get; set; }
    }

    public class Ability
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Nature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RaisedStat { get; set; }
        public string LoweredStat { get; set; }
    }

    public class DamageBase
    {
        public int Id { get; set; }
        public string DiceDamage { get; set; }
        public int SetDamage { get; set; }
    }
}
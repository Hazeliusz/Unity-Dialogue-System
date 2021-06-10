using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Skills
{
    Acrobatics, //DEX
    Athletics, //STR
    Deception, //CHA
    Insight, //WIS
    Intimidation, //Highest combat attribute
    Investigation, //INT
    Knowledge, //INT
    Nature, //WIS
    Perception, //WIS
    Persusion, //CHA
    Stealth, //DEX
    Survival, //WIS
    Technology //INT
}

public enum CombatAttributes
{
    Bows,
    Crossbows,
    Firearms,
    Magic,
    MartialArts,
    OneHanded,
    TwoHanded
}

public class PlayerAbilities
{
    public string name; 

    //Skills
    public Dictionary<Skills, int> skills;

    //Combat attributes
    public Dictionary<CombatAttributes, int> combatAttributes;

}

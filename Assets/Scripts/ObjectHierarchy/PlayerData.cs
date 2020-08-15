using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;

public class PlayerData : CharacterData
{
    public List<Feat> feats;

    public PlayerData(string characterClass, string race, int level)
    {
        string fighterString = File.ReadAllText("Assets/ClassesDatabase/FIGHTER.json");
        var FighterJSON = JSON.Parse(fighterString);
        int hitDie = FighterJSON["Fighter"]["hitDie"].AsInt;
        Debug.Log(hitDie);

        this.level = level;
        this.race = new RaceData(race);
        this.characterClass = new ClassData(characterClass);
    }
}

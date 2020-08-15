using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;

public class PlayerData : CharacterData
{
    public int hitDie;
    public List<Feat> feats;
    public List<JSONString> armorProficiencies;
    public List<JSONString> weaponProficiencies;
    public List<JSONString> savingThrows;



    public void Start()
    {
        string fighterString = File.ReadAllText("Assets/ClassesDatabase/FIGHTER.json");
        var FighterJSON = JSON.Parse(fighterString);
        int armor = FighterJSON["Fighter"]["Armor"];
        //Debug.Log(hitDie);
        this.race = new RaceData(raceName);
        this.characterClass = new ClassData(className);
    }
}

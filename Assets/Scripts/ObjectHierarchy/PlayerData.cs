using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using System.IO;

public class PlayerData : CharacterData
{
    public int hitDie;
    public List<Feat> feats;
    public List<string> armorProficiencies;
    public List<string> weaponProficiencies;
    public List<string> savingThrows;

    public void Awake()
    {
        string classfilePath = "Assets/ClassesDatabase/" + className + ".json";
        string classDataString = File.ReadAllText(classfilePath);
        var classJSON = JSON.Parse(classDataString);

        //load armor proficiencies
        JSONNode armorProficienciesJSON = classJSON[className]["Armor"];
        JSONNode.KeyEnumerator armorKey = armorProficienciesJSON.Keys;
        while (armorKey.MoveNext())
        {
            string armorName = armorKey.Current;
            armorProficiencies.Add(armorName);
        }

        //load weapon proficiencies
        JSONNode weaponProficienciesJSON = classJSON[className]["Weapons"];
        JSONNode.KeyEnumerator weaponKey = weaponProficienciesJSON.Keys;
        while (weaponKey.MoveNext())
        {
            string weaponName = weaponKey.Current;
            weaponProficiencies.Add(weaponName);
        }

        //load saving throws
        JSONNode savingThrowsJSON = classJSON[className]["SavingThrows"];
        JSONNode.KeyEnumerator savingThrowKey = savingThrowsJSON.Keys;
        while (savingThrowKey.MoveNext())
        {
            string savingThrowName = savingThrowKey.Current;
            savingThrows.Add(savingThrowName);
        }

        //foreach (JSONString armorType in armorProficiencies)
        //{
        //    Debug.Log(armorType);
        //}

        //int armor = FighterJSON["Fighter"]["Armor"];
        ////Debug.Log(hitDie);
        //this.race = new RaceData(raceName);
        //this.characterClass = new ClassData(className);
    }
}

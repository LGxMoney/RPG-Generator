using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterData : MonoBehaviour
{
    //GameData
    public bool isDM;

    //Character Stats
    public int level;
    public int hp;
    public int hpMax;
    public int challengeRating;
    public int armorClass;
    public int speed;
    public int[] stats;

    //Inventory
    public int gold;
    public List<ItemData> inventory;

    //Descriptions
    public string gender;
    public RaceData race;
    public ClassData characterClass;

    public CharacterData()
    {
        level = 1;
        hpMax = 10;
        hp = hpMax;
        challengeRating = 1;
        armorClass = 10;
        stats = new int[6]{ 10,10,10,10,10,10};
        gold = 0;
        speed = 30;
        gender = "male";
        //inventory = new List<ItemData>();
        
        //race = new RaceData();
        //characterClass = new ClassData();
    }
}

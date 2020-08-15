using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;

public class ClassData
{
    public ClassData(string characterClass)
    {
        //create a json object to read from for the specified class
        string ClassJSONPath = "Assets/ClassesDatabase/" + characterClass + ".json";
        string fighterString = File.ReadAllText(ClassJSONPath);
        var ClassJSONObj = JSON.Parse(fighterString);


        int hitDie = ClassJSONObj[characterClass][].AsInt;
    }
    
}

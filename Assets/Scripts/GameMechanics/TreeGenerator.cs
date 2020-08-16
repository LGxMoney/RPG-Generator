using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    public int treeCount = 40;
    public int spacing = 4;

    public GameObject prefab;
    //public Element[] trees;

    private void Start()
    {
        for (int i = 0; i < treeCount; i += 1)
        {
            Vector3 position = new Vector3(Random.Range(1, 100), .2f, Random.Range(1, 100));
            //Element tree = trees[0];
            GameObject newTree = Instantiate(prefab);
            newTree.transform.position = position;

            newTree.transform.eulerAngles = new Vector3(
                newTree.transform.eulerAngles.x,
                newTree.transform.eulerAngles.y + Random.Range(0, 360),
                newTree.transform.eulerAngles.z);

            float randomScale = Random.Range(0.8f, 3.0f);
            newTree.transform.localScale = new Vector3(
                newTree.transform.localScale.x * randomScale,
                newTree.transform.localScale.y * randomScale + 1,
                newTree.transform.localScale.z * randomScale
                );

        }
        
    }
}

//[System.Serializable]
//public class Element
//{
//    public GameObject prefab;
//}

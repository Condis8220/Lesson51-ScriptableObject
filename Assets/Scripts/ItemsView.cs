using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsView : MonoBehaviour
{
    public List<DataItem> items;

    private void Start()
    {
        foreach(var i in items)
            Debug.Log(i.header);    
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            items[0].countInStack++;

        if (Input.GetKeyDown(KeyCode.M))
        {
            DataItem tempObj = ScriptableObject.CreateInstance<DataItem>();

            tempObj.header = "New item";
            tempObj.countInStack = 50;

            UnityEditor.AssetDatabase.CreateAsset(tempObj, "Assets/Items/NewItem.asset");
        }
    }
}

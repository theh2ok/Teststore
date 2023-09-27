using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreElements : MonoBehaviour
{
    [SerializeField]
    ScriptableObject[] heads, shoulders, weapon, pants, boots;
    [SerializeField]
    GameObject prefab;
     public int basicpool;
    public enum typeelment
    {
        head,
        shoolder,
        weapon,
        pánts,
        boots

    }
    public typeelment myList;
    // Start is called before the first frame update
    void Start()
    {
        generatedItem();
    }

     void generatedItem()
    {
        for (int i = 0; i < basicpool; i++)
        {
            var prefabInstance = Instantiate(prefab);
            prefabInstance.SetActive(false);
        }
    
    }
    public void Menus()
    {

    }
}

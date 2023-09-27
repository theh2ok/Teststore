using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreElements : MonoBehaviour
{
    [SerializeField]
    ItemData[] heads, shoulders, weapon, pants, boots;
    [SerializeField]
    GameObject prefab,parent;
    [SerializeField]
    List <GameObject> items=new List<GameObject>();
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
            var prefabInstance = Instantiate(prefab, parent.transform);
            prefabInstance.SetActive(false);
            items.Add(prefabInstance);
        }
    
    }
    public void Menushead( )
    {
        for (int i = 0; i < heads.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = heads[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
    public void MenusSholder()
    {
        for (int i = 0; i < shoulders.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = shoulders[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
    public void Menusweapon()
    {
        for (int i = 0; i < weapon.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = weapon[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
    public void MenusPants()
    {
        for (int i = 0; i < pants.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = pants[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
    public void MenusBoots()
    {
        for (int i = 0; i < boots.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = boots[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
}

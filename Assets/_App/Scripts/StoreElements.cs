using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StoreElements : MonoBehaviour
{
    public UnityEvent OnstoreOn;
    [SerializeField]
    DataItem[] heads, shoulders, weapon, pants, boots,chest;
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
    private void OnEnable()
    {
        OnstoreOn.Invoke();
    }
    void closeAll()
    {
        foreach (var item in items)
        {
            item.SetActive(false);
        }
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
        closeAll();
        for (int i = 0; i < heads.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = heads[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
    public void MenusSholder()
    {
        closeAll();
        for (int i = 0; i < shoulders.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = shoulders[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
    public void Menusweapon()
    {
        closeAll();
        for (int i = 0; i < weapon.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = weapon[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
    public void MenusChest()
    {
        closeAll();
        for (int i = 0; i < chest.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = chest[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
    public void MenusPants()
    {
        closeAll();
        for (int i = 0; i < pants.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = pants[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
    public void MenusBoots()
    {
        closeAll();
        for (int i = 0; i < boots.Length; i++)
        {
            items[i].GetComponent<ItemInfo>().myscritable = boots[i];
            items[i].GetComponent<ItemInfo>().UpdateData();
            items[i].SetActive(true);
        }
    }
}

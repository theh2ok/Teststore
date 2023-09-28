using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemInfo : MonoBehaviour
{
  
   public  ItemData myscritable;
   // [SerializeField]
    public Image icon;
    public TextMeshProUGUI buypricetext;
    public TextMeshProUGUI Sellpricetext;
    public bool Ownned;
    [SerializeField]
    GameObject buyprice, sellprice;
    // Start is called before the first frame update
    void Start()
    {
        UpdateData();
    }
   public void UpdateData()
    {
      
        icon.sprite= myscritable.icon;
        buypricetext.text     =""+myscritable.buyprice        ;
        Sellpricetext.text   =""+myscritable.Sellprice       ;
        Ownned = myscritable.Ownned;
        buyprice.SetActive(true);
        ItemUIUpdate();
    }
    public void ItemUIUpdate()
    {
        if (Ownned)
        {
            sellprice.SetActive(true);
            buyprice.SetActive(false);
        }
    }
        public void buyItem()
        {
        Debug.Log("buying "+ DataPlayerManager.gold+"loque vale "+ myscritable.buyprice);
        if (DataPlayerManager.gold > myscritable.buyprice)
              {
            DataPlayerManager.gold -= myscritable.buyprice;
            Aciones.Globalgold();
            myscritable.Ownned = true;
            ItemUIUpdate();
        }
          }
    public void SellItem()
    {
        if (DataPlayerManager.gold > myscritable.Sellprice)
        {
            DataPlayerManager.gold += myscritable.Sellprice;
            Aciones.Globalgold();
            myscritable.Ownned = false;
            ItemUIUpdate();
        }
    }
}

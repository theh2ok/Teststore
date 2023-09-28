using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemInfo : MonoBehaviour
{
  
   public  DataItem myscritable;
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
        sellprice.SetActive(false);
        ItemUIUpdate();
    }
    public void ItemUIUpdate()
    {
        Ownned = myscritable.Ownned;
        if (Ownned)
        {
            sellprice.SetActive(true);
            buyprice.SetActive(false);
        }
        else
        {
            sellprice.SetActive(false);
            buyprice.SetActive(true);
        }
    }
        public void buyItem()
        {
        Debug.Log("buying "+ PlayerManager.gold+"loque vale "+ myscritable.buyprice);
        if (PlayerManager.gold >= myscritable.buyprice)
              {
            PlayerManager.gold -= myscritable.buyprice;
            Aciones.Globalgold();
            myscritable.Ownned = true;
            Aciones.ItemUpdate(myscritable.myIDPart, myscritable.ID);
            ItemUIUpdate();
        }
          }
    public void SellItem()
    {
       
            PlayerManager.gold += myscritable.Sellprice;
            Aciones.Globalgold();
            myscritable.Ownned = false;
            ItemUIUpdate();
   
    }
}

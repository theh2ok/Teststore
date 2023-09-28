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
     
    }
   public void UpdateData()
    {
      
        icon.sprite= myscritable.icon;
        buypricetext.text     =""+myscritable.buyprice        ;
        Sellpricetext.text   =""+myscritable.Sellprice       ;
        Ownned = myscritable.Ownned;
        buyprice.SetActive(true);
        if (Ownned)
        {
            sellprice.SetActive(true);
            buyprice.SetActive(false);
        }
    }
 
        public void buyItem()
        {
         //   if (DataPlayerManager.gold > myscritable.buyprice)
                 {
          //      DataPlayerManager.gold -= myscritable.buyprice;
                myscritable.Ownned = true;
            }
        }
    public void SellItem()
    {
       // if (DataPlayerManager.gold > myscritable.buyprice)
        {
       //     DataPlayerManager.gold += myscritable.Sellprice;
            myscritable.Ownned = false;
        }
    }
}

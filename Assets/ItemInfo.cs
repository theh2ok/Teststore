using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
  
   public  ItemData myscritable;
   // [SerializeField]
    public Sprite icon;
    public int buyprice;
    public int sellprice;
    public bool Ownned;
    // Start is called before the first frame update
    void Start()
    {
     
    }
   public void UpdateData()
    {
        icon= myscritable.icon;
        buyprice     =myscritable.buyprice        ;
        sellprice    =myscritable.sellprice       ;
        Ownned = myscritable.Ownned;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

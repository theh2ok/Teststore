using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinPlayer : MonoBehaviour
{
    public DataPlayerSkin myskin;
    public DataPlayerSkin[] skintosell;
    public Sprite head;
    public Sprite sholder1;

    public Sprite sholder2;
    public Sprite weapon;
    public Sprite legs;
    public Sprite chest;
    public Sprite boots1;
    public Sprite boots2;
    public string names;
    public enum typeparts
    {
            head,
            sholder,
            weapon,
            legs,
            chest,
            boots
    }
  public static  typeparts myparts;
    private void UpdateSkin()
    {
  head =myskin.head;
  sholder1 =myskin.sholder1;
  
  sholder2 =myskin.sholder2;
  weapon =myskin.weapon;
  legs =myskin.legs;
  chest =myskin.chest;
  boots1 =myskin.boots1;
  boots2 =myskin.boots2;
}
    private void Start()
    {
        UpdateSkin();
    }
    public void UpdatePart(int IDpart,int IDOrderItem)
    {
        switch (IDpart)
        {
            case 1:
                head = skintosell[IDOrderItem].head ;
                break;
             
            case 2:
                sholder1 = skintosell[IDOrderItem].sholder1;
                sholder2 = skintosell[IDOrderItem].sholder2;
                break;
            case 3:
                weapon = skintosell[IDOrderItem].weapon;
                break;
            case 4:
                legs = skintosell[IDOrderItem].legs;
                break;
            case 5:
                chest = skintosell[IDOrderItem].chest;
                break;
            case 6:
                boots1 = skintosell[IDOrderItem].boots1;
                boots2 = skintosell[IDOrderItem].boots2;
                break;
            default:
                break;
        }

    }
}

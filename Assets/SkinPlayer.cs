using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinPlayer : MonoBehaviour
{
    public DataPlayerSkin myskin;
    public DataPlayerSkin[] skintosell;
    public SpriteRenderer head;
    public SpriteRenderer sholder1;

    public SpriteRenderer sholder2;
    public SpriteRenderer weapon;
    public SpriteRenderer legs;
    public SpriteRenderer chest;
    public SpriteRenderer boots1;
    public SpriteRenderer boots2;
    public string names;
    public enum typeparts
    {
            head,//1
            sholder,//2
            weapon,//3
            legs,//4
            chest,//5
            boots//6
    }
  public static  typeparts myparts;
    private void UpdateSkin()
    {
  head.sprite =myskin.head;
  sholder1.sprite = myskin.sholder1;
  
  sholder2.sprite = myskin.sholder2;
  weapon.sprite = myskin.weapon;
  legs.sprite = myskin.legs;
  chest.sprite = myskin.chest;
  boots1.sprite = myskin.boots1;
  boots2.sprite = myskin.boots2;
}
    private void Start()
    {
        UpdateSkin();
    }
    private void OnEnable()
    {
        Aciones.ItemUpdate += UpdatePart;
    }
    private void OnDisable()
    {
        Aciones.ItemUpdate -= UpdatePart;
    }
    [ContextMenu("changeskin")]
    public void updateSet()
    {
        head.sprite = skintosell[2].head;
    
                sholder1.sprite = skintosell[2].sholder1;
        sholder2.sprite = skintosell[2].sholder2;
     
                weapon.sprite = skintosell[2].weapon;
    
                legs.sprite = skintosell[2].legs;
      
                chest.sprite = skintosell[2].chest;
   
                boots1.sprite = skintosell[2].boots1;
        boots2.sprite = skintosell[2].boots2;
    }
    public void UpdatePart(int IDpart,int IDOrderItem)
    {
        switch (IDpart)
        {
            case 1:
                head.sprite = skintosell[IDOrderItem].head ;
                break;
             
            case 2:
                sholder1.sprite = skintosell[IDOrderItem].sholder1;
                sholder2.sprite = skintosell[IDOrderItem].sholder2;
                break;
            case 3:
                weapon.sprite = skintosell[IDOrderItem].weapon;
                break;
            case 4:
                legs.sprite = skintosell[IDOrderItem].legs;
                break;
            case 5:
                chest.sprite = skintosell[IDOrderItem].chest;
                break;
            case 6:
                boots1.sprite = skintosell[IDOrderItem].boots1;
                boots2.sprite = skintosell[IDOrderItem].boots2;
                break;
            default:
                break;
        }

    }
}

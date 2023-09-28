using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewScriptableObject", menuName = "Custom/Item")]
public class DataItem : ScriptableObject
{
    public Sprite icon;
    public int buyprice;
    public int Sellprice;
    public int myIDPart;// podria ser un enum
    public int ID;
    public bool Ownned;
}

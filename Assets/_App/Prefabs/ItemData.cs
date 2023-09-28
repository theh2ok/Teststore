using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewScriptableObject", menuName = "Custom/Item")]
public class ItemData : ScriptableObject
{
    public Sprite icon;
    public int buyprice;
    public int Sellprice;
    public bool Ownned;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObject", menuName = "Custom/Item")]
public class ItemData : ScriptableObject
{
    public Sprite icon;
    public int buyprice;
    public int sellprice;
    public bool Ownned;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerManager : MonoBehaviour
{
    public static int gold;

    public TextMeshPro mygold;
 
   
    [SerializeField]
    int InitialGold;
    private void OnEnable()
    {
        Aciones.Globalgold += UPdateGold;
    }
    private void OnDisable()
    {
        Aciones.Globalgold -= UPdateGold;
    }
    private void Start()
    {
        gold = InitialGold;
        UPdateGold();
    }
   

    // Start is called before the first frame update

    void UPdateGold()
    {
        
       mygold.text = "" + gold;    
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PlayerManager : MonoBehaviour
{
    public static int gold;
    int extragold=0;
    public TextMeshPro mygold;
    public TextMeshProUGUI mygoldUI;
    public GameObject UIelemetgoldUI;
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
        UPdateGold(extragold);
    }
   

    // Start is called before the first frame update

    void UPdateGold(int goldextra)
    {
        var totalgold = gold + goldextra;
       mygold.text = "" + totalgold;
        mygoldUI.text = "" + totalgold;
        UIelemetgoldUI.SetActive(true);
    }

   
}

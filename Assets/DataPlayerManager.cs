using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DataPlayerManager : MonoBehaviour
{
    public   int gold;
    public TextMeshPro mygold;
    public static event Action<int> goldactualizacion;
    // Start is called before the first frame update
    void messhupdate()
    {
        mygold.text = ""+gold;
    }

   
}

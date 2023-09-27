using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillStore : MonoBehaviour
{
    public GameObject ItemPrefb;
    public int numberofitems;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberofitems; i++)
        {
            Instantiate(ItemPrefb,transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

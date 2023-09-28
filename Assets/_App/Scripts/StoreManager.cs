using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public bool StoreAvalible = false;
    public GameObject myStore,mysingStore;

    public void stateStore(bool state)
    {
        StoreAvalible = state;
        mysingStore.SetActive(state);
    }
    public void EnabledStore()
    {
        if (StoreAvalible)
        {
            myStore.SetActive(true);
          
        }

    }
}
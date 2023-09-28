using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StayUnityevent : MonoBehaviour
{
 
    public UnityEvent StayPlace;
    public UnityEvent EndPlaceStay;

    void Start()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        // storeSing.SetActive(true);
        StayPlace.Invoke();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        EndPlaceStay.Invoke();
    }
}

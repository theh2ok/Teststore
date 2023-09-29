using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisabledAUtimatic : MonoBehaviour
{
    public Animator myanim;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DisableAnim",2);   
    }

   void DisableAnim()
    {
        myanim.enabled=false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cainos.PixelArtTopDown_Basic
{
    //let camera follow target
    public class CameraFollow : MonoBehaviour
    {
        public Transform target;
     
        private void Start()
        {
            if (target == null) return;

       
        }

        private void Update()
        {
            if (target == null) return;

           
            transform.position = target.position-Vector3.forward*2;
        }

    }
}

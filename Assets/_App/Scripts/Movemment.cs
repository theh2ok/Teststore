using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemment : MonoBehaviour
{
    Rigidbody2D myrigi;
    // Start is called before the first frame update
    void Start()
    {
        myrigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myrigi.velocity= new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
      
    }
}

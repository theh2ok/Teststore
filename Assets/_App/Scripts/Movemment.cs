using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemment : MonoBehaviour
{
    Rigidbody2D myrigi;
    Animator myanim;
    [SerializeField]
    float Speed;
    [SerializeField]
    GameObject mybody;
    // Start is called before the first frame update
    void Start()
    {
        myrigi = GetComponent<Rigidbody2D>();
        myanim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float myHorzontal = Input.GetAxis("Horizontal");
        float MyVertical = Input.GetAxis("Vertical");
        myrigi.velocity= new Vector2(myHorzontal * Speed * Time.deltaTime, MyVertical * Speed * Time.deltaTime);
        myanim.SetFloat("Velocity", myrigi.velocity.magnitude);
        if (MyVertical>0.1f)
        {
          //  mybody.transform.eulerAngles(100);
        }
    }
}

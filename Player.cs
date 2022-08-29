using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //to move
        //transform.Translate(x,y,z);
        //if(Input.GetKey(KeyCode.RightArrow)) //when left arrow kew is pressed
        //    transform.Translate(0.01f,0,0); //moves player right

        if(Input.GetKey(KeyCode.D)) 
            transform.Translate(0.01f,0,0);
        if(Input.GetKey(KeyCode.A))
            transform.Translate(-0.01f,0,0); //left
        if(Input.GetKey(KeyCode.W))
            transform.Translate(0,0.01f,0); //up
        if(Input.GetKey(KeyCode.S))
            transform.Translate(0,-0.01f,0); //down
    }
}

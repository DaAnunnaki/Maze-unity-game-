using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collison : MonoBehaviour
{
    [SerializeField] bool HasOrangeKey;

    private void OnTriggerEnter(Collider2D collision) {
        
        //if collide with object names orange
        if(collision.gameObject.name.Equals("OrangeKey")) {
            HasOrangeKey = true;
            Destroy(collision.gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D collision) {
        //if the name = "orange door" then destroy the door
        if(collision.gameObject.name.Equals("orangeDoor") && HasOrangeKey){
            Destroy(collision.gameObject);
        }
    }
   
}

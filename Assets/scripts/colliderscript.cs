using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderscript : MonoBehaviour
{
     private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.tag == "player"){
            Debug.Log("toco");


        }
        
    }

    
}

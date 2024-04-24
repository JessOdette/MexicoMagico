using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkGround : MonoBehaviour
{
    public static bool isGrounded;

     void OnTriggerEnter2D(Collider2D collision){
        isGrounded = true;
    }

    void OnTriggerExit2D(Collider2D collision){
      isGrounded = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerController playerInteraction;
    public AudioSource audioPlayer;

    void Start()
    {
          if (audioPlayer == null)
     {
        Debug.LogError("Destroy sound not assigned in the Inspector.");
     }  
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.contacts[0].normal.y < -0.5) 
            {
                audioPlayer.Play(); 
                Destroy(gameObject); 
            }
            else
            {
                playerInteraction.TakeDamage(1); 
            }
        }
    }
}



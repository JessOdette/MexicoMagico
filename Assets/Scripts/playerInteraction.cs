using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 3; 
    public int maxHealth = 10;

void Start ()
{
    health = maxHealth;
}


public void TakeDamage(int amount)
{
    health -= amount;
    if (health <= 0)
    {
        Destroy(gameObject);
    }
}




}
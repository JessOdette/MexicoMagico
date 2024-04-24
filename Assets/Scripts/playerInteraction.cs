using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Necesario para trabajar con UI

public class PlayerController : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public Image healthBarForeground; // Referencia al componente Image del indicador de salud

    void Start ()
    {
        health = maxHealth;
        UpdateHealthBar();
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            UpdateHealthBar(); // Actualiza la barra de salud cada vez que el jugador recibe daño
        }
    }

    void UpdateHealthBar()
    {
        
        float healthRatio = (float)health / maxHealth;
        healthBarForeground.fillAmount = healthRatio;

    }
}

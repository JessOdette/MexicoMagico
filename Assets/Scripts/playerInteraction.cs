using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using TMPro; 

public class PlayerController : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public Image healthBarForeground; 
    public TextMeshProUGUI gameOverText; 

    void Start ()
    {
        health = maxHealth;
        UpdateHealthBar();
        gameOverText.gameObject.SetActive(false); 
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            gameOverText.gameObject.SetActive(true); 
            StartCoroutine(RestartLevel()); 
        }
        else
        {
            UpdateHealthBar(); 
        }
    }

    public void RestoreHealth(int amount)
{
    health += amount;
    if (health > maxHealth)
    {
        health = maxHealth; // Asegura que la salud no exceda la salud máxima
    }
    UpdateHealthBar();
}


    void UpdateHealthBar()
    {
        float healthRatio = (float)health / maxHealth;
        healthBarForeground.fillAmount = healthRatio;
    }

    

    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(2); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}

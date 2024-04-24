using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Necesario para trabajar con UI
using UnityEngine.SceneManagement;
using TMPro; // Necesario para manejar escenas

public class PlayerController : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public Image healthBarForeground; // Referencia al componente Image del indicador de salud
    public TextMeshProUGUI gameOverText; // Referencia al texto de Game Over

    void Start ()
    {
        health = maxHealth;
        UpdateHealthBar();
        gameOverText.gameObject.SetActive(false); // Asegúrate de que el texto de Game Over está oculto al inicio
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            gameOverText.gameObject.SetActive(true); // Activa el texto de Game Over
            StartCoroutine(RestartLevel()); // Inicia la rutina para reiniciar el nivel
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

    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(2); // Espera dos segundos antes de reiniciar el nivel
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Carga de nuevo la escena actual
    }
}

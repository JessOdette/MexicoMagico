using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthAmount = 5; // Cantidad de salud que este objeto restaura

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();
            if (player != null)
            {
                player.RestoreHealth(healthAmount); // Restaurar salud
                Destroy(gameObject); // Destruir el objeto de salud
            }
        }
    }
}

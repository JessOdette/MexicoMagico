using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed = 4f;          // Velocidad de movimiento del enemigo
    public float distance = 8.0f;      // Distancia máxima de desplazamiento a cada lado

    private Vector3 startingPosition;   // Posición inicial del enemigo

    void Start()
    {
        // Guardar la posición inicial para usarla como base del movimiento
        startingPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startingPosition + new Vector3(movement, 0, 0);
    }
}
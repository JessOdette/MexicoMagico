using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed = 4f;          
    public float distance = 8.0f;      

    private Vector3 startingPosition;   

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startingPosition + new Vector3(movement, 0, 0);
    }
}
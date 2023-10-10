using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    [SerializeField]
    float speed = 0;

    [SerializeField]
    float timeBetweenReverse = 0;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D obstacleRigidBody = GetComponent<Rigidbody2D>();
        obstacleRigidBody.velocity = Vector2.up * speed;

        InvokeRepeating("Reverse", 0, timeBetweenReverse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Reverse()
    {
        Rigidbody2D obstacleRigidBody = GetComponent<Rigidbody2D>();
        obstacleRigidBody.velocity *= -1;
    }
}

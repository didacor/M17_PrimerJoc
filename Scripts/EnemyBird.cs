using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyBird : MonoBehaviour
{
    //configurem la velocitat de l'enemic
    [SerializeField]
    float speed = -2;


    // Start is called before the first frame update
    void Start()
    {
        //l'ocell enemic té velocitat quan iniciem el joc
        Rigidbody2D birdBody = GetComponent<Rigidbody2D>();
        birdBody.velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Enemic"))
        {
            
        }
    }
}

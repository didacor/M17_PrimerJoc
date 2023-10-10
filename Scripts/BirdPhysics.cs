using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class BirdPhysics : MonoBehaviour
{
    //configurem la velocitat
    [SerializeField]
    float speed = 2;

    //configurem la força
    [SerializeField]
    float force = 200;

    [SerializeField]
    TextMeshProUGUI text_puntuacio;

    [SerializeField]
    TextMeshProUGUI text_obstacle;

    [SerializeField]
    UnityEngine.UI.Image vida0;

    [SerializeField]
    UnityEngine.UI.Image vida1;

    [SerializeField]
    UnityEngine.UI.Image vida2;

    int points = 0, obstacle = 0, vides = 3;

    // Start is called before the first frame update
    void Start()
    {
        //l'ocell té velocitat quan iniciem el joc
        Rigidbody2D birdBody = GetComponent<Rigidbody2D>();
        birdBody.velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        //cada cop que fem click, l'ocell saltarà
        if (Input.GetMouseButtonDown(0))
        {
            Rigidbody2D birdBody = GetComponent<Rigidbody2D>();
            birdBody.AddForce(Vector2.up * force);
        }

        if (vides == 2)
        {
            Destroy(vida2);
        }

        if (vides == 1)
        {
            Destroy(vida1);
        }

        if (vides == 0)
        {
            Destroy(vida0);
        }

        if (vides == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    //quan xoquem, reiniciarem el joc
    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Pickup"))
        {
            points++;
            text_puntuacio.text = ("Puntuació: " + points.ToString());
            Destroy(collision.gameObject);
        }

        if (collision.tag.Equals("Obstacle"))
        {
            obstacle++;
            text_obstacle.text = ("Obstacle: " + obstacle);
        }

        if (collision.tag.Equals("Enemic"))
        {
            vides--;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;


    private void Start()
    {
        //convert screenspace to worldspace
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;
    }


    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        //jos peliobjekti menee variablen vasen reuna yli se tuhoutuu
        if (transform.position.x < leftEdge )
        {
            Destroy(gameObject);
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }*/

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Despawn")
        {
            Destroy(gameObject);
            Debug.Log("despawn");
        }
    }
}

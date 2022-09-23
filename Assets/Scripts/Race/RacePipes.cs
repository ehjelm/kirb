using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacePipes : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        // liikkuu vasemmalle speed variablen nopeudella
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Despawn")
        {
            Destroy(gameObject);
        }
    }

}

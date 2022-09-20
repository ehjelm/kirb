using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    //referenssi esteeseen
    public GameObject prefab;

    //syntymis/spawnitiheys
    public float spawnRate = 1f;

    //m‰‰r‰‰ mihin v‰liin esteet spawnaa
    public float minHeight = -1f;
    public float maxHeight = 1f;

    //m‰‰r‰‰ esteiden koon v‰lin
    public float minScale = 1;
    public float maxScale = 5;



    private void OnEnable()
    {
        //toistaa metodin Spawn nopeusehdoilla spawnRate
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        //tekee esteen kopion
        GameObject enemy = Instantiate(prefab, transform.position, Quaternion.identity);
        //randomisoi vihollisen spawnikohdan
        enemy.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        //randomisoi esteen koon
        enemy.transform.localScale = new Vector3(Random.Range(minScale, maxScale), Random.Range(minScale, maxScale), Random.Range(minScale, maxScale));
    }

}

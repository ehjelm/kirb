using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingSpawner : MonoBehaviour
{
    //referenssi esteeseen
    public GameObject prefab;

    //syntymis/spawnitiheys
    public float spawnRate = 1f;

    //m‰‰r‰‰ mihin v‰liin esteet spawnaa
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject enemy = Instantiate(prefab, transform.position, Quaternion.identity);
        enemy.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}

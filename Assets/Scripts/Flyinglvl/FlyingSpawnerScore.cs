using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingSpawnerScore : MonoBehaviour
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
        GameObject score = Instantiate(prefab, transform.position, Quaternion.identity);
        score.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}

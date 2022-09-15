using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwimmingSpawner : MonoBehaviour
{
    public GameObject prefab;

    public float spawnRate = 1f;

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
        //spawnaa putket sieltä missä "spawner" peliobjekti on ilman rotaatiota
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        //spawnaa putket randomisti minHeight ja maxHeight arvojen välillä
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}

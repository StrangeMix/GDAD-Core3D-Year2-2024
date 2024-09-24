using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public int numberOfCollectibles = 10;
    public Vector3 spawnArea;



    private void Start()
    {
        SpawnCollectibles();
    }

    void SpawnCollectibles()
    {
        for (int i = 0; i < numberOfCollectibles; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-spawnArea.x / 2, spawnArea.x / 2),
                Random.Range(0, -spawnArea.y),
                Random.Range(spawnArea.z / 2, spawnArea.z / 2)
                );
            Instantiate(collectiblePrefab, randomPosition, Quaternion.identity);
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, spawnArea);
    }
}
 
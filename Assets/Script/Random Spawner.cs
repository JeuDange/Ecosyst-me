using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;

    void Update()
    {
        if (Input.GetKeyDown((KeyCode.Space))
        {
            Vector3 randomSpawnPosition = new Vector3(RandomSpawner.Range(-10, 11), 5, RandomSpawner.Range(-10, 11));
            Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        }
    }
}

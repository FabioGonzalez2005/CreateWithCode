using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = -6;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal() {
        // Randomly generate animal index and spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
    }
}

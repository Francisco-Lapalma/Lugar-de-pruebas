using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float spawnInterval = 10f;
    [SerializeField] float spawnDelay = 15f;
    void Start()
    {
        //SpawnBullet();
        InvokeRepeating("SpawnBullet", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void SpawnBullet()
    {
        Instantiate(bulletPrefab, transform);
    }
}

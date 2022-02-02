using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float spawnInterval = 5f;
    [SerializeField] float spawnDelay = 10f; 
    
    void Start()
    {
        //SpawnBullet();
        InvokeRepeating("SpawnBullet", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ScaleBullet();
        }
    }
    
    private void SpawnBullet()
    {
        Instantiate(bulletPrefab, transform);
    }

    private void ScaleBullet()
    {
        transform.localScale = new Vector3(1f, 1f, 1f) *2f;
    }
}

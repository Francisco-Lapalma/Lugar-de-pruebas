using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretController : MonoBehaviour
{
    [SerializeField] private float turretRange = 150f;
    [SerializeField] private float fireRate = 0.6f;
    private float timePass = 0f;
    [SerializeField] private LayerMask hittableLayers;
    [SerializeField] private Transform[] shootpoints;
    private bool canShoot = true;
    [SerializeField] private float detectPlayerDistance = 50f;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject cañon;

    void Start()
    {
        
    }

    
    void Update()
    {
        DetectPlayer();
    }

    private void DetectPlayer()
    {
        if ((player.transform.position - transform.position).magnitude <= detectPlayerDistance)
        {
            LookPlayer();
            FireCooldownTurret();
        }
        
    }

    private void LookPlayer()
    {
        Quaternion newRotation = Quaternion.LookRotation((player.transform.position - cañon.transform.position));
        cañon.transform.rotation = newRotation;
    }

    private void FireCooldownTurret()
    {
        if (canShoot)
        {
            TurretShoot();
        }
        else
        {
            timePass += Time.deltaTime;

        }

        if (timePass > fireRate)
        {
            canShoot = true;
        }
        else
        {
            canShoot = false;
        }
    }
    private void TurretShoot()
    {
        RaycastHit hit;
        Physics.Raycast(shootpoints[Random.Range(0, shootpoints.Length)].position, Vector3.forward, out hit, turretRange, hittableLayers);
        Debug.Log("Pium Pium");
        timePass = 0f;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float bulletSpeed = 5f;
    [SerializeField] int bulletDamage = 20;
    [SerializeField] Vector3 direccion = new Vector3(0, 0, 0);
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet(Vector3.right);
        if (transform.position.x > 35f)
        {
            Destroy(gameObject);
        }
    }

    void MoveBullet(Vector3 direccion)
    {
        transform.position += bulletSpeed * Time.deltaTime * direccion;
    }

}

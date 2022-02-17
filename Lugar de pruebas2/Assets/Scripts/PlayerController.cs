using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float speedPlayer = 3f;
    float playerAxieX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }

        RotatePlayer();
    }

    void MovePlayer(Vector3 direccion)
    {
      transform.Translate(speedPlayer * Time.deltaTime * direccion);  
    }

    void RotatePlayer()
    {
        playerAxieX += Input.GetAxis("Mouse X");
        Quaternion angle = Quaternion.Euler(0f , playerAxieX * speedPlayer , 0f);
        transform.localRotation = angle;
    }
    
}

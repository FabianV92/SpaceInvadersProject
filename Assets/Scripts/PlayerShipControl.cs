using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerShipControl : MonoBehaviour
{
    [SerializeField] private GameObject LaserGreen;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -8.4)
        {
            if (Input.GetKey(KeyCode.R))
            {
                transform.position += new Vector3(-0.05f, 0, 0);
            }
        }

        if (transform.position.x < 8.4)
        {
            if (Input.GetKey(KeyCode.T))
            {
                transform.position += new Vector3(0.05f, 0, 0);
            }
        }

        if (transform.position.y > -4.4)
        {
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, -0.05f, 0);
            }
        }

        if (transform.position.y < 4.4)
        {
            if (Input.GetKey(KeyCode.F))
            {
                transform.position += new Vector3(0, 0.05f, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Instantiate(LaserGreen, transform.position, quaternion.identity);
        }
    }
}
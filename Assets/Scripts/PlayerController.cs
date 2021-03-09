using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    [SerializeField] private GameObject laserPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 8.4)
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -8.4)
            {
                transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Instantiate(laserPrefab, transform.position, quaternion.identity);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    [SerializeField]
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 10f * Time.deltaTime, 0);
        t
        if (transform.position.y > 7)
        {
            Destroy(gameObject);
        }
    }
}
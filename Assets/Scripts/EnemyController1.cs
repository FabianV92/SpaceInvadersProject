using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class EnemyController1 : MonoBehaviour
{
    [SerializeField] private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, -_speed * Time.deltaTime, 0f);
        if (transform.position.y < -6)
        {
            
            transform.position = new Vector3(Random.Range(-8.4f,8.4f),
                7f,transform.position.z);
        }        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        PlayerModel.GetInstance().SetScore(PlayerModel.GetInstance().GetScore() + 1);
        Debug.Log(PlayerModel.GetInstance().GetScore());
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private float _spawnRate;
    [SerializeField] private float _nextSpawnTime;
    [SerializeField] private GameObject _enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        _nextSpawnTime = _spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        _nextSpawnTime -= Time.deltaTime;
        if (_nextSpawnTime <= 0)
        {
            GameObject.Instantiate(_enemy,
                new Vector3(Random.Range(-8.4f, 8.4f), 7f, 0f),
                Quaternion.identity);
            _nextSpawnTime = _spawnRate;
        }
    }
}

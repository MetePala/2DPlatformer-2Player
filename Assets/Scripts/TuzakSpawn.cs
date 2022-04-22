using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuzakSpawn : MonoBehaviour
{
    
    [SerializeField] float _minSpawnTime, _maxSpawnTime;
    [SerializeField] GameObject _tuzak;
    [SerializeField] float _randomSpawnTime, _currentTime;
    private void FixedUpdate()
    {
        _currentTime += Time.deltaTime;
        if (_currentTime > _randomSpawnTime)
        {
            TuzakSpawnStart();
        }

    }

    void TuzakSpawnStart()
    {
        Instantiate(_tuzak, transform.position, _tuzak.transform.rotation, transform);
        ResetTuzakSpawn();
    }
    void ResetTuzakSpawn()
    {
        _currentTime = 0;
        _randomSpawnTime = Random.Range(_minSpawnTime, _maxSpawnTime);
    }
}

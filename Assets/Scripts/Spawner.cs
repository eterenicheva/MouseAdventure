using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject _spawnPrefab;
    [SerializeField] private float _waitTime;

    private float _elapsedTime = 0;

    private void Start()
    {
        Initialize(_spawnPrefab);
    }

    private void Update()
    {
        if (TryGetObject(out GameObject coin))
        {
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime >= _waitTime)
            {
                _elapsedTime = 0;
                SetCoin(coin);
            }
        }
    }

    private void SetCoin(GameObject coin)
    {
        coin.SetActive(true);
    }
}

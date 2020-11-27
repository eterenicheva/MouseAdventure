using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] GameObject _spawnCoin;
    [SerializeField] private float _waitTime;

    private SpriteRenderer _sprireRenderer;
    private CircleCollider2D _collider;

    private void Start()
    {
        _sprireRenderer = GetComponent<SpriteRenderer>();
        _collider = GetComponent<CircleCollider2D>();

        _sprireRenderer.enabled = true;
        _collider.enabled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Player>(out Player player))
        {
            player.CountCoin();
            StartCoroutine(SpawnCoin());
        }
    }

    private IEnumerator SpawnCoin()
    {
        _sprireRenderer.enabled = false;
        _collider.enabled = false;

        yield return new WaitForSeconds(_waitTime);
        GameObject newCoin = Instantiate(_spawnCoin, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        
        Destroy(gameObject);
    }
}

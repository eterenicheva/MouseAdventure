using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    [SerializeField] private float _waitTime;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Player>(out Player player))
        {
            player.CountCoin(1);
            gameObject.SetActive(false);
            Invoke("RespawnCoin", _waitTime);
            
        }
    }

    private void RespawnCoin()
    {
        GameObject newCoin = Instantiate(gameObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        newCoin.SetActive(true);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _coins;

    public void CountCoin(int count)
    {
        _coins += count;
        Debug.Log(_coins);
    }
}

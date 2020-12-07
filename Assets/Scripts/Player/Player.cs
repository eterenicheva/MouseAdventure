using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _coins;

    public void CountCoin()
    {
        _coins ++;
        Debug.Log(_coins);
    }

}

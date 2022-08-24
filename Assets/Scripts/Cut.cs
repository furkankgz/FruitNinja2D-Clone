using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    private Manager _manager;

    void Start()
    {
        _manager = GameObject.FindObjectOfType<Manager>();    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            Destroy(collision.gameObject);
            _manager._score += 1;
        }
        else if (collision.gameObject.CompareTag("Bomb"))
        {
            _manager.RestartGame();
        }
    }
}

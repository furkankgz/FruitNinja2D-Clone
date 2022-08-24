using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float _minX;
    public float _maxX;
    public float _minY;
    public float _maxY;
    public float _lifeTime;

    void Start()
    {
        rb.velocity = new Vector2(
                Random.Range(_minX, _maxX),
                Random.Range(_minY, _maxY)
            );
        Destroy(gameObject, _lifeTime);
    }
}

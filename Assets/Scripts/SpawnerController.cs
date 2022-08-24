using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject _prefab;
    public float _minX;
    public float _maxX;
    public float _startTime;   // Hangi aral�klarda
    private float _time;        // ��ks�n
    public Sprite[] _sprites;   // Birden �ok meyve sprite'�m�z oldu�u i�in sprite dizisi olu�turduk

    void Update()
    {
        if (_time <= 0)
        {
            SpawnObject();
            _time = _startTime;
        }
        else
        {
            _time -= Time.deltaTime;
        }
    }

    private void SpawnObject()
    {
        GameObject _newPrefab = Instantiate(_prefab);
        _newPrefab.transform.position = new Vector2(
                Random.Range(_minX, _maxX),
                transform.position.y
                );

        Sprite _randomSprite = _sprites[Random.Range(0, _sprites.Length)]; // sprite dizisinden dizi say�s�na g�re rastgele bi sprite se�
        _newPrefab.GetComponent<SpriteRenderer>().sprite = _randomSprite;  // se�ilen dizi say�s�ndan ��kan sprite _newprefab de�i�kenine ata
    }
}

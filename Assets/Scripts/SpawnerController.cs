using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject _prefab;
    public float _minX;
    public float _maxX;
    public float _startTime;   // Hangi aralýklarda
    private float _time;        // çýksýn
    public Sprite[] _sprites;   // Birden çok meyve sprite'ýmýz olduðu için sprite dizisi oluþturduk

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

        Sprite _randomSprite = _sprites[Random.Range(0, _sprites.Length)]; // sprite dizisinden dizi sayýsýna göre rastgele bi sprite seç
        _newPrefab.GetComponent<SpriteRenderer>().sprite = _randomSprite;  // seçilen dizi sayýsýndan çýkan sprite _newprefab deðiþkenine ata
    }
}

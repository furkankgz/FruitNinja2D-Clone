using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject _cutPrefab; 
    public float _cutLifeTime; // ataca��m�z kesi�in belli bir s�re sonra silinmesi i�in
    private bool _dragging; 
    private Vector2 _swipeStart; // ba�lang�� pozisyonu i�in

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _dragging = true; // kesme i�lemi ba�lay�nca true de�ilse false
            _swipeStart = Camera.main.ScreenToWorldPoint(Input.mousePosition); // mouse pozisyonunu swipe start'a aktard�k
        }
        else if (Input.GetMouseButtonUp(0) && _dragging)
        {
            _dragging = false;
            CutSpawner();
        }
    }

    private void CutSpawner()
    {
        Vector2 _swipeEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject _cutInstance = Instantiate(_cutPrefab, _swipeStart, Quaternion.identity);

        _cutInstance.GetComponent<LineRenderer>().SetPosition(0, _swipeStart);
        _cutInstance.GetComponent<LineRenderer>().SetPosition(1, _swipeEnd);

        Vector2[] _colliderPoints = new Vector2[2];
        _colliderPoints[0] = Vector2.zero;
        _colliderPoints[1] = _swipeEnd - _swipeStart;

        _cutInstance.GetComponent<EdgeCollider2D>().points = _colliderPoints;

        Destroy(_cutInstance, _cutLifeTime);
    }
}

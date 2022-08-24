using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int _score;
    public TMP_Text _scoreText;


    void Update()
    {
        GameScore();
    }

    private void GameScore()
    {
        _scoreText.text = _score.ToString();    
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}

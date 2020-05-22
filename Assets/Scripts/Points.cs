using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

    [SerializeField]
    public GameObject _pipe;

    [SerializeField]
    public GameObject _player;

    private int _runScore=0;

    public Text _currentScore;
    public Text _highscore;
    

    private void Start()
    {
        _currentScore.text = _runScore.ToString();
        _highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    void Update()
    {
        GameStart();
    }

    private void GameStart()
    {
        if(_pipe.transform.position.x < _player.transform.position.x)
        {
            Scoring();
        }
    }

    private void Scoring()
    {
        _runScore++;
        if (_runScore > PlayerPrefs.GetInt("HighScore", 0)){
        PlayerPrefs.SetInt("HighScore", _runScore);
        }
        _currentScore.text = _runScore.ToString();
    }

}

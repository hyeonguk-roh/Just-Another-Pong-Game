using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _computerScore;
    public TMP_Text playerscore;
    public TMP_Text computerscore;

    void Update()
    {
        playerscore.text = _playerScore.ToString();
        computerscore.text = _computerScore.ToString();
    }

    public void PlayerScores()
    {
        _playerScore++;

        this.ball.ResetPosition();
    }

    public void ComputerScores()
    {
        _computerScore++;

        this.ball.ResetPosition();
    }
}

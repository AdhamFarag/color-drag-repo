using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int playerScore;
    public int playerHighScore;

    public GameObject scoreText;
    public GameObject highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        playerHighScore = PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerScore > playerHighScore)
        {
            playerHighScore = playerScore;
            PlayerPrefs.SetInt("highscore", playerHighScore);

        }
        scoreText.GetComponent<TextMeshProUGUI>().text = playerScore.ToString();
        highScoreText.GetComponent<TextMeshProUGUI>().text = "Best: " + playerHighScore.ToString();
    }
}

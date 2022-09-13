using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public FlyingMovement player;

    public Text scoreText;
    public GameObject playButton;
    public GameObject returnToMenu;
    public GameObject gameOver;
    public GameObject pressPlay;
    public Text foreverScore;

    public int score;
    public int flyingScore;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        Pause();

        flyingScore = PlayerPrefs.GetInt("flyingScore");
        foreverScore.text = flyingScore.ToString();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        returnToMenu.SetActive(false);
        gameOver.SetActive(false);
        pressPlay.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;




        FlyingScore[] flyingScore = FindObjectsOfType<FlyingScore>();

        for (int i = 0; i < flyingScore.Length; i++)
        {
            Destroy(flyingScore[i].gameObject);
        }

        FlyingEnemy[] flyingEnemy = FindObjectsOfType<FlyingEnemy>();

        for (int i = 0; i < flyingEnemy.Length; i++)
        {
            Destroy(flyingEnemy[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;


    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        returnToMenu.SetActive(true);
        playButton.SetActive(true);


        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void FlyingScore()
    {

        flyingScore++;
        foreverScore.text = flyingScore.ToString();
        PlayerPrefs.SetInt("flyingScore", flyingScore);

    }


}

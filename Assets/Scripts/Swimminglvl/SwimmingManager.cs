using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwimmingManager : MonoBehaviour
{
    public SwimmingMovement player;

    public Text scoreText;
    public GameObject playButton;
    public GameObject returnToMenu;
    public GameObject gameOver;
    public GameObject pressPlay;
    public Text foreverScore;

    private int score;
    public int swimmingScore;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        Pause();

        swimmingScore = PlayerPrefs.GetInt("swimmingScore");
        foreverScore.text = swimmingScore.ToString();

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

        //tuohaa n�kyvill� olevat putket kun peli alkaa
        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
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

    public void SwimmingScore()
    {
        swimmingScore++;
        foreverScore.text = swimmingScore.ToString();
        PlayerPrefs.SetInt("swimmingScore", swimmingScore);
    }
}

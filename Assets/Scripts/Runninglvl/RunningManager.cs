using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunningManager : MonoBehaviour
{
    public RunningMovement player;

    Vector3 originalPos;

    public Text scoreText;
    public GameObject playButton;
    public GameObject returnToMenu;
    public GameObject gameOver;
    public GameObject pressPlay;
    public Text foreverScore;

    public GameObject ohjeet;
    public GameObject paneeli;

    public int score;
    public int runningScore;

    public AudioSource batwings;
    public AudioSource loseSound;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        Pause();

        runningScore = PlayerPrefs.GetInt("runningScore");
        foreverScore.text = runningScore.ToString();

        originalPos = player.transform.position;

        AudioSource batwings = GetComponent<AudioSource>();
        AudioSource loseSound = GetComponent<AudioSource>();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        returnToMenu.SetActive(false);
        gameOver.SetActive(false);
        pressPlay.SetActive(false);

        ohjeet.SetActive(false);
        paneeli.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        batwings.Play();

        RunningEnemy[] runningEnemy = FindObjectsOfType<RunningEnemy>();

        for (int i = 0; i < runningEnemy.Length; i++)
        {
            Destroy(runningEnemy[i].gameObject);
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;

        batwings.Stop();
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        returnToMenu.SetActive(true);
        playButton.SetActive(true);

        //palauttaa pelaajan alkuperäiseen kohtaan
        player.transform.position = originalPos;

        Pause();

        loseSound.Play();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void RunningScore()
    {

        runningScore++;
        foreverScore.text = runningScore.ToString();
        PlayerPrefs.SetInt("runningScore", runningScore);

    }


}

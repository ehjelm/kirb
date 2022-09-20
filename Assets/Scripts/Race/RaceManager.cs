using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceManager : MonoBehaviour
{
    public RaceRun player;

    Vector3 originalPos;

    
    public GameObject playButton;
    public GameObject returnToMenu;
    public GameObject gameOver;
    public GameObject pressPlay;

    public AudioSource batwings;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        gameOver.SetActive(false);
        Pause();

        

        originalPos = player.transform.position;

        AudioSource batwings = GetComponent<AudioSource>();
    }

    public void Play()
    {
        

        playButton.SetActive(false);
        returnToMenu.SetActive(false);
        gameOver.SetActive(false);
        pressPlay.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        batwings.Play();

        /*RunningEnemy[] runningEnemy = FindObjectsOfType<RunningEnemy>();

        for (int i = 0; i < runningEnemy.Length; i++)
        {
            Destroy(runningEnemy[i].gameObject);
        }*/
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
    }
}

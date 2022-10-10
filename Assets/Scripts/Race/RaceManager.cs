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


    public  GameObject starOne;
    public  GameObject starTwo;
    public  GameObject medalOne;
    public  GameObject medalTwo;
    public GameObject winner;
    public  GameObject winScreen;
    public GameObject banner;

    public AudioSource batwings;

    public GameObject kamera;
    


    private void Awake()
    {
        starOne.SetActive(false);
        starTwo.SetActive(false);
        medalOne.SetActive(false);
        medalTwo.SetActive(false);
        winner.SetActive(false);
        winScreen.SetActive(false);
        banner.SetActive(false);

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

        starOne.SetActive(false);
        starTwo.SetActive(false);
        medalOne.SetActive(false);
        medalTwo.SetActive(false);
        winner.SetActive(false);
        winScreen.SetActive(false);
        banner.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        batwings.Play();

        kamera.transform.position = originalPos;

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

    public void WinGame ()
    {
        starOne.SetActive(true);
        starTwo.SetActive(true);
        medalOne.SetActive(true);
        medalTwo.SetActive(true);
        winner.SetActive(true);
        winScreen.SetActive(true);
        banner.SetActive(true);
        returnToMenu.SetActive(true);
        playButton.SetActive(true);

        //palauttaa pelaajan alkuperäiseen kohtaan
        player.transform.position = originalPos;

        Pause();

    }
}

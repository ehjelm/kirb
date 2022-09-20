using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text flyingScoreText;
    public int flyingScore;

    public Text swimmingScoreText;
    public int swimmingScore;

    public Text runningScoreText;
    public int runningScore;

    public GameObject resetButton;
    

    public Slider slider;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        flyingScore = PlayerPrefs.GetInt("flyingScore");
        flyingScoreText.text = flyingScore.ToString();

        swimmingScore = PlayerPrefs.GetInt("swimmingScore");
        swimmingScoreText.text = swimmingScore.ToString();

        runningScore = PlayerPrefs.GetInt("runningScore");
        runningScoreText.text = runningScore.ToString();

    }


    public void ResetProgress()
    {

        flyingScore = 0;
        flyingScoreText.text = flyingScore.ToString();
        PlayerPrefs.SetInt("flyingScore", 0);

        swimmingScore = 0;
        swimmingScoreText.text = flyingScore.ToString();
        PlayerPrefs.SetInt("swimmingScore", 0);

        runningScore = 0;
        runningScoreText.text = runningScore.ToString();
        PlayerPrefs.SetInt("runningScore", 0);


    }

    public void SaveScore()
    {
        SaveSystem.SaveScore(this);
    }



    public void LoadScore()
    {
        ScoreData data = SaveSystem.LoadScore();

        swimmingScore = data.swimScore;
        runningScore = data.runScore;
        flyingScore = data.flyScore;

        flyingScoreText.text = flyingScore.ToString();
        swimmingScoreText.text = flyingScore.ToString();
        runningScoreText.text = runningScore.ToString();

    }


}

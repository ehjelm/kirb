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

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ResetProgress()
    {

        flyingScore = 0;
        flyingScoreText.text = flyingScore.ToString();
        PlayerPrefs.SetInt("flyingScore", 0);

        swimmingScore = 0;
        swimmingScoreText.text = flyingScore.ToString();
        PlayerPrefs.SetInt("swimmingScore", 0);
        

    }
}

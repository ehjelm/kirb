using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text flyingScoreText;
    public int flyingScore;

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
        

    }
}

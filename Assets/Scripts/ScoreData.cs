using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ScoreData {
    
    public int swimScore;
    public int runScore;
    public int flyScore;

    public ScoreData (Score score)
    {
        swimScore = PlayerPrefs.GetInt("swimmingScore");
        runScore = PlayerPrefs.GetInt("runningScore");
        flyScore = PlayerPrefs.GetInt("flyingScore");
    }

}

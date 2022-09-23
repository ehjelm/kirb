using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunningSlider : MonoBehaviour
{
    private Slider slider;
    public float targetProgress;

    public GameObject resetButton;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        targetProgress = PlayerPrefs.GetInt("runningScore");
    }


    void Update()
    {
        slider.value = targetProgress;
    }

    public void ResetProgress()
    {
        targetProgress = 0;
    }



    /*public void IncrementProgress(float newProgress)
    {
        targetProgress =  newProgress;
    }*/
}

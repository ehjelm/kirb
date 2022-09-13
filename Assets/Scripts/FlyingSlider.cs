using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlyingSlider : MonoBehaviour
{

    private Slider slider;
    public float targetProgress;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        targetProgress = PlayerPrefs.GetInt("flyingScore");
    }

    
    void Update()
    {
        slider.value = targetProgress;
    }


    /*public void IncrementProgress(float newProgress)
    {
        targetProgress =  newProgress;
    }*/
}

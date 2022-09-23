using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{

    private float playerEnergy;
    Vector3  jaksamisPiste;

    private float flyingProgress;
    private float runningProgress;
    private float swimmingProgress;

    // Start is called before the first frame update
    void Start()
    {

        flyingProgress = PlayerPrefs.GetInt("flyingScore");
        runningProgress = PlayerPrefs.GetInt("runningScore");
        swimmingProgress = PlayerPrefs.GetInt("swimmingScore");

        playerEnergy = (swimmingProgress + runningProgress + flyingProgress) / 3 * 10;

        jaksamisPiste = new Vector3(playerEnergy, transform.position.y, -10);

        Debug.Log(" flyingProgress: " + flyingProgress + " runningProgress: " + runningProgress + " swimmingProgress: " + swimmingProgress + " player energy point: " + playerEnergy);

    }

    // Update is called once per frame
    void Update()
    {

       /* if (Mathf.Approximately(playerEnergy, transform.position.x))
        {
            //FindObjectOfType<RaceManager>().GameOver();
            Debug.Log("Point reached");
        }*/
        
        if(transform.position == jaksamisPiste)
        {
            //FindObjectOfType<RaceManager>().GameOver();
            Debug.Log("Point reached");
        }


        /*if (playerBat.transform.position == new Vector3(playerEnergy, transform.position.y, -10))
        {
            //FindObjectOfType<RaceManager>().GameOver();
            Debug.Log("Point reached");
        }*/

    }
}

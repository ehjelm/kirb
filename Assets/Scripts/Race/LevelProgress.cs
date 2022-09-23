using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelProgress : MonoBehaviour
{

    public GameObject playerBat;

    private float playerEnergy;
    private Transform jaksamisPiste;

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
        //jaksamisPiste = playerEnergy;

        Debug.Log(" flyingProgress: " + flyingProgress + " runningProgress: " + runningProgress + " swimmingProgress: " + swimmingProgress +  " player energy point: " + playerEnergy);

    }

    // Update is called once per frame
    void Update()
    {

       /* if (Mathf.Approximately(playerBat.position.x, playerEnergy))
        {
            //FindObjectOfType<RaceManager>().GameOver();
            Debug.Log("Point reached");
        }*/




        /*if (playerBat.transform.position == new Vector3(playerEnergy, transform.position.y, -10))
        {
            //FindObjectOfType<RaceManager>().GameOver();
            Debug.Log("Point reached");
        }*/

    }
}

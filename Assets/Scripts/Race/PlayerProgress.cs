using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    
    private float playerEnergy;
    public Vector3  jaksamisPiste;
    public GameObject jaksamisPistePrefab;

    private float flyingProgress;
    private float runningProgress;
    private float swimmingProgress;

    

    // Start is called before the first frame update
    void Start()
    {
        /* lasketaan yhteen pistem‰‰r‰t ja jaetaan ne, jotta niist‰ tuleva luku voidaan asettaa janalle 0-1000.
        jaksamisPiste on kohta kent‰ss‰/janalla, jossa pelaaja v‰s‰ht‰‰. Siihen spawnataan objekti t‰gill‰ "enemy", joka
        aiheuttaa pelin h‰vi‰misen*/
        flyingProgress = PlayerPrefs.GetInt("flyingScore");
        runningProgress = PlayerPrefs.GetInt("runningScore");
        swimmingProgress = PlayerPrefs.GetInt("swimmingScore");

        playerEnergy = (swimmingProgress + runningProgress + flyingProgress) / 3 * 10;
        jaksamisPiste = new Vector3(playerEnergy, transform.position.y, -10);

        Debug.Log(" flyingProgress: " + flyingProgress + " runningProgress: " + runningProgress + " swimmingProgress: " + swimmingProgress + " player energy point: " + playerEnergy);
        Debug.Log("jaksamispiste location" + jaksamisPiste);

        Instantiate(jaksamisPistePrefab, jaksamisPiste, Quaternion.identity);
    }

    
    void Update()
    {

    }
}

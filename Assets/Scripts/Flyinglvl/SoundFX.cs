using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    public AudioSource select;

    public void PlaySelect()
    {
        select.Play();
    }

}

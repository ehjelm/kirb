using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confirmation : MonoBehaviour
{

    public GameObject exitConfirm;
    public GameObject returnButton;
    public GameObject sureText;
    public GameObject panel;

    public GameObject yes;
    public GameObject no;
    public GameObject resetText;
    public GameObject resetpanel;


    public void Awake()
    {
        exitConfirm.SetActive(false);
        returnButton.SetActive(false);
        sureText.SetActive(false);
        panel.SetActive(false);

        yes.SetActive(false);
        no.SetActive(false);
        resetText.SetActive(false);
        resetpanel.SetActive(false);
    }




    public void ConfirmExit()
    {
        exitConfirm.SetActive(true);
        returnButton.SetActive(true);
        sureText.SetActive(true);
        panel.SetActive(true);
    }



    public void ConfirmReset()
    {
        yes.SetActive(true);
        no.SetActive(true);
        yes.SetActive(true);
        no.SetActive(true);
        resetText.SetActive(true);
        resetpanel.SetActive(true);
    }

    public void ResetProgressYes()
    {
        yes.SetActive(false);
        no.SetActive(false);
        resetText.SetActive(false);
        resetpanel.SetActive(false);
    }



    public void ReturnToGame()
    {
        exitConfirm.SetActive(false);
        returnButton.SetActive(false);
        sureText.SetActive(false);
        panel.SetActive(false);

        yes.SetActive(false);
        no.SetActive(false);
        resetText.SetActive(false);
        resetpanel.SetActive(false);
    }

}

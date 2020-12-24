using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeViewbox : MonoBehaviour, IInteractable
{
    public Camera mainCam;
    public Camera birdEyeCam;
    
    public void OnInteract()
    {
        if (birdEyeCam.enabled)
        {
            birdEyeCam.enabled = false;
            mainCam.enabled = true;
        }
        else
        {
            birdEyeCam.enabled = true;
            mainCam.enabled = false;
        }
    }

    public string GetPrompt()
    {
        return "Switch Camera View";
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show : MonoBehaviour
{
    public GameObject details;
    public AudioSource elementname;

    public void DisplayOn()
    {
        details.SetActive(true);
        elementname.Play();
    }

    public void DisplayOff() 
    { 
        details.SetActive(false);
    }
}

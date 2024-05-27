using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    public GameObject original;
    public GameObject blue;
    public GameObject red;
    public GameObject blue1;
    public GameObject red1;
    public AudioSource blue2;
    public AudioSource red2;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "cucl2")
        {
            original.SetActive(false);
            blue.SetActive(true);
            blue1.SetActive(true);
            blue2.Play();
            Debug.Log("collided in");
        }

        if (col.gameObject.tag == "srcl2")
        {
            original.SetActive(false);
            red.SetActive(true);
            red1.SetActive(true);
            red2.Play();
            Debug.Log("collided in 2");
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "cucl2")
        {
            original.SetActive(true);
            blue.SetActive(false);
            blue1.SetActive(false);
            Debug.Log("collided out");
        }

        if (col.gameObject.tag == "srcl2")
        {
            original.SetActive(true);
            red.SetActive(false);
            red1.SetActive(false);
            Debug.Log("collided out 2");
        }
    }
}

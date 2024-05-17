using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    public GameObject original;
    public GameObject blue;
    public GameObject red;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "cucl2")
        {
            original.SetActive(false);
            blue.SetActive(true);
            Debug.Log("collided in");
        }

        if (col.gameObject.tag == "srcl2")
        {
            original.SetActive(false);
            red.SetActive(true);
            Debug.Log("collided in 2");
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "cucl2")
        {
            original.SetActive(true);
            blue.SetActive(false);
            Debug.Log("collided out");
        }

        if (col.gameObject.tag == "srcl2")
        {
            original.SetActive(true);
            red.SetActive(false);
            Debug.Log("collided out 2");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public string sceneToLoad;

    public void change()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutScript : MonoBehaviour
{
    public void Scan()
    {
        SceneManager.LoadScene("StartAR");
    }

    public void GoHome()
    {
        SceneManager.LoadScene("Home Page");
    }
}

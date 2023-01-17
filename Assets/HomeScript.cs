using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScript : MonoBehaviour
{
    public void Scan()
    {
        SceneManager.LoadScene("StartAR");
    }

    public void GoAbout()
    {
        SceneManager.LoadScene("About Page");
    }

    public void GoListZodiac()
    {
        SceneManager.LoadScene("List Zodiac");
    }
}

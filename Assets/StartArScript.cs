using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartArScript : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("Home Page");
    }
}

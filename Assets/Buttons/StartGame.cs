using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void OnStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void OnMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Cursor.lockState = CursorLockMode.None;
    }
}

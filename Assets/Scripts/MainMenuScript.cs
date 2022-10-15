using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayButton()
    {
        Debug.Log("gogogo!");
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}

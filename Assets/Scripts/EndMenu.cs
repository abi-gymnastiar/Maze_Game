using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public void BackMenuButton()
    {
        Debug.Log("back to menu");
        SceneManager.LoadScene(0);
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}

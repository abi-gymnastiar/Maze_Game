using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DyingScreenScript : MonoBehaviour
{
    public void RetryButton()
    {
        Debug.Log("retry");
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("exit");
    }
}

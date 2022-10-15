using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            Debug.Log("finish!");
            SceneManager.LoadScene(sceneIndex+1);
        }
    }
}

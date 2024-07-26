using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endOfLevel : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
            if (nextLevel < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(nextLevel);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}

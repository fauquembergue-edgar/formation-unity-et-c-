using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathZones : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Recharger la scène actuelle
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}


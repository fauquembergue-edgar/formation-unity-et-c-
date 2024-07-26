using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinDetection : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Log pour le débogage
            Debug.Log("Pièce collectée!");

            // Détruire la pièce
            Destroy(gameObject);
        }
    }
}


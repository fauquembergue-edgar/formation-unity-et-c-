using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinDetection : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Log pour le d�bogage
            Debug.Log("Pi�ce collect�e!");

            // D�truire la pi�ce
            Destroy(gameObject);
        }
    }
}


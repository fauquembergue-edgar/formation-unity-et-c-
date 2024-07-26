using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
    public Transform[] teleportPoints;  // Points de téléportation définis dans l'inspecteur
    public GameObject[] cameras;        // Caméras à activer/désactiver définies dans l'inspecteur

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("suite1"))
        {
            transform.position = teleportPoints[0].position;
            cameras[1].SetActive(true);
            cameras[0].SetActive(false);
        }
        else if (collision.CompareTag("suite2"))
        {
            transform.position = teleportPoints[1].position;
            cameras[2].SetActive(true);
            cameras[1].SetActive(false);
        }
    }
}

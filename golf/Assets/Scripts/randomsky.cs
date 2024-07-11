using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomsky : MonoBehaviour
{
    public Material[] mat;   //liste des ciels

    void Start()
    {
        int random = Random.Range(0, mat.Length);  // nbr aléatoire
        RenderSettings.skybox = mat[random];  // modif de skybox
    }

    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", value: 0.75f * Time.time);
    }
}

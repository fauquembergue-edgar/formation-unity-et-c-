using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class balle : MonoBehaviour
{
    public GameObject winParticles;
    public Text text;
    public shot shotScript;
    public GameObject panelFin;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "fall")
        {
            SFXManager.Instance.PlaySfxById(2);
            StartCoroutine("LoadLevelAfterSecond");
        }
        if (other.gameObject.tag == "fin")
        {
            int score = (10 - shotScript.nbShots) * 100;
            if (score < 0)
            {
                score = 0;
            }
            GameManager.Instance.score += score;

            Instantiate(winParticles, transform.position, Quaternion.identity);
            SFXManager.Instance.PlaySfxById(0);
            text.text = "Terminé en " + shotScript.nbShots +" coup(s) !";
            panelFin.SetActive(true);
            
        }
    }
    IEnumerator LoadLevelAfterSecond()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

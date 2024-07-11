using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class panelFin : MonoBehaviour
{
    public Text textScore;

    private void Start()
    {
        SetTotalScore();
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void GoToNextLevel()
    {
        print("go to next level !");
        int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextLevel < 11)
        {
            SceneManager.LoadScene(nextLevel);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    public void UnlockNextLevel(int lvl)
    {
        int lastUnlockedLevel = PlayerPrefs.GetInt("lastLevel");
        if(lvl > lastUnlockedLevel)
        {
            PlayerPrefs.SetInt("lastLevel", lvl);
        }

    }

    public void SetTotalScore()
    {
        textScore.text = "Votre score total : " + GameManager.Instance.score;
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject htp;
    public void Play()
    {
        SceneManager.LoadScene("Level");
    }

    public void HowToPlay()
    {
        htp.SetActive(true);
    }

    public void closeHTP()
    {
        htp.SetActive(false);

    }

    public void Quit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

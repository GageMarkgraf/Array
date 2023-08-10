using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Player Has Quit");
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(1);
    }
    public void LevelOne()
    {
        SceneManager.LoadScene(3);
    }
}

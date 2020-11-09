using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

     public GameObject DeathMenuUI;


    // Update is called once per frame
    void Update()
    {
    
    }

    public void Restart ()
    {
      DeathMenuUI.SetActive(false);
      Time.timeScale = 1f;
      GameIsPaused = false;

    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1 );
    }

    void Pause ()
    {
      DeathMenuUI.SetActive(true);
      Time.timeScale =0f;
      GameIsPaused = true;
    }

    public void LoadMenu()
    {
       SceneManager.LoadScene("Main_Menu");
    }

    public void QuitGame()
    {
       Debug.Log("Quitting game...");
       Application.Quit();
    }
}

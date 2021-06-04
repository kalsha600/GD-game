using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    
    public static bool isGamePaused = false;

  [SerializeField] GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          
          
            if (isGamePaused)
            {
                Resumegame();
                
            }
            else
            {
                PauseGame();
                
            }
            Input.GetKeyDown(null);
            
        }
    }
    public void Resumegame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
       


    }
    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    

    }

    public void loadMenu(){

        SceneManager.LoadScene("Menu");
        

    }
    public void QuitGame(){

      Debug.Log("Quit the Game");
      Application.Quit();
    

  }
}

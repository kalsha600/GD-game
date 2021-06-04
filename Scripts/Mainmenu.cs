using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{


    public AudioSource hurtSound;

    public void playTheGame(){ 

      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        hurtSound.Play();
    }

  public void QuitTheGame(){

      Debug.Log("Quit the Game");
      Application.Quit();
      hurtSound.Play();

    }
}

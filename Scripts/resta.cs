using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resta : MonoBehaviour
{

 

    // Start is called before the first frame update
    public void restartgame(){ 

      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       

    }
    public void loadMenu(){

         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
      
    }
    public void Nextlevel()
    {

        SceneManager.LoadScene("Scene_1_");


    }

}


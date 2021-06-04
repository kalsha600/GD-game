using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour
{

    public GameObject levelcomplite;
    public AudioSource hurtSound;

    //void Start()
    //{
    //    Endscrn.SetActive(false);
    //}
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            levelcomplite.gameObject.SetActive(true);
            hurtSound.Play();
        }
    }

  

    

}



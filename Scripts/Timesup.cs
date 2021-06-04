using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timesup : MonoBehaviour
{
    // Time's up ................................IT15099600
    Image timerBar;
    public float maxTime = 180f;
    float timeLeft;
    public GameObject timesUpText;
    public AudioSource hurtSound;


    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft >0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;

        }

        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
            hurtSound.Play();
        }
    }
}

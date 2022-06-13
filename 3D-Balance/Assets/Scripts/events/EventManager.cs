using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EventManager : MonoBehaviour
{
    public GameObject PauseScreen;
   // public GameObject PauseButton;
   bool alreadyCollided = false;

    bool GamePaused;

    private void Start()
    {
        GamePaused = false;
    }

    void Update()
    {
        if (GamePaused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball" && !alreadyCollided)
        {
            GamePaused = true;
            PauseScreen.SetActive(true);
           // PauseButton.SetActive(false);
           alreadyCollided = true;
        }
    }

    public void ResumeGame()
    {
        GamePaused = false;
        PauseScreen.SetActive(false);
        
       // PauseButton.SetActive(true);
    }







}

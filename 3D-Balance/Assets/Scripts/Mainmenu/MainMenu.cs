using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image panel;


    public void Start()
    {
        panel.gameObject.SetActive(false);
        StartCoroutine(delay());
    }

    public void PlayGame()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        SceneManager.LoadScene(3);
    }

    public void Quit()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        Application.Quit();
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(5f);
        panel.gameObject.SetActive(true);  
    }
}

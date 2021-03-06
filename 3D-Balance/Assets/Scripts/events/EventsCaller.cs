using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EventsCaller : MonoBehaviour
{
    public GameObject Explosion;
    public Image Heathbar;
    public float health, maxhealth = 100f;
    float lerpSpeed;
    int count = 0;
    float hurt = 20f;
    public TextMeshProUGUI DisplayText;
    public static event Action eventcaller;
    public static event Action eventcaller2;
    public static event Action eventcaller3;
    private BallSize ballSize;

    bool GameEnded = false;

    private void Start()
    {
        Explosion.SetActive(false);
        ballSize = FindObjectOfType<BallSize>();
        EventsCaller.eventcaller2 += Counter;
        EventsCaller.eventcaller3 += Damage;
        health = maxhealth;
    }

    private void Update()
    {
        lerpSpeed = 3 * Time.deltaTime;
        


        if (health > maxhealth) health = maxhealth;
        HealthbarFiller();
        ColorChange();

        eventcaller?.Invoke();

        explosion();

    }




    public static void Counting()
    {
        eventcaller2?.Invoke();
    }

    public void Counter()
    {
        
        count++;

        DisplayText.text = "Point :- " + count;
    }

    private void OnDisable()
    {
        EventsCaller.eventcaller2 -= Counter;
        EventsCaller.eventcaller3 -= Damage;    
    }

    public void explosion()
    {
        if(health <1)
        {
            FindObjectOfType<AudioManager>().Play("Explod");
            StartCoroutine(load());
            //GameObject explosion = Instantiate(Explosion, transform.position, transform.rotation);
            //Destroy(explosion, 0.1f);
            EndGame();
        }
    }









    public static void DamageEvent()
    {
        eventcaller3?.Invoke();
    }
    public void HealthbarFiller()
    {
        Heathbar.fillAmount = Mathf.Lerp(Heathbar.fillAmount, health / maxhealth, lerpSpeed);
    }

    void ColorChange()
    {
        Color healthcolor = Color.Lerp(Color.red, Color.green, (health / maxhealth));
        Heathbar.color = healthcolor;
    }

    public void Damage()
    {
        
            health -= hurt;
    }



    public void EndGame()
    {
        if(GameEnded == false)
        {
            GameEnded = true;
            Restart();
        }
    }

    void Restart()
    {
        StartCoroutine(change());
    }


    IEnumerator change()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(2);
    }

    IEnumerator load()
    {
        yield return new WaitForSeconds(0.2f);
        Explosion.SetActive(true);
    }
}

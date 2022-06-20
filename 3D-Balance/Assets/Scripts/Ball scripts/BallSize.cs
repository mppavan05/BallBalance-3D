using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallSize : MonoBehaviour
{
    public GameObject Blast;
    public Image Heathbar;
    bool iscollided = false;

    public float health, maxhealth = 100f;
    float lerpSpeed;

    public int count = 0;


    private void Start()
    {
        EventsCaller.eventcaller += BallSizeController;
        health = maxhealth;
    }

    private void Update()
    {
        lerpSpeed = 3 * Time.deltaTime;
        //BallSizeController();

       
        if(health > maxhealth) health = maxhealth;
        HealthbarFiller();
        ColorChange();


       // Debug.Log(health);
    }

    public void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<AudioManager>().Play("Bounce");
        if (collision.collider.CompareTag("Disk"))
        {
            
            iscollided = true;
        }

    }

    public void BallSizeController()
    {

        if(iscollided == true )
        {
            this.transform.localScale = this.transform.localScale - new Vector3(0.01f, 0.01f, 0.01f) * Time.deltaTime/2;

            //Debug.Log(transform.localScale.x);
            health -= transform.localScale.x;
        }

        if(health < 0)
        {
            EventsCaller.Counting(); 
            Debug.Log("hello");
            Destroy(GameObject.FindWithTag("Ball"));
            GameObject explosion = Instantiate(Blast, transform.position, transform.rotation);
            Destroy(explosion, 0.5f);
            FindObjectOfType<AudioManager>().Play("SmallB");
        }

       // if (health > 0)
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

    private void OnDisable()
    {
        EventsCaller.eventcaller -= BallSizeController;
    }

}

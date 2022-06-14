using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSize : MonoBehaviour
{
   bool iscollided = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        BallSizeController();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Disk"))
        {
            iscollided = true;
        }

    }

    public void BallSizeController()
    {
        if(iscollided == true)
        {
            this.transform.localScale = this.transform.localScale - new Vector3(0.01f, 0.01f, 0.01f) * Time.deltaTime/2;
        }
        
    }
}

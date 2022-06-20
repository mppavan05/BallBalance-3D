using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Destroying : MonoBehaviour
{
    public CinemachineImpulseSource m_ImpulseSource;

    void Start()
    {
        m_ImpulseSource = transform.GetComponent<CinemachineImpulseSource>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            EventsCaller.DamageEvent();
            Destroy(collision.gameObject);
        }

    }

   /* IEnumerator Shaking(Collision colliding)
    {
        Debug.Log("before");
        m_ImpulseSource.GenerateImpulse(10f);
        yield return new WaitForSeconds(1f);
        
        Debug.Log(m_ImpulseSource);
    }*/


}


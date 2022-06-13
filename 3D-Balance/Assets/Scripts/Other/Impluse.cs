using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Impluse : MonoBehaviour
{

    CinemachineImpulseSource m_ImpulseSource;
    // Start is called before the first frame update
    void Start()
    {
        m_ImpulseSource = transform.GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
           Invoke("shake", 0);
        }
        
    }

    void shake()
    {
        m_ImpulseSource.GenerateImpulse(10f);
    }
}

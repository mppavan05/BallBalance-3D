using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject Balls;
    public float radius = 1;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            spawnObject();
        }
    }

    void spawnObject()
    {
        Vector3 randompos = Random.onUnitSphere * radius;

        Instantiate(Balls, randompos, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(this.transform.position, radius);
    }
}


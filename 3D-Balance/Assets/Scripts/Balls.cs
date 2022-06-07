using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public GameObject[] myObjects;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            int RandomIndex = Random.Range(0, myObjects.Length);
            Vector3 RandomSpwaner = new Vector3(Random.Range(-5, 5), 20, Random.Range(-5, 5));

            Instantiate(myObjects[RandomIndex], RandomSpwaner, Quaternion.identity);
        }
        
    }
}

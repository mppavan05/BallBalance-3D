using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Following : MonoBehaviour
{
    Camera cam;
    Collider plaincollider;
    RaycastHit hit;
    Ray ray;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        plaincollider = GameObject.Find("Base").GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider == plaincollider)
            {
                transform.position = Vector3.MoveTowards(transform.position, hit.point, Time.deltaTime * 5);
            }
        }
    }
}*/

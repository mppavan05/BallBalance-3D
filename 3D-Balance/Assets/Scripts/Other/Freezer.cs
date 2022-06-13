using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freezer : MonoBehaviour
{
    private float duration = 100f;

    bool _isFrozen = false;
    float pendingFreezeDuration = 0f;

    private void Update()
    {
        if(pendingFreezeDuration < 0f && !_isFrozen)
        {
            
        }
    }

    public void Freeze()
    {
        pendingFreezeDuration = duration;
    }

    IEnumerator DoFreeze()
    {
        _isFrozen = true;
        var orginal = Time.timeScale;
        Time.timeScale = 0f;    

        yield return new WaitForSecondsRealtime(duration);

        Time.timeScale = orginal;
        pendingFreezeDuration = 0;
        _isFrozen = false;
    }
}


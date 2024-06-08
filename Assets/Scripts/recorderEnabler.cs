using Photon.Voice.PUN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recorderEnabler : MonoBehaviour
{
    // Start is called before the first frame update
    public PunVoiceClient gmo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TriggerPlayer.x)
        {
            gmo.enabled = true;
        }
        else
        {
            gmo.enabled = false;
        }
    }
}

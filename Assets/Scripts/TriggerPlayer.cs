using Photon.Voice.PUN;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Profiling;

public class TriggerPlayer : MonoBehaviour
{
    public static bool x = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        x = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        x=false;
    }
}

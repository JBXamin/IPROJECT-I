using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    private float x,y;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        transform.position += (Vector3)new Vector2(x * speed * Time.deltaTime, 0);
        y = Input.GetAxis("Vertical");
        transform.position += (Vector3)new Vector2(0, y * speed * Time.deltaTime);
    }
}

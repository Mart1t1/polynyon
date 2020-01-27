using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moves : MonoBehaviour
{
    public Rigidbody perso;

    public int déplacement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("q"))
        {
            transform.Translate(new Vector3(-50f*Time.deltaTime, 0, 0));
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(50f*Time.deltaTime, 0, 0));
        }
        if (Input.GetKey("z"))
        {
            transform.Translate(new Vector3(0, 0, 50f*Time.deltaTime));
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, 0, -50f*Time.deltaTime));
        }
    }
}
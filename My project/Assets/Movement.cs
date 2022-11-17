using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay($"{{{nameof(DebuggerDisplay)}(),nq}}")]
public class Movement : MonoBehaviour
{
    float rotationspeed = 180;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.forward * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0, 1), rotationspeed * Time.deltaTime);

        }
        {
            if (Input.GetKey(KeyCode.UpArrow))


        } 
                    transform.Rotate(new Vector3(1, 0, 0), rotationspeed * Time.deltaTime);
            
                }
           velocity += acceleration * Time.deltaTimel
                    transform.position += velocity * Time.deltaTime;

    private string DebuggerDisplay => ToString();
}
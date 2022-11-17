using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mOV : MonoBehaviour
{
    public float speed = 2;
      
    void Update()
    {
        Vector3 movementDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.Translate(movementDirection.normalized * speed * Time.delatime);
    }
}

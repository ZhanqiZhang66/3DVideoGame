using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RotateView : MonoBehaviour
{

    public float speed = -1f;

    void Update()
    {
        Vector3 movement = new Vector3(0, 0, speed);


        // Rotate our platform on user's command
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Rotate(0f, 0f, 120f);
        }

        //rb.AddForce(movement * speed);
        transform.Translate(movement * Time.deltaTime);


    }


}

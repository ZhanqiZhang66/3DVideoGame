using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class RotateView : MonoBehaviour
{

    public float speed = -1f;

    private void Start()
    {

        AudioProcessor processor = FindObjectOfType<AudioProcessor>();
        processor.onBeat.AddListener(onOnbeatDetected);

    }

    void Update()
    {
        Vector3 movement = new Vector3(0, 0, speed);
        transform.Translate(movement * Time.deltaTime);
        //rb.AddForce(movement * speed);

        if (SceneManager.GetActiveScene().name != "Try")
        {
            // Rotate our platform on user's command
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.Rotate(0f, 0f, 120f);
            }

            transform.Translate(movement * Time.deltaTime);
        }

        //transform.Translate(movement * Time.deltaTime);
    }

    void onOnbeatDetected()
    {
        //transform.Rotate(0f, 0f, 120f);
    }


}

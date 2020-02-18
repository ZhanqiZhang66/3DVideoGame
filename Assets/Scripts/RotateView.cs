using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateView : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        // Get Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Rotate our platform 
            transform.Rotate(0f, 0f, 120f);
        }
        
    }
}

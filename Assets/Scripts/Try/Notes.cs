using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public float beatTempo;

    public bool started;

    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            transform.position -= new Vector3(0f, 0f, beatTempo * Time.deltaTime);
        }
        
    }
}

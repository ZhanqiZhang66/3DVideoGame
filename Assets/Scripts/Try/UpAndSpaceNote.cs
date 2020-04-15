using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndSpaceNote : MonoBehaviour
{
    public bool canBePressed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.W))
        {
            if (canBePressed)
            {
                Destroy(gameObject);
                GameController.instance.NormalHit();

            }
        }
        else
        {
            if (canBePressed)
            {
                GameController.instance.BadHit();
            }
            
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canBePressed = false;
        }
        GameController.instance.NoteMissed();
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

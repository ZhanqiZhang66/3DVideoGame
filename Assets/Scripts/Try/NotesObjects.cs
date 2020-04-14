using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesObjects : MonoBehaviour
{
    public bool canBePressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (canBePressed)
            {
                Destroy(gameObject);
                GameController.instance.NormalHit();

/*                if (transform.position.z >= -33.43)
                {
                    print("bad");
                    GameController.instance.BadHit();
                }else if(transform.position.z >= -33.8)
                {
                    print("normal");
                    GameController.instance.NormalHit();
                }else if(transform.position.z >= -34.08)
                {
                    print("good");
                    GameController.instance.GoodHit();
                }else if(transform.position.z >= -34.27)
                {
                    print("perfect");
                    GameController.instance.PerfectHit();
                }*/
                
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //print("trigger exit");
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

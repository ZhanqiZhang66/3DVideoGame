using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float score; //keep track of the score of our game
    public Transform[] positions; //left, right ,mid 3 position points
    int currentPos = 1;
    public float speed; //9.2
 

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        int len = positions.Length; 

        //move game object left
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (currentPos != len - 1) currentPos++;
        }

        //move game object right
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (currentPos != 0) currentPos--;
        }


        //transform the game object to the desired location
        transform.position = Vector3.MoveTowards(transform.position, positions[currentPos].position, speed * Time.deltaTime);

    }


}

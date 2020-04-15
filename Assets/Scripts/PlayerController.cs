using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float score; //keep track of the score of our game
    public Transform[] positions; //left, right ,mid 3 position points
    int currentPos = 1;
    public float speed; //9.2
    [SerializeField] ParticleSystem collectParticle = null;

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
    //void OnTriggerEnter(Collider other) {
    //    if(other.gameObject.layer == LayerMask.NameToLayer("Notes") )
    //    {
    //        Debug.Log("The player has collided with the cube");
    //            collectParticle.Play();
    //            Color transparencyColor = new Color(0, 0, 0, 10f);
    //            Renderer tempRenderer;
    //            tempRenderer = other.GetComponent<Renderer>();
    //            Debug.Log("tempRenderer.name = " + tempRenderer.name);
    //            tempRenderer.material.color = transparencyColor;
    //    }
    //}
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("The player has collided with the cube");
            collectParticle.Play();
            Color transparencyColor = new Color(0, 0, 0, 10f);
            Renderer tempRenderer;
            tempRenderer = other.GetComponent<Renderer>();
            Debug.Log("tempRenderer.name = " + tempRenderer.name);
            tempRenderer.material.color = transparencyColor;
        }
        if(other.tag == "EndGame")
        {
            SceneManager.LoadScene("Finish");
        }
    }

}

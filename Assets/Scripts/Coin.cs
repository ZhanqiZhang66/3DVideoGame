using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    public float speed = -580f;
    private void OnCollisionEnter(Collision collision)
    {
        PlayerController player = collision.gameObject.GetComponent<PlayerController>();
        if(player != null)
        {
            player.score++;
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void Update()
    {

        if (SceneManager.GetActiveScene().name == "Try")
        {
            Vector3 movement = new Vector3(0, 0, speed);

            transform.Translate(movement * Time.deltaTime);
        }
    }
}

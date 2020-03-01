using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public Transform[] spawnPoints;
    public GameObject coin;
    public GameObject ParentGameObject;





    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        AudioProcessor processor = FindObjectOfType<AudioProcessor>();
        processor.onBeat.AddListener(onOnbeatDetected);

    }

    void onOnbeatDetected()
    {
        // transform.Rotate(0f, 0f, 120f);
        // Debug.Log("Beat!!!");
        if (SceneManager.GetActiveScene().name != "Try")
        {
            SpawnCoin();
        }
    }

    void SpawnCoin()
    {
        Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

        GameObject Coin = Instantiate(coin, randomSpawnPoint.position, Quaternion.identity);

        Coin.transform.parent = ParentGameObject.transform;
    
        
    }
}

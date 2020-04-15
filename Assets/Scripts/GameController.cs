using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public AudioSource faded;
    public bool startMusic;

    public Notes notes;

    public int comboCount = 0;
    public int maxCombo = 0;
    public int currentScore = 0;
    public int scoreNormalNote = 100;
    public int scoreGoodNote = 120;
    public int scorePerfectNote = 150;
    public int multiplier = 1;
    public float percentage = 0;
    public int perfectScore = 0;


    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    private void Update()
    {
        if (!startMusic)
        {
            if (Input.anyKeyDown)
            {
                startMusic = true;
                notes.started = true;

                faded.Play();
            }
        }
    }

    public void Notehit()
    {
        comboCount++;
        perfectScore += scoreNormalNote * multiplier;
        percentage = currentScore / perfectScore;

        if (comboCount < 20)
        {
            multiplier = 1;
        }else if(comboCount >= 20 && comboCount < 50)
        {
            multiplier = 2;
        }
        else
        {
            multiplier = 3;
        }

    }

    public void NormalHit()
    {
        Notehit();
        currentScore += scoreNormalNote * multiplier;
    }

    public void GoodHit()
    {
        Notehit();
        currentScore += scoreGoodNote * multiplier;
    }

    public void PerfectHit()
    {
        Notehit();
        currentScore += scorePerfectNote * multiplier;
    }

    public void BadHit()
    {
        NoteMissed();
    }

    public void NoteMissed()
    {
        if(comboCount > maxCombo)
        {
            maxCombo = comboCount;
        }
        comboCount = 0;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingScene : MonoBehaviour
{
    public Text percentage;
    public Text maxCombo;

    public float p;
    public int c;
    // Start is called before the first frame update
    void Start()
    {
        p = GameController.instance.currentScore / GameController.instance.perfectScore;
        c = GameController.instance.maxCombo;
        percentage.text = "" + p;
        maxCombo.text = "" + c;
    }
}

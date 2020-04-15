using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndingScene : MonoBehaviour
{
    public Text percentage;
    public Text maxCombo;

    public double p;
    public int c;
    // Start is called before the first frame update
    void Start()
    {
        p = GameController.instance.currentScore * 1.0 / GameController.instance.perfectScore * 100;
        c = GameController.instance.maxCombo;
        percentage.text = "" + p.ToString("F2") + "%";
        maxCombo.text = "" + c;
    }
}

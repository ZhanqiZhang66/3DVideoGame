using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Combo : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI comboC;
    private static int score;  //  A new Static variable to hold our score.
    private static int fontSize;
    void Start(){
    comboC = GetComponent<TextMeshProUGUI>();
    score = 0;
    fontSize = 40;
    }
    void Update()
    {
        score = GameObject.Find("GameController").GetComponent<GameController>().comboCount;
	comboC.fontSize = 40 + (score * 5);
        if(score == 0) {
	comboC.text = "";
	} else {
	comboC.text = "X" + score;
	}
    }

    
}

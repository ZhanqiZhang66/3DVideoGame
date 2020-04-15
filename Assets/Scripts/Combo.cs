using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Combo : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI comboC;
    //public Text comboT;
    private static int score;  //  A new Static variable to hold our score.
    private static int fontSize;
    void Start(){
        comboC = GetComponent<TextMeshProUGUI>();
        //comboT = GetComponent<Text>();
        score = 0;
    }
    void Update()
    {
        score = GameObject.Find("GameController").GetComponent<GameController>().comboCount;
        if (score == 0) {
	        comboC.text = "";
            //comboT.text = "";
	    } else {
            comboC.text = "x" + score;
            bool updateText = true;
            if(updateText == true)
            {
                StartCoroutine(PopUp());
                updateText = false;
            }
            
            //comboT.text = "Combo";
        }
    }

    IEnumerator PopUp()
    {
        //print("inside popup");
        
        comboC.fontSize = 25;
        //Waits 10 frames , play with this
        for (int framecnt = 0; framecnt < 2; framecnt++)
        {
            yield return new WaitForEndOfFrame();
        }
        comboC.fontSize = 55;

    }


}

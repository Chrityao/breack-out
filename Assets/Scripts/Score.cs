using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // We have to add the UnityEngine.UI namespace in order to work with Text variables


public class Score : MonoBehaviour
{

    public Text ScoreupText;
    int Scoreup;
    int Life;




    void OnCollisionEnter2D(Collision2D col)
    {

        //this is our condition (if the ball collides with an object with the name Wallright)
        if (col.gameObject.name == "Wallright")
        {
            //this line will just add 1 point to the score
            Scoreup += 10;
            //this line will convert the int score variable to a string variable
            ScoreupText.text = Scoreup.ToString();

        }
        //this is our condition (if the ball collides with an object with the name Walldown)
        if (col.gameObject.name == "Walldown")
        {
            Scoreup -= 5;
            ScoreupText.text = Scoreup.ToString();
        }
       
    }
}
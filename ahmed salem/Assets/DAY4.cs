using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DAY4 : MonoBehaviour
{
    public int score = 0;
    public int inc = 1;

    public Text scoretext;
    public Text inctext;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void scoreup()
    {
        score += inc;
        scoretext.text = score.ToString();
    }

    public void shop()
    {
        if (score >= 5)
        {
            inc += 1;
            score -= 5;
            inctext.text = ("inc: " + inc);
            scoretext.text = score.ToString();
        }

    }
}

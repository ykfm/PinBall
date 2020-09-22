using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetScore();
    }

    void OnCollisionEnter(Collision collision)
    {
        string yourTag = collision.gameObject.tag;

        if (yourTag == "SmallStarTag")
        {
            score += 150;
        }
        else
        {
            score += 100;
        }

        SetScore();
    }


    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }

   
}

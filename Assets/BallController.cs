﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private float visiblePosZ = -6.5f;

    private GameObject gameoverText;

    private GameObject scoreText;

    private int morescore = 0;
   

    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");

        this.scoreText = GameObject.Find("Score");

        this.scoreText.GetComponent<Text>().text = "Score:" + morescore;

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "LargeStarTag")
        {
            morescore += 10;
            this.scoreText.GetComponent<Text>().text = "Score:" + morescore;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            morescore += 20;
            this.scoreText.GetComponent<Text>().text = "Score:" + morescore;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            morescore += 40;
            this.scoreText.GetComponent<Text>().text = "Score:" + morescore;
        }
    }



}

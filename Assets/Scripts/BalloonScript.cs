using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BalloonScript : MonoBehaviour
{
    // Update is called once per frame
    // public Text scoreText;
    // public Text levelText;
    // float speed;
    void Update()
    {
        // Debug.Log(scoreText.text);
        // // Debug.Log(levelText.text);
        // if (Int32.Parse(scoreText.text) < 10)
        // {
        //     speed = 0.2f;
        //     levelText.text = "1";
        // }
        // else if (Int32.Parse(scoreText.text) < 20)
        // {
        //     speed = 0.4f;
        //     levelText.text = "2";
        // }
        // else if (Int32.Parse(scoreText.text) < 30)
        // {
        //     speed = 0.8f;
        //     levelText.text = "3";
        // }
        transform.Translate(Vector3.up * Time.deltaTime * 0.2f);
        // transform.Translate(Vector3.forward * Time.deltaTime * 0.2f);
    }
}

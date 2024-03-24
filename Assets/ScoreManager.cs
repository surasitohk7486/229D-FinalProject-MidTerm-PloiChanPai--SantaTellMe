using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    [SerializeField]
    public static int score;
    public TextMeshProUGUI scoreText;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            score++;
            scoreText.text = "Score : " + score;
            Destroy(other.gameObject);
        }
    }
}

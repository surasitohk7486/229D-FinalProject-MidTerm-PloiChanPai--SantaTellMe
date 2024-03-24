using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        winGame();
    }

    public void winGame()
    {
        if(ScoreManager.score == 15)
        {
            SceneManager.LoadScene("Credits");
        }
    }
}

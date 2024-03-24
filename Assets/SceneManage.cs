using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void onClickPlay()
    {
        SceneManager.LoadScene("Demo 01");
    }

    public void onClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void onClickExit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour {

    public void PlayPressed()
    {
        SceneManager.LoadScene("Menu1");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Test1()
    {
        SceneManager.LoadScene("Game");
    }

    public void Test2()
    {
        SceneManager.LoadScene("Game2");
    }

    public void Test3()
    {
        SceneManager.LoadScene("Game3");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}

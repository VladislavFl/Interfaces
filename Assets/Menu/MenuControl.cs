using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour {

    public GameObject MainMenu;
    public GameObject Submenu;
    public GameObject Levels;
    public GameObject Levels2;
    public GameObject About;
    public GameObject About2;
    public Parametrs parametrs;

    private bool checkDownMenu = false;
    private bool checkDownSubmenu = false;
    private bool checkDownAbout = false;

    private bool checkDownMenu2 = false;
    private bool checkDownSubmenu2 = false;
    private bool checkDownAbout2 = false;


    public void PlayPressed()
    {
        if (checkDownMenu == false)
        {
            Submenu.SetActive(true);
            checkDownMenu = true;
        }
        else
        {
            Submenu.SetActive(false);
            checkDownMenu = false;
        }
        
    }

    public void Sub()
    {
        if (checkDownSubmenu == false)
        {
            if (checkDownSubmenu2 == true) Levels2.SetActive(false);
            Levels.SetActive(true);
            checkDownSubmenu = true;
            
        }
        else
        {
            Levels.SetActive(false);
            checkDownSubmenu = false;
            
        }
    }

    public void Sub2()
    {
        if (checkDownSubmenu2 == false)
        {
            if (checkDownSubmenu == true) Levels.SetActive(false);
            Levels2.SetActive(true);
            checkDownSubmenu2 = true;
            
        }
        else
        {
            Levels2.SetActive(false);
            checkDownSubmenu2 = false;
        }
    }

    public void Ab()
    {
        if (checkDownAbout == false)
        {
            About.SetActive(true);
            checkDownAbout = true;
        }
        else
        {
            About.SetActive(false);
            checkDownAbout = false;
        }
    }

    public void Ab2()
    {
        if (checkDownAbout2 == false)
        {
            About2.SetActive(true);
            checkDownAbout2 = true;
        }
        else
        {
            About2.SetActive(false);
            checkDownAbout2 = false;
        }
    }

    public void BackMenu()
    {

        Submenu.SetActive(false);
    }

    public void Test1()
    {
        parametrs.K = 1;
        SceneManager.LoadScene("Game3");
    }

    public void Test2()
    {
        parametrs.K = 3;
        SceneManager.LoadScene("Game3");
    }

    public void Test3()
    {
        SceneManager.LoadScene("Game3");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}

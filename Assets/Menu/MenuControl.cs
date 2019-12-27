using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour {

    public GameObject MainMenu;
    public GameObject Submenu;
    public GameObject Levels;
    public GameObject Levels2;
    public GameObject Levels3;
    public GameObject ButtonMenu1;
    public GameObject ButtonMenu2;
    public GameObject ButtonMenu3;
    public GameObject About;
    public GameObject About2;
    public Parametrs parametrs;

    private bool checkDownMenu = false;
    private bool checkDownSubmenu = false;
    private bool checkDownAbout = false;

    private bool checkDownMenu2 = false;
    private bool checkDownSubmenu2 = false;
    private bool checkDownAbout2 = false;

    private bool checkDownMenu3 = false;
    private bool checkDownSubmenu3 = false;
    private bool checkDownAbout3 = false;

    public Color color;

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
            OneTrue(1);
            ButtonMenu1.GetComponent<Image>().color = color;
        }
        else
        {
            Levels.SetActive(false);
            checkDownSubmenu = false;
            ButtonMenu1.GetComponent<Image>().color = new Color(255, 255, 255);
        }
    }

    public void Sub2()
    {
        if (checkDownSubmenu2 == false)
        {
            OneTrue(2);
            ButtonMenu2.GetComponent<Image>().color = color;
        }
        else
        {
            Levels2.SetActive(false);
            checkDownSubmenu2 = false;
            ButtonMenu2.GetComponent<Image>().color = new Color(255, 255, 255);
        }
    }

    public void Sub3()
    {
        if (checkDownSubmenu3 == false)
        {
            OneTrue(3);
            ButtonMenu3.GetComponent<Image>().color = color;
        }
        else
        {
            Levels3.SetActive(false);
            checkDownSubmenu3 = false;
            ButtonMenu3.GetComponent<Image>().color = new Color(255, 255, 255);
        }
    }

    public void OneTrue(int numberButton){
      if (numberButton == 1){
        Levels.SetActive(true);
        Levels2.SetActive(false);
        Levels3.SetActive(false);

        checkDownSubmenu = true;
        checkDownSubmenu2 = false;
        checkDownSubmenu3 = false;

        ButtonMenu2.GetComponent<Image>().color = new Color(255, 255, 255);
        ButtonMenu3.GetComponent<Image>().color = new Color(255, 255, 255);
      }
      if (numberButton == 2){
        Levels.SetActive(false);
        Levels2.SetActive(true);
        Levels3.SetActive(false);

        checkDownSubmenu = false;
        checkDownSubmenu2 = true;
        checkDownSubmenu3 = false;

        ButtonMenu1.GetComponent<Image>().color = new Color(255, 255, 255);
        ButtonMenu3.GetComponent<Image>().color = new Color(255, 255, 255);
      }
      if (numberButton == 3){
        Levels.SetActive(false);
        Levels2.SetActive(false);
        Levels3.SetActive(true);

        checkDownSubmenu = false;
        checkDownSubmenu2 = false;
        checkDownSubmenu3 = true;

        ButtonMenu1.GetComponent<Image>().color = new Color(255, 255, 255);
        ButtonMenu2.GetComponent<Image>().color = new Color(255, 255, 255);
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
        parametrs.K = 2;
        SceneManager.LoadScene("Game3");
    }

    public void Test3()
    {
        parametrs.K = 3;
        SceneManager.LoadScene("Game3");
    }

    public void Test4()
    {
        parametrs.K = 4;
        SceneManager.LoadScene("Game3");
    }

    public void Test5()
    {
        parametrs.K = 5;
        SceneManager.LoadScene("Game3");
    }

    public void Test6()
    {
        parametrs.K = 6;
        SceneManager.LoadScene("Game3");
    }

    public void Test7()
    {
        parametrs.K = 7;
        SceneManager.LoadScene("Game3");
    }

    public void Test8()
    {
        parametrs.K = 8;
        SceneManager.LoadScene("Game3");
    }

    public void Test9()
    {
        parametrs.K = 9;
        SceneManager.LoadScene("Game4");
    }

    public void Test10()
    {
        parametrs.K = 10;
        SceneManager.LoadScene("Game4");
    }

    public void Test11()
    {
        parametrs.K = 11;
        SceneManager.LoadScene("Game4");
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

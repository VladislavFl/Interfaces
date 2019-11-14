using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public float timer;
    public bool ispause;
    public bool guipause;

    void Update()
    {
        Time.timeScale = timer;
        if (Input.GetKeyDown(KeyCode.Escape) && ispause == false)
        {
            ispause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && ispause == true)
        {
            ispause = false;
        }
        if (ispause == true)
        {
            timer = 1f;
            guipause = true;

        }
        else if (ispause == false)
        {
            timer = 1f;
            guipause = false;

        }
    }
    public void OnGUI()
    {
        if (guipause == true)
        {
            Cursor.visible = true;
            if (GUI.Button(new Rect((float)(Screen.width / 2) - 75f, (float)(Screen.height / 2) - 150f, 150f, 45f), "Продолжить"))
            {
                ispause = false;
                timer = 1;
                Cursor.visible = true;
            }
            if (GUI.Button(new Rect((float)(Screen.width / 2) - 75f, (float)(Screen.height / 2) - 100f , 150f, 45f), "В Меню"))
            {
                ispause = false;
                timer = 1;
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
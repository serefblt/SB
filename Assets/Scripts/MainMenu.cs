using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void Play()
    {
    
        if (PlayerPrefs.GetInt("level") == 2)
        {
            SceneManager.LoadScene(2);
        }
       else if (PlayerPrefs.GetInt("level") == 3)
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }
   public void Quit()
    {
        Application.Quit();
    }

    public void MainMenus()
    {
        SceneManager.LoadScene(0);
    }
}

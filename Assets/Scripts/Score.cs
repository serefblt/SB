using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] public Text _arrowText;
    [SerializeField] GameObject _levelPanel;
    public static int ArrowCount = 5;
    public static int _ArrowCount;


    private void Awake()
    {
        ArrowCount = PlayerPrefs.GetInt("ArrowCount");
        _ArrowCount = ArrowCount;
    }
    private void FixedUpdate()
    {
        _arrowText.text = _ArrowCount.ToString();
        Finish();
      
    }

    public void Finish()
    {
        if (_ArrowCount == 0)
        {
            Time.timeScale = 0;
            _levelPanel.SetActive(true);
        }
    }

    public void NextLevelButtonOnClick1Level()
    {
        PlayerPrefs.SetInt("level", 2);
        ArrowCount = PlayerPrefs.GetInt("ArrowCount") + 3;
        PlayerPrefs.SetInt("ArrowCount", ArrowCount);
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void NextLevelButtonOnClick2Level()
    {
        PlayerPrefs.SetInt("level", 3);
        ArrowCount = PlayerPrefs.GetInt("ArrowCount") + 5;
        PlayerPrefs.SetInt("ArrowCount", ArrowCount);
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }
    public void NextLevelButtonOnClick3Level()
    {
     
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Level2Again()
    {
        
        Time.timeScale = 1;
        SceneManager.LoadScene(2);

    }
    public void Level3Again()
    {
        
        Time.timeScale = 1;
        SceneManager.LoadScene(3);

    }
}

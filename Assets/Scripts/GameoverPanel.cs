using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameoverPanel : MonoBehaviour
{
    [SerializeField] public GameObject _gameOverPanel;
    [SerializeField] Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Tryagain()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOverPanel()
    {
        _gameOverPanel.SetActive(true);
    }
    public void AnimGameOver()
    {
        _anim.SetTrigger("End");
    }
}

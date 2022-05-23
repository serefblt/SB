using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    bool isPinned = false;
    [SerializeField] float _speed = 20f;
    [SerializeField] Rigidbody2D _rb2D;
    //[SerializeField] GameObject _endPanel;
  

    private void Awake()
    {
        
    }
    void Update()
    {
        if (!isPinned)
        {
            _rb2D.MovePosition(_rb2D.position + Vector2.up * _speed * Time.deltaTime);
        }
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Circle"))
        {
            transform.SetParent(collision.transform);
            //collision.GetComponent<CircleRotation>()._CircleSpeed *= -1; vurduðumuzda diðer yine dönüyor
            Score.ArrowCount++;
          
            isPinned = true;
        }
        else if (collision.gameObject.CompareTag("Arrow"))
        {
            Time.timeScale = 0;
            FindObjectOfType<GameoverPanel>().GameOverPanel();
            //FindObjectOfType<GameoverPanel>().AnimGameOver();



        }
    }
  
}

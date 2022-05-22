using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    bool isPinned = false;
    [SerializeField] float _speed = 20f;
    [SerializeField] Rigidbody2D _rb2D;
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
            isPinned = true;
        }
    }
}

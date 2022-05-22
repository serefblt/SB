using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotation : MonoBehaviour
{
    [SerializeField] float _CircleSpeed;


    private void Update()
    {
        transform.Rotate(0f, 0f, _CircleSpeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    [SerializeField] GameObject _arrow;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnArrow();
        }
    }

    void SpawnArrow()
    {
        Instantiate(_arrow, transform.position, transform.rotation, transform);
    }
}

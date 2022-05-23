using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text _arrowText;
    public static int ArrowCount = 0;

    private void Start()
    {
        ArrowCount = 0;
    }

    private void Update()
    {
        _arrowText.text = ArrowCount.ToString();
    }
}

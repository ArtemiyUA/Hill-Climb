using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayDistanceText : MonoBehaviour
{
    [SerializeField] private TMP_Text distanceText;
    [SerializeField] private Transform playerTrans;

    private Vector2 startPoint;

    private void Start()
    {
        startPoint = playerTrans.position;
    }

    private void Update()
    {
        Vector2 distance = (Vector2)playerTrans.position - startPoint;
        distance.y = 0f;

        if(distance.x < 0)
        {
            distance.x = 0;
        }

        distanceText.text = distance.x.ToString("F0") + "m";
    }
}

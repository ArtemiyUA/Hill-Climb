using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private Car car;
    public bool buttonPressed;

    private void Awake()
    {
        car = FindObjectOfType<Car>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        if (!buttonPressed)
        {
            car.moveInput = 1;
        }
        else
        {
            car.moveInput = -1;
        }
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        car.moveInput = 0;
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
    }
}

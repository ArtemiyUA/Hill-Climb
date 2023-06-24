/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Speedometer : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public  float MAX_SPEED_ANGLE = -20;
    public  float ZERO_SPEED_ANGLE = 230;

    public Transform needleTranform;
    public Transform needle2;
    

    public float speedMax;
    public float speed;

   public bool btnpressed;
    private void Awake() {
        //needleTranform = transform.Find("needle");
      

        speed = 0f;
        speedMax = 200f;

    }

    private void Update() {
        //HandlePlayerInput();
        if (!btnpressed)
        {
            float deceleration = 20f;
            speed -= deceleration * Time.deltaTime;
            
        }
        else
        {
            float acceleration = 80f;
            speed += acceleration * Time.deltaTime;
        }
        speed = Mathf.Clamp(speed, 0f, speedMax);
        needleTranform.eulerAngles = new Vector3(0, 0, GetSpeedRotation());
        
    }

    public void Upaarow()
    {

    }

    private void HandlePlayerInput() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            float acceleration = 80f;
            speed += acceleration * Time.deltaTime;
        } else {
            float deceleration = 20f;
            speed -= deceleration * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            float brakeSpeed = 100f;
            speed -= brakeSpeed * Time.deltaTime;
        }

        speed = Mathf.Clamp(speed, 0f, speedMax);
    }

   

    private float GetSpeedRotation() {
        float totalAngleSize = ZERO_SPEED_ANGLE - MAX_SPEED_ANGLE;

        float speedNormalized = speed / speedMax;

        return ZERO_SPEED_ANGLE - speedNormalized * totalAngleSize;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        btnpressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        btnpressed = false;
    }
}

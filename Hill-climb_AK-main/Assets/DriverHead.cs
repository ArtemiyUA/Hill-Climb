using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverHead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            StartCoroutine(GameOver());
        }

        IEnumerator GameOver()
        {
            yield return new WaitForSeconds(1f);
            GameManager.instance.GameOver();
        }
    }
}


using UnityEngine;
using DG.Tweening;


public class Coin : MonoBehaviour
{ 
   private  void StartAnimation()
    {
        transform.DOMoveY(+4f, 1.5f)
            .SetEase(Ease.InOutQuart)
            .OnComplete(EndAnimation);
    }

    private void EndAnimation()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartAnimation();
            Wallet.Instance.AddCoin(1);
        }
    }
}

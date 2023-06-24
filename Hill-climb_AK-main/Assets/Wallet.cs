using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    public static Wallet Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
        UpdateUI();
    }
    [SerializeField] private TMP_Text coinText;
    public int coin = 0;

  
    public void AddCoin(int amount)
    {
        coin += amount;
        UpdateUI();
    }
     private void UpdateUI()
    {
        coinText.text = "You coin " + coin.ToString();
    }
    
}

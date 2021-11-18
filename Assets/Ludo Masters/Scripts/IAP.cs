using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IAP : MonoBehaviour
{

    public GameObject coinsBuyWindow;
    public GameObject purchaseFailTest;
    public void PurchaseCoinSuccess(int coins) {
        coinsBuyWindow.SetActive(false);
        GameManager.Instance.playfabManager.addCoinsRequest(coins);
    }

    public void PurchaseCoinFail() {
        purchaseFailTest.SetActive(true);


    }
}

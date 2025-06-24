using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BettingCoin : MonoBehaviour
{
    public static int  currentSelectedCoin=1;
    public static int totalBalance=100000;
    public TextMeshProUGUI balanceAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        balanceAmount.text = totalBalance.ToString();
    }
    public void AllCoin(int coinValue)
    {
        currentSelectedCoin = coinValue;
        Debug.Log(currentSelectedCoin);
    }
}

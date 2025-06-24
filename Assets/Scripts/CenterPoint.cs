using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CenterPoint : MonoBehaviour
{
    public List<GameObject> centerPointImage = new List<GameObject>();
    public List<int> upgradeCurrentPoint6 = new List<int>();
    //public List<int> numbersStored = new List<int>();
    public List<TextMeshProUGUI> text6 = new List<TextMeshProUGUI>();
    public int current;
    public int transferValueCenterpoint;
    public int centerPointStore;
    public int totalBalaceAmountBy4;
    public int maxBettingAmount;
    public int doubleValue;
    public List<FourCenterBackValue> by4 = new List<FourCenterBackValue>();
    AudioManagerr audioManager;



    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current = BettingCoin.currentSelectedCoin;
        totalBalaceAmountBy4 = BettingCoin.totalBalance;

    }
    public void Center4(int centerButton)
    {
        for (int i = 0; i < centerPointImage.Count; i++)
        {
            
            if (centerButton == i)
            {
                if (BettingCoin.totalBalance >= current)
                {
                   //Debug.Log(i);
                    centerPointImage[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);

                    maxBettingAmount = upgradeCurrentPoint6[i];
                    maxBettingAmount += current;
                    if(maxBettingAmount <= 50000)
                    {
                        upgradeCurrentPoint6[i] += current;
                        BettingCoin.totalBalance -= current;
                        transferValueCenterpoint += current;
                        text6[i].text = upgradeCurrentPoint6[i].ToString();
                        centerPointStore = centerButton;
                    }
                    
                }
            }
        }
       

       
    }
    public void CenterPointBn()
    {
        for(int i = 0;i < centerPointImage.Count;i++)
        {
            BettingCoin.totalBalance += upgradeCurrentPoint6[i];
            upgradeCurrentPoint6[i] = 0;
            centerPointImage[i].SetActive(false);
           
        }
        transferValueCenterpoint = 0;
        for (int j = 0; by4.Count > j; j++)
        {
            by4[j].reduceChips.Chips.Clear();
        }
    }
    public void DoubleBn()
    {
        transferValueCenterpoint = 0;
        for (int i = 0; i < centerPointImage.Count; i++)
        {

            if (BettingCoin.totalBalance >= upgradeCurrentPoint6[i])
            {
                doubleValue = upgradeCurrentPoint6[i] * 2;
                if (doubleValue <= 50000)
                {
                    upgradeCurrentPoint6[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPoint6[i] / 2;
                }
                

            }
         
            transferValueCenterpoint += upgradeCurrentPoint6[i];
            text6[i].text = upgradeCurrentPoint6[i].ToString();
        }
    }
}

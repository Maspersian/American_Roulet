using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlackAndRed : MonoBehaviour
{
    public List<GameObject> RedAndBlackImage = new List<GameObject>();
    public List<int> upgradeCurrentPoint5 = new List<int>();
    public List<TextMeshProUGUI> text5 = new List<TextMeshProUGUI>();
    public int current;
    public int transferValueRedAndBlack;
    public int redAndBlackStore;
    public int totalBalaceAmountBlackAndRed;
    public int maxBettingAmound;
    public int doubleValue;
    public List<BlackAndRedBackValue> bAndRed = new List<BlackAndRedBackValue>();
    AudioManagerr audioManager;


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current=BettingCoin.currentSelectedCoin;
        totalBalaceAmountBlackAndRed = BettingCoin.totalBalance;

    }
    public void RedAndBlackButt(int balckAndRedButton)
    {
        for (int i = 0; i < RedAndBlackImage.Count; i++)
        {
            if (balckAndRedButton == i)
            {
                if (BettingCoin.totalBalance >= current)
                {
                    RedAndBlackImage[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);

                    maxBettingAmound = upgradeCurrentPoint5[i];
                    maxBettingAmound += current;
                    if(maxBettingAmound <= 50000)
                    {
                        upgradeCurrentPoint5[i] += current;
                        BettingCoin.totalBalance -= current;
                        transferValueRedAndBlack += current;
                        text5[i].text = upgradeCurrentPoint5[i].ToString();
                        redAndBlackStore = balckAndRedButton;
                    }   
                }
            }
        }
    }
    public void BlackAndRedBn()
    {
        for(int i = 0; upgradeCurrentPoint5.Count > i; i++)
        {
            BettingCoin.totalBalance += upgradeCurrentPoint5[i];
            upgradeCurrentPoint5[i] = 0;
            RedAndBlackImage[i].SetActive(false);
        }
        transferValueRedAndBlack = 0;   
        for(int i = 0;bAndRed.Count > i; i++)
        {
            bAndRed[i].reduceChips.Chips.Clear();
        }
    }
    public void DoubleBn()
    {
        transferValueRedAndBlack = 0;
        for (int i = 0; upgradeCurrentPoint5.Count > i; i++)
        {
            if (BettingCoin.totalBalance >= upgradeCurrentPoint5[i])
            {
                doubleValue = upgradeCurrentPoint5[i] * 2;
                if (doubleValue < 50000)
                {
                    upgradeCurrentPoint5[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPoint5[i] / 2;
                }
            }
            transferValueRedAndBlack += upgradeCurrentPoint5[i];
            text5[i].text = upgradeCurrentPoint5[i].ToString();

        }
    }
}

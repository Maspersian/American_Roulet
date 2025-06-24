using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EvenandOdd : MonoBehaviour
{
    public List<GameObject> evenAndOddImage = new List<GameObject>();
    public List<int> upgradeCurrentPoint4 = new List<int>();
    public List<TextMeshProUGUI> text4 = new List<TextMeshProUGUI>();
    public int current;
    public int transferValueEvenOrOdd;
    public int evenAndOddStore;
    public int totalBalaceAmountOddAndEven;
    public int maxBettingValue;
    public int doubleValue;
    public List<OddAndEvenBackValue> oddAndEven = new List<OddAndEvenBackValue>();
    AudioManagerr audioManager;

    // Start is called before the first frame update
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
        current=BettingCoin.currentSelectedCoin;
        totalBalaceAmountOddAndEven = BettingCoin.totalBalance;

    }
    public void EvenAndOddNo(int evenAndOddButton)
    {
        for (int i = 0; i < evenAndOddImage.Count; i++)
        {
            if (evenAndOddButton == i)
            {
                if (BettingCoin.totalBalance >= current)
                {
                    evenAndOddImage[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);

                    maxBettingValue = upgradeCurrentPoint4[i];
                    maxBettingValue += current;
                    if(maxBettingValue <= 50000 )
                    {
                        upgradeCurrentPoint4[i] += current;
                        BettingCoin.totalBalance -= current;
                        transferValueEvenOrOdd += current;
                        text4[i].text = upgradeCurrentPoint4[i].ToString();
                    }
                   
                }
            }
        }
    }
    public void EveneAndOddBn()
    {
        for(int i = 0;i < upgradeCurrentPoint4.Count; i++)
        {
            BettingCoin.totalBalance += upgradeCurrentPoint4[i];
            upgradeCurrentPoint4[i] = 0;
            evenAndOddImage[i].SetActive(false) ;
        }
        transferValueEvenOrOdd = 0;
        for (int i = 0;oddAndEven.Count > i; i++)
        {
            oddAndEven[i].reduceChips.Chips.Clear();
        }
    }
    public void DoubleBn()
    {
        transferValueEvenOrOdd=0;
        for (int i = 0; i < upgradeCurrentPoint4.Count; i++)
        {
            if (BettingCoin.totalBalance >= upgradeCurrentPoint4[i])
            {
                doubleValue = upgradeCurrentPoint4[i] * 2;
                if(doubleValue < 50000)
                {
                    upgradeCurrentPoint4[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPoint4[i] / 2;
                }
            }
           
            transferValueEvenOrOdd += upgradeCurrentPoint4[i];
            text4[i].text = upgradeCurrentPoint4[i].ToString();

        }
    }
}

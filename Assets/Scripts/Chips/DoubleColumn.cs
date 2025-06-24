using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoubleColumn : MonoBehaviour
{
    public List<GameObject> bySixChips = new List<GameObject>();
    public List<int> upgradeCurrentPoint8 = new List<int>();
    public List<TextMeshProUGUI> text8 = new List<TextMeshProUGUI>();
    public int current;
    public int transferDoubleColumnsValue;
    public int totalBalaceAmountBy6;
    public int maxBettingValue;
    public int storeBy6;
    public int doubleValue;
    public List<By6BackValue> by6 = new List<By6BackValue>();
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
        current = BettingCoin.currentSelectedCoin;
        totalBalaceAmountBy6 = BettingCoin.totalBalance;

    }
    public void BySix(int bySixButton)
    {
        for (int i = 0; i < bySixChips.Count; i++)
        {
            if (bySixButton == i)
            {
                storeBy6 = i;
                if (BettingCoin.totalBalance >= upgradeCurrentPoint8[i])
                {
                    bySixChips[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);

                    maxBettingValue = upgradeCurrentPoint8[i];
                    maxBettingValue += current;
                    if (maxBettingValue <= 50000)
                    {
                        upgradeCurrentPoint8[i] += current;
                        BettingCoin.totalBalance -= current;
                        transferDoubleColumnsValue += current;
                        text8[i].text = upgradeCurrentPoint8[i].ToString();
                    }
                }
            }
        }
    }
    public void ClearBn()
    {
        for (int i = 0; i < bySixChips.Count; i++)
        {
            BettingCoin.totalBalance += upgradeCurrentPoint8[i];
            upgradeCurrentPoint8[i] = 0; // Set each element to zero
            bySixChips[i].SetActive(false);
        }
        transferDoubleColumnsValue = 0;
        for (int i = 0;by6.Count > i; i++)
        {
            by6[i].reduceChips.Chips.Clear();
        }
    }
    public void DoubleBn()
    {
        transferDoubleColumnsValue = 0;
        for (int i = 0; i < upgradeCurrentPoint8.Count; i++)
        {
            if (BettingCoin.totalBalance >= current)
            {
                doubleValue = upgradeCurrentPoint8[i] * 2;
                if (doubleValue <= 50000)
                {
                    upgradeCurrentPoint8[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPoint8[i] / 2;
                }
            }
           transferDoubleColumnsValue += upgradeCurrentPoint8[i];
            text8[i].text = upgradeCurrentPoint8[i].ToString();
        }
    }
}

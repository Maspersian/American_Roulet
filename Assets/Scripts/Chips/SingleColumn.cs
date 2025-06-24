using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SingleColumn : MonoBehaviour
{
    public List<GameObject> singleColumnChips = new List<GameObject>();
    public List<int> upgradeCurrentPoint9 = new List<int>();
    public List<TextMeshProUGUI> text9 = new List<TextMeshProUGUI>();
    public int current;
    public int transferBettingSingleColmn;
    public int totalBalaceAmountSingle;
    public int maxBettingValue;
    public int storingBy3;
    public int doubleValue;
    public List<By3BackValues> by3 = new List<By3BackValues>();
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
        totalBalaceAmountSingle = BettingCoin.totalBalance;

    }
    public void SingleColumnSelect(int singleColumnButton)
    {
        for (int i = 0; i < singleColumnChips.Count; i++)
        {
            if (singleColumnButton == i)
            {
                if (BettingCoin.totalBalance >= current)
                {
                    singleColumnChips[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);

                    maxBettingValue = upgradeCurrentPoint9[i];
                    maxBettingValue += current;
                    if (maxBettingValue <= 50000)
                    {
                        upgradeCurrentPoint9[i] += current;
                        BettingCoin.totalBalance -= current;
                        transferBettingSingleColmn += current;
                        text9[i].text = upgradeCurrentPoint9[i].ToString();
                    }
                }
               storingBy3 = singleColumnButton;
            }
        }
    }
    public void SingleColumnBn()
    {
        for(int i = 0;i<upgradeCurrentPoint9.Count;i++)
        {
            BettingCoin.totalBalance += upgradeCurrentPoint9[i];
            upgradeCurrentPoint9[i] = 0;
            singleColumnChips[i].SetActive(false);
        }
        transferBettingSingleColmn = 0;
        for(int i = 0;by3.Count > i; i++)
        {
            by3[i].reduceChips.Chips.Clear();
        }
    }
    public void DoubleBn()
    {
        transferBettingSingleColmn = 0;
        for (int i = 0; i < upgradeCurrentPoint9.Count; i++)
        {
            if (BettingCoin.totalBalance >= upgradeCurrentPoint9[i])
            {
                doubleValue = upgradeCurrentPoint9[i] * 2;
                if (doubleValue <= 50000)
                {
                    upgradeCurrentPoint9[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPoint9[i] / 2;
                }
            }
            transferBettingSingleColmn += upgradeCurrentPoint9[i];
            text9[i].text = upgradeCurrentPoint9[i].ToString();
        }
    }
}

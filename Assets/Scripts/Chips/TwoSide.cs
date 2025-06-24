using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TwoSide : MonoBehaviour
{
    public List<GameObject> TwosideChips = new List<GameObject>();
    public List<int> upgradeCurrentPoint7 = new List<int>();
    public List<TextMeshProUGUI> text7 = new List<TextMeshProUGUI>();
    public int current;
    public int translate2Side;
    public GameObject textForRatio;
    public int twoSideStore;
    public int totalBalaceAmountBy2;
    public int maxBettingValue;
    public int doubleValue;
    public List<TwoSideBackVAlye> by2 = new List<TwoSideBackVAlye>();
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
        current = BettingCoin.currentSelectedCoin;
        totalBalaceAmountBy2 = BettingCoin.totalBalance;

    }
    public void TwoSidee(int twoSidesButton)
    {
        for (int i = 0; i < TwosideChips.Count; i++)
        {
            if (twoSidesButton == i)
            {
                if (BettingCoin.totalBalance >= current)
                {
                    TwosideChips[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);

                    maxBettingValue = upgradeCurrentPoint7[i];
                    maxBettingValue += current;
                    if(maxBettingValue <= 50000)
                    {
                        upgradeCurrentPoint7[i] += current;
                        BettingCoin.totalBalance -= current;
                        translate2Side += current;
                        text7[i].text = upgradeCurrentPoint7[i].ToString();
                        twoSideStore = twoSidesButton;
                    }
                   
                }
            }
        }
    }
    public void TwoSideBn()
    {
        for(int i = 0;i<upgradeCurrentPoint7.Count;i++)
        {
            BettingCoin.totalBalance += upgradeCurrentPoint7[i];
            upgradeCurrentPoint7[i] = 0;
            TwosideChips[i].SetActive(false);
        }
        translate2Side = 0;
        for (int j = 0; by2.Count > j; j++)
        {
            by2[j].reduceChips.Chips.Clear();
        }
    }
    public void DoubleBn()
    {
        translate2Side = 0;
        for (int i = 0; i < upgradeCurrentPoint7.Count; i++)
        {
            if (BettingCoin.totalBalance >= upgradeCurrentPoint7[i])
            {
                doubleValue = upgradeCurrentPoint7[i] * 2;
                if(doubleValue <= 50000)
                {
                    upgradeCurrentPoint7[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPoint7[i] / 2;
                }
            }
            
            translate2Side += upgradeCurrentPoint7[i];
            text7[i].text = upgradeCurrentPoint7[i].ToString();
        }
    }
}

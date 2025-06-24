using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TwoToOne : MonoBehaviour
{
    //public List<GameObject> twoToOneChips = new List<GameObject>();
    public List<GameObject> twoToOneImage = new List<GameObject>();
    public List<int> upgradeCurrentPoint = new List<int>();
    public List<TextMeshProUGUI> text1 = new List<TextMeshProUGUI>();
    public int current;
    public int totalBalaceAmount2to1;
    public int transferValue2to1;
    public int twoToOneStore;
    public int maxBettingValue;
    public int doubleValue;
    AudioManagerr audioManager;
    public List<TwotoOneBackValue> twoto1= new List<TwotoOneBackValue>();


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
        totalBalaceAmount2to1 = BettingCoin.totalBalance;
    }
    public void TwoToOneChipss(int chipss)
    {
        for (int i = 0; i < twoToOneImage.Count; i++)
        {
            if (chipss == i)
            {
                if (BettingCoin.totalBalance >= current)
                {


                    twoToOneImage[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);

                    maxBettingValue = upgradeCurrentPoint[i];
                    maxBettingValue += current;
                    if (maxBettingValue <= 50000)
                    {
                        upgradeCurrentPoint[i] += current;
                        BettingCoin.totalBalance -= current;
                        transferValue2to1 += current;
                        text1[i].text = upgradeCurrentPoint[i].ToString();
                        twoToOneStore = chipss;
                        Debug.Log(twoToOneStore);
                    }
                    
                }
            }
        }
    }
    public void TwotoOneBn()
    {
        
        for (int i = 0;i < twoToOneImage.Count; i++)
        {
            BettingCoin.totalBalance += upgradeCurrentPoint[i];
            upgradeCurrentPoint[i]= 0;
            twoToOneImage[i].SetActive(false);
            transferValue2to1 = 0;
        }
        for (int i = 0; twoto1.Count > i; i++)
        {
            twoto1[i].reduceChips.Chips.Clear();
        }

    }
    public void DoubleBn()
    {
        transferValue2to1 = 0;
        for (int i = 0; i < twoToOneImage.Count; i++)
        {
            if (BettingCoin.totalBalance >= upgradeCurrentPoint[i])
            {
                doubleValue = upgradeCurrentPoint[i] * 2;
                if(doubleValue <= 50000)
                {
                    upgradeCurrentPoint[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPoint[i] / 2;
                }
               

            }
            transferValue2to1 += upgradeCurrentPoint[i];
            text1[i].text = upgradeCurrentPoint[i].ToString();
        }
    }
}

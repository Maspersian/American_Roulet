using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class By12 : MonoBehaviour
{
    public List<GameObject> ByTwelve = new List<GameObject>();
    public List<int> upgradeCurrentPoint2 = new List<int>();
    public List<TextMeshProUGUI> text2 = new List<TextMeshProUGUI>();
    public int current;
    public int transferValueBy12;
    public int byTwelveStore;
    public int totalBalaceAmountby12;
    public int maxBettingAmount;
    public int doubleValue;
    AudioManagerr audioManager;
    public List<TwelveByBackValue> by12 = new List<TwelveByBackValue>();


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
        totalBalaceAmountby12 = BettingCoin.totalBalance;

    }
    public void Bytwelvee(int bytwelvechips)
    {
        for (int i = 0; i < ByTwelve.Count; i++)
        {
            if (bytwelvechips == i)
            {
                if (BettingCoin.totalBalance >= current)
                {

                    ByTwelve[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);

                    maxBettingAmount = upgradeCurrentPoint2[i];
                    maxBettingAmount += current;
                    if(maxBettingAmount <= 50000)
                    {
                        upgradeCurrentPoint2[i] += current;
                        BettingCoin.totalBalance -= current;
                        transferValueBy12 += current;
                        text2[i].text = upgradeCurrentPoint2[i].ToString();
                        byTwelveStore = bytwelvechips;
                        Debug.Log(bytwelvechips);
                    }
                   
                }
            }
        }
    }
    public void By12Bn()
    {
       for(int i = 0; upgradeCurrentPoint2.Count > i; i++)
       {
            BettingCoin.totalBalance += upgradeCurrentPoint2[i];
            upgradeCurrentPoint2[i] = 0;
            ByTwelve[i].SetActive(false);
        }
        transferValueBy12 = 0;
        for (int i = 0;i < by12.Count; i++)
       {
            by12[i].reduceChips.Chips.Clear();
       }
    }
    public void DoubleBn()
    {
        transferValueBy12 = 0;
        for (int i = 0; upgradeCurrentPoint2.Count > i; i++)
        {
            if (BettingCoin.totalBalance >= upgradeCurrentPoint2[i])
            {
                doubleValue = upgradeCurrentPoint2[i] * 2;
                if (doubleValue < 50000)
                {
                    upgradeCurrentPoint2[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPoint2[i] / 2;
                }
                

            }
            
            transferValueBy12+= upgradeCurrentPoint2[i];
            text2[i].text = upgradeCurrentPoint2[i].ToString();
        }    
    }
}

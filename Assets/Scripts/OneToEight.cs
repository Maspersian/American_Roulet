using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OneToEight : MonoBehaviour
{
    public List<GameObject> by18 = new List<GameObject>();
    public List<int> upgradeCurrentPoint3 = new List<int>();
    public List<TextMeshProUGUI> text3 = new List<TextMeshProUGUI>();
    public int current;
    public int transferValue1to18;
    public Timee Timee;
    public int by18Store;
    public int totalBalaceAmountby18;
    public int maxBettingAmount;
    public int doubleValue;
    public List<OneBy18BackValue> by18BackValue = new List<OneBy18BackValue>();
    AudioManagerr audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();
    }
    //public Timee Timee;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        current = BettingCoin.currentSelectedCoin;
        totalBalaceAmountby18 = BettingCoin.totalBalance;

    }
    public void By18(int byeigteenchips)
    {
        for (int i = 0; i <  by18.Count; i++)
        {
            if (byeigteenchips == i)
            {

                if (BettingCoin.totalBalance >= current)
                {
                    by18[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);

                    maxBettingAmount = upgradeCurrentPoint3[i];
                    maxBettingAmount += current;
                    if(maxBettingAmount <= 50000)
                    {
                        upgradeCurrentPoint3[i] += current;
                        BettingCoin.totalBalance -= current;
                        transferValue1to18 += current;
                        text3[i].text = upgradeCurrentPoint3[i].ToString();
                        by18Store = byeigteenchips;
                    }
                    
                }
            }
        }
    }
    public void By18Bn()
    {
        for(int i = 0;i < by18.Count;i++)
        {
            BettingCoin.totalBalance += upgradeCurrentPoint3[i];
            upgradeCurrentPoint3[i] = 0;
           Timee.checkingRepeating=true;
            by18[i].SetActive(false);
        }
        transferValue1to18 = 0;
        for (int i = 0;by18BackValue.Count > i; i++)
        {
            by18BackValue[i].reduceChips.Chips.Clear();
        }
    }
    public void DoubleBn()
    {
        transferValue1to18 = 0;
        for (int i = 0; i < by18.Count; i++)
        {
            if (BettingCoin.totalBalance >= upgradeCurrentPoint3[i])
            {
                doubleValue = upgradeCurrentPoint3[i] * 2;
                if (doubleValue < 50000)
                {
                    upgradeCurrentPoint3[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPoint3[i] / 2;
                }
            }
            transferValue1to18 += upgradeCurrentPoint3[i];
            text3[i].text = upgradeCurrentPoint3[i].ToString();
            //by18[i].SetActive(false);
        }
    }
}

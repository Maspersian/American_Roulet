using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class By3AddBEttingPointt : MonoBehaviour
{
    public List<GameObject> by3Image = new List<GameObject>();
    public int current;
    public List<int> upgradeCurrentPointBy3 = new List<int>();
    public List<TextMeshProUGUI> textBy3 = new List<TextMeshProUGUI>();
    public int maxBettingAmount;
    public int transferValueBy3;
    public int By3PointStore;
    public int by3DoubleValue;
    AudioManagerr audioManager;
    public int storing;


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();
    }
    void Update()
    {
        current = BettingCoin.currentSelectedCoin;
    }
    public void By3AddPoint(int by3Point)
    {
        for (int i = 0; i < by3Image.Count; i++)
        {
            if(by3Point  == i)
            {
               if( BettingCoin.totalBalance >= current)
                {
                    by3Image[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);
                    maxBettingAmount = upgradeCurrentPointBy3[i];
                    maxBettingAmount += current;

                    if (maxBettingAmount <= 50000)
                    {
                        upgradeCurrentPointBy3[i] += current;
                        BettingCoin.totalBalance -= current;
                        transferValueBy3 += current;
                        textBy3[i].text = upgradeCurrentPointBy3[i].ToString();
                        By3PointStore = by3Point;
                    }
                }
               // storing = by3Point;
            }
        }
    }
    public void By3ClearBn()
    {
        for (int i = 0; i < by3Image.Count; i++)
        {
            BettingCoin.totalBalance += upgradeCurrentPointBy3[i];
            upgradeCurrentPointBy3[i] = 0;
            by3Image[i].SetActive(false);
        }
        transferValueBy3 = 0;
    }
    public void By3DoubleBn()
    {
        transferValueBy3 = 0;
        for (int i = 0; i < by3Image.Count; i++)
        {

            if (BettingCoin.totalBalance >= upgradeCurrentPointBy3[i])
            {
                by3DoubleValue = upgradeCurrentPointBy3[i] * 2;
                if (by3DoubleValue <= 50000)
                {
                    upgradeCurrentPointBy3[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPointBy3[i] / 2;
                }
            }
            transferValueBy3 += upgradeCurrentPointBy3[i];
            textBy3[i].text = upgradeCurrentPointBy3[i].ToString();
        }
    }
}

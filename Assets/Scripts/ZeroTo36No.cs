using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;



public class ZeroTo36No : MonoBehaviour/*IPointerClickHandler*/
{
    //public BackValue backValue;
    //public List<GameObject> ZeroTo36Chips = new List<GameObject>();
    public List<GameObject> ZeroTo36Image = new List<GameObject>();
    public int current;
    public int totalBalaceAmount;
    public int win;
    public  List<int> upgradeCurrentPOint = new List<int>();
    public  List<int> currentPOint;
    public List<TextMeshProUGUI> text = new List<TextMeshProUGUI>();
    public int transferValue0to36=0;
    public SlotSetting SlotSetting;
    public int storing;
    public int MaxValueStore;
    public int doubleValue;
    public List<BackValue> backValues = new List<BackValue>();
    AudioManagerr audioManager;
    /*  public AudioSource sound;
      public AudioClip betSound;*/
    //public int currentDupl;
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
        totalBalaceAmount = BettingCoin.totalBalance;
        
    }
    
    public void ZeroToThirtySix(int chips0to36)
    {

        for(int i =0; i < ZeroTo36Image.Count; i++)
        {
            if (chips0to36 == i)
            {
               
                if (BettingCoin.totalBalance >= current)
                {
                   
                    ZeroTo36Image[i].SetActive(true);
                    audioManager.SoundPlayingg(audioManager.BettingChips);
                   
                    MaxValueStore = upgradeCurrentPOint[i];
                    MaxValueStore += current;
                    if (MaxValueStore <= 50000)
                    {
                        upgradeCurrentPOint[i] += current;
                        //MaxValueStore += current;
                        BettingCoin.totalBalance -= current;
                        transferValue0to36 += current;
                        text[i].text = upgradeCurrentPOint[i].ToString();
                    }
                    
                }
              
               
                Debug.Log("zxy");
                storing=chips0to36;
            }
        }
       
    }
    public void ClearBn()
    {
        for (int i = 0; i < ZeroTo36Image.Count; i++)
        {
            BettingCoin.totalBalance += upgradeCurrentPOint[i];
            upgradeCurrentPOint[i] = 0; // Set each element to zero
            ZeroTo36Image[i].SetActive(false) ;
            transferValue0to36 = 0;
            for (int j = 0; backValues.Count > j; j++)
            {
                backValues[i].reduceChips.Chips.Clear();
            }
            // Debug.Log("Remove alll elements in the list");
        }
        audioManager.SoundPlayingg(audioManager.clearAudio);

    }
    public void DoubleBn()
    {
        transferValue0to36 = 0;
        for (int i = 0; i < ZeroTo36Image.Count; i++)
        {
            if (BettingCoin.totalBalance >= upgradeCurrentPOint[i])
            {
                doubleValue = upgradeCurrentPOint[i]*2;
               // doubleValue += current;
               if (doubleValue <= 50000)
                {
                    upgradeCurrentPOint[i] *= 2;
                    BettingCoin.totalBalance -= upgradeCurrentPOint[i] / 2;
                }
                   
                
               
            }
            transferValue0to36 += upgradeCurrentPOint[i];
            text[i].text = upgradeCurrentPOint[i].ToString();
           
        }
        audioManager.SoundPlayingg(audioManager.doubleAudio);

    }

}


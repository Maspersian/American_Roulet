using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TwoSideBackVAlye : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public ReduceChips reduceChips;
    public TwoSide twoSide;
    public List<int> twoSideBeckup = new List<int>();
    public Timee Timee;
    public bool checking=false;
    AudioManagerr audioManager;
    // Start is called before the first frame update
    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();
    }
   

    // Update is called once per frame
    void Update()
    {
        if (Timee.timer < 3&&checking==false)
        {
            twoSideBeckup.AddRange(reduceChips.Chips);
            checking = true;
            //twoSideBeckup=new List<int> (5);
            for (int i = 0; i < reduceChips.Chips.Count; i++)
            {
                Debug.Log(i);


                Debug.Log(twoSideBeckup[i]);
                // twoSideBeckup.Add(reduceChips.Chips[i]);
                //twoSideBeckup[i] = 0;
                //twoSideBeckup[i] = reduceChips.Chips[i];
            }
        }

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (twoSide.maxBettingValue <= 50000)
            {
                reduceChips.Chips.Add(twoSide.current);
                //twoSideBeckup.Add(twoSide.current);

            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {

            if (reduceChips.Chips.Count > 0 && twoSide.upgradeCurrentPoint7.Count > 0)
            {
                int removedValue = reduceChips.Chips[reduceChips.Chips.Count - 1];
                

                // Remove from Chips list
                reduceChips.Chips.RemoveAt(reduceChips.Chips.Count - 1);
                //twoSideBeckup.RemoveAt(twoSideBeckup.Count - 1);

                // Find and remove from upgradeCurrentPOint
                for (int i = twoSide.twoSideStore; i < twoSide.upgradeCurrentPoint7.Count; i++)
                {
                    if (twoSide.upgradeCurrentPoint7[i] >= removedValue)
                    {
                        twoSide.upgradeCurrentPoint7[twoSide.twoSideStore] -= removedValue;
                        twoSide.translate2Side -= removedValue; 
                        audioManager.SoundPlayingg(audioManager.BettingChips);
                        BettingCoin.totalBalance += removedValue;
                        twoSide.text7[twoSide.twoSideStore].text = twoSide.upgradeCurrentPoint7[twoSide.twoSideStore].ToString();

                        // If value is zero, disable the chip UI
                        if (twoSide.upgradeCurrentPoint7[twoSide.twoSideStore] <= 0)
                        {
                            twoSide.TwosideChips[twoSide.twoSideStore].SetActive(false);
                            //blackAndRed.upgradeCurrentPoint5.RemoveAt(blackAndRed.redAndBlackStore); // Remove the entry
                        }
                        break; // Stop after updating first matching value
                    }
                }
            }
        }
    }
  
    public void OnPointerEnter(PointerEventData eventData)
    {
       if (eventData.pointerEnter.CompareTag("1t"))
        {
            twoSide.twoSideStore = 0;
        }
        if (eventData.pointerEnter.CompareTag("2t"))
        {
            twoSide.twoSideStore = 1;

        }
        if (eventData.pointerEnter.CompareTag("3t"))
        {
            twoSide.twoSideStore = 2;

        }
        if (eventData.pointerEnter.CompareTag("4t"))
        {
            twoSide.twoSideStore = 3;

        }
        if (eventData.pointerEnter.CompareTag("5t"))
        {
            twoSide.twoSideStore = 4;

        }
        if (eventData.pointerEnter.CompareTag("6t"))
        {
            twoSide.twoSideStore = 5;

        }
        if (eventData.pointerEnter.CompareTag("7t"))
        {
            twoSide.twoSideStore = 6;

        }
        if (eventData.pointerEnter.CompareTag("8t"))
        {
            twoSide.twoSideStore = 7;

        }
        if (eventData.pointerEnter.CompareTag("9t"))
        {
            twoSide.twoSideStore = 8;

        }
        if (eventData.pointerEnter.CompareTag("10t"))
        {
            twoSide.twoSideStore = 9;

        }
        if (eventData.pointerEnter.CompareTag("11t"))
        {
            twoSide.twoSideStore = 10;

        }
        if (eventData.pointerEnter.CompareTag("12t"))
        {
            twoSide.twoSideStore = 11;

        }
        if (eventData.pointerEnter.CompareTag("13t"))
        {
            twoSide.twoSideStore = 12;

        }
        if (eventData.pointerEnter.CompareTag("14t"))
        {
            twoSide.twoSideStore = 13;

        }
        if (eventData.pointerEnter.CompareTag("15t"))
        {
            twoSide.twoSideStore = 14;

        }
        if (eventData.pointerEnter.CompareTag("16t"))
        {
            twoSide.twoSideStore = 15;

        }
        if (eventData.pointerEnter.CompareTag("17t"))
        {
            twoSide.twoSideStore = 16;

        }
        if (eventData.pointerEnter.CompareTag("18t"))
        {
            twoSide.twoSideStore = 17;

        }
        if (eventData.pointerEnter.CompareTag("19t"))
        {
            twoSide.twoSideStore = 18;

        }
        if (eventData.pointerEnter.CompareTag("20t"))
        {
            twoSide.twoSideStore = 19;

        }
        if (eventData.pointerEnter.CompareTag("21t"))
        {
            twoSide.twoSideStore = 20;

        }
        if (eventData.pointerEnter.CompareTag("22T"))
        {
            twoSide.twoSideStore = 21;

        }
        if (eventData.pointerEnter.CompareTag("23T"))
        {
            twoSide.twoSideStore = 22;
        }
        if (eventData.pointerEnter.CompareTag("24T"))
        {
            twoSide.twoSideStore = 23;

        }
        if (eventData.pointerEnter.CompareTag("25T"))
        {
            twoSide.twoSideStore = 24;

        }
        if (eventData.pointerEnter.CompareTag("26T"))
        {
            twoSide.twoSideStore = 25;

        }
        if (eventData.pointerEnter.CompareTag("27T"))
        {
            twoSide.twoSideStore = 26;

        }
        if (eventData.pointerEnter.CompareTag("28T"))
        {
            twoSide.twoSideStore = 27;

        }
        if (eventData.pointerEnter.CompareTag("29T"))
        {
            twoSide.twoSideStore = 28;

        }
        if (eventData.pointerEnter.CompareTag("30T"))
        {
            twoSide.twoSideStore = 29;

        }
        if (eventData.pointerEnter.CompareTag("31T"))
        {
            twoSide.twoSideStore = 30;

        }
        if (eventData.pointerEnter.CompareTag("32T"))
        {
            twoSide.twoSideStore = 31;

        }
        if (eventData.pointerEnter.CompareTag("33T"))
        {
            twoSide.twoSideStore = 32;

        }
        if (eventData.pointerEnter.CompareTag("34T"))
        {
            twoSide.twoSideStore = 33;

        }
        if (eventData.pointerEnter.CompareTag("35T"))
        {
            twoSide.twoSideStore = 34;

        }
        if (eventData.pointerEnter.CompareTag("36T"))
        {
            twoSide.twoSideStore = 35;

        }
        if (eventData.pointerEnter.CompareTag("37T"))
        {
            twoSide.twoSideStore = 36;

        }
        if (eventData.pointerEnter.CompareTag("38T"))
        {
            twoSide.twoSideStore = 37;

        }
        if (eventData.pointerEnter.CompareTag("39T"))
        {
            twoSide.twoSideStore = 38;
        }
        if (eventData.pointerEnter.CompareTag("40T"))
        {
            twoSide.twoSideStore = 39;

        }
        if (eventData.pointerEnter.CompareTag("41T"))
        {
            twoSide.twoSideStore = 40;

        }
        if (eventData.pointerEnter.CompareTag("42T"))
        {
            twoSide.twoSideStore = 41;

        }
        if (eventData.pointerEnter.CompareTag("43T"))
        {
            twoSide.twoSideStore = 42;

        }
        if (eventData.pointerEnter.CompareTag("44T"))
        {
            twoSide.twoSideStore = 43;

        }
        if (eventData.pointerEnter.CompareTag("45T"))
        {
            twoSide.twoSideStore = 44;

        }
        if (eventData.pointerEnter.CompareTag("46T"))
        {
            twoSide.twoSideStore = 45;

        }
        if (eventData.pointerEnter.CompareTag("47T"))
        {
            twoSide.twoSideStore = 46;

        }
        if (eventData.pointerEnter.CompareTag("48T"))
        {
            twoSide.twoSideStore = 47;

        }
        if (eventData.pointerEnter.CompareTag("49T"))
        {
            twoSide.twoSideStore = 48;

        }
        if (eventData.pointerEnter.CompareTag("50T"))
        {
            twoSide.twoSideStore = 49;

        }
        if (eventData.pointerEnter.CompareTag("51T"))
        {
            twoSide.twoSideStore = 50;

        }
        if (eventData.pointerEnter.CompareTag("52T"))
        {
            twoSide.twoSideStore = 51;

        }
        if (eventData.pointerEnter.CompareTag("53T"))
        {
            twoSide.twoSideStore = 52;

        }
        if (eventData.pointerEnter.CompareTag("54T"))
        {
            twoSide.twoSideStore = 53;

        }
        if (eventData.pointerEnter.CompareTag("55T"))
        {
            twoSide.twoSideStore = 54;

        }
        if (eventData.pointerEnter.CompareTag("56T"))
        {
            twoSide.twoSideStore = 55;

        }
        if (eventData.pointerEnter.CompareTag("57T"))
        {
            twoSide.twoSideStore = 56;

        }
        if (eventData.pointerEnter.CompareTag("58T"))
        {
            twoSide.twoSideStore = 57;

        }
        if (eventData.pointerEnter.CompareTag("59T"))
        {
            twoSide.twoSideStore = 58;

        }
        if (eventData.pointerEnter.CompareTag("60T"))
        {
            twoSide.twoSideStore = 59;
        }
        if (eventData.pointerEnter.CompareTag("61T"))
        {
            twoSide.twoSideStore = 60;

        }
        /*if (eventData.pointerEnter.CompareTag("62T"))
        {
            twoSide.twoSideStore = 61;

        }*/
    }
    public void OnPointerExit(PointerEventData eventData)
    {
    
        if (eventData.pointerEnter.CompareTag("1t"))
        {
            twoSide.twoSideStore = 65;
        }
        if (eventData.pointerEnter.CompareTag("2t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("3t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("4t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("5t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("6t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("7t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("8t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("9t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("10t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("11t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("12t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("13t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("14t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("15t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("16t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("17t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("18t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("19t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("20t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("21t"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("22T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("23T"))
        {
            twoSide.twoSideStore = 65;
        }
        if (eventData.pointerEnter.CompareTag("24T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("25T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("26T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("27T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("28T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("29T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("30T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("31T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("32T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("33T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("34T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("35T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("36T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("37T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("38T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("39T"))
        {
            twoSide.twoSideStore = 65;
        }
        if (eventData.pointerEnter.CompareTag("40T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("41T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("42T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("43T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("44T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("45T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("46T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("47T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("48T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("49T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("50T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("51T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("52T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("53T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("54T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("55T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("56T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("57T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("58T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("59T"))
        {
            twoSide.twoSideStore = 65;

        }
        if (eventData.pointerEnter.CompareTag("60T"))
        {
            twoSide.twoSideStore = 65;
        }
        if (eventData.pointerEnter.CompareTag("61T"))
        {
            twoSide.twoSideStore = 65;

        }
    }
}

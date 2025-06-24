using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
[System.Serializable]
public class ReduceChips
{
    public List<int> Chips = new List<int>();
}
public class BackValue : MonoBehaviour, IPointerEnterHandler,IPointerClickHandler
{
    public ReduceChips reduceChips;
    public ZeroTo36No ZeroTo36No;
    public OneTo36 oneTo36;
    public Timee time;
    public int reducingPoints;
    public bool CheckRightClick=false;
    public BettingCoin BettingCoin;
    public int totalReduceValue;
    AudioManagerr audioManager;
    //public GameObject image1;
    //public TextMeshProUGUI text1;

    // Start is called before the first frame update
    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (ZeroTo36No.MaxValueStore <= 50000)
            {
                reduceChips.Chips.Add(ZeroTo36No.current);
            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            Debug.Log(ZeroTo36No.storing);
            if (reduceChips.Chips.Count > 0 && ZeroTo36No.upgradeCurrentPOint.Count > 0)
            {
                int removedValue = reduceChips.Chips[reduceChips.Chips.Count - 1];

                // Remove from Chips list
                
                reduceChips.Chips.RemoveAt(reduceChips.Chips.Count - 1);

                // Find and remove from upgradeCurrentPOint
                for (int i = ZeroTo36No.storing; i < ZeroTo36No.upgradeCurrentPOint.Count; i++)
                {
                    if (oneTo36.Panel[ZeroTo36No.storing] == true)
                    {
                        if (ZeroTo36No.upgradeCurrentPOint[i] <= removedValue || oneTo36.Panel[i]==true /*&& oneTo36.Panel[i] == oneTo36.No[i]*/)
                        {
                            Debug.Log(ZeroTo36No.upgradeCurrentPOint[i] + " uppovalue" + removedValue + " removable value");
                         
                            ZeroTo36No.upgradeCurrentPOint[ZeroTo36No.storing] -= removedValue;
                            ZeroTo36No.transferValue0to36 -= removedValue;
                            audioManager.SoundPlayingg(audioManager.BettingChips);

                            BettingCoin.totalBalance += removedValue;

                            // Update the UI with the new betting amount
                            time.  totalBettingAmountText.text =time. bettingAmountCalculation.ToString();

                            reducingPoints = removedValue;
                            // Debug.Log("removedValue " +removedValue);    
                            ZeroTo36No.text[ZeroTo36No.storing].text = ZeroTo36No.upgradeCurrentPOint[ZeroTo36No.storing].ToString();
                            // Subtract from total betting amount and update UI


                            
                            // If value is zero, disable the chip UI
                            if (ZeroTo36No.upgradeCurrentPOint[ZeroTo36No.storing] <= 0)
                            {
                                ZeroTo36No.ZeroTo36Image[ZeroTo36No.storing].SetActive(false);
                            }
                            break; // Stop after updating first matching value
                        }
                    }
                }
            }
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerEnter.CompareTag("1"))
        {
            ZeroTo36No.storing = 1;
        }
        else if (eventData.pointerEnter.CompareTag("0"))
        {
            ZeroTo36No.storing = 0;
        }
        else if (eventData.pointerEnter.CompareTag("2"))
        {
            ZeroTo36No.storing = 2;
        }
        else if (eventData.pointerEnter.CompareTag("3"))
        {
            ZeroTo36No.storing = 3;
        }
        else if (eventData.pointerEnter.CompareTag("4"))
        {
            ZeroTo36No.storing = 4;
        }
        else if (eventData.pointerEnter.CompareTag("5"))
        {
            ZeroTo36No.storing = 5;
        }
        else if (eventData.pointerEnter.CompareTag("6"))
        {
            ZeroTo36No.storing = 6;
        }
        else if (eventData.pointerEnter.CompareTag("7"))
        {
            ZeroTo36No.storing = 7;
        }
        else if (eventData.pointerEnter.CompareTag("8"))
        {
            ZeroTo36No.storing = 8;
        }
        else if (eventData.pointerEnter.CompareTag("9"))
        {
            ZeroTo36No.storing = 9;
        }
        else if (eventData.pointerEnter.CompareTag("10"))
        {
            ZeroTo36No.storing = 10;
        }
        else if (eventData.pointerEnter.CompareTag("11"))
        {
            ZeroTo36No.storing = 11;
        }
        else if (eventData.pointerEnter.CompareTag("12"))
        {
            ZeroTo36No.storing = 12;
        }
        else if (eventData.pointerEnter.CompareTag("13"))
        {
            ZeroTo36No.storing = 13;
        }
        else if (eventData.pointerEnter.CompareTag("14"))
        {
            ZeroTo36No.storing = 14;
        }
        else if (eventData.pointerEnter.CompareTag("15"))
        {
            ZeroTo36No.storing = 15;
        }
        else if (eventData.pointerEnter.CompareTag("16"))
        {
            ZeroTo36No.storing = 16;
        }
        else if (eventData.pointerEnter.CompareTag("17"))
        {
            ZeroTo36No.storing = 17;
        }
        else if (eventData.pointerEnter.CompareTag("18"))
        {
            ZeroTo36No.storing = 18;
        }
        else if (eventData.pointerEnter.CompareTag("19"))
        {
            ZeroTo36No.storing = 19;
        }
        else if (eventData.pointerEnter.CompareTag("20"))
        {
            ZeroTo36No.storing = 20;
        }
        else if (eventData.pointerEnter.CompareTag("21"))
        {
            ZeroTo36No.storing = 21;
        }
        else if (eventData.pointerEnter.CompareTag("22"))
        {
            ZeroTo36No.storing = 22;
        }
        else if (eventData.pointerEnter.CompareTag("23"))
        {
            ZeroTo36No.storing = 23;
        }
        else if (eventData.pointerEnter.CompareTag("24"))
        {
            ZeroTo36No.storing = 24;
        }
        else if (eventData.pointerEnter.CompareTag("25"))
        {
            ZeroTo36No.storing = 25;
        }
        else if (eventData.pointerEnter.CompareTag("26"))
        {
            ZeroTo36No.storing = 26;
        }
        else if (eventData.pointerEnter.CompareTag("27"))
        {
            ZeroTo36No.storing = 27;
        }
        else if (eventData.pointerEnter.CompareTag("28"))
        {
            ZeroTo36No.storing = 28;
        }
        else if (eventData.pointerEnter.CompareTag("29"))
        {
            ZeroTo36No.storing = 29;
        }
        else if (eventData.pointerEnter.CompareTag("30"))
        {
            ZeroTo36No.storing = 30;
        }
        else if (eventData.pointerEnter.CompareTag("31"))
        {
            ZeroTo36No.storing = 31;
        }
        else if (eventData.pointerEnter.CompareTag("32"))
        {
            ZeroTo36No.storing = 32;
        }
        else if (eventData.pointerEnter.CompareTag("33"))
        {
            ZeroTo36No.storing = 33;
        }
        else if (eventData.pointerEnter.CompareTag("34"))
        {
            ZeroTo36No.storing = 34;
        }
        else if (eventData.pointerEnter.CompareTag("35"))
        {
            ZeroTo36No.storing = 35;
        }
        else if (eventData.pointerEnter.CompareTag("36"))
        {
            ZeroTo36No.storing = 36;
        }
        else if (eventData.pointerEnter.CompareTag("00"))
        {
            ZeroTo36No.storing = 37;
        }
        
    }

}

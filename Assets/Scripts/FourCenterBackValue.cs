using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FourCenterBackValue : MonoBehaviour,IPointerClickHandler,IPointerEnterHandler
{
    public ReduceChips reduceChips;
    public CenterPoint centerPoint;
    AudioManagerr audioManager;
    // Start is called before the first frame update
    void Awake()
    {
       
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if(centerPoint.maxBettingAmount <= 50000)
            {
                reduceChips.Chips.Add(centerPoint.current);

            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {

            if (reduceChips.Chips.Count > 0 && centerPoint.upgradeCurrentPoint6.Count > 0)
            {
                int removedValue = reduceChips.Chips[reduceChips.Chips.Count - 1];

                // Remove from Chips list
                reduceChips.Chips.RemoveAt(reduceChips.Chips.Count - 1);

                // Find and remove from upgradeCurrentPOint
                for (int i = centerPoint.centerPointStore; i < centerPoint.upgradeCurrentPoint6.Count; i++)
                {
                    if (centerPoint.upgradeCurrentPoint6[i] >= removedValue)
                    {
                        centerPoint.upgradeCurrentPoint6[centerPoint.centerPointStore] -= removedValue;
                        centerPoint.transferValueCenterpoint -= removedValue;
                        audioManager.SoundPlayingg(audioManager.BettingChips);
                        BettingCoin.totalBalance += removedValue;
                        centerPoint.text6[centerPoint.centerPointStore].text = centerPoint.upgradeCurrentPoint6[centerPoint.centerPointStore].ToString();

                        // If value is zero, disable the chip UI
                        if (centerPoint.upgradeCurrentPoint6[centerPoint.centerPointStore] <= 0)
                        {
                            centerPoint.centerPointImage[centerPoint.centerPointStore].SetActive(false);
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
        if (eventData.pointerEnter.CompareTag("1c"))
        {
            centerPoint.centerPointStore = 0;
        }
        if (eventData.pointerEnter.CompareTag("2c"))
        {
            centerPoint.centerPointStore = 1;

        }
        if (eventData.pointerEnter.CompareTag("3c"))
        {
            centerPoint.centerPointStore = 2;

        }
        if (eventData.pointerEnter.CompareTag("4c"))
        {
            centerPoint.centerPointStore = 3;

        }
        if (eventData.pointerEnter.CompareTag("5c"))
        {
            centerPoint.centerPointStore = 4;

        }
        if (eventData.pointerEnter.CompareTag("6c"))
        {
            centerPoint.centerPointStore = 5;

        }
        if (eventData.pointerEnter.CompareTag("7c"))
        {
            centerPoint.centerPointStore = 6;

        }
        if (eventData.pointerEnter.CompareTag("8c"))
        {
            centerPoint.centerPointStore = 7;

        }
        if (eventData.pointerEnter.CompareTag("9c"))
        {
            centerPoint.centerPointStore = 8;

        }
        if (eventData.pointerEnter.CompareTag("10c"))
        {
            centerPoint.centerPointStore =9;

        }
        if (eventData.pointerEnter.CompareTag("11c"))
        {
            centerPoint.centerPointStore = 10;

        }
        if (eventData.pointerEnter.CompareTag("12c"))
        {
            centerPoint.centerPointStore = 11;

        }
        if (eventData.pointerEnter.CompareTag("13c"))
        {
            centerPoint.centerPointStore = 12;

        }
        if (eventData.pointerEnter.CompareTag("14c"))
        {
            centerPoint.centerPointStore = 13;

        }
        if (eventData.pointerEnter.CompareTag("15c"))
        {
            centerPoint.centerPointStore = 14;

        }
        if (eventData.pointerEnter.CompareTag("16c"))
        {
            centerPoint.centerPointStore = 15;

        }
        if (eventData.pointerEnter.CompareTag("17c"))
        {
            centerPoint.centerPointStore = 16;

        }
        if (eventData.pointerEnter.CompareTag("18c"))
        {
            centerPoint.centerPointStore = 17;

        }
        if (eventData.pointerEnter.CompareTag("19c"))
        {
            centerPoint.centerPointStore = 18;

        }
        if (eventData.pointerEnter.CompareTag("20c"))
        {
            centerPoint.centerPointStore = 19;

        }
        if (eventData.pointerEnter.CompareTag("21c"))
        {
            centerPoint.centerPointStore = 20;

        }
        if (eventData.pointerEnter.CompareTag("22c"))
        {
            centerPoint.centerPointStore = 21;

        }
    }
}

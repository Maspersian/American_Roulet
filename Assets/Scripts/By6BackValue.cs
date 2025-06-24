using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class By6BackValue : MonoBehaviour, IPointerEnterHandler,IPointerClickHandler
{

    public ReduceChips reduceChips;
    public DoubleColumn DoubleColumn;
    AudioManagerr audioManager;

    //public By3Panelselection By3Panelselection;
    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (DoubleColumn.maxBettingValue <= 50000)
            {
                reduceChips.Chips.Add(DoubleColumn.current);
            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {

            if (reduceChips.Chips.Count > 0 && DoubleColumn.upgradeCurrentPoint8.Count > 0)
            {
                int removedValue = reduceChips.Chips[reduceChips.Chips.Count - 1];

                // Remove from Chips list
                reduceChips.Chips.RemoveAt(reduceChips.Chips.Count - 1);

                // Find and remove from upgradeCurrentPOint
                for (int i = DoubleColumn.storeBy6; i < DoubleColumn.upgradeCurrentPoint8.Count; i++)
                {
                    if (DoubleColumn.upgradeCurrentPoint8.Count >= removedValue && i == DoubleColumn.storeBy6)
                    {
                        DoubleColumn.upgradeCurrentPoint8[DoubleColumn.storeBy6] -= removedValue;
                        DoubleColumn.transferDoubleColumnsValue -= removedValue;
                        audioManager.SoundPlayingg(audioManager.BettingChips);
                        DoubleColumn.text8[DoubleColumn.storeBy6].text = DoubleColumn.upgradeCurrentPoint8[DoubleColumn.storeBy6].ToString();
                        BettingCoin.totalBalance += removedValue;

                        // If value is zero, disable the chip UI
                        if (DoubleColumn.upgradeCurrentPoint8[DoubleColumn.storeBy6] <= 0)
                        {
                            DoubleColumn.bySixChips[DoubleColumn.storeBy6].SetActive(false);
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
        if (eventData.pointerEnter.CompareTag("1By6"))
        {
            DoubleColumn.storeBy6 = 0;
        }
        else if (eventData.pointerEnter.CompareTag("2By6"))
        {
            DoubleColumn.storeBy6 = 1;
        }
        else if (eventData.pointerEnter.CompareTag("3By6"))
        {
            DoubleColumn.storeBy6 = 2;

        }
        else if (eventData.pointerEnter.CompareTag("4By6"))
        {
            DoubleColumn.storeBy6 = 3;

        }
        else if (eventData.pointerEnter.CompareTag("5By6"))
        {
            DoubleColumn.storeBy6 = 4;

        }
        else if (eventData.pointerEnter.CompareTag("6By6"))
        {
            DoubleColumn.storeBy6 = 5;

        }
        else if (eventData.pointerEnter.CompareTag("7By6"))
        {
            DoubleColumn.storeBy6 = 6;

        }

        else if (eventData.pointerEnter.CompareTag("8By6"))
        {
            DoubleColumn.storeBy6 = 7;

        }
        else if (eventData.pointerEnter.CompareTag("9By6"))
        {
            DoubleColumn.storeBy6 = 8;

        }
        else if (eventData.pointerEnter.CompareTag("10By6"))
        {
            DoubleColumn.storeBy6 = 9;

        }
        else if (eventData.pointerEnter.CompareTag("11By6"))
        {
            DoubleColumn.storeBy6 = 10;

        }
        else if (eventData.pointerEnter.CompareTag("12By6"))
        {
            DoubleColumn.storeBy6 = 11;

        }
    }
}

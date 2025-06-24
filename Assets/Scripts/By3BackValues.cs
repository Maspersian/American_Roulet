using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class By3BackValues : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
{
    public ReduceChips reduceChips;
    public SingleColumn SingleColumn;
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
            if (SingleColumn.maxBettingValue <= 50000)
            {
                reduceChips.Chips.Add(SingleColumn.current);
            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {

            if (reduceChips.Chips.Count > 0 && SingleColumn.upgradeCurrentPoint9.Count > 0)
            {
                int removedValue = reduceChips.Chips[reduceChips.Chips.Count - 1];

                // Remove from Chips list
                reduceChips.Chips.RemoveAt(reduceChips.Chips.Count - 1);

                // Find and remove from upgradeCurrentPOint
                for (int i = SingleColumn.storingBy3; i < SingleColumn.upgradeCurrentPoint9.Count; i++)
                {
                    if (SingleColumn.upgradeCurrentPoint9.Count >= removedValue && i==SingleColumn.storingBy3 )
                    {
                        SingleColumn.upgradeCurrentPoint9[SingleColumn.storingBy3] -= removedValue;
                        SingleColumn.transferBettingSingleColmn -= removedValue;
                        audioManager.SoundPlayingg(audioManager.BettingChips);
                        SingleColumn.text9[SingleColumn.storingBy3].text = SingleColumn.upgradeCurrentPoint9[SingleColumn.storingBy3].ToString();
                        BettingCoin.totalBalance += removedValue;

                        // If value is zero, disable the chip UI
                        if (SingleColumn.upgradeCurrentPoint9[SingleColumn.storingBy3] <= 0)
                        {
                            SingleColumn.singleColumnChips[SingleColumn.storingBy3].SetActive(false);
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
        if (eventData.pointerEnter.CompareTag("1By3"))
        {
            SingleColumn.storingBy3 = 0;
        }
        else if (eventData.pointerEnter.CompareTag("2By3"))
        {
            SingleColumn.storingBy3 = 1;
        }
        else if (eventData.pointerEnter.CompareTag("3By3"))
        {
            SingleColumn.storingBy3 = 2;

        }
        else if (eventData.pointerEnter.CompareTag("4By3"))
        {
            SingleColumn.storingBy3 = 3;

        }
        else if (eventData.pointerEnter.CompareTag("5By3"))
        {
            SingleColumn.storingBy3 = 4;

        }
        else if (eventData.pointerEnter.CompareTag("6By3"))
        {
            SingleColumn.storingBy3 = 5;

        }
        else if (eventData.pointerEnter.CompareTag("7By3"))
        {
            SingleColumn.storingBy3 = 6;

        }

        else if (eventData.pointerEnter.CompareTag("8By3"))
        {
            SingleColumn.storingBy3 = 7;

        }
        else if (eventData.pointerEnter.CompareTag("9By3"))
        {
            SingleColumn.storingBy3 = 8;

        }
        else if (eventData.pointerEnter.CompareTag("10By3"))
        {
            SingleColumn.storingBy3 = 9;

        }
        else if (eventData.pointerEnter.CompareTag("11By3"))
        {
            SingleColumn.storingBy3 = 10;

        }
        else if (eventData.pointerEnter.CompareTag("12By3"))
        {
            SingleColumn.storingBy3 = 11;

        }
    }
}

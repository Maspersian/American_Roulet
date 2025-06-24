using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class By3BackValueReducePoint : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public ReduceChips reduceChips;
    public By3AddBEttingPointt by3AddBEttingPointt;
    AudioManagerr audioManager;
    public By3Panel By3Panel;
   // public TextMeshProUGUI textBy3BackValue;
    //public List<TextMeshProUGUI> textBy3BackValue = new List<TextMeshProUGUI>();


    // Start is called before the first frame update
    void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManagerr>();

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (by3AddBEttingPointt.maxBettingAmount <= 50000)
            {
                reduceChips.Chips.Add(by3AddBEttingPointt.current);
            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            if (reduceChips.Chips.Count > 0 )
            {
                int removedValue = reduceChips.Chips[reduceChips.Chips.Count - 1];
                // Remove from Chips list
                reduceChips.Chips.RemoveAt(reduceChips.Chips.Count - 1);
                // Find and remove from upgradeCurrentPOint

                for (int i = by3AddBEttingPointt.By3PointStore; i < by3AddBEttingPointt.upgradeCurrentPointBy3.Count; i++)
                {
                    
                    if (by3AddBEttingPointt.upgradeCurrentPointBy3[i] >= removedValue)
                    {
                        Debug.Log("Find The bug" + i);
                        by3AddBEttingPointt.upgradeCurrentPointBy3[by3AddBEttingPointt.By3PointStore] -= removedValue;
                        by3AddBEttingPointt.transferValueBy3 -= removedValue;
                        audioManager.SoundPlayingg(audioManager.BettingChips);
                        BettingCoin.totalBalance += removedValue;
                       // textBy3BackValue.text = by3AddBEttingPointt.upgradeCurrentPointBy3[by3AddBEttingPointt.storing].ToString();
                        by3AddBEttingPointt.textBy3[by3AddBEttingPointt.By3PointStore].text = by3AddBEttingPointt.upgradeCurrentPointBy3[by3AddBEttingPointt.By3PointStore].ToString();
                        // If value is zero, disable the chip UI

                        if (by3AddBEttingPointt.upgradeCurrentPointBy3[by3AddBEttingPointt.By3PointStore] <= 0)
                        {
                            Debug.Log("The value is zero");
                            by3AddBEttingPointt.by3Image[by3AddBEttingPointt.By3PointStore].SetActive(false);
                        }
                        break; // Stop after updating first matching value
                    }
                    
                }
            }
        } 
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerEnter.CompareTag("By31"))
        {
            by3AddBEttingPointt.By3PointStore = 0;
        }
        if (eventData.pointerEnter.CompareTag("By32"))
        {
            by3AddBEttingPointt.By3PointStore = 1;

        }
        if (eventData.pointerEnter.CompareTag("By33"))
        {
            by3AddBEttingPointt.By3PointStore = 2;

        }
    }
    /*public void OnPointerExit(PointerEventData eventData)
    {

        if (eventData.pointerEnter.CompareTag("By31"))
        {
            by3AddBEttingPointt.storing = 65;
        }
        if (eventData.pointerEnter.CompareTag("By32"))
        {
            by3AddBEttingPointt.storing = 65;

        }
        if (eventData.pointerEnter.CompareTag("By33"))
        {
            by3AddBEttingPointt.storing = 65;

        }
    }*/

}

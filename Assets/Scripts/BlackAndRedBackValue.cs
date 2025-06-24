using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BlackAndRedBackValue : MonoBehaviour,IPointerClickHandler,IPointerEnterHandler
{
    public ReduceChips reduceChips;
    public BlackAndRed blackAndRed;
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
            if (blackAndRed.maxBettingAmound <= 50000)
            {
                reduceChips.Chips.Add(blackAndRed.current);
            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {

            if (reduceChips.Chips.Count > 0 && blackAndRed.upgradeCurrentPoint5.Count > 0)
            {
                int removedValue = reduceChips.Chips[reduceChips.Chips.Count - 1];

                // Remove from Chips list
                reduceChips.Chips.RemoveAt(reduceChips.Chips.Count - 1);

                // Find and remove from upgradeCurrentPOint
                for (int i = blackAndRed.redAndBlackStore ; i < blackAndRed.upgradeCurrentPoint5.Count; i++)
                {
                    if (blackAndRed.upgradeCurrentPoint5[i] >= removedValue)
                    {
                        blackAndRed.upgradeCurrentPoint5[blackAndRed.redAndBlackStore] -= removedValue;
                        blackAndRed.transferValueRedAndBlack -= removedValue;
                        audioManager.SoundPlayingg(audioManager.BettingChips);
                        BettingCoin.totalBalance += removedValue;
                        blackAndRed.text5[blackAndRed.redAndBlackStore].text = blackAndRed.upgradeCurrentPoint5[blackAndRed.redAndBlackStore].ToString();

                        // If value is zero, disable the chip UI
                        if (blackAndRed.upgradeCurrentPoint5[blackAndRed.redAndBlackStore] <= 0)
                        {
                            blackAndRed.RedAndBlackImage[blackAndRed.redAndBlackStore].SetActive(false);
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
        if (eventData.pointerEnter.CompareTag("Red"))
        {
            blackAndRed.redAndBlackStore = 1;
        }
        if (eventData.pointerEnter.CompareTag("Black"))
        {
            blackAndRed.redAndBlackStore = 0;

        }
    }

}

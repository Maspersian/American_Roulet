using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OddAndEvenBackValue : MonoBehaviour ,IPointerClickHandler,IPointerEnterHandler
{

    public ReduceChips reduceChips;
    public EvenandOdd evenandOdd;
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
            if (evenandOdd.maxBettingValue <= 50000)
            {
                reduceChips.Chips.Add(evenandOdd.current);
            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {

            if (reduceChips.Chips.Count > 0 && evenandOdd.upgradeCurrentPoint4.Count > 0)
            {
                int removedValue = reduceChips.Chips[reduceChips.Chips.Count - 1];

                // Remove from Chips list
                reduceChips.Chips.RemoveAt(reduceChips.Chips.Count - 1);

                // Find and remove from upgradeCurrentPOint
                for (int i = evenandOdd.evenAndOddStore; i < evenandOdd.upgradeCurrentPoint4.Count; i++)
                {
                    if (evenandOdd.upgradeCurrentPoint4[i] >= removedValue)
                    {
                        evenandOdd.upgradeCurrentPoint4[evenandOdd.evenAndOddStore] -= removedValue;
                        evenandOdd.transferValueEvenOrOdd -= removedValue;
                        audioManager.SoundPlayingg(audioManager.BettingChips);
                        BettingCoin.totalBalance += removedValue;
                        evenandOdd.text4[evenandOdd.evenAndOddStore].text = evenandOdd.upgradeCurrentPoint4[evenandOdd.evenAndOddStore].ToString();

                        // If value is zero, disable the chip UI
                        if (evenandOdd.upgradeCurrentPoint4[evenandOdd.evenAndOddStore] <= 0)
                        {
                            evenandOdd.evenAndOddImage[evenandOdd.evenAndOddStore].SetActive(false);
                           // evenandOdd.upgradeCurrentPoint4.RemoveAt(i); // Remove the entry
                        }
                        break; // Stop after updating first matching value
                    }
                }
            }
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerEnter.CompareTag("Even"))
        {
            evenandOdd.evenAndOddStore = 0;
        }
        if (eventData.pointerEnter.CompareTag("Odd"))
        {
            evenandOdd.evenAndOddStore = 1;

        }
    }
}

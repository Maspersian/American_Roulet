using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class OneBy18BackValue : MonoBehaviour ,IPointerClickHandler,IPointerEnterHandler
{
    public ReduceChips reduceChips;
    public OneToEight oneToEight;
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
            if (oneToEight.maxBettingAmount <= 50000)
            {
               reduceChips.Chips.Add(oneToEight.current);
            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {

            if (reduceChips.Chips.Count > 0 && oneToEight.upgradeCurrentPoint3.Count > 0)
            {
                int removedValue = reduceChips.Chips[reduceChips.Chips.Count - 1];

                // Remove from Chips list
                reduceChips.Chips.RemoveAt(reduceChips.Chips.Count - 1);

                // Find and remove from upgradeCurrentPOint
                for (int i = oneToEight.by18Store; i < oneToEight.upgradeCurrentPoint3.Count; i++)
                {
                    if (oneToEight.upgradeCurrentPoint3[i] >= removedValue)
                    {
                        oneToEight.upgradeCurrentPoint3[oneToEight.by18Store] -= removedValue;
                        oneToEight.transferValue1to18 -= removedValue;
                        audioManager.SoundPlayingg(audioManager.BettingChips);
                        BettingCoin.totalBalance += removedValue;
                        oneToEight.text3[oneToEight.by18Store].text = oneToEight.upgradeCurrentPoint3[oneToEight.by18Store].ToString();

                        // If value is zero, disable the chip UI
                        if (oneToEight.upgradeCurrentPoint3[oneToEight.by18Store] <= 0)
                        {
                            oneToEight.by18[oneToEight.by18Store].SetActive(false);
                           // oneToEight.upgradeCurrentPoint3.RemoveAt(oneToEight.by18Store); // Remove the entry
                        }
                        break; // Stop after updating first matching value
                    }
                }
            }
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerEnter.CompareTag("1to18"))
        {
            oneToEight.by18Store = 0;
        }
        if (eventData.pointerEnter.CompareTag("19to36"))
        {
            oneToEight.by18Store = 1;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TwelveByBackValue : MonoBehaviour , IPointerClickHandler,IPointerEnterHandler
{

    public ReduceChips reduceChips;
    public By12 by12;
    AudioManagerr audioManager;
    //public TextMeshProUGUI text;

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
            if (by12.maxBettingAmount <= 50000)
            {
                reduceChips.Chips.Add(by12.current);
            }
        }
        if (eventData.button == PointerEventData.InputButton.Right)
        {

            if (reduceChips.Chips.Count > 0) // Ensure the list is not empty
            {
                int lastIndex = reduceChips.Chips.Count - 1;
                int removedValue = reduceChips.Chips[lastIndex]; // Store the removed value

                reduceChips.Chips.RemoveAt(lastIndex);

                // Find the correct index in ZeroTo36No and update UI
                for (int i = by12.byTwelveStore; i < by12.upgradeCurrentPoint2.Count; i++)
                {
                    if (by12.upgradeCurrentPoint2[i] >= removedValue)
                    {
                        by12.upgradeCurrentPoint2[by12.byTwelveStore] -= removedValue;
                        by12.transferValueBy12 -= removedValue;
                        audioManager.SoundPlayingg(audioManager.BettingChips);
                        BettingCoin.totalBalance += removedValue;
                        by12.text2[by12.byTwelveStore].text = by12.upgradeCurrentPoint2[by12.byTwelveStore].ToString();

                        // If value becomes zero, disable the chip UI
                        if (by12.upgradeCurrentPoint2[by12.byTwelveStore] <= 0)
                        {
                            by12.ByTwelve[by12.byTwelveStore].SetActive(false);
                        }
                        break; // Stop after updating the first matching value
                    }
                }
            }
        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerEnter.CompareTag("FirstBy12"))
        {
            by12.byTwelveStore = 0;
        }
        if (eventData.pointerEnter.CompareTag("Second12"))
        {
            by12.byTwelveStore = 1;
        }
        if (eventData.pointerEnter.CompareTag("Third12"))
        {
            by12.byTwelveStore = 2;
        }
    }
}

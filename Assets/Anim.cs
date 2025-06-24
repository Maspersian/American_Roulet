using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    public Animator animator;
    private int winningNumber;
    //public Timee Timee;

    void Start()
    {
        if (animator == null)
            animator = GetComponent<Animator>();
    }

    // Function to spin the wheel and play the winning animation
    public void SpinWheel()
    {
        // Generate a random winning number between 0 and 36
        //winningNumber = Timee.winnerNum;
        Debug.Log("Winning Number: " + winningNumber);

        // Trigger the related animation
        PlayWinningAnimation(winningNumber);
    }

    void PlayWinningAnimation(int number)
    {
        string animationName = "Wheel " + number;

        // Check if the animation exists in the animator
        if (animator.HasState(0, Animator.StringToHash(animationName)))
        {
            animator.Play(animationName);
        }
        else
        {
            Debug.LogWarning("Animation not found: " + animationName);
        }
    }

}

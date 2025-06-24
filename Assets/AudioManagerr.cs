using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerr : MonoBehaviour
{
    [Header("-------------- Audio Source--------------")]
    [SerializeField] AudioSource sound;

    [Header("-------------- Audio Clip----------------")]
    public AudioClip BettingChips;
    public AudioClip WheelRotate;
    public List<AudioClip> winNum = new List<AudioClip>();
    public AudioClip winnerSound;
    public AudioClip reDSound;
    public AudioClip blackSound;
    public AudioClip nextRound;
    public AudioClip noMoreBets;
    public AudioClip betPlease;
    public AudioClip repeatAudio;
    public AudioClip clearAudio;
    public AudioClip doubleAudio;

    public bool isMuted = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void SoundPlayingg(AudioClip clip)
    {
        if (!isMuted)
        {
            sound.PlayOneShot(clip);
        }
    }
}

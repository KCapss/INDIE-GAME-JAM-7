using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [Header("Music")]
    [SerializeField] private AudioClip TitleMsc;
    [SerializeField] private AudioClip InGame;


    [Header("SFX")]
    [SerializeField] private AudioClip HoverMsc;
    [SerializeField] private AudioClip GameOver;
    [SerializeField] private AudioClip Press;

    [Header("Dialogue")]
    [SerializeField] private AudioClip DiaglogueClip;

    public static AudioManager Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public AudioClip RetrieveInGameMsc()
    {
        return InGame;
    }

    public AudioClip RetreiveTitleMsc()
    {
        return TitleMsc;
    }

    public AudioClip RetrieveSFXPress()
    {
        return Press;
    }

    public AudioClip RetrieveSFXGameOver()
    {
        return GameOver;
    }

    public AudioClip RetrieveDialogue()
    {
        return DiaglogueClip;
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

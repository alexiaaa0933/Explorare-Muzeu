using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static SoundManager instance; // Singleton pattern

    public AudioClip tRexSound;
    public AudioClip egyptianSound;
    public AudioClip japanSound;

    private AudioSource audioSource;

    void Awake()
    {
        // Singleton pattern pentru a asigura că există o singură instanță a SoundManager în toate scenele
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Obiectul va persista între scene
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayTrexSound()
    {
        audioSource.PlayOneShot(tRexSound);
    }

    public void PlayEgyptianSound()
    {
        audioSource.PlayOneShot(egyptianSound);
    }

    public void PlayJapanSound()
    {
        audioSource.PlayOneShot(japanSound);
    }

}

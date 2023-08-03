using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    public static Audio_Manager instance;

    public float volumeSet;
    public AudioSource[] allSounds;
    // Start is called before the first frame update
    void Start()
    {
        //Calls a function on game startup to find all audio scources in the current scene.
        FindAudio();
    }
    private void OnLevelWasLoaded()
    {
        //Calls a function when a scene change occurs to find all audio scources in the current scene.
        FindAudio();
    }

    // Update is called once per frame
    void Update()
    {
        //Increases or decreases the volume of all the scenes audio.
        if (Input.GetKeyDown("z"))
        {
            volumeSet -= 0.1f;

            changeVolume();
        }
        if (Input.GetKeyDown("x"))
        {
            volumeSet += 0.1f;

            changeVolume();
        }
    }

    void changeVolume()
    {
        //This is what sets the audio for the sound in the scene (Not: it will set everything to the same volume). 
        for (int i = 0; i < allSounds.Length; i++)
        {
            allSounds[i].volume = volumeSet;
        }

        //Balances the volumeSet float to not cause strange behaviors.
        if(volumeSet > 1)
        {
            volumeSet = 1;
        }
        if (volumeSet < 0)
        {
            volumeSet = 0;
        }
    }
    void FindAudio()
    {
        //Removes all audio sources from previous scenes to prevent errors.
        //allSounds = null;
        //Finds all audio sources and sets array values accordingly.
        allSounds = FindObjectsOfType<AudioSource>();
        //Makes audio manager stay through scenes.
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
  
        changeVolume();
        //Debug.Log("Start");
    }
}

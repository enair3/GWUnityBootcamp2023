using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSync : MonoBehaviour
{
    public bool songOver;
    //Audio playing
    public AudioSource testSong;

    public float songType;

    //Time since song started
    public float songTime;

    //Song beats per minute
    public float songBpm;

    //The number of seconds for each song beat
    public float secPerBeat;

    //Current song position, in beats
    public float songPositionInBeats;

    public float noteCreator;

    public NoteCreation noteSpawner;
    public NoteCreation noteSpawnerp2;

    public float beatsBeforeSpawn = 0;

    public float timer;
    public bool hasStarted;

    // Start is called before the first frame update
    void Start()
    {
        //sets the bpm by dividing one second by the bpm
        secPerBeat = 60f / songBpm;
        noteCreator = secPerBeat;
        songOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (songOver == false)
        {
            timer += Time.deltaTime;
            /*
            if (timer >= 1.5 && hasStarted == false)
            {
                testSong.Play();
                hasStarted = true;
            }
            */
            noteCreator -= Time.deltaTime;

            if (testSong.isPlaying)
            {
                //sets song time to the actual value for time since song started
                songTime = testSong.time;
            }
            //Finds how many beats have happened since the beggining of the song
            songPositionInBeats = Mathf.Round(testSong.time / secPerBeat);

            if (songType == 1)
            {
                if (noteCreator <= 0)
                {
                    noteCreator = secPerBeat;
                    beatsBeforeSpawn -= 1;

                    if (beatsBeforeSpawn <= 0)
                    {
                        noteSpawner.createNote();
                        noteSpawnerp2.createNote();

                        if (songTime <= 10)
                        {
                            beatsBeforeSpawn = 2;
                        }
                        if (songTime >= 10)
                        {
                            beatsBeforeSpawn = 1;
                        }
                        if (songTime >= 98)
                        {
                            beatsBeforeSpawn = 2;
                        }
                        if (songTime >= 109)
                        {
                            beatsBeforeSpawn = 1;
                        }
                        if (songTime >= 131)
                        {
                            beatsBeforeSpawn = 2;
                        }
                        if (songTime >= 140)
                        {
                            songOver = true;
                        }
                    }
                }
            }
        }
    }
}

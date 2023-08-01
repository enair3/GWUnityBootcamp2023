using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScroll : MonoBehaviour
{
    public Rigidbody2D selfRB;
    public bool noteCheck;
    public bool missedNote = false;
    public float time;
    public MusicSync musicStart;
    //Note Scroll Speed (does not effect rythm);
    public float NSS;
    public bool hasCrossedBorder;
    public string keyCode;

    // Start is called before the first frame update
    void Start()
    {
        musicStart = FindObjectOfType<MusicSync>();

        selfRB.velocity = new Vector2(NSS, 0);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("noteDestroy"))
        {
            Destroy(gameObject);
        }

        if (collision.CompareTag("noteOverlap"))
        {
            noteCheck = true;

            //Debug.Log("Collided");
        }
        /*
        if (collision.CompareTag("Border"))
        {
            hasCrossedBorder = true;
        }
        */
        if (collision.CompareTag("SongBegin"))
        {
            //Debug.Log("Play");
            if (musicStart.hasStarted == false)
            {
                musicStart.testSong.Play();
                musicStart.hasStarted = true;
                Debug.Log("Play");
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("noteOverlap"))
        {
            noteCheck = false;
        }
    }

    public void destroyNote()
    {
        if (noteCheck == true)
        {
            Destroy(gameObject);
        }
    }
}



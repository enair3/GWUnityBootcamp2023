using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScroll : MonoBehaviour
{
    public Rigidbody2D selfRB;
    public bool noteCheck;
    public float time;
    public MusicSync musicStart;
    //Note Scroll Speed (does not effect rythm);
    public float NSS;
    // Start is called before the first frame update
    void Start()
    {
        selfRB.velocity = new Vector2(NSS, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            if (noteCheck == true)
            {
                print(time);
                Destroy(gameObject);
            }
        }
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

        if (collision.CompareTag("SongBegin"))
        {
            if (musicStart.hasStarted == false)
            {
                musicStart.testSong.Play();
                musicStart.hasStarted = true;
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
}

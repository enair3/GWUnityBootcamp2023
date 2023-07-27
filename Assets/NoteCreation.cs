using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCreation : MonoBehaviour
{
    public GameObject Note;
    public Transform noteHit;
    public float offSet;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(noteHit.transform.position.x + offSet, transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void createNote()
    {
        Instantiate(Note, transform.position, Quaternion.identity);
    }
}

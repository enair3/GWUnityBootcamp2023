using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCreation : MonoBehaviour
{
    public GameObject Note;
    // Start is called before the first frame update
    void Start()
    {

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

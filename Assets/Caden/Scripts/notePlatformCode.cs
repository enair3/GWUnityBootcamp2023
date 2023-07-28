using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notePlatformCode : MonoBehaviour
{
    public bool noteActive;
    public GameObject noteSelected;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Note"))
        {
            noteActive = true;
            noteSelected = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            noteActive = false;
        }
    }

    public void destroyNote()
    {
        Destroy(noteSelected);
        Debug.Log("destroyNote");
    }
}
